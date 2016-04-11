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
    public partial class FormEditChapter : Form
    {
        public FormEditChapter()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 章节服务.
        /// </summary>
        private ChapterServiceImpl chapterService = new ChapterServiceImpl();



        /// <summary>
        /// 章节代码.
        /// </summary>
        public string ChapterCode { set; get; }



        /// <summary>
        /// 当前章节.
        /// </summary>
        private Chapter currentChapter;



        /// <summary>
        /// 初始化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEditChapter_Load(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(ChapterCode))
            {
                this.btnSave.Enabled = false;
                return;
            }


            currentChapter = chapterService.GetChapter(ChapterCode);


            if (currentChapter == null)
            {
                this.btnSave.Enabled = false;
                return;
            }


            // 章节代码.
            this.lblChapterCode.Text = this.currentChapter.ChapterCode;


            // 章节名称.
            this.txtName.Text = this.currentChapter.ChapterName;

            // 章节名称翻译.
            this.txtTranslateName.Text = this.currentChapter.ChapterTranslateName;


        }



        /// <summary>
        /// 保存.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtName.Text))
            {
                MyMessage.Warn("名称必须输入！");
                this.txtName.Focus();

                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }


            if (!MyMessage.Makesure("确认要修改章节么？"))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }


            Chapter chapter = new Chapter()
            {
                BookCode = currentChapter.BookCode,

                ChapterCode = currentChapter.ChapterCode,


                ChapterName = this.txtName.Text.Trim(),

                ChapterTranslateName = this.txtTranslateName.Text.Trim(),


                Lines = new List<Line> (),
            };


            bool result = chapterService.InsertOrUpdate(chapter );

            if (result)
            {
                MyMessage.Success("更新成功！");

                this.Close();
            }
            else
            {
                MyMessage.Fail(chapterService.ResultMessage);
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }


        }



    }
}
