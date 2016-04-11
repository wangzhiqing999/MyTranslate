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
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 行服务.
        /// </summary>
        private LineServiceImpl lineService = new LineServiceImpl();



        /// <summary>
        /// 命名列表.
        /// </summary>
        private List<Line> namesLineList;






        private void FormResult_Load(object sender, EventArgs e)
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
        /// Build.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuildDoc_Click(object sender, EventArgs e)
        {



            // 取得代码.
            string bookCode = this.cboBooks.SelectedValue as string;
            // 加载命名列表.
            string nameCode = String.Format("{0}/NAMES", bookCode);
            namesLineList = lineService.GetChapterLineList(nameCode);



            // 取得代码.
            string chapterCode = this.cboChapters.SelectedValue as string;


            // 取得行列表.
            List<Line> mainLineList = lineService.GetChapterLineList(chapterCode);



            // 本章节使用到的名词部分.
            List<Line> subNamesLineList = new List<Line>();



            StringBuilder buff = new StringBuilder();


            foreach (Line oneLine in mainLineList)
            {
                switch (oneLine.Status)
                {
                    case Line.STATUS_IS_DONE:

                        if (oneLine.IsBlank)
                        {
                            buff.AppendLine("　");
                        }
                        else
                        {
                            buff.AppendLine(oneLine.TranslateText);
                        }
                        break;

                    case Line.STATUS_IS_FAIL:
                        buff.AppendFormat("### 机翻脑补失败 ### {0}", oneLine.SourceText);
                        buff.AppendLine();
                        break;
                }


                List<Line> waitRemoveList = new List<Line>();

                foreach (Line nameLine in namesLineList)
                {
                    if (oneLine.SourceText.IndexOf(nameLine.SourceText) >= 0)
                    {
                        waitRemoveList.Add(nameLine);
                        subNamesLineList.Add(nameLine);
                    }
                }


                if (waitRemoveList.Count() > 0)
                {
                    foreach(Line nameLine in waitRemoveList) {
                        namesLineList.Remove(nameLine);
                    }
                }
            }





            this.txtResult.Text = "关于译名";
            this.txtResult.AppendText("\r\n");


            foreach (Line nameLine in subNamesLineList)
            {
                string nameString = String.Format("{0}  :  {1} \r\n", nameLine.SourceText, nameLine.TranslateText);
                txtResult.AppendText(nameString);
            }



            this.txtResult.AppendText("　\r\n　\r\n正文：\r\n　\r\n");


            this.txtResult.AppendText(buff.ToString());

        }




    }
}
