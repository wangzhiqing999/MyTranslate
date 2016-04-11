using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using MyTranslate.App.Common;

using MyTranslate.Service;
using MyTranslate.ServiceImpl;

using MyTranslate.Model;


namespace MyTranslate.App.UI
{
    public partial class FormEditAutoReplace : Form
    {
        public FormEditAutoReplace()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 当前数据.
        /// </summary>
        private AutoReplace currentAutoReplace;

        /// <summary>
        /// 当前编辑数据.
        /// </summary>
        public AutoReplace EditAutoReplace
        {
            set
            {
                // 暂存当前数据.
                currentAutoReplace = value;

                // 原始文本.
                this.txtSourceText.Text = value.SourceText;

                // 机翻文本.
                this.txtMachineText.Text = value.MachineText;

                // 翻译文本.
                this.txtTranslateText.Text = value.TranslateText;

                // 有效性.
                this.chkActive.Checked = value.IsActive;

            }
        }


        /// <summary>
        /// 自动替换服务.
        /// </summary>
        private IAutoReplaceService autoReplaceService = new AutoReplaceService();



        /// <summary>
        /// 保存.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(this.txtSourceText.Text))
            {
                MyMessage.Warn("原始文本 必须输入！");
                this.txtSourceText.Focus();

                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }

            if (String.IsNullOrEmpty(this.txtMachineText.Text))
            {
                MyMessage.Warn("机翻文本 必须输入！");
                this.txtMachineText.Focus();

                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }

            if (String.IsNullOrEmpty(this.txtTranslateText.Text))
            {
                MyMessage.Warn("翻译文本 必须输入！");
                this.txtTranslateText.Focus();

                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }


            if (!MyMessage.Makesure("确认要更新自动替换数据么？"))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }


            if (currentAutoReplace == null)
            {
                currentAutoReplace = new AutoReplace();
            }


            // 原始文本.
            currentAutoReplace.SourceText = this.txtSourceText.Text;

            // 机翻文本
            currentAutoReplace.MachineText = this.txtMachineText.Text;

            // 翻译文本
            currentAutoReplace.TranslateText = this.txtTranslateText.Text;

            // 有效性.
            currentAutoReplace.IsActive = this.chkActive.Checked;


            bool result = autoReplaceService.InsertOrUpdateAutoReplace(currentAutoReplace);

            if (result)
            {
                MyMessage.Success("更新成功！");

                this.Close();
            }
            else
            {
                MyMessage.Fail(autoReplaceService.ResultMessage);

                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }

        }




    }
}
