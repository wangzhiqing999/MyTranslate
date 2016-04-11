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
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }



        private BookServiceImpl bookService = new BookServiceImpl();


        /// <summary>
        /// 书籍列表.
        /// </summary>
        private List<Book> mainBookList;



        /// <summary>
        /// 重新加载数据.
        /// </summary>
        private void ReloadBookData()
        {
            mainBookList = bookService.GetBookList();

            this.gvBooks.DataSource = null;
            this.gvBooks.DataSource = mainBookList;
        }



        /// <summary>
        /// 初始化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBooks_Load(object sender, EventArgs e)
        {
            ReloadBookData();
        }


        /// <summary>
        /// 双击.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvBooks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 取得行号.
            int index = e.RowIndex;

            if (index < 0)
            {
                // 忽略为 负数的行号.
                return;
            }


            // 取得指定行的数据.
            Book currentBook = mainBookList[index];


            // 打开 编辑窗口.
            FormEditBook subForm = new FormEditBook();

            subForm.EditBook = currentBook;

            DialogResult diaResult = subForm.ShowDialog();


            if (diaResult == System.Windows.Forms.DialogResult.OK)
            {
                // 数据发生变化时，重新加载数据.
                ReloadBookData();
            }

        }


        /// <summary>
        /// 新增.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewBook_Click(object sender, EventArgs e)
        {
            FormNewBook subForm = new FormNewBook();

            DialogResult diaResult = subForm.ShowDialog();


            if (diaResult == System.Windows.Forms.DialogResult.OK)
            {
                // 数据发生变化时，重新加载数据.
                ReloadBookData();
            }
        }


    }
}
