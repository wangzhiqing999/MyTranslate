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


    }
}
