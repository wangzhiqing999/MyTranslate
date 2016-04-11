namespace MyTranslate.App
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaptersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSwitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.namesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchNewChapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newChapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoTransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualTransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.workToolStripMenuItem,
            this.resultToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.chaptersToolStripMenuItem,
            this.linesToolStripMenuItem,
            this.autoReplaceToolStripMenuItem,
            this.dataSwitchToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.systemToolStripMenuItem.Text = "系统";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.booksToolStripMenuItem.Text = "书籍";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // chaptersToolStripMenuItem
            // 
            this.chaptersToolStripMenuItem.Name = "chaptersToolStripMenuItem";
            this.chaptersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chaptersToolStripMenuItem.Text = "章节";
            this.chaptersToolStripMenuItem.Click += new System.EventHandler(this.chaptersToolStripMenuItem_Click);
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.linesToolStripMenuItem.Text = "行";
            this.linesToolStripMenuItem.Click += new System.EventHandler(this.linesToolStripMenuItem_Click);
            // 
            // autoReplaceToolStripMenuItem
            // 
            this.autoReplaceToolStripMenuItem.Name = "autoReplaceToolStripMenuItem";
            this.autoReplaceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.autoReplaceToolStripMenuItem.Text = "自动替换";
            this.autoReplaceToolStripMenuItem.Click += new System.EventHandler(this.autoReplaceToolStripMenuItem_Click);
            // 
            // dataSwitchToolStripMenuItem
            // 
            this.dataSwitchToolStripMenuItem.Name = "dataSwitchToolStripMenuItem";
            this.dataSwitchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataSwitchToolStripMenuItem.Text = "数据交换";
            this.dataSwitchToolStripMenuItem.Click += new System.EventHandler(this.dataSwitchToolStripMenuItem_Click);
            // 
            // workToolStripMenuItem
            // 
            this.workToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBookToolStripMenuItem,
            this.namesToolStripMenuItem,
            this.nameManagerToolStripMenuItem,
            this.batchNewChapterToolStripMenuItem,
            this.newChapterToolStripMenuItem,
            this.autoTransToolStripMenuItem,
            this.manualTransToolStripMenuItem});
            this.workToolStripMenuItem.Name = "workToolStripMenuItem";
            this.workToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.workToolStripMenuItem.Text = "作业";
            // 
            // newBookToolStripMenuItem
            // 
            this.newBookToolStripMenuItem.Name = "newBookToolStripMenuItem";
            this.newBookToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newBookToolStripMenuItem.Text = "新书籍";
            this.newBookToolStripMenuItem.Click += new System.EventHandler(this.newBookToolStripMenuItem_Click);
            // 
            // namesToolStripMenuItem
            // 
            this.namesToolStripMenuItem.Name = "namesToolStripMenuItem";
            this.namesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.namesToolStripMenuItem.Text = "名称";
            this.namesToolStripMenuItem.Click += new System.EventHandler(this.namesToolStripMenuItem_Click);
            // 
            // nameManagerToolStripMenuItem
            // 
            this.nameManagerToolStripMenuItem.Name = "nameManagerToolStripMenuItem";
            this.nameManagerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nameManagerToolStripMenuItem.Text = "名称管理";
            this.nameManagerToolStripMenuItem.Click += new System.EventHandler(this.nameManagerToolStripMenuItem_Click);
            // 
            // batchNewChapterToolStripMenuItem
            // 
            this.batchNewChapterToolStripMenuItem.Name = "batchNewChapterToolStripMenuItem";
            this.batchNewChapterToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.batchNewChapterToolStripMenuItem.Text = "批量新增章节";
            this.batchNewChapterToolStripMenuItem.Click += new System.EventHandler(this.batchNewChapterToolStripMenuItem_Click);
            // 
            // newChapterToolStripMenuItem
            // 
            this.newChapterToolStripMenuItem.Name = "newChapterToolStripMenuItem";
            this.newChapterToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newChapterToolStripMenuItem.Text = "新章节";
            this.newChapterToolStripMenuItem.Click += new System.EventHandler(this.newChapterToolStripMenuItem_Click);
            // 
            // autoTransToolStripMenuItem
            // 
            this.autoTransToolStripMenuItem.Name = "autoTransToolStripMenuItem";
            this.autoTransToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.autoTransToolStripMenuItem.Text = "机翻";
            this.autoTransToolStripMenuItem.Click += new System.EventHandler(this.autoTransToolStripMenuItem_Click);
            // 
            // manualTransToolStripMenuItem
            // 
            this.manualTransToolStripMenuItem.Name = "manualTransToolStripMenuItem";
            this.manualTransToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.manualTransToolStripMenuItem.Text = "人工翻译";
            this.manualTransToolStripMenuItem.Click += new System.EventHandler(this.manualTransToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transResultToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.resultToolStripMenuItem.Text = "结果";
            // 
            // transResultToolStripMenuItem
            // 
            this.transResultToolStripMenuItem.Name = "transResultToolStripMenuItem";
            this.transResultToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.transResultToolStripMenuItem.Text = "生成结果文本";
            this.transResultToolStripMenuItem.Click += new System.EventHandler(this.transResultToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exportToolStripMenuItem.Text = "导出文本文件";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.showToolStripMenuItem.Text = "打开窗口";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "退出";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaptersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newChapterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoTransToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualTransToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem namesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchNewChapterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSwitchToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

