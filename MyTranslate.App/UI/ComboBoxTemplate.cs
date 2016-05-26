using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace MyTranslate.App.UI
{
    public partial class ComboBoxTemplate : ComboBox
    {
        public ComboBoxTemplate()
        {
            InitializeComponent();

            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        public void InitTemplate(string path = "Template")
        {
            string[] templateFiles = Directory.GetFiles(path, "*.*.vm");

            this.DataSource = templateFiles;
        }


        /// <summary>
        /// 选择的文件类型.
        /// </summary>
        public string SelectedFileType
        {
            get
            {
                if (this.SelectedIndex == -1)
                {
                    return null;
                }
                string[] fileParts = this.Text.Split('.');
                return fileParts[fileParts.Length - 2];
            }
        }

    }
}
