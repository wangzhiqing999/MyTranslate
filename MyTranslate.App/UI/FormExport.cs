using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;


using Velocity = NVelocity.App.Velocity;
using VelocityContext = NVelocity.VelocityContext;
using Template = NVelocity.Template;
using ParseErrorException = NVelocity.Exception.ParseErrorException;
using ResourceNotFoundException = NVelocity.Exception.ResourceNotFoundException;




using MyTranslate.Model;
using MyTranslate.DataAccess;
using MyTranslate.ServiceImpl;
using MyTranslate.Util;

using MyTranslate.App.Common;


namespace MyTranslate.App.UI
{
    public partial class FormExport : Form
    {
        public FormExport()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 章节列表.
        /// </summary>
        private List<Chapter> chapterList;



        /// <summary>
        /// 行服务.
        /// </summary>
        private LineServiceImpl lineService = new LineServiceImpl();


        /// <summary>
        /// 书代码.
        /// </summary>
        private string bookCode;





        /// <summary>
        /// 初始化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormExport_Load(object sender, EventArgs e)
        {
            // 初始化下拉列表.
            this.cboBooks.InitBooks();

            this.cboTemplate.InitTemplate();
        }



        /// <summary>
        /// 书下拉列表发生变化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 取得代码.
            bookCode = this.cboBooks.SelectedValue as string;


            // 再次检索.
            using (MyTranslateContext context = new MyTranslateContext())
            {

                chapterList = context.Chapters.Where(p => p.BookCode == bookCode).ToList();

                this.gvChapters.DataSource = null;
                this.gvChapters.DataSource = chapterList;

            }
        }


        /// <summary>
        /// 选择目录.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtOutputPath.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }



        /// <summary>
        /// 导出.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExp_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.txtOutputPath.Text))
            {
                MyMessage.Warn("导出目录不存在！");
                return;
            }



            if (this.rdoOneChapterOneFile.Checked)
            {
                // 一章节一个文件.
                foreach (Chapter c in chapterList)
                {
                    if (c.IsActive)
                    {
                        BuildOneFile(c);
                    }
                }
            }
            else
            {
                // 所有章节，一个文件.

                var query =
                    from data in chapterList
                    where
                        data.IsActive
                    orderby
                        data.ChapterSubCode
                    select data;

                List<Chapter> dataList = query.ToList();

                BuildAllFile(dataList);
            }

            MyMessage.Success("导出完毕！");
            
        }



        /// <summary>
        /// 创建单个文件.
        /// </summary>
        private void BuildOneFile(Chapter c)
        {

            List<Chapter> chapterList = new List<Chapter>();

            Chapter myChapter = new Chapter();
            myChapter.BookCode = c.BookCode;
            myChapter.ChapterCode = c.ChapterCode;
            myChapter.ChapterName = c.ChapterName;
            

            // 取得行列表.
            myChapter.Lines = lineService.GetChapterLineList(c.ChapterCode);


            
            chapterList.Add(myChapter);


            // Velocity 初始化.
            // 从配置文件读取配置信息.
            Velocity.Init("nvelocity.properties");
            // 创建 Velocity Context
            VelocityContext context = new VelocityContext();
            // 将列表的数据， 以 ChapterList 作为名称，放入 context.
            context.Put("ChapterList", chapterList);



            // 模版.
            Template template = null;

            string templateFile = this.cboTemplate.Text;


            // 尝试加载模版文件.
            try
            {
                template = Velocity.GetTemplate(templateFile);
            }
            catch (ResourceNotFoundException)
            {
                MyMessage.Fail(String.Format("未能找到模板文件：{0}", templateFile));
            }
            catch (ParseErrorException pee)
            {
                MyMessage.Fail(String.Format("解析模板文件 {0} 发生了异常！\n{1}", templateFile, pee));
            }


            try
            {

                // 处理模版信息.
                if (template != null)
                {

                    string fileName = String.Format("{0}\\{1}.{2}", this.txtOutputPath.Text, c.ChapterSubCode, this.cboTemplate.SelectedFileType);

                    using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
                    {
                        template.Merge(context, sw);
                    }
                }
            }
            catch(Exception ex)
            {
                MyMessage.Fail(String.Format("根据模板文件 {0} 生成文档的过程中，发生了异常！\n{1}", templateFile, ex));
            }
        }




        private void BuildAllFile(List<Chapter> cList)
        {
            List<Chapter> chapterList = new List<Chapter>();

            foreach (var c in cList)
            {
                Chapter myChapter = new Chapter();
                myChapter.BookCode = c.BookCode;
                myChapter.ChapterCode = c.ChapterCode;
                myChapter.ChapterName = c.ChapterName;


                // 取得行列表.
                myChapter.Lines = lineService.GetChapterLineList(c.ChapterCode);

                chapterList.Add(myChapter);
            }

            // Velocity 初始化.
            // 从配置文件读取配置信息.
            Velocity.Init("nvelocity.properties");
            // 创建 Velocity Context
            VelocityContext context = new VelocityContext();
            // 将列表的数据， 以 ChapterList 作为名称，放入 context.
            context.Put("ChapterList", chapterList);



            // 模版.
            Template template = null;

            string templateFile = this.cboTemplate.Text;


            // 尝试加载模版文件.
            try
            {
                template = Velocity.GetTemplate(templateFile);
            }
            catch (ResourceNotFoundException)
            {
                MyMessage.Fail(String.Format("未能找到模板文件：{0}", templateFile));
            }
            catch (ParseErrorException pee)
            {
                MyMessage.Fail(String.Format("解析模板文件 {0} 发生了异常！\n{1}", templateFile, pee));
            }


            try
            {

                // 处理模版信息.
                if (template != null)
                {

                    string fileName = String.Format("{0}\\{1}.{2}", this.txtOutputPath.Text, this.cboBooks.SelectedValue, this.cboTemplate.SelectedFileType);

                    using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
                    {
                        template.Merge(context, sw);
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessage.Fail(String.Format("根据模板文件 {0} 生成文档的过程中，发生了异常！\n{1}", templateFile, ex));
            }
        }



    }
}
