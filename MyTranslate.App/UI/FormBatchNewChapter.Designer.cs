namespace MyTranslate.App.UI
{
    partial class FormBatchNewChapter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gvWebChapters = new System.Windows.Forms.DataGridView();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chapterCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterUrlDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gvChapters = new System.Windows.Forms.DataGridView();
            this.chapterCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFoot = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLoadWeb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBooks = new MyTranslate.App.UI.ComboBoxBooks();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbrChapter = new System.Windows.Forms.ProgressBar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWebChapters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChapters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).BeginInit();
            this.pnlFoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.gvWebChapters, 1, 2);
            this.tlpMain.Controls.Add(this.gvChapters, 0, 2);
            this.tlpMain.Controls.Add(this.pnlFoot, 0, 3);
            this.tlpMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMain.Controls.Add(this.label2, 0, 1);
            this.tlpMain.Controls.Add(this.pbrChapter, 0, 4);
            this.tlpMain.Controls.Add(this.webBrowser1, 1, 4);
            this.tlpMain.Controls.Add(this.panel1, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(903, 540);
            this.tlpMain.TabIndex = 1;
            // 
            // gvWebChapters
            // 
            this.gvWebChapters.AllowUserToAddRows = false;
            this.gvWebChapters.AllowUserToDeleteRows = false;
            this.gvWebChapters.AutoGenerateColumns = false;
            this.gvWebChapters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWebChapters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsActive,
            this.chapterCodeDataGridViewTextBoxColumn1,
            this.chapterNameDataGridViewTextBoxColumn1,
            this.chapterUrlDataGridViewTextBoxColumn1});
            this.gvWebChapters.DataSource = this.chapterBindingSource1;
            this.gvWebChapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvWebChapters.Location = new System.Drawing.Point(454, 93);
            this.gvWebChapters.Name = "gvWebChapters";
            this.gvWebChapters.RowTemplate.Height = 23;
            this.gvWebChapters.Size = new System.Drawing.Size(446, 374);
            this.gvWebChapters.TabIndex = 4;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "选择";
            this.IsActive.Name = "IsActive";
            // 
            // chapterCodeDataGridViewTextBoxColumn1
            // 
            this.chapterCodeDataGridViewTextBoxColumn1.DataPropertyName = "ChapterCode";
            this.chapterCodeDataGridViewTextBoxColumn1.HeaderText = "章节代码";
            this.chapterCodeDataGridViewTextBoxColumn1.Name = "chapterCodeDataGridViewTextBoxColumn1";
            this.chapterCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // chapterNameDataGridViewTextBoxColumn1
            // 
            this.chapterNameDataGridViewTextBoxColumn1.DataPropertyName = "ChapterName";
            this.chapterNameDataGridViewTextBoxColumn1.HeaderText = "章节名称";
            this.chapterNameDataGridViewTextBoxColumn1.Name = "chapterNameDataGridViewTextBoxColumn1";
            this.chapterNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // chapterUrlDataGridViewTextBoxColumn1
            // 
            this.chapterUrlDataGridViewTextBoxColumn1.DataPropertyName = "ChapterUrl";
            this.chapterUrlDataGridViewTextBoxColumn1.HeaderText = "网页地址";
            this.chapterUrlDataGridViewTextBoxColumn1.Name = "chapterUrlDataGridViewTextBoxColumn1";
            this.chapterUrlDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // chapterBindingSource1
            // 
            this.chapterBindingSource1.DataSource = typeof(MyTranslate.Model.Chapter);
            // 
            // gvChapters
            // 
            this.gvChapters.AllowUserToAddRows = false;
            this.gvChapters.AllowUserToDeleteRows = false;
            this.gvChapters.AutoGenerateColumns = false;
            this.gvChapters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChapters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chapterCodeDataGridViewTextBoxColumn,
            this.chapterNameDataGridViewTextBoxColumn,
            this.chapterUrlDataGridViewTextBoxColumn,
            this.bookCodeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.gvChapters.DataSource = this.chapterBindingSource;
            this.gvChapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvChapters.Location = new System.Drawing.Point(3, 93);
            this.gvChapters.Name = "gvChapters";
            this.gvChapters.ReadOnly = true;
            this.gvChapters.RowTemplate.Height = 23;
            this.gvChapters.Size = new System.Drawing.Size(445, 374);
            this.gvChapters.TabIndex = 3;
            // 
            // chapterCodeDataGridViewTextBoxColumn
            // 
            this.chapterCodeDataGridViewTextBoxColumn.DataPropertyName = "ChapterCode";
            this.chapterCodeDataGridViewTextBoxColumn.HeaderText = "章节代码";
            this.chapterCodeDataGridViewTextBoxColumn.Name = "chapterCodeDataGridViewTextBoxColumn";
            this.chapterCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chapterNameDataGridViewTextBoxColumn
            // 
            this.chapterNameDataGridViewTextBoxColumn.DataPropertyName = "ChapterName";
            this.chapterNameDataGridViewTextBoxColumn.HeaderText = "章节名称";
            this.chapterNameDataGridViewTextBoxColumn.Name = "chapterNameDataGridViewTextBoxColumn";
            this.chapterNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chapterUrlDataGridViewTextBoxColumn
            // 
            this.chapterUrlDataGridViewTextBoxColumn.DataPropertyName = "ChapterUrl";
            this.chapterUrlDataGridViewTextBoxColumn.HeaderText = "网页地址";
            this.chapterUrlDataGridViewTextBoxColumn.Name = "chapterUrlDataGridViewTextBoxColumn";
            this.chapterUrlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookCodeDataGridViewTextBoxColumn
            // 
            this.bookCodeDataGridViewTextBoxColumn.DataPropertyName = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn.HeaderText = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn.Name = "bookCodeDataGridViewTextBoxColumn";
            this.bookCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // chapterBindingSource
            // 
            this.chapterBindingSource.DataSource = typeof(MyTranslate.Model.Chapter);
            // 
            // pnlFoot
            // 
            this.tlpMain.SetColumnSpan(this.pnlFoot, 2);
            this.pnlFoot.Controls.Add(this.btnSave);
            this.pnlFoot.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFoot.Location = new System.Drawing.Point(3, 473);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(822, 44);
            this.pnlFoot.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(304, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlHeader
            // 
            this.tlpMain.SetColumnSpan(this.pnlHeader, 2);
            this.pnlHeader.Controls.Add(this.btnLoadWeb);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.cboBooks);
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(822, 44);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnLoadWeb
            // 
            this.btnLoadWeb.Location = new System.Drawing.Point(304, 9);
            this.btnLoadWeb.Name = "btnLoadWeb";
            this.btnLoadWeb.Size = new System.Drawing.Size(75, 23);
            this.btnLoadWeb.TabIndex = 4;
            this.btnLoadWeb.Text = "加载网站";
            this.btnLoadWeb.UseVisualStyleBackColor = true;
            this.btnLoadWeb.Click += new System.EventHandler(this.btnLoadWeb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "书籍";
            // 
            // cboBooks
            // 
            this.cboBooks.DisplayMember = "BookName";
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(89, 9);
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(162, 20);
            this.cboBooks.TabIndex = 2;
            this.cboBooks.ValueMember = "BookCode";
            this.cboBooks.SelectedIndexChanged += new System.EventHandler(this.cboBooks_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "本机";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "网站";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbrChapter
            // 
            this.pbrChapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbrChapter.Location = new System.Drawing.Point(3, 523);
            this.pbrChapter.Name = "pbrChapter";
            this.pbrChapter.Size = new System.Drawing.Size(445, 14);
            this.pbrChapter.TabIndex = 7;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(454, 523);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(446, 20);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSelectAll);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(454, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 34);
            this.panel1.TabIndex = 9;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(15, 10);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(48, 16);
            this.chkSelectAll.TabIndex = 7;
            this.chkSelectAll.Text = "全选";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // FormBatchNewChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 540);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormBatchNewChapter";
            this.Text = "批量新增章节";
            this.Load += new System.EventHandler(this.FormBatchNewChapter_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvWebChapters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChapters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).EndInit();
            this.pnlFoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private ComboBoxBooks cboBooks;
        private System.Windows.Forms.Panel pnlFoot;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gvChapters;
        private System.Windows.Forms.DataGridView gvWebChapters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadWeb;
        private System.Windows.Forms.BindingSource chapterBindingSource1;
        private System.Windows.Forms.BindingSource chapterBindingSource;
        private System.Windows.Forms.ProgressBar pbrChapter;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterUrlDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkSelectAll;
    }
}