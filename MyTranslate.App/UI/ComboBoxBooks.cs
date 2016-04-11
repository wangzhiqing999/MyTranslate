using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using MyTranslate.Model;
using MyTranslate.DataAccess;


namespace MyTranslate.App.UI
{
    public partial class ComboBoxBooks : ComboBox
    {



        public ComboBoxBooks()
        {
            InitializeComponent();

            this.DisplayMember = "BookName";
            this.ValueMember = "BookCode";

        }




        public void InitBooks()
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {
                var query =
                    from data in context.Books
                    where
                        data.Status == Book.STATUS_IS_ACTIVE
                    select
                        data;

                List<Book> books = query.ToList();
                this.DataSource = books;
            }
        }


    }
}
