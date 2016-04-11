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
    public partial class FormNameManager : Form
    {
        public FormNameManager()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 行服务.
        /// </summary>
        private LineServiceImpl lineService = new LineServiceImpl();


        /// <summary>
        /// 行列表
        /// </summary>
        private List<Line> mainLineList;


        /// <summary>
        /// 当前行索引.
        /// </summary>
        private int currentRowIndex;




        /// <summary>
        /// 命名列表.
        /// </summary>
        private List<Line> namesLineList;




        private void FormNameManager_Load(object sender, EventArgs e)
        {
            // 初始化下拉列表.
            this.cboBooks.InitBooks();

            this.cboLineStatus.InitLineStatus();
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
            this.cboNames.InitNames(bookCode);



            // 加载命名列表.
            string nameCode = String.Format("{0}/NAMES", bookCode);
            namesLineList = lineService.GetChapterLineList(nameCode);
        }



        /// <summary>
        /// 命名下拉列表发生变化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadLineData();
        }


        /// <summary>
        /// 隐藏已完成.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkHideDone_CheckedChanged(object sender, EventArgs e)
        {
            ReloadLineData();
        }


        /// <summary>
        /// 单元格点击.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvLines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 取得行.
            int rowNum = e.RowIndex;

            if (rowNum < 0)
            {
                // 忽略未选择的情况.
                return;
            }


            // 保存当前行索引， 用于翻页.
            currentRowIndex = e.RowIndex;


            // 加载一行.
            LoadOneLine(rowNum);
        }


        /// <summary>
        /// 上一行.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentRowIndex <= 0)
            {
                return;
            }

            // 换行前数据检查
            if (!BeforeLineChangeCheck())
            {
                return;
            }


            currentRowIndex--;

            this.gvLines.Rows[currentRowIndex].Selected = true;


            // 加载一行.
            LoadOneLine(currentRowIndex);
        }


        /// <summary>
        /// 下一行.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentRowIndex >= this.gvLines.Rows.Count - 1)
            {
                return;
            }

            // 换行前数据检查
            if (!BeforeLineChangeCheck())
            {
                return;
            }

            currentRowIndex++;

            this.gvLines.Rows[currentRowIndex].Selected = true;


            // 加载一行.
            LoadOneLine(currentRowIndex);
        }






        /// <summary>
        /// 复制到剪贴板.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.txtSource.Text);
        }




        /// <summary>
        /// 暂存.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTempSave_Click(object sender, EventArgs e)
        {
            // 取得当前行.
            Line selectLine = this.mainLineList[currentRowIndex];


            // 结果文本.
            selectLine.TranslateText = this.txtTranslate.Text;

            // 翻译状态.
            selectLine.Status = this.cboLineStatus.SelectedValue as string;


            // 保存.
            bool result = lineService.UpdateOneLine(selectLine);

            if (result)
            {
                lblUpdateResult.Text = "处理完毕！";

                // 显示合计.
                ShowSummary();
            }
            else
            {
                MyMessage.Fail(lineService.ResultMessage);
            }
        }



        /// <summary>
        /// 完成并保存.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 取得当前行.
            Line selectLine = this.mainLineList[currentRowIndex];

            // 机翻文本.
            selectLine.MachineText = this.txtMachine.Text;

            // 结果文本.
            selectLine.TranslateText = this.txtTranslate.Text;

            // 翻译状态.
            selectLine.Status = Line.STATUS_IS_DONE;


            // 保存.
            bool result = lineService.UpdateOneLine(selectLine);

            if (result)
            {
                lblUpdateResult.Text = "处理完毕！";


                // 显示合计.
                ShowSummary();
            }
            else
            {
                MyMessage.Fail(lineService.ResultMessage);
            }

        }











        /// <summary>
        /// 重新加载行数据.
        /// </summary>
        private void ReloadLineData()
        {
            // 取得代码.
            string bookCode = this.cboBooks.SelectedValue as string;

            // 取得代码.
            string nameStr = this.cboNames.SelectedValue as string;

            // 取得行列表.
            mainLineList = lineService.GetLineListByName(bookCode, nameStr);

            if (this.chkHideDone.Checked)
            {
                // 要求隐藏已完成的.
                mainLineList = mainLineList.Where(p => p.Status != Line.STATUS_IS_DONE).ToList();
            }

            // 数据绑定.
            this.gvLines.DataSource = null;
            this.gvLines.DataSource = mainLineList;



            // 显示合计.
            ShowSummary();

        }

        /// <summary>
        /// 显示当前画面合计.
        /// </summary>
        private void ShowSummary()
        {

            StringBuilder buff = new StringBuilder();
            buff.AppendFormat("总行数：{0};", mainLineList.Count);
            buff.AppendFormat("非空白行：{0};", mainLineList.Count(p => p.IsBlank == false));

            buff.AppendFormat("机翻完毕：{0};", mainLineList.Count(p => p.IsBlank == false && p.Status == Line.STATUS_IS_MACHINE));

            buff.AppendFormat("已完成：{0};", mainLineList.Count(p => p.IsBlank == false && p.Status == Line.STATUS_IS_DONE));

            buff.AppendFormat("处理不能：{0};", mainLineList.Count(p => p.IsBlank == false && p.Status == Line.STATUS_IS_FAIL));

            lblLineSummaryInfo.Text = buff.ToString();
        }





        /// <summary>
        /// 加载一行.
        /// </summary>
        /// <param name="rowNum"></param>
        private void LoadOneLine(int rowNum)
        {
            // 取得行.
            Line selectLine = this.mainLineList[rowNum];

            // 源文本.
            this.txtSource.Text = selectLine.SourceText;

            // 机翻文本.
            this.txtMachine.Text = selectLine.MachineText;

            // 结果文本.
            this.txtTranslate.Text = selectLine.TranslateText;

            // 翻译状态.
            this.lblStatus.Text = selectLine.Status;


            if (selectLine.ChapterCode.Contains("NAMES"))
            {
                // 名称行，机翻部分可修改.
                this.txtMachine.ReadOnly = false;
            }
            else
            {
                // 其他行，机翻部分不可修改.
                this.txtMachine.ReadOnly = true;
            }


            if (String.IsNullOrEmpty(this.txtTranslate.Text) && !String.IsNullOrEmpty(this.txtMachine.Text))
            {
                // 未处理的情况下， 结果 = 机翻.
                this.txtTranslate.Text = this.txtMachine.Text;
            }

            // 翻译状态.
            this.cboLineStatus.SelectedValue = selectLine.Status;


            // 更新结果.
            lblUpdateResult.Text = "";


            // 行号.
            lblRowNumber.Text = String.Format("{0} / {1}", rowNum + 1, this.mainLineList.Count);



            // 命名部分.
            txtNames.Text = "";

            if (!String.IsNullOrEmpty(this.txtSource.Text))
            {
                // 非空白情况下， 尝试检索， 文章中， 是否存在 制定的命名.

                foreach (Line nameLine in namesLineList)
                {
                    if (this.txtSource.Text.IndexOf(nameLine.SourceText) >= 0)
                    {
                        // 文章中存在指定的名词.
                        string nameString = String.Format("{0}  :  {1} \r\n", nameLine.SourceText, nameLine.TranslateText);
                        txtNames.AppendText(nameString);
                    }
                }

            }


        }




        /// <summary>
        /// 换行前数据检查.
        /// </summary>
        /// <returns></returns>
        private bool BeforeLineChangeCheck()
        {
            // 取得行.
            Line selectLine = this.mainLineList[currentRowIndex];

            if (String.IsNullOrEmpty(selectLine.TranslateText))
            {
                // 还没翻译过.

                if (selectLine.MachineText == this.txtTranslate.Text)
                {
                    // 数据一致.
                    return true;
                }
            }
            else
            {

                // 已经翻译过.

                if (selectLine.TranslateText == this.txtTranslate.Text)
                {
                    // 数据一致.
                    return true;
                }

            }
            return MyMessage.Makesure("数据好像发生了变化，确定要作换行处理么？");
        }









    }
}
