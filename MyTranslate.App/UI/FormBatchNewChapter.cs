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
using MyTranslate.DataAccess;


using MyTranslate.ServiceImpl;




namespace MyTranslate.App.UI
{
    public partial class FormBatchNewChapter : Form
    {
        public FormBatchNewChapter()
        {
            InitializeComponent();
        }



        /// <summary>
        /// web读取服务.
        /// </summary>
        private WebReaderServiceImpl webReaderService = new WebReaderServiceImpl();



        /// <summary>
        /// 书籍服务.
        /// </summary>
        private BookServiceImpl bookService = new BookServiceImpl();



        /// <summary>
        /// 章节服务.
        /// </summary>
        private ChapterServiceImpl chapterService = new ChapterServiceImpl();





        /// <summary>
        /// 本地章节.
        /// </summary>
        private List<Chapter> loaclChapterList;


        /// <summary>
        /// Web章节.
        /// </summary>
        private List<Chapter> webChapterList;



        private void FormBatchNewChapter_Load(object sender, EventArgs e)
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
            // 取得代码.
            string bookCode = this.cboBooks.SelectedValue as string;


            // 再次检索.
            using (MyTranslateContext context = new MyTranslateContext())
            {

                loaclChapterList = context.Chapters.Where(p => p.BookCode == bookCode).ToList();

                this.gvChapters.DataSource = loaclChapterList;


                this.gvWebChapters.DataSource = null;

                this.btnSave.Enabled = false;

            }
        }



        /// <summary>
        /// 加载网页.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadWeb_Click(object sender, EventArgs e)
        {
            // 取得代码.
            string bookCode = this.cboBooks.SelectedValue as string;

            Book book = bookService.GetBook(bookCode);



            webChapterList = webReaderService.ReadChapterList(book.BookUrl);

            this.gvWebChapters.DataSource = webChapterList;

            this.btnSave.Enabled = true;
        }






        private List<Chapter> todoList;



        /// <summary>
        /// 保存.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {



            if (webChapterList == null || webChapterList.Count == 0)
            {

                MyMessage.Warn("没有读取到 Web 数据！");
                return;
            }

            // 取得代码.
            string bookCode = this.cboBooks.SelectedValue as string;


            todoList = new List<Chapter>();


            foreach (Chapter c in webChapterList)
            {

                if (!c.IsActive)
                {
                    continue;
                }


                if (!this.loaclChapterList.Exists(p => p.ChapterCode == c.ChapterCode))
                {

                    // 设置章节的 书籍代码.
                    c.BookCode = bookCode;

                    todoList.Add(c);
                }
            }


            if (todoList.Count == 0)
            {
                MyMessage.Warn("没有新章节需要读取！");
                return;
            }



            String message = String.Format("确认要批量新增这 {0} 个章节么？", todoList.Count);


            if (!MyMessage.Makesure(message))
            {
                return;
            }



            pbrChapter.Value = 0;
            pbrChapter.Maximum = todoList.Count;


            Chapter chapter = todoList[0];



            string html = webReaderService.ReadLineList(chapter.GetChapterUrl());

            webBrowser1.DocumentText = html;


            this.btnSave.Enabled = false;
            
        }





        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Chapter chapter = todoList[pbrChapter.Value];

            StringBuilder textBuffer = new StringBuilder();

            foreach (HtmlElement item in webBrowser1.Document.All)
            {
                if (!String.IsNullOrEmpty(item.InnerHtml))
                {
                    textBuffer.AppendLine(item.InnerText);
                    break;
                }
            }

            string text = textBuffer.ToString();


            bool result = chapterService.NewChapter(chapter, text.Split('\r'));


            if (!result)
            {
                MyMessage.Fail(chapterService.ResultMessage);
                return;
            }



            if (pbrChapter.Value == todoList.Count - 1)
            {
                MyMessage.Success("处理完毕！！！");
                return;
            }


            pbrChapter.Value++;
            Chapter nextChapter = todoList[pbrChapter.Value];


            string html = webReaderService.ReadLineList(nextChapter.GetChapterUrl());

            webBrowser1.DocumentText = html;
        }





    }
}
