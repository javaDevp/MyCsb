using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Touha.Tools.Csb.Biz;

namespace Touha.Tools.Csb.UI
{
    public partial class FrmTransManage : Form
    {
        private BizTrans biz = new BizTrans();

        public FrmTransManage()
        {
            InitializeComponent();
            InitInterface();
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        private void InitInterface()
        {
            //DataSet ds = bizTrans.GetTransByID("0");
            //DataTable main = ds.Tables["main"];
            //DataTable detail = ds.Tables["detail"];
            lvwTrans.Columns.Clear();
            lvwTrans.Columns.Add("TransName", "交易名称", 100, HorizontalAlignment.Left, -1);

            gdvTransDetail.Columns.Clear();
            gdvTransDetail.AutoGenerateColumns = false;
            gdvTransDetail.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "FieldName", HeaderText = "字段名称" });
            gdvTransDetail.Columns.Add(new DataGridViewComboBoxColumn() { DataPropertyName = "FieldType", HeaderText = "字段名称", DataSource = biz.GetFiledTypes(), DisplayMember = "Name", ValueMember = "ID" });
            gdvTransDetail.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "FieldName", HeaderText = "字段长度" });
            gdvTransDetail.Columns.Add(new DataGridViewCheckBoxColumn() { DataPropertyName = "FieldIsRequired", HeaderText = "是否必填" });
            gdvTransDetail.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "FieldDescription", HeaderText = "字段描述" });
        }

        private void FrmTransManage_Load(object sender, EventArgs e)
        {
            DataTable dtTranInfo = biz.GetTransInfo();
            foreach (DataRow dr in dtTranInfo.Rows)
                lvwTrans.Items.Add(new ListViewItem() { Text = dr["TransName"].ToString(), Tag = dr["TransID"].ToString() });
        }

        private void lvwTrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvwTrans.SelectedIndices.Count > 0)
            {
                ListViewItem lvi = lvwTrans.Items[lvwTrans.SelectedIndices[0]];
                var transID = lvi.Tag.ToString();
                DataView dv = biz.GetTransFields().DefaultView;
                dv.RowFilter = "TransID = '" + transID + "'";
                gdvTransDetail.DataSource = dv;
            }
        }

        private void gdvTransDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (biz.HasChanged())
            {
                biz.SaveChanges();
            }
        }
    }
}
