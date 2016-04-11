using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using MyTranslate.Model;


namespace MyTranslate.App.UI
{
    public partial class ComboBoxLineStatus : ComboBox
    {
        public ComboBoxLineStatus()
        {
            InitializeComponent();

            this.DisplayMember = "Text";
            this.ValueMember = "Value";
        }


        private List<LineStatus> lineStatusList = new List<LineStatus>()
        {
            new LineStatus() { Text="待处理", Value= Line.STATUS_IS_WAIT },

            new LineStatus() { Text="机翻完毕", Value= Line.STATUS_IS_MACHINE },

            new LineStatus() { Text="已完成", Value= Line.STATUS_IS_DONE },

            new LineStatus() { Text="处理不能", Value= Line.STATUS_IS_FAIL },


            new LineStatus() { Text="有效数据", Value= Line.STATUS_IS_ACTIVE },

            new LineStatus() { Text="无效数据", Value= Line.STATUS_IS_INACTIVE },
        };



        public void InitLineStatus()
        {
            this.DataSource = lineStatusList;
        }

    }


    public class LineStatus
    {
        public string Text { set; get; }
        public string Value { set; get; }
    }

}
