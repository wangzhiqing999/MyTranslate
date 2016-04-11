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
    public partial class FormNewBook : Form
    {
        public FormNewBook()
        {
            InitializeComponent();
        }



        private BookServiceImpl bookService = new BookServiceImpl();



        /// <summary>
        /// 新增.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewBook_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(this.txtCode.Text))
            {
                MyMessage.Warn("代码必须输入！");
                this.txtCode.Focus();

                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }

            if (String.IsNullOrEmpty(this.txtName.Text))
            {
                MyMessage.Warn("名称必须输入！");
                this.txtName.Focus();

                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }


            if (!MyMessage.Makesure("确认要新增书籍么？"))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }





            Book book = new Book()
            {
                BookCode = this.txtCode.Text,

                BookName = this.txtName.Text,

                BookUrl = this.txtUrl.Text
            };


            bool result = bookService.NewBook(book);

            if (result)
            {
                MyMessage.Success("创建成功！");
            }
            else
            {
                MyMessage.Fail(bookService.ResultMessage);
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
