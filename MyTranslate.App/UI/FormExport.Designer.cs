namespace MyTranslate.App.UI
{
    partial class FormExport
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
            this.gvChapters = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExp = new System.Windows.Forms.Button();
            this.rdoAllChapterOneFile = new System.Windows.Forms.RadioButton();
            this.rdoOneChapterOneFile = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboBooks = new MyTranslate.App.UI.ComboBoxBooks();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chapterCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChapters)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gvChapters, 0, 3);
            this.tlpMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMain.Controls.Add(this.panel1, 0, 1);
            this.tlpMain.Controls.Add(this.panel2, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(984, 588);
            this.tlpMain.TabIndex = 2;
            // 
            // gvChapters
            // 
            this.gvChapters.AllowUserToAddRows = false;
            this.gvChapters.AllowUserToDeleteRows = false;
            this.gvChapters.AutoGenerateColumns = false;
            this.gvChapters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChapters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isActiveDataGridViewCheckBoxColumn,
            this.chapterCodeDataGridViewTextBoxColumn,
            this.chapterNameDataGridViewTextBoxColumn});
            this.gvChapters.DataSource = this.chapterBindingSource;
            this.gvChapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvChapters.Location = new System.Drawing.Point(3, 153);
            this.gvChapters.Name = "gvChapters";
            this.gvChapters.RowTemplate.Height = 23;
            this.gvChapters.Size = new System.Drawing.Size(978, 432);
            this.gvChapters.TabIndex = 3;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.cboBooks);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(335, 44);
            this.pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Books";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelectPath);
            this.panel1.Controls.Add(this.txtOutputPath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 44);
            this.panel1.TabIndex = 2;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(738, 15);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPath.TabIndex = 2;
            this.btnSelectPath.Text = "选择...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(85, 16);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(621, 21);
            this.txtOutputPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "导出目录";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExp);
            this.panel2.Controls.Add(this.rdoAllChapterOneFile);
            this.panel2.Controls.Add(this.rdoOneChapterOneFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 44);
            this.panel2.TabIndex = 4;
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(738, 10);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(75, 23);
            this.btnExp.TabIndex = 2;
            this.btnExp.Text = "导出";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // rdoAllChapterOneFile
            // 
            this.rdoAllChapterOneFile.AutoSize = true;
            this.rdoAllChapterOneFile.Location = new System.Drawing.Point(164, 16);
            this.rdoAllChapterOneFile.Name = "rdoAllChapterOneFile";
            this.rdoAllChapterOneFile.Size = new System.Drawing.Size(95, 16);
            this.rdoAllChapterOneFile.TabIndex = 1;
            this.rdoAllChapterOneFile.Text = "全部一个文件";
            this.rdoAllChapterOneFile.UseVisualStyleBackColor = true;
            // 
            // rdoOneChapterOneFile
            // 
            this.rdoOneChapterOneFile.AutoSize = true;
            this.rdoOneChapterOneFile.Checked = true;
            this.rdoOneChapterOneFile.Location = new System.Drawing.Point(28, 16);
            this.rdoOneChapterOneFile.Name = "rdoOneChapterOneFile";
            this.rdoOneChapterOneFile.Size = new System.Drawing.Size(107, 16);
            this.rdoOneChapterOneFile.TabIndex = 0;
            this.rdoOneChapterOneFile.TabStop = true;
            this.rdoOneChapterOneFile.Text = "每章节一个文件";
            this.rdoOneChapterOneFile.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // chapterBindingSource
            // 
            this.chapterBindingSource.DataSource = typeof(MyTranslate.Model.Chapter);
            // 
            // cboBooks
            // 
            this.cboBooks.DisplayMember = "BookName";
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(85, 13);
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(186, 20);
            this.cboBooks.TabIndex = 2;
            this.cboBooks.ValueMember = "BookCode";
            this.cboBooks.SelectedIndexChanged += new System.EventHandler(this.cboBooks_SelectedIndexChanged);
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "选择";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // chapterCodeDataGridViewTextBoxColumn
            // 
            this.chapterCodeDataGridViewTextBoxColumn.DataPropertyName = "ChapterCode";
            this.chapterCodeDataGridViewTextBoxColumn.HeaderText = "ChapterCode";
            this.chapterCodeDataGridViewTextBoxColumn.Name = "chapterCodeDataGridViewTextBoxColumn";
            this.chapterCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chapterNameDataGridViewTextBoxColumn
            // 
            this.chapterNameDataGridViewTextBoxColumn.DataPropertyName = "ChapterName";
            this.chapterNameDataGridViewTextBoxColumn.HeaderText = "ChapterName";
            this.chapterNameDataGridViewTextBoxColumn.Name = "chapterNameDataGridViewTextBoxColumn";
            this.chapterNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.chapterNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // FormExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 588);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormExport";
            this.Text = "导出文本";
            this.Load += new System.EventHandler(this.FormExport_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvChapters)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private ComboBoxBooks cboBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView gvChapters;
        private System.Windows.Forms.BindingSource chapterBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoOneChapterOneFile;
        private System.Windows.Forms.RadioButton rdoAllChapterOneFile;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterNameDataGridViewTextBoxColumn;
    }
}