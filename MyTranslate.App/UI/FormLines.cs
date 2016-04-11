using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




using MyTranslate.Model;
using MyTranslate.ServiceImpl;





namespace MyTranslate.App.UI
{
    public partial class FormLines : Form
    {
        public FormLines()
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
        /// 重新加载行数据.
        /// </summary>
        private void ReloadLineData()
        {

            // 取得代码.
            string chapterCode = this.cboChapters.SelectedValue as string;


            if (String.IsNullOrEmpty(chapterCode))
            {
                // 没有章节，忽略.
                return;
            }


            // 取得行列表.
            mainLineList = lineService.GetChapterLineList(chapterCode);


            // 数据绑定.
            this.gvLines.DataSource = null;
            this.gvLines.DataSource = mainLineList;
        }




        private void FormLines_Load(object sender, EventArgs e)
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
            ReloadLineData();
        }





    }
}
