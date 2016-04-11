namespace MyTranslate.App.UI
{
    partial class FormDataSwitch
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
            this.gvLines = new System.Windows.Forms.DataGridView();
            this.lineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.btnExpBook = new System.Windows.Forms.Button();
            this.btnImpBook = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnImp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboChapters = new MyTranslate.App.UI.ComboBoxChapters();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBooks = new MyTranslate.App.UI.ComboBoxBooks();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translateTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBlankDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chapterCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gvLines, 0, 1);
            this.tlpMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(884, 437);
            this.tlpMain.TabIndex = 1;
            // 
            // gvLines
            // 
            this.gvLines.AllowUserToAddRows = false;
            this.gvLines.AllowUserToDeleteRows = false;
            this.gvLines.AllowUserToOrderColumns = true;
            this.gvLines.AutoGenerateColumns = false;
            this.gvLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineIDDataGridViewTextBoxColumn,
            this.lineNumberDataGridViewTextBoxColumn,
            this.sourceTextDataGridViewTextBoxColumn,
            this.machineTextDataGridViewTextBoxColumn,
            this.translateTextDataGridViewTextBoxColumn,
            this.isBlankDataGridViewCheckBoxColumn,
            this.chapterCodeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.createUserDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.lastUpdateUserDataGridViewTextBoxColumn,
            this.lastUpdateTimeDataGridViewTextBoxColumn});
            this.gvLines.DataSource = this.lineBindingSource;
            this.gvLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvLines.Location = new System.Drawing.Point(3, 83);
            this.gvLines.Name = "gvLines";
            this.gvLines.ReadOnly = true;
            this.gvLines.RowTemplate.Height = 23;
            this.gvLines.Size = new System.Drawing.Size(878, 351);
            this.gvLines.TabIndex = 0;
            // 
            // lineBindingSource
            // 
            this.lineBindingSource.DataSource = typeof(MyTranslate.Model.Line);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnSaveBook);
            this.pnlHeader.Controls.Add(this.btnExpBook);
            this.pnlHeader.Controls.Add(this.btnImpBook);
            this.pnlHeader.Controls.Add(this.btnSave);
            this.pnlHeader.Controls.Add(this.btnExp);
            this.pnlHeader.Controls.Add(this.btnImp);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.cboChapters);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.cboBooks);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(833, 74);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Enabled = false;
            this.btnSaveBook.Location = new System.Drawing.Point(740, 12);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBook.TabIndex = 11;
            this.btnSaveBook.Text = "存储书籍";
            this.btnSaveBook.UseVisualStyleBackColor = true;
            this.btnSaveBook.Click += new System.EventHandler(this.btnSaveBook_Click);
            // 
            // btnExpBook
            // 
            this.btnExpBook.Location = new System.Drawing.Point(475, 12);
            this.btnExpBook.Name = "btnExpBook";
            this.btnExpBook.Size = new System.Drawing.Size(75, 23);
            this.btnExpBook.TabIndex = 10;
            this.btnExpBook.Text = "导出书籍";
            this.btnExpBook.UseVisualStyleBackColor = true;
            this.btnExpBook.Click += new System.EventHandler(this.btnExpBook_Click);
            // 
            // btnImpBook
            // 
            this.btnImpBook.Location = new System.Drawing.Point(659, 12);
            this.btnImpBook.Name = "btnImpBook";
            this.btnImpBook.Size = new System.Drawing.Size(75, 23);
            this.btnImpBook.TabIndex = 9;
            this.btnImpBook.Text = "导入书籍";
            this.btnImpBook.UseVisualStyleBackColor = true;
            this.btnImpBook.Click += new System.EventHandler(this.btnImpBook_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(740, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "存储章节";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(475, 42);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(75, 23);
            this.btnExp.TabIndex = 7;
            this.btnExp.Text = "导出章节";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnImp
            // 
            this.btnImp.Location = new System.Drawing.Point(659, 42);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(75, 23);
            this.btnImp.TabIndex = 6;
            this.btnImp.Text = "导入章节";
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "章节";
            // 
            // cboChapters
            // 
            this.cboChapters.DisplayMember = "DisplayChapterName";
            this.cboChapters.FormattingEnabled = true;
            this.cboChapters.Location = new System.Drawing.Point(85, 43);
            this.cboChapters.Name = "cboChapters";
            this.cboChapters.Size = new System.Drawing.Size(384, 20);
            this.cboChapters.TabIndex = 4;
            this.cboChapters.ValueMember = "ChapterCode";
            this.cboChapters.SelectedIndexChanged += new System.EventHandler(this.cboChapters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "书籍";
            // 
            // cboBooks
            // 
            this.cboBooks.DisplayMember = "BookName";
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(85, 13);
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(384, 20);
            this.cboBooks.TabIndex = 2;
            this.cboBooks.ValueMember = "BookCode";
            this.cboBooks.SelectedIndexChanged += new System.EventHandler(this.cboBooks_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML文件|*.xml|所有文件|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML文件|*.xml|所有文件|*.*";
            // 
            // lineIDDataGridViewTextBoxColumn
            // 
            this.lineIDDataGridViewTextBoxColumn.DataPropertyName = "LineID";
            this.lineIDDataGridViewTextBoxColumn.HeaderText = "行流水";
            this.lineIDDataGridViewTextBoxColumn.Name = "lineIDDataGridViewTextBoxColumn";
            this.lineIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineNumberDataGridViewTextBoxColumn
            // 
            this.lineNumberDataGridViewTextBoxColumn.DataPropertyName = "LineNumber";
            this.lineNumberDataGridViewTextBoxColumn.HeaderText = "第几行";
            this.lineNumberDataGridViewTextBoxColumn.Name = "lineNumberDataGridViewTextBoxColumn";
            this.lineNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceTextDataGridViewTextBoxColumn
            // 
            this.sourceTextDataGridViewTextBoxColumn.DataPropertyName = "SourceText";
            this.sourceTextDataGridViewTextBoxColumn.HeaderText = "原文";
            this.sourceTextDataGridViewTextBoxColumn.Name = "sourceTextDataGridViewTextBoxColumn";
            this.sourceTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceTextDataGridViewTextBoxColumn.Width = 150;
            // 
            // machineTextDataGridViewTextBoxColumn
            // 
            this.machineTextDataGridViewTextBoxColumn.DataPropertyName = "MachineText";
            this.machineTextDataGridViewTextBoxColumn.HeaderText = "机翻文本";
            this.machineTextDataGridViewTextBoxColumn.Name = "machineTextDataGridViewTextBoxColumn";
            this.machineTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.machineTextDataGridViewTextBoxColumn.Width = 150;
            // 
            // translateTextDataGridViewTextBoxColumn
            // 
            this.translateTextDataGridViewTextBoxColumn.DataPropertyName = "TranslateText";
            this.translateTextDataGridViewTextBoxColumn.HeaderText = "结果文本";
            this.translateTextDataGridViewTextBoxColumn.Name = "translateTextDataGridViewTextBoxColumn";
            this.translateTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.translateTextDataGridViewTextBoxColumn.Width = 150;
            // 
            // isBlankDataGridViewCheckBoxColumn
            // 
            this.isBlankDataGridViewCheckBoxColumn.DataPropertyName = "IsBlank";
            this.isBlankDataGridViewCheckBoxColumn.HeaderText = "IsBlank";
            this.isBlankDataGridViewCheckBoxColumn.Name = "isBlankDataGridViewCheckBoxColumn";
            this.isBlankDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isBlankDataGridViewCheckBoxColumn.Visible = false;
            // 
            // chapterCodeDataGridViewTextBoxColumn
            // 
            this.chapterCodeDataGridViewTextBoxColumn.DataPropertyName = "ChapterCode";
            this.chapterCodeDataGridViewTextBoxColumn.HeaderText = "ChapterCode";
            this.chapterCodeDataGridViewTextBoxColumn.Name = "chapterCodeDataGridViewTextBoxColumn";
            this.chapterCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.chapterCodeDataGridViewTextBoxColumn.Visible = false;
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
            // createUserDataGridViewTextBoxColumn
            // 
            this.createUserDataGridViewTextBoxColumn.DataPropertyName = "CreateUser";
            this.createUserDataGridViewTextBoxColumn.HeaderText = "CreateUser";
            this.createUserDataGridViewTextBoxColumn.Name = "createUserDataGridViewTextBoxColumn";
            this.createUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.createUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastUpdateUserDataGridViewTextBoxColumn
            // 
            this.lastUpdateUserDataGridViewTextBoxColumn.DataPropertyName = "LastUpdateUser";
            this.lastUpdateUserDataGridViewTextBoxColumn.HeaderText = "LastUpdateUser";
            this.lastUpdateUserDataGridViewTextBoxColumn.Name = "lastUpdateUserDataGridViewTextBoxColumn";
            this.lastUpdateUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastUpdateUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastUpdateTimeDataGridViewTextBoxColumn
            // 
            this.lastUpdateTimeDataGridViewTextBoxColumn.DataPropertyName = "LastUpdateTime";
            this.lastUpdateTimeDataGridViewTextBoxColumn.HeaderText = "LastUpdateTime";
            this.lastUpdateTimeDataGridViewTextBoxColumn.Name = "lastUpdateTimeDataGridViewTextBoxColumn";
            this.lastUpdateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastUpdateTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormDataSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 437);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormDataSwitch";
            this.Text = "数据交换";
            this.Load += new System.EventHandler(this.FormDataSwitch_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.DataGridView gvLines;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label2;
        private ComboBoxChapters cboChapters;
        private System.Windows.Forms.Label label1;
        private ComboBoxBooks cboBooks;
        private System.Windows.Forms.BindingSource lineBindingSource;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImpBook;
        private System.Windows.Forms.Button btnExpBook;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translateTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBlankDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateTimeDataGridViewTextBoxColumn;
    }
}