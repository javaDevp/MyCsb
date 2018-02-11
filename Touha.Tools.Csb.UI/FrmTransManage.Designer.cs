namespace Touha.Tools.Csb.UI
{
    partial class FrmTransManage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvwTrans = new System.Windows.Forms.ListView();
            this.gdvTransDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTransDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvwTrans);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gdvTransDetail);
            this.splitContainer1.Size = new System.Drawing.Size(965, 581);
            this.splitContainer1.SplitterDistance = 161;
            this.splitContainer1.TabIndex = 0;
            // 
            // lvwTrans
            // 
            this.lvwTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTrans.Location = new System.Drawing.Point(0, 0);
            this.lvwTrans.Name = "lvwTrans";
            this.lvwTrans.Size = new System.Drawing.Size(161, 581);
            this.lvwTrans.TabIndex = 0;
            this.lvwTrans.UseCompatibleStateImageBehavior = false;
            this.lvwTrans.View = System.Windows.Forms.View.Details;
            this.lvwTrans.SelectedIndexChanged += new System.EventHandler(this.lvwTrans_SelectedIndexChanged);
            // 
            // gdvTransDetail
            // 
            this.gdvTransDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvTransDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvTransDetail.Location = new System.Drawing.Point(0, 0);
            this.gdvTransDetail.Name = "gdvTransDetail";
            this.gdvTransDetail.RowTemplate.Height = 23;
            this.gdvTransDetail.Size = new System.Drawing.Size(800, 581);
            this.gdvTransDetail.TabIndex = 0;
            this.gdvTransDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvTransDetail_CellValueChanged);
            // 
            // FrmTransManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 581);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmTransManage";
            this.Text = "交易管理";
            this.Load += new System.EventHandler(this.FrmTransManage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvTransDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvwTrans;
        private System.Windows.Forms.DataGridView gdvTransDetail;
    }
}