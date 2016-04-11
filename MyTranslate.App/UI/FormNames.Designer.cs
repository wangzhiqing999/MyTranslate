namespace MyTranslate.App.UI
{
    partial class FormNames
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
            this.lblNameCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBooks = new MyTranslate.App.UI.ComboBoxBooks();
            this.pnlFoot = new System.Windows.Forms.Panel();
            this.txtMachineTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTranslate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translateTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gvLines, 0, 1);
            this.tlpMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMain.Controls.Add(this.pnlFoot, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpMain.Size = new System.Drawing.Size(984, 527);
            this.tlpMain.TabIndex = 1;
            // 
            // gvLines
            // 
            this.gvLines.AllowUserToAddRows = false;
            this.gvLines.AllowUserToDeleteRows = false;
            this.gvLines.AutoGenerateColumns = false;
            this.gvLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineIDDataGridViewTextBoxColumn,
            this.lineNumberDataGridViewTextBoxColumn,
            this.sourceTextDataGridViewTextBoxColumn,
            this.machineTextDataGridViewTextBoxColumn,
            this.translateTextDataGridViewTextBoxColumn,
            this.chapterCodeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.createUserDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.lastUpdateUserDataGridViewTextBoxColumn,
            this.lastUpdateTimeDataGridViewTextBoxColumn});
            this.gvLines.DataSource = this.lineBindingSource;
            this.gvLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvLines.Location = new System.Drawing.Point(3, 53);
            this.gvLines.Name = "gvLines";
            this.gvLines.ReadOnly = true;
            this.gvLines.RowTemplate.Height = 23;
            this.gvLines.Size = new System.Drawing.Size(978, 351);
            this.gvLines.TabIndex = 0;
            // 
            // lineBindingSource
            // 
            this.lineBindingSource.DataSource = typeof(MyTranslate.Model.Line);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblNameCode);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.cboBooks);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(846, 44);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblNameCode
            // 
            this.lblNameCode.AutoSize = true;
            this.lblNameCode.Location = new System.Drawing.Point(413, 17);
            this.lblNameCode.Name = "lblNameCode";
            this.lblNameCode.Size = new System.Drawing.Size(11, 12);
            this.lblNameCode.TabIndex = 4;
            this.lblNameCode.Text = "-";
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
            this.cboBooks.Size = new System.Drawing.Size(186, 20);
            this.cboBooks.TabIndex = 2;
            this.cboBooks.ValueMember = "BookCode";
            this.cboBooks.SelectedIndexChanged += new System.EventHandler(this.cboBooks_SelectedIndexChanged);
            // 
            // pnlFoot
            // 
            this.pnlFoot.Controls.Add(this.txtMachineTo);
            this.pnlFoot.Controls.Add(this.label5);
            this.pnlFoot.Controls.Add(this.txtMachine);
            this.pnlFoot.Controls.Add(this.label4);
            this.pnlFoot.Controls.Add(this.btnSave);
            this.pnlFoot.Controls.Add(this.txtTranslate);
            this.pnlFoot.Controls.Add(this.label3);
            this.pnlFoot.Controls.Add(this.txtSource);
            this.pnlFoot.Controls.Add(this.label2);
            this.pnlFoot.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFoot.Location = new System.Drawing.Point(3, 410);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(888, 114);
            this.pnlFoot.TabIndex = 2;
            // 
            // txtMachineTo
            // 
            this.txtMachineTo.Location = new System.Drawing.Point(393, 47);
            this.txtMachineTo.Name = "txtMachineTo";
            this.txtMachineTo.Size = new System.Drawing.Size(191, 21);
            this.txtMachineTo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "结果文字";
            // 
            // txtMachine
            // 
            this.txtMachine.Location = new System.Drawing.Point(79, 47);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(214, 21);
            this.txtMachine.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "机翻文字";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(615, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "新增";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTranslate
            // 
            this.txtTranslate.Location = new System.Drawing.Point(78, 83);
            this.txtTranslate.Name = "txtTranslate";
            this.txtTranslate.Size = new System.Drawing.Size(505, 21);
            this.txtTranslate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "译文说明";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(79, 10);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(505, 21);
            this.txtSource.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "名词";
            // 
            // lineIDDataGridViewTextBoxColumn
            // 
            this.lineIDDataGridViewTextBoxColumn.DataPropertyName = "LineID";
            this.lineIDDataGridViewTextBoxColumn.HeaderText = "LineID";
            this.lineIDDataGridViewTextBoxColumn.Name = "lineIDDataGridViewTextBoxColumn";
            this.lineIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lineIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // lineNumberDataGridViewTextBoxColumn
            // 
            this.lineNumberDataGridViewTextBoxColumn.DataPropertyName = "LineNumber";
            this.lineNumberDataGridViewTextBoxColumn.HeaderText = "LineNumber";
            this.lineNumberDataGridViewTextBoxColumn.Name = "lineNumberDataGridViewTextBoxColumn";
            this.lineNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.lineNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // sourceTextDataGridViewTextBoxColumn
            // 
            this.sourceTextDataGridViewTextBoxColumn.DataPropertyName = "SourceText";
            this.sourceTextDataGridViewTextBoxColumn.HeaderText = "名称";
            this.sourceTextDataGridViewTextBoxColumn.Name = "sourceTextDataGridViewTextBoxColumn";
            this.sourceTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceTextDataGridViewTextBoxColumn.Width = 200;
            // 
            // machineTextDataGridViewTextBoxColumn
            // 
            this.machineTextDataGridViewTextBoxColumn.DataPropertyName = "MachineText";
            this.machineTextDataGridViewTextBoxColumn.HeaderText = "机翻文本";
            this.machineTextDataGridViewTextBoxColumn.Name = "machineTextDataGridViewTextBoxColumn";
            this.machineTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.machineTextDataGridViewTextBoxColumn.Width = 200;
            // 
            // translateTextDataGridViewTextBoxColumn
            // 
            this.translateTextDataGridViewTextBoxColumn.DataPropertyName = "TranslateText";
            this.translateTextDataGridViewTextBoxColumn.HeaderText = "结果文本";
            this.translateTextDataGridViewTextBoxColumn.Name = "translateTextDataGridViewTextBoxColumn";
            this.translateTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.translateTextDataGridViewTextBoxColumn.Width = 200;
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
            // FormNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 527);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormNames";
            this.Text = "新增名称";
            this.Load += new System.EventHandler(this.FormNames_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFoot.ResumeLayout(false);
            this.pnlFoot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.DataGridView gvLines;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private ComboBoxBooks cboBooks;
        private System.Windows.Forms.BindingSource lineBindingSource;
        private System.Windows.Forms.Panel pnlFoot;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTranslate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNameCode;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMachineTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translateTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateTimeDataGridViewTextBoxColumn;
    }
}