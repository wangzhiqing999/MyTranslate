namespace MyTranslate.App.UI
{
    partial class FormManualTrans
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
            this.lblRowNumber = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtTranslate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnEditChapter = new System.Windows.Forms.Button();
            this.lblLineSummaryInfo = new System.Windows.Forms.Label();
            this.chkHideDone = new System.Windows.Forms.CheckBox();
            this.chkHideBlank = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboChapters = new MyTranslate.App.UI.ComboBoxChapters();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBooks = new MyTranslate.App.UI.ComboBoxBooks();
            this.gvLines = new System.Windows.Forms.DataGridView();
            this.lineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlFoot = new System.Windows.Forms.Panel();
            this.cboLineStatus = new MyTranslate.App.UI.ComboBoxLineStatus();
            this.btnTempSave = new System.Windows.Forms.Button();
            this.lblUpdateResult = new System.Windows.Forms.Label();
            this.btnSaveDone = new System.Windows.Forms.Button();
            this.pnlNames = new System.Windows.Forms.Panel();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReloadName = new System.Windows.Forms.Button();
            this.lineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translateTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBlankDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chapterCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).BeginInit();
            this.pnlFoot.SuspendLayout();
            this.pnlNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMain.Controls.Add(this.lblRowNumber, 2, 4);
            this.tlpMain.Controls.Add(this.txtNames, 1, 2);
            this.tlpMain.Controls.Add(this.label6, 0, 2);
            this.tlpMain.Controls.Add(this.lblStatus, 2, 5);
            this.tlpMain.Controls.Add(this.txtTranslate, 1, 5);
            this.tlpMain.Controls.Add(this.label5, 0, 5);
            this.tlpMain.Controls.Add(this.txtMachine, 1, 4);
            this.tlpMain.Controls.Add(this.label4, 0, 4);
            this.tlpMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMain.Controls.Add(this.gvLines, 0, 1);
            this.tlpMain.Controls.Add(this.label3, 0, 3);
            this.tlpMain.Controls.Add(this.txtSource, 1, 3);
            this.tlpMain.Controls.Add(this.btnCopyToClipboard, 2, 3);
            this.tlpMain.Controls.Add(this.btnPrev, 0, 6);
            this.tlpMain.Controls.Add(this.btnNext, 2, 6);
            this.tlpMain.Controls.Add(this.pnlFoot, 1, 6);
            this.tlpMain.Controls.Add(this.pnlNames, 2, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.Size = new System.Drawing.Size(982, 573);
            this.tlpMain.TabIndex = 0;
            // 
            // lblRowNumber
            // 
            this.lblRowNumber.AutoSize = true;
            this.lblRowNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRowNumber.Location = new System.Drawing.Point(835, 423);
            this.lblRowNumber.Name = "lblRowNumber";
            this.lblRowNumber.Size = new System.Drawing.Size(144, 50);
            this.lblRowNumber.TabIndex = 18;
            this.lblRowNumber.Text = "-";
            this.lblRowNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNames
            // 
            this.txtNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNames.Location = new System.Drawing.Point(153, 306);
            this.txtNames.Multiline = true;
            this.txtNames.Name = "txtNames";
            this.txtNames.ReadOnly = true;
            this.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNames.Size = new System.Drawing.Size(676, 64);
            this.txtNames.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 70);
            this.label6.TabIndex = 16;
            this.label6.Text = "参考用名词";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(835, 473);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(144, 50);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "状态";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTranslate
            // 
            this.txtTranslate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTranslate.Location = new System.Drawing.Point(153, 476);
            this.txtTranslate.Multiline = true;
            this.txtTranslate.Name = "txtTranslate";
            this.txtTranslate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTranslate.Size = new System.Drawing.Size(676, 44);
            this.txtTranslate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "结果文本";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMachine
            // 
            this.txtMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMachine.Location = new System.Drawing.Point(153, 426);
            this.txtMachine.Multiline = true;
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.ReadOnly = true;
            this.txtMachine.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMachine.Size = new System.Drawing.Size(676, 44);
            this.txtMachine.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "机翻文本";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.tlpMain.SetColumnSpan(this.pnlHeader, 3);
            this.pnlHeader.Controls.Add(this.btnEditChapter);
            this.pnlHeader.Controls.Add(this.lblLineSummaryInfo);
            this.pnlHeader.Controls.Add(this.chkHideDone);
            this.pnlHeader.Controls.Add(this.chkHideBlank);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.cboChapters);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.cboBooks);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(976, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnEditChapter
            // 
            this.btnEditChapter.Location = new System.Drawing.Point(779, 8);
            this.btnEditChapter.Name = "btnEditChapter";
            this.btnEditChapter.Size = new System.Drawing.Size(91, 23);
            this.btnEditChapter.TabIndex = 17;
            this.btnEditChapter.Text = "修改章节名";
            this.btnEditChapter.UseVisualStyleBackColor = true;
            this.btnEditChapter.Click += new System.EventHandler(this.btnEditChapter_Click);
            // 
            // lblLineSummaryInfo
            // 
            this.lblLineSummaryInfo.AutoSize = true;
            this.lblLineSummaryInfo.Location = new System.Drawing.Point(15, 44);
            this.lblLineSummaryInfo.Name = "lblLineSummaryInfo";
            this.lblLineSummaryInfo.Size = new System.Drawing.Size(11, 12);
            this.lblLineSummaryInfo.TabIndex = 16;
            this.lblLineSummaryInfo.Text = "-";
            // 
            // chkHideDone
            // 
            this.chkHideDone.AutoSize = true;
            this.chkHideDone.Location = new System.Drawing.Point(869, 44);
            this.chkHideDone.Name = "chkHideDone";
            this.chkHideDone.Size = new System.Drawing.Size(96, 16);
            this.chkHideDone.TabIndex = 15;
            this.chkHideDone.Text = "隐藏已完成行";
            this.chkHideDone.UseVisualStyleBackColor = true;
            this.chkHideDone.CheckedChanged += new System.EventHandler(this.chkHideDone_CheckedChanged);
            // 
            // chkHideBlank
            // 
            this.chkHideBlank.AutoSize = true;
            this.chkHideBlank.Location = new System.Drawing.Point(779, 44);
            this.chkHideBlank.Name = "chkHideBlank";
            this.chkHideBlank.Size = new System.Drawing.Size(84, 16);
            this.chkHideBlank.TabIndex = 14;
            this.chkHideBlank.Text = "隐藏空白行";
            this.chkHideBlank.UseVisualStyleBackColor = true;
            this.chkHideBlank.CheckedChanged += new System.EventHandler(this.chkHideBlank_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "章节";
            // 
            // cboChapters
            // 
            this.cboChapters.DisplayMember = "DisplayChapterName";
            this.cboChapters.FormattingEnabled = true;
            this.cboChapters.Location = new System.Drawing.Point(338, 9);
            this.cboChapters.Name = "cboChapters";
            this.cboChapters.Size = new System.Drawing.Size(421, 20);
            this.cboChapters.TabIndex = 12;
            this.cboChapters.ValueMember = "ChapterCode";
            this.cboChapters.SelectedIndexChanged += new System.EventHandler(this.cboChapters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "书籍";
            // 
            // cboBooks
            // 
            this.cboBooks.DisplayMember = "BookName";
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(74, 9);
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(186, 20);
            this.cboBooks.TabIndex = 10;
            this.cboBooks.ValueMember = "BookCode";
            this.cboBooks.SelectedIndexChanged += new System.EventHandler(this.cboBooks_SelectedIndexChanged);
            // 
            // gvLines
            // 
            this.gvLines.AllowUserToAddRows = false;
            this.gvLines.AllowUserToDeleteRows = false;
            this.gvLines.AutoGenerateColumns = false;
            this.gvLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineNumberDataGridViewTextBoxColumn,
            this.sourceTextDataGridViewTextBoxColumn,
            this.translateTextDataGridViewTextBoxColumn,
            this.isBlankDataGridViewCheckBoxColumn,
            this.chapterCodeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.createUserDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.lastUpdateUserDataGridViewTextBoxColumn,
            this.lastUpdateTimeDataGridViewTextBoxColumn});
            this.tlpMain.SetColumnSpan(this.gvLines, 3);
            this.gvLines.DataSource = this.lineBindingSource;
            this.gvLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvLines.Location = new System.Drawing.Point(3, 83);
            this.gvLines.MultiSelect = false;
            this.gvLines.Name = "gvLines";
            this.gvLines.ReadOnly = true;
            this.gvLines.RowTemplate.Height = 23;
            this.gvLines.Size = new System.Drawing.Size(976, 217);
            this.gvLines.TabIndex = 1;
            this.gvLines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvLines_CellClick);
            // 
            // lineBindingSource
            // 
            this.lineBindingSource.DataSource = typeof(MyTranslate.Model.Line);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "源文本";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSource
            // 
            this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSource.Location = new System.Drawing.Point(153, 376);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSource.Size = new System.Drawing.Size(676, 44);
            this.txtSource.TabIndex = 6;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(845, 386);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(123, 23);
            this.btnCopyToClipboard.TabIndex = 11;
            this.btnCopyToClipboard.Text = "复制到剪贴板(&C)";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrev.Location = new System.Drawing.Point(37, 536);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "上一行(&P)";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.Location = new System.Drawing.Point(869, 536);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "下一行(&N)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlFoot
            // 
            this.pnlFoot.Controls.Add(this.cboLineStatus);
            this.pnlFoot.Controls.Add(this.btnTempSave);
            this.pnlFoot.Controls.Add(this.lblUpdateResult);
            this.pnlFoot.Controls.Add(this.btnSaveDone);
            this.pnlFoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFoot.Location = new System.Drawing.Point(153, 526);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(676, 44);
            this.pnlFoot.TabIndex = 15;
            // 
            // cboLineStatus
            // 
            this.cboLineStatus.DisplayMember = "Text";
            this.cboLineStatus.FormattingEnabled = true;
            this.cboLineStatus.Location = new System.Drawing.Point(12, 15);
            this.cboLineStatus.Name = "cboLineStatus";
            this.cboLineStatus.Size = new System.Drawing.Size(121, 20);
            this.cboLineStatus.TabIndex = 5;
            this.cboLineStatus.ValueMember = "Value";
            // 
            // btnTempSave
            // 
            this.btnTempSave.Location = new System.Drawing.Point(139, 13);
            this.btnTempSave.Name = "btnTempSave";
            this.btnTempSave.Size = new System.Drawing.Size(75, 23);
            this.btnTempSave.TabIndex = 4;
            this.btnTempSave.Text = "暂存(&T)";
            this.btnTempSave.UseVisualStyleBackColor = true;
            this.btnTempSave.Click += new System.EventHandler(this.btnTempSave_Click);
            // 
            // lblUpdateResult
            // 
            this.lblUpdateResult.AutoSize = true;
            this.lblUpdateResult.Location = new System.Drawing.Point(568, 17);
            this.lblUpdateResult.Name = "lblUpdateResult";
            this.lblUpdateResult.Size = new System.Drawing.Size(11, 12);
            this.lblUpdateResult.TabIndex = 3;
            this.lblUpdateResult.Text = "-";
            // 
            // btnSaveDone
            // 
            this.btnSaveDone.Location = new System.Drawing.Point(409, 12);
            this.btnSaveDone.Name = "btnSaveDone";
            this.btnSaveDone.Size = new System.Drawing.Size(113, 23);
            this.btnSaveDone.TabIndex = 2;
            this.btnSaveDone.Text = "完成并保存(&S)";
            this.btnSaveDone.UseVisualStyleBackColor = true;
            this.btnSaveDone.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlNames
            // 
            this.pnlNames.Controls.Add(this.btnReplace);
            this.pnlNames.Controls.Add(this.btnReloadName);
            this.pnlNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNames.Location = new System.Drawing.Point(835, 306);
            this.pnlNames.Name = "pnlNames";
            this.pnlNames.Size = new System.Drawing.Size(144, 64);
            this.pnlNames.TabIndex = 19;
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReplace.Location = new System.Drawing.Point(10, 37);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(123, 23);
            this.btnReplace.TabIndex = 20;
            this.btnReplace.Text = "尝试替换名词(&R)";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReloadName
            // 
            this.btnReloadName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReloadName.Location = new System.Drawing.Point(10, 8);
            this.btnReloadName.Name = "btnReloadName";
            this.btnReloadName.Size = new System.Drawing.Size(125, 23);
            this.btnReloadName.TabIndex = 19;
            this.btnReloadName.Text = "重新加载名词(&L)";
            this.btnReloadName.UseVisualStyleBackColor = true;
            this.btnReloadName.Click += new System.EventHandler(this.btnReloadName_Click);
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
            this.sourceTextDataGridViewTextBoxColumn.HeaderText = "原始文本";
            this.sourceTextDataGridViewTextBoxColumn.Name = "sourceTextDataGridViewTextBoxColumn";
            this.sourceTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceTextDataGridViewTextBoxColumn.Width = 150;
            // 
            // translateTextDataGridViewTextBoxColumn
            // 
            this.translateTextDataGridViewTextBoxColumn.DataPropertyName = "TranslateText";
            this.translateTextDataGridViewTextBoxColumn.HeaderText = "翻译文本";
            this.translateTextDataGridViewTextBoxColumn.Name = "translateTextDataGridViewTextBoxColumn";
            this.translateTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.translateTextDataGridViewTextBoxColumn.Width = 200;
            // 
            // isBlankDataGridViewCheckBoxColumn
            // 
            this.isBlankDataGridViewCheckBoxColumn.DataPropertyName = "IsBlank";
            this.isBlankDataGridViewCheckBoxColumn.HeaderText = "是否空白行";
            this.isBlankDataGridViewCheckBoxColumn.Name = "isBlankDataGridViewCheckBoxColumn";
            this.isBlankDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // chapterCodeDataGridViewTextBoxColumn
            // 
            this.chapterCodeDataGridViewTextBoxColumn.DataPropertyName = "ChapterCode";
            this.chapterCodeDataGridViewTextBoxColumn.HeaderText = "章节代码";
            this.chapterCodeDataGridViewTextBoxColumn.Name = "chapterCodeDataGridViewTextBoxColumn";
            this.chapterCodeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // FormManualTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 573);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormManualTrans";
            this.Text = "手动翻译";
            this.Load += new System.EventHandler(this.FormManualTrans_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineBindingSource)).EndInit();
            this.pnlFoot.ResumeLayout(false);
            this.pnlFoot.PerformLayout();
            this.pnlNames.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label2;
        private ComboBoxChapters cboChapters;
        private System.Windows.Forms.Label label1;
        private ComboBoxBooks cboBooks;
        private System.Windows.Forms.DataGridView gvLines;
        private System.Windows.Forms.BindingSource lineBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTranslate;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkHideBlank;
        private System.Windows.Forms.CheckBox chkHideDone;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblLineSummaryInfo;
        private System.Windows.Forms.Panel pnlFoot;
        private System.Windows.Forms.Button btnSaveDone;
        private System.Windows.Forms.Label lblUpdateResult;
        private System.Windows.Forms.Button btnTempSave;
        private ComboBoxLineStatus cboLineStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.Label lblRowNumber;
        private System.Windows.Forms.Button btnReloadName;
        private System.Windows.Forms.Panel pnlNames;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnEditChapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translateTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBlankDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateTimeDataGridViewTextBoxColumn;
    }
}