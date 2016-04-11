using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.IO;
using System.Xml;
using System.Xml.Serialization;


using MyTranslate.Model;
using MyTranslate.DataAccess;
using MyTranslate.ServiceImpl;

using MyTranslate.Util;

using MyTranslate.App.Common;



namespace MyTranslate.App.UI
{
    public partial class FormDataSwitch : Form
    {
        public FormDataSwitch()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 行服务.
        /// </summary>
        private LineServiceImpl lineService = new LineServiceImpl();



        private void FormDataSwitch_Load(object sender, EventArgs e)
        {
            // 初始化下拉列表.
            this.cboBooks.InitBooks();
        }



        /// <summary>
        /// 书下拉列表发生变化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

            // 取得代码.
            string bookCode = this.cboBooks.SelectedValue as string;


            // 初始化 章节下拉列表.
            this.cboChapters.InitChapters(bookCode);

        }


        /// <summary>
        /// 章节下拉列表发生变化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 取得代码.
            string chapterCode = this.cboChapters.SelectedValue as string;




            List<Line> lines = lineService.GetChapterLineList(chapterCode);

            this.gvLines.DataSource = null;
            this.gvLines.DataSource = lines;

       

            this.btnSave.Enabled = false;
        }



        #region 章节的部分.



        /// <summary>
        /// 章节服务.
        /// </summary>
        private ChapterServiceImpl chapterService = new ChapterServiceImpl();


        /// <summary>
        /// 导出.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExp_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                // 用户取消.
                return;
            }


            // 取得代码.
            string chapterCode = this.cboChapters.SelectedValue as string;

            if (String.IsNullOrEmpty(chapterCode))
            {
                MyMessage.Warn("未选择章节！");
                return;
            }

            Chapter dbChapter = null;

            using (MyTranslateContext context = new MyTranslateContext())
            {
                dbChapter = context.Chapters.Include("Book").Include("Lines").FirstOrDefault(p => p.ChapterCode == chapterCode);
            }            


            if (dbChapter == null)
            {
                MyMessage.Warn("章节数据不存在！");
                return;
            }



            Chapter expChapter = new Chapter();
            CommonModelCopyer.ModelCopy(dbChapter, expChapter);

            expChapter.Lines = new List<Line>();
            foreach (Line dbLine in dbChapter.Lines)
            {
                Line expLine = new Line();
                CommonModelCopyer.ModelCopy(dbLine, expLine);
                expLine.Status = dbLine.Status;
                expChapter.Lines.Add(expLine);
            }



            // 输出 UTF-8 的 XML 文件.
            XmlSerializer xs = new XmlSerializer(typeof(Chapter));
            using(StreamWriter sw = new StreamWriter(this.saveFileDialog1.FileName)) 
            {
                xs.Serialize(sw, expChapter);
            }


            MyMessage.Success("导出完毕！");
        }







        /// <summary>
        /// 导入的章节.
        /// </summary>
        private Chapter impChapter = null;



        /// <summary>
        /// 导入.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImp_Click(object sender, EventArgs e)
        {

            if (this.openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                // 用户取消.
                return;
            }

            try
            {

                XmlSerializer xs = new XmlSerializer(typeof(Chapter));
                using (StreamReader sr = new StreamReader(this.openFileDialog1.FileName))
                {
                    impChapter = xs.Deserialize(sr) as Chapter;
                    sr.Close();
                }



                this.gvLines.DataSource = null;
                this.gvLines.DataSource = impChapter.Lines;

                this.btnSave.Enabled = true;


                MyMessage.Success("导入完毕！ 按保存按钮完成数据更新！");

            }
            catch (Exception ex)
            {
                MyMessage.Fail("导入文件的时候，发生了错误：" + ex.Message);
            }
        }



        /// <summary>
        /// 存储.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (impChapter == null)
            {
                MyMessage.Warn("数据不存在！");
                return;
            }



            if (!MyMessage.Makesure("确认要开始处理了么？"))
            {
                return;
            }



            bool result = chapterService.InsertOrUpdate(impChapter);

            if (result)
            {
                MyMessage.Success("处理完毕！");
            }
            else
            {
                MyMessage.Fail(chapterService.ResultMessage);
            }


        }


        #endregion 章节的部分.





        #region 书籍的部分.



        /// <summary>
        /// 书籍服务.
        /// </summary>
        private BookServiceImpl bookService = new BookServiceImpl();


        /// <summary>
        /// 导出书籍.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpBook_Click(object sender, EventArgs e)
        {

            // 取得代码.
            string bookCode = this.cboBooks.SelectedValue as string;

            if (String.IsNullOrEmpty(bookCode))
            {
                MyMessage.Warn("未选择书籍！");
                return;
            }



            if (this.saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                // 用户取消.
                return;
            }


            


            try
            {

                this.Cursor = Cursors.WaitCursor;
                this.gvLines.Enabled = false;


                Book dbBook = null;

                Book expBook = new Book();


                using (MyTranslateContext context = new MyTranslateContext())
                {
                    dbBook = context.Books.Include("Chapters").FirstOrDefault(p => p.BookCode == bookCode);

                    if (dbBook == null)
                    {
                        MyMessage.Warn("书籍数据不存在！");
                        return;
                    }


                    CommonModelCopyer.ModelCopy(dbBook, expBook);


                    expBook.Chapters = new List<Chapter>();
                    foreach (Chapter dbChapter in dbBook.Chapters)
                    {

                        Chapter expChapter = new Chapter();
                        CommonModelCopyer.ModelCopy(dbChapter, expChapter);
                        expChapter.Status = dbChapter.Status;


                        expChapter.Lines = new List<Line>();
                        foreach (Line dbLine in dbChapter.Lines)
                        {
                            Line expLine = new Line();
                            CommonModelCopyer.ModelCopy(dbLine, expLine);
                            expLine.Status = dbLine.Status;
                            expChapter.Lines.Add(expLine);
                        }

                        expBook.Chapters.Add(expChapter);
                    }

                }


                // 输出 UTF-8 的 XML 文件.
                XmlSerializer xs = new XmlSerializer(typeof(Book));
                using (StreamWriter sw = new StreamWriter(this.saveFileDialog1.FileName))
                {
                    xs.Serialize(sw, expBook);
                }



                MyMessage.Success("导出完毕！");

            }
            catch (Exception ex)
            {
                MyMessage.Fail(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.gvLines.Enabled = true;
            }


            

        }







        /// <summary>
        /// 导入的书籍.
        /// </summary>
        private Book impBook = null;


        /// <summary>
        /// 导入书籍.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImpBook_Click(object sender, EventArgs e)
        {

            if (this.openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                // 用户取消.
                return;
            }

            try
            {

                XmlSerializer xs = new XmlSerializer(typeof(Book));
                using (StreamReader sr = new StreamReader(this.openFileDialog1.FileName))
                {
                    impBook = xs.Deserialize(sr) as Book;
                    sr.Close();
                }



                this.gvLines.DataSource = null;
                //this.gvLines.DataSource = impChapter.Lines;

                this.btnSaveBook.Enabled = true;


                MyMessage.Success("导入完毕！ 按保存按钮完成数据更新！");

            }
            catch (Exception ex)
            {
                MyMessage.Fail("导入文件的时候，发生了错误：" + ex.Message);
            }
        }



        /// <summary>
        /// 存储书籍.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            if (impBook == null)
            {
                MyMessage.Warn("数据不存在！");
                return;
            }


            // 全部替换标志.
            bool replaceAllFlag = true;


            Book book = bookService.GetBook(impBook.BookCode);

            if (book == null)
            {
                // 数据库中，书籍不存在，不需要确定  是否覆盖已存在的。

                if (!MyMessage.Makesure("确认要开始处理了么？"))
                {
                    return;
                }
            }
            else
            {
                // 数据库中，书籍已存在，需要确定， 是否覆盖已存在的。

                DialogResult diaResult = MessageBox.Show(
                    this,
                    "当前数据库中，检测到书籍已存在，是否彻底覆盖当前的数据？\r\n  选择是，则完全覆盖。\r\n选择否，则仅仅新增，不覆盖已存在的章节。 ",
                    "确认！",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Asterisk);

                if (diaResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    // 用户取消.
                    return;
                }

                if (diaResult == System.Windows.Forms.DialogResult.No)
                {
                    // 仅仅新增，不覆盖已存在的章节.
                    replaceAllFlag = false;
                }
            }




            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.gvLines.Enabled = false;

                bool result = bookService.InsertOrUpdateBookAndChapter(impBook, replaceAllFlag);

                if (result)
                {
                    MyMessage.Success("处理完毕！");
                }
                else
                {
                    MyMessage.Fail(chapterService.ResultMessage);
                }
            }
            catch (Exception ex)
            {
                MyMessage.Fail(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.gvLines.Enabled = true;
            }
        }


        #endregion 书籍的部分.






    }
}
