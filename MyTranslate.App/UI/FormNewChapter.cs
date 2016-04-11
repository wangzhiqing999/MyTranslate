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
    public partial class FormNewChapter : Form
    {
        public FormNewChapter()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 章节服务.
        /// </summary>
        private ChapterServiceImpl chapterService = new ChapterServiceImpl();




        private void FormNewChapter_Load(object sender, EventArgs e)
        {

            // 初始化下拉列表.
            this.cboBooks.InitBooks();
        }






        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.cboBooks.SelectedIndex < 0)
            {
                MyMessage.Warn("书籍必须选择！");
                this.cboBooks.Focus();
                return;
            }


            if (String.IsNullOrEmpty(this.txtCode.Text))
            {
                MyMessage.Warn("代码必须输入！");
                this.txtCode.Focus();
                return;
            }

            if (String.IsNullOrEmpty(this.txtName.Text))
            {
                MyMessage.Warn("名称必须输入！");
                this.txtName.Focus();
                return;
            }


            if (!MyMessage.Makesure("确认要新增章节么？"))
            {
                return;
            }




            Chapter chapter = new Chapter()
            {
                BookCode = this.cboBooks.SelectedValue as string,

                ChapterCode = this.txtCode.Text.Trim(),

                ChapterName = this.txtName.Text.Trim(),
            };


            bool result = chapterService.NewChapter(chapter, this.txtLines.Lines);

            if (result)
            {
                MyMessage.Success("创建成功！");
            }
            else
            {
                MyMessage.Fail(chapterService.ResultMessage);
            }

        }




    }
}
