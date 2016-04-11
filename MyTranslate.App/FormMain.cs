using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Data.Entity;
using System.Data.Entity.Migrations;

using System.Reflection;

using MyTranslate.App.UI;


namespace MyTranslate.App
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();


            // 当 Code First 与数据库结构不一致时
            // 自动升级到最新的版本.
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyTranslate.DataAccess.MyTranslateContext, MyTranslate.Migrations.Configuration>());





            // 提示当前程序版本信息.
            this.Text = "翻译小工具 - V " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            this.notifyIcon1.Text = this.Text;

        }



        /// <summary>
        /// 书.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBooks subForm = new FormBooks();
            subForm.MdiParent = this;
            subForm.Show();
        }


        /// <summary>
        /// 章节.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chaptersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChapters subForm = new FormChapters();
            subForm.MdiParent = this;
            subForm.Show();
        }


        /// <summary>
        /// 行.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLines subForm = new FormLines();
            subForm.MdiParent = this;
            subForm.Show();
        }


        /// <summary>
        /// 自动替换.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAutoReplace subForm = new FormAutoReplace();
            subForm.MdiParent = this;
            subForm.Show();
        }


        /// <summary>
        /// 名称管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNameManager subForm = new FormNameManager();
            subForm.MdiParent = this;
            subForm.Show();
        }







        /// <summary>
        /// 新书籍.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewBook subForm = new FormNewBook();
            subForm.MdiParent = this;
            subForm.Show();
        }



        /// <summary>
        /// 批量新增章节.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void batchNewChapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBatchNewChapter subForm = new FormBatchNewChapter();
            subForm.MdiParent = this;
            subForm.Show();
        }


        /// <summary>
        /// 新章节.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newChapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewChapter subForm = new FormNewChapter();
            subForm.MdiParent = this;
            subForm.Show();

        }


        /// <summary>
        /// 自动机翻处理.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAutoTrans subForm = new FormAutoTrans();
            subForm.MdiParent = this;
            subForm.Show();
        }



        /// <summary>
        /// 名词处理.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void namesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNames subForm = new FormNames();
            subForm.MdiParent = this;
            subForm.Show();
        }



        /// <summary>
        /// 人工处理.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manualTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManualTrans subForm = new FormManualTrans();
            subForm.MdiParent = this;
            subForm.Show();
        }




        /// <summary>
        /// 结果.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResult subForm = new FormResult();
            subForm.MdiParent = this;
            subForm.Show();
        }


        /// <summary>
        /// 导出.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExport subForm = new FormExport();
            subForm.MdiParent = this;
            subForm.Show();
        }




        /// <summary>
        /// 数据交换.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataSwitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataSwitch subForm = new FormDataSwitch();
            subForm.MdiParent = this;
            subForm.Show();
        }













        /// <summary>
        /// 窗口隐藏模式.
        /// </summary>
        private bool hideMode = true;

        /// <summary>
        /// 窗口关闭.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = hideMode;
        }



        /// <summary>
        /// 双击.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            // 显示窗口.
            this.Show();
            this.Activate();
        }



        /// <summary>
        /// 弹出菜单的 打开.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }


        /// <summary>
        /// 弹出菜单的 退出.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 真的要退出了，取消隐藏模式.
            hideMode = false;

            // 关闭主窗口.
            this.Close();
        }


        /// <summary>
        /// 主菜单的 退出.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 真的要退出了，取消隐藏模式.
            hideMode = false;

            // 关闭主窗口.
            this.Close();
        }











 



    }
}
