namespace MyTranslate.App.UI
{
    partial class FormAutoTrans
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFoot = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTrans = new System.Windows.Forms.TextBox();
            this.lblCheckReault = new System.Windows.Forms.Label();
            this.cboChapters = new MyTranslate.App.UI.ComboBoxChapters();
            this.cboBooks = new MyTranslate.App.UI.ComboBoxBooks();
            this.tlpMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpMain.Controls.Add(this.pnlFoot, 0, 2);
            this.tlpMain.Controls.Add(this.txtSource, 0, 1);
            this.tlpMain.Controls.Add(this.txtTrans, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.Size = new System.Drawing.Size(939, 510);
            this.tlpMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.tlpMain.SetColumnSpan(this.pnlHeader, 2);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.cboChapters);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.cboBooks);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(827, 44);
            this.pnlHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "章节";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "书籍";
            // 
            // pnlFoot
            // 
            this.tlpMain.SetColumnSpan(this.pnlFoot, 2);
            this.pnlFoot.Controls.Add(this.lblCheckReault);
            this.pnlFoot.Controls.Add(this.btnStart);
            this.pnlFoot.Location = new System.Drawing.Point(3, 463);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(827, 44);
            this.pnlFoot.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(681, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始处理";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtSource
            // 
            this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSource.Location = new System.Drawing.Point(3, 53);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSource.Size = new System.Drawing.Size(463, 404);
            this.txtSource.TabIndex = 2;
            // 
            // txtTrans
            // 
            this.txtTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTrans.Location = new System.Drawing.Point(472, 53);
            this.txtTrans.Multiline = true;
            this.txtTrans.Name = "txtTrans";
            this.txtTrans.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTrans.Size = new System.Drawing.Size(464, 404);
            this.txtTrans.TabIndex = 3;
            // 
            // lblCheckReault
            // 
            this.lblCheckReault.AutoSize = true;
            this.lblCheckReault.Location = new System.Drawing.Point(18, 17);
            this.lblCheckReault.Name = "lblCheckReault";
            this.lblCheckReault.Size = new System.Drawing.Size(11, 12);
            this.lblCheckReault.TabIndex = 1;
            this.lblCheckReault.Text = "-";
            // 
            // cboChapters
            // 
            this.cboChapters.DisplayMember = "DisplayChapterName";
            this.cboChapters.FormattingEnabled = true;
            this.cboChapters.Location = new System.Drawing.Point(423, 9);
            this.cboChapters.Name = "cboChapters";
            this.cboChapters.Size = new System.Drawing.Size(391, 20);
            this.cboChapters.TabIndex = 8;
            this.cboChapters.ValueMember = "ChapterCode";
            this.cboChapters.SelectedIndexChanged += new System.EventHandler(this.cboChapters_SelectedIndexChanged);
            // 
            // cboBooks
            // 
            this.cboBooks.DisplayMember = "BookName";
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(77, 9);
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(186, 20);
            this.cboBooks.TabIndex = 6;
            this.cboBooks.ValueMember = "BookCode";
            this.cboBooks.SelectedIndexChanged += new System.EventHandler(this.cboBooks_SelectedIndexChanged);
            // 
            // FormAutoTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 510);
            this.Controls.Add(this.tlpMain);
            this.Name = "FormAutoTrans";
            this.Text = "机翻处理";
            this.Load += new System.EventHandler(this.FormAutoTrans_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFoot.ResumeLayout(false);
            this.pnlFoot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label2;
        private ComboBoxChapters cboChapters;
        private System.Windows.Forms.Label label1;
        private ComboBoxBooks cboBooks;
        private System.Windows.Forms.Panel pnlFoot;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTrans;
        private System.Windows.Forms.Label lblCheckReault;
    }
}