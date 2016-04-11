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
    public partial class FormNames : Form
    {
        public FormNames()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 行服务.
        /// </summary>
        private NameLineServiceImpl lineService = new NameLineServiceImpl();



        /// <summary>
        /// 命名列表.
        /// </summary>
        private List<Line> namesLineList;




        private void FormNames_Load(object sender, EventArgs e)
        {
            // 初始化下拉列表.
            this.cboBooks.InitBooks();
        }



        /// <summary>
        /// 下拉列表选择发生变化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadLineData();
        }



        /// <summary>
        /// 新增.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Line line = new Line()
            {
                // 章节代码.
                ChapterCode = this.lblNameCode.Text,


                SourceText = this.txtSource.Text,

                MachineText =  String.Format("{0}={1}",   this.txtMachine.Text, this.txtMachineTo.Text),

                TranslateText = this.txtTranslate.Text,

                Status = Line.STATUS_IS_DONE
            };


            // 保存.
            bool result = lineService.NewOneLine(line);

            if (result)
            {
                ReloadLineData();
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


            // 加载命名列表.
            string nameCode = String.Format("{0}/NAMES", bookCode);
            namesLineList = lineService.GetChapterLineList(nameCode);


            // 命名章节代码.
            this.lblNameCode.Text = nameCode;


            this.gvLines.DataSource = null;
            this.gvLines.DataSource = namesLineList;
        }








    }


}
