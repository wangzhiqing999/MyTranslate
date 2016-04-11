namespace MyTranslate.App.UI
{
    partial class FormChapters
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
            this.chapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBooks = new MyTranslate.App.UI.ComboBoxBooks();
            this.chapterCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChapterTranslateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChapters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gvChapters, 0, 1);
            this.tlpMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(847, 496);
            this.tlpMain.TabIndex = 0;
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
            this.ChapterTranslateName,
            this.bookCodeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.createUserDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.lastUpdateUserDataGridViewTextBoxColumn,
            this.lastUpdateTimeDataGridViewTextBoxColumn});
            this.gvChapters.DataSource = this.chapterBindingSource;
            this.gvChapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvChapters.Location = new System.Drawing.Point(3, 53);
            this.gvChapters.Name = "gvChapters";
            this.gvChapters.ReadOnly = true;
            this.gvChapters.RowTemplate.Height = 23;
            this.gvChapters.Size = new System.Drawing.Size(841, 440);
            this.gvChapters.TabIndex = 0;
            this.gvChapters.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvChapters_CellMouseDoubleClick);
            // 
            // chapterBindingSource
            // 
            this.chapterBindingSource.DataSource = typeof(MyTranslate.Model.Chapter);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.cboBooks);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(752, 44);
            this.pnlHeader.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "双击单元格，进行编辑。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books";
            // 
            // cboBooks
            // 
            this.cboBooks.DisplayMember = "BookName";
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(93, 13);
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(162, 20);
            this.cboBooks.TabIndex = 0;
            this.cboBooks.ValueMember = "BookCode";
            this.cboBooks.SelectedIndexChanged += new System.EventHandler(this.cboBooks_SelectedIndexChanged);
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
            this.chapterNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // ChapterTranslateName
            // 
            this.ChapterTranslateName.DataPropertyName = "ChapterTranslateName";
            this.ChapterTranslateName.HeaderText = "章节译名";
            this.ChapterTranslateName.Name = "ChapterTranslateName";
            this.ChapterTranslateName.ReadOnly = true;
            this.ChapterTranslateName.Width = 250;
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
            // FormChapters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 496);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormChapters";
            this.Text = "章节";
            this.Load += new System.EventHandler(this.FormChapters_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvChapters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.DataGridView gvChapters;
        private System.Windows.Forms.BindingSource chapterBindingSource;
        private System.Windows.Forms.Panel pnlHeader;
        private ComboBoxBooks cboBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapterTranslateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateTimeDataGridViewTextBoxColumn;
    }
}