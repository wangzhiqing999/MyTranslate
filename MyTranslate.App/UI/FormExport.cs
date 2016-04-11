using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;


using MyTranslate.Model;
using MyTranslate.DataAccess;
using MyTranslate.ServiceImpl;


using MyTranslate.App.Common;


namespace MyTranslate.App.UI
{
    public partial class FormExport : Form
    {
        public FormExport()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 章节列表.
        /// </summary>
        private List<Chapter> chapterList;



        /// <summary>
        /// 行服务.
        /// </summary>
        private LineServiceImpl lineService = new LineServiceImpl();


        /// <summary>
        /// 书代码.
        /// </summary>
        private string bookCode;





        /// <summary>
        /// 初始化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormExport_Load(object sender, EventArgs e)
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
            bookCode = this.cboBooks.SelectedValue as string;


            // 再次检索.
            using (MyTranslateContext context = new MyTranslateContext())
            {

                chapterList = context.Chapters.Where(p => p.BookCode == bookCode).ToList();

                this.gvChapters.DataSource = null;
                this.gvChapters.DataSource = chapterList;

            }
        }


        /// <summary>
        /// 选择目录.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtOutputPath.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }



        /// <summary>
        /// 导出.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExp_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.txtOutputPath.Text))
            {
                MyMessage.Warn("导出目录不存在！");
                return;
            }



            if (this.rdoOneChapterOneFile.Checked)
            {
                // 一章节一个文件.
                foreach (Chapter c in chapterList)
                {
                    if (c.IsActive)
                    {
                        BuildOneFile(c);
                    }
                }
            }
            else
            {
                // 所有章节，一个文件.

                // 名称优先.
                Chapter nameChapter = chapterList.FirstOrDefault(p => p.ChapterSubCode == "NAMES");

                if (nameChapter != null)
                {
                    AppendOneFile(nameChapter);
                }



                // 名称外 按顺序写入.
                var query =
                    from data in chapterList
                    where
                        data.IsActive
                        && data.ChapterSubCode != "NAMES"
                    orderby
                        data.ChapterSubCode
                    select data;


                foreach (Chapter otherChapter in query)
                {
                    AppendOneFile(otherChapter);
                }

            }



            MyMessage.Success("导出完毕！");
            
        }



        /// <summary>
        /// 创建单个文件.
        /// </summary>
        private void BuildOneFile(Chapter c)
        {
            // 取得行列表.
            List<Line> mainLineList = lineService.GetChapterLineList(c.ChapterCode);

            string fileName = String.Format("{0}\\{1}.txt", this.txtOutputPath.Text, c.ChapterSubCode);


            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
            {

                writer.WriteLine("--------------------------------------------------------------------------------");
                writer.WriteLine("{0} : {1}", c.ChapterCode, c.ChapterName);
                writer.WriteLine("--------------------------------------------------------------------------------");
                writer.WriteLine();

                if (c.ChapterSubCode == "NAMES")
                {
                    foreach (Line line in mainLineList)
                    {
                        writer.WriteLine("{0}  :  {1}", line.SourceText, line.TranslateText);
                    }
                }
                else
                {
                    foreach (Line line in mainLineList)
                    {
                        writer.WriteLine(line.TranslateText);
                    }
                }

                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine();

            }

        }




        /// <summary>
        /// 追加一个文件.
        /// </summary>
        /// <param name="c"></param>
        private void AppendOneFile(Chapter c)
        {
            // 取得行列表.
            List<Line> mainLineList = lineService.GetChapterLineList(c.ChapterCode);

            string fileName = String.Format("{0}\\{1}.txt", this.txtOutputPath.Text, this.bookCode);

            using (StreamWriter writer = new StreamWriter(fileName, true, Encoding.UTF8))
            {

                writer.WriteLine("--------------------------------------------------------------------------------");
                writer.WriteLine("{0} : {1}", c.ChapterCode, c.ChapterName);
                writer.WriteLine("--------------------------------------------------------------------------------");
                writer.WriteLine();

                if (c.ChapterSubCode == "NAMES")
                {
                    foreach (Line line in mainLineList)
                    {
                        writer.WriteLine("{0}  :  {1}", line.SourceText, line.TranslateText);                    
                    }
                }
                else
                {
                    foreach (Line line in mainLineList)
                    {
                        writer.WriteLine(line.TranslateText);
                    }
                }

                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine();

            }
        }


    }
}
