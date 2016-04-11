using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.IO;
using System.Xml;
using System.Xml.Serialization;


using MyTranslate.Model;
using MyTranslate.Service;
using MyTranslate.ServiceImpl;
using MyTranslate.Util;
using MyTranslate.App.Common;


namespace MyTranslate.App.UI
{


    public partial class FormAutoReplace : Form
    {
        public FormAutoReplace()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 自动替换服务.
        /// </summary>
        private IAutoReplaceService autoReplaceService = new AutoReplaceService();


        /// <summary>
        /// 主数据列表.
        /// </summary>
        private List<AutoReplace> mainDataList;



        private void ReloadData()
        {
            // 加载数据.
            this.mainDataList = this.autoReplaceService.GetAutoReplaceList();

            // 绑定.
            this.dgvAutoReplace.DataSource = null;
            this.dgvAutoReplace.DataSource = this.mainDataList;


        }




        /// <summary>
        /// 初始化.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAutoReplace_Load(object sender, EventArgs e)
        {
            ReloadData();

        }


        /// <summary>
        /// 新增.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormEditAutoReplace editFrom = new FormEditAutoReplace();


            if (editFrom.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ReloadData(); 
            }



        }

        /// <summary>
        /// 双击编辑.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAutoReplace_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 取得行号.
            int index = e.RowIndex;

            if (index < 0)
            {
                // 忽略为 负数的行号.
                return;
            }


            // 取得指定行的数据.
            AutoReplace currentData = mainDataList[index];

            FormEditAutoReplace editFrom = new FormEditAutoReplace();
            editFrom.EditAutoReplace = currentData;

            editFrom.ShowDialog();
            
        }



        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExp_Click(object sender, EventArgs e)
        {

            if (this.mainDataList == null || this.mainDataList.Count == 0)
            {
                MyMessage.Warn("当前没有数据可导出！");
                return;
            }


            if (this.saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                // 用户取消.
                return;
            }



            List<AutoReplace> todoList = new List<AutoReplace>();
            foreach (var item in this.mainDataList)
            {
                AutoReplace expData = new AutoReplace();
                CommonModelCopyer.ModelCopy(item, expData);
                expData.Status = item.Status;
                todoList.Add(expData);
            }



            // 输出 UTF-8 的 XML 文件.
            XmlSerializer xs = new XmlSerializer(typeof(List<AutoReplace>));
            using (StreamWriter sw = new StreamWriter(this.saveFileDialog1.FileName))
            {
                xs.Serialize(sw, todoList);
            }


            

            MyMessage.Success("导出完毕！");


        }



        /// <summary>
        /// 导入.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImp_Click(object sender, EventArgs e)
        {

            if (this.openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                // 用户取消.
                return;
            }


            try
            {

                List<AutoReplace> impDataList = null;


                XmlSerializer xs = new XmlSerializer(typeof(List<AutoReplace>));
                using (StreamReader sr = new StreamReader(this.openFileDialog1.FileName))
                {
                    impDataList = xs.Deserialize(sr) as List<AutoReplace>;
                    sr.Close();
                }


                foreach (var item in impDataList)
                {
                    this.autoReplaceService.InsertOrUpdateAutoReplace(item);
                }

                ReloadData(); 

                MyMessage.Success("导入完毕！");



            }
            catch (Exception ex)
            {
                MyMessage.Fail("导入文件的时候，发生了错误：" + ex.Message);
            }
        }



    }
}
