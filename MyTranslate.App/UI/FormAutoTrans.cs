using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using MyTranslate.App.Common;

using MyTranslate.Model;
using MyTranslate.ServiceImpl;

namespace MyTranslate.App.UI
{
    public partial class FormAutoTrans : Form
    {
        public FormAutoTrans()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 章节服务.
        /// </summary>
        private ChapterServiceImpl chapterService = new ChapterServiceImpl();



        private void FormAutoTrans_Load(object sender, EventArgs e)
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
        /// 章节拉列表发生变化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 取得代码.
            string chapterCode = this.cboChapters.SelectedValue as string;


            // 取得章节文本.
            string[] sourceLines = chapterService.GetChapterLineSourceText(chapterCode);
            this.txtSource.Lines = sourceLines;


            // 取得翻译后文本.
            string[] transLines = chapterService.GetChapterLineMachineText(chapterCode);
            this.txtTrans.Lines = transLines;

        }




        /// <summary>
        /// 开始.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.cboBooks.SelectedIndex < 0)
            {
                MyMessage.Warn("书籍必须选择！");
                this.cboBooks.Focus();
                return;
            }

            if (this.cboChapters.SelectedIndex < 0)
            {
                MyMessage.Warn("章节必须选择！");
                this.cboBooks.Focus();
                return;
            }


            if (DataCheck() == false)
            {
                // 数据检查失败.
                if (!bothMode)
                {
                    MyMessage.Warn("机翻文本中，可能存在问题！");
                    return;
                }


                if (!MyMessage.Makesure("无法识别的处理模式，将尝试使用 原文/译文 模式 进行处理 ？"))
                {
                    return;
                }

            }



            if (!MyMessage.Makesure("确认要开始处理了么？"))
            {
                return;
            }



            // 取得代码.
            string chapterCode = this.cboChapters.SelectedValue as string;


            // 译文数组
            string[] tranTextArray;

            if (bothMode)
            {
                // 粘贴的文本中， 为  原文/译文模式
                tranTextArray = this.txtTrans.Lines;
            } else {
                // 粘贴的文本中，仅仅包含 译文.
                tranTextArray = new string[this.txtTrans.Lines.Length * 2];

                for (int i = 0; i < this.txtTrans.Lines.Length; i++)
                {
                    tranTextArray[2 * i] = this.txtSource.Lines[i];
                    tranTextArray[2 * i + 1] = this.txtTrans.Lines[i];
                }
            }


            bool result = chapterService.AutoTrans(chapterCode, tranTextArray);

            if (result)
            {
                MyMessage.Success("处理完毕！");
            }
            else
            {
                MyMessage.Fail(chapterService.ResultMessage);
            }

        }






        /// <summary>
        /// 机翻文本， 为  原文/译文  模式.
        /// </summary>
        private bool bothMode = false;


        /// <summary>
        /// 机翻文本数据检查.
        /// </summary>
        /// <returns></returns>
        private bool DataCheck()
        {
            this.txtSource.Text = this.txtSource.Text.Trim();

            this.txtTrans.Text = this.txtTrans.Text.Trim();


            if (this.txtSource.Lines.Count() == this.txtTrans.Lines.Count())
            {
                lblCheckReault.Text = "机翻文本为 仅仅包含译文.";

                bothMode = false;


                // 进一步检查.
                for (int i = 0; i < this.txtSource.Lines.Count(); i++)
                {
                    if (String.IsNullOrEmpty(this.txtSource.Lines[i])
                        && !String.IsNullOrEmpty(this.txtTrans.Lines[i].Trim()))
                    {

                        lblCheckReault.Text = lblCheckReault.Text + 
                            String.Format("数据不一致！第 {0} 行，原文为空行，机翻有数据。", i+1);

                        return false;
                    }

                    if (!String.IsNullOrEmpty(this.txtSource.Lines[i])
                        && String.IsNullOrEmpty(this.txtTrans.Lines[i].Trim()))
                    {

                        lblCheckReault.Text = lblCheckReault.Text +
                            String.Format("数据不一致！第 {0} 行，原文有数据，机翻为空行。", i + 1);

                        return false;
                    }
                }

                

            }
            else if (this.txtSource.Lines.Count() * 2 == this.txtTrans.Lines.Count())
            {
                lblCheckReault.Text = "机翻文本为  原文/译文 模式.";
                bothMode = true;
            }
            else
            {
                lblCheckReault.Text = String.Format(
                    "检测到源文本为 {0} 行， 机翻文本为 {1} 行， 无法识别对应关系 ",
                    this.txtSource.Lines.Count(),
                    this.txtTrans.Lines.Count());

                bothMode = true;

                return false;
            }

            return true;
        }







        #region  前往机翻页面.


        /// <summary>
        /// 取得 书与章节.
        /// </summary>
        /// <param name="book"></param>
        /// <param name="chapter"></param>
        /// <returns></returns>
        private bool GetBookAndChapter(out string book, out string chapter)
        {
            book = null;
            chapter = null;

            if (this.cboBooks.SelectedIndex < 0)
            {
                MyMessage.Warn("书籍必须选择！");
                this.cboBooks.Focus();
                return false;
            }

            if (this.cboChapters.SelectedIndex < 0)
            {
                MyMessage.Warn("章节必须选择！");
                this.cboBooks.Focus();
                return false;
            }



            // 取得章节代码.
            string chapterCode = this.cboChapters.SelectedValue as string;


            // 拆分 n1576cu/005
            string[] bookchapter = chapterCode.Split('/');

            book = bookchapter[0];
            chapter = bookchapter[1];

            // 去除掉章节前面的 0
            chapter = chapter.TrimStart('0');

            return true;
        }



        /// <summary>
        /// 前往 Excite 机翻页面。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcite_Click(object sender, EventArgs e)
        {
            string book, chapter;

            if (!GetBookAndChapter(out book, out chapter))
            {
                // 检查失败.
                return;
            }




            string url = string.Format(
                "http://www.excite-webtl.jp/world/chinese/web/?wb_url=http%3A%2F%2Fncode.syosetu.com%2F{0}%2F{1}%2F&wb_lp=JACH&wb_dis=1&big5=no", 
                book, chapter);


            // 用系统默认浏览器打开.
            System.Diagnostics.Process.Start(url);
        }



        /// <summary>
        /// 前往 Baidu 机翻页面。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBaidu_Click(object sender, EventArgs e)
        {
            string book, chapter;

            if (!GetBookAndChapter(out book, out chapter))
            {
                // 检查失败.
                return;
            }


            string url = string.Format(
                "http://fanyi.baidu.com/transpage?query=http%3A%2F%2Fncode.syosetu.com%2F{0}%2F{1}%2F&from=auto&to=zh&source=url&render=1",
                book, chapter);


            // 用系统默认浏览器打开.
            System.Diagnostics.Process.Start(url);
        }


        #endregion  前往机翻页面.

    }
}
