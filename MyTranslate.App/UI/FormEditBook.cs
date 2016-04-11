using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using MyTranslate.App.Common;

using MyTranslate.ServiceImpl;

using MyTranslate.Model;


namespace MyTranslate.App.UI
{
    public partial class FormEditBook : Form
    {
        public FormEditBook()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 当前数据.
        /// </summary>
        private Book currentBook;


        public Book EditBook
        {
            set
            {
                // 暂存当前数据.
                currentBook = value;

                // 代码.
                this.txtCode.Text = value.BookCode;

                // 名称.
                this.txtName.Text = value.BookName;

                // URL.
                this.txtUrl.Text = value.BookUrl;

                // 有效性.
                this.chkActive.Checked = value.IsActive;

            }
        }



        private BookServiceImpl bookService = new BookServiceImpl();


        private void FormEditBook_Load(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// 新增.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditBook_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(this.txtName.Text))
            {
                MyMessage.Warn("名称必须输入！");
                this.txtName.Focus();

                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }


            if (!MyMessage.Makesure("确认要更新书籍么？"))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }





            // 书名.
            currentBook.BookName = this.txtName.Text;

            // 地址.
            currentBook.BookUrl = this.txtUrl.Text;


            // 有效性.
            currentBook.IsActive = this.chkActive.Checked;



            bool result = bookService.UpdateBook(currentBook);

            if (result)
            {
                MyMessage.Success("更新成功！");
                this.Close();
            }
            else
            {
                MyMessage.Fail(bookService.ResultMessage);
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }




        }





    }
}
