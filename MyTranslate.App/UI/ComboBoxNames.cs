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
    public partial class ComboBoxNames : ComboBox
    {
        public ComboBoxNames()
        {
            InitializeComponent();

            this.DisplayMember = "SourceText";
            this.ValueMember = "SourceText";
        }



        public void InitNames(string bookCode)
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {
                var query =
                    from data in context.Lines
                    where
                        data.Chapter.BookCode == bookCode
                        && data.ChapterCode == bookCode + "/NAMES"
                    orderby
                        data.SourceText
                    select data;

                List<Line> nameList = query.ToList();
                this.DataSource = nameList;
            }
        }

    }
}
