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
    public partial class ComboBoxChapters : ComboBox
    {
        public ComboBoxChapters()
        {
            InitializeComponent();

            this.DisplayMember = "DisplayChapterName";
            this.ValueMember = "ChapterCode";
        }


        public void InitChapters()
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {
                List<Chapter> chapters = context.Chapters.ToList();
                this.DataSource = chapters;
            }
        }


        public void InitChapters(string bookCode)
        {
            using (MyTranslateContext context = new MyTranslateContext())
            {
                List<Chapter> chapters = context.Chapters.Where(p=>p.BookCode == bookCode).OrderBy(p=>p.ChapterCode).ToList();
                this.DataSource = chapters;
            }
        }



    }
}
