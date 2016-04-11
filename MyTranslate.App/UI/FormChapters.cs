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
    public partial class FormChapters : Form
    {
        public FormChapters()
        {
            InitializeComponent();
        }



        private ChapterServiceImpl chapterService = new ChapterServiceImpl();


        /// <summary>
        /// 主数据列表.
        /// </summary>
        private List<Chapter> mainChapterList;



        /// <summary>
        /// 重新加载数据.
        /// </summary>
        private void ReloadChapterData()
        {
            // 取得代码.
            string bookCode = this.cboBooks.SelectedValue as string;

            if (String.IsNullOrEmpty(bookCode))
            {
                // 没有书的情况下，忽略后续处理.
                return;
            }


            mainChapterList = chapterService.GetChapterList(bookCode);

            this.gvChapters.DataSource = null;
            this.gvChapters.DataSource = mainChapterList;
        }





        private void FormChapters_Load(object sender, EventArgs e)
        {
            // 初始化下拉列表.
            this.cboBooks.InitBooks();
        }




        /// <summary>
        /// 下拉列表数据发生变化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadChapterData();
        }





        /// <summary>
        /// 双击.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvChapters_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 取得行号.
            int index = e.RowIndex;

            if (index < 0)
            {
                // 忽略为 负数的行号.
                return;
            }


            // 取得指定行的数据.
            Chapter currentChapter = mainChapterList[index];


            FormEditChapter editForm = new FormEditChapter();

            editForm.ChapterCode = currentChapter.ChapterCode;

            DialogResult diaResult = editForm.ShowDialog();

            if (diaResult == System.Windows.Forms.DialogResult.OK)
            {
                // 数据更新后， 刷新
                ReloadChapterData();
            }

        }








    }
}
