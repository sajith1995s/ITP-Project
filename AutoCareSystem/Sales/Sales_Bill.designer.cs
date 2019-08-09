namespace AutoCareSystem
{
    partial class Sales_Bill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRepairUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crystalReportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 506);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRepairUpdate);
            this.groupBox2.Location = new System.Drawing.Point(3, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1014, 59);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnRepairUpdate
            // 
            this.btnRepairUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRepairUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRepairUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepairUpdate.BorderRadius = 7;
            this.btnRepairUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRepairUpdate.ButtonText = "BackToSales ";
            this.btnRepairUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepairUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnRepairUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRepairUpdate.Iconimage = global::AutoCareSystem.Properties.Resources.Available_Updates_32px;
            this.btnRepairUpdate.Iconimage_right = null;
            this.btnRepairUpdate.Iconimage_right_Selected = null;
            this.btnRepairUpdate.Iconimage_Selected = null;
            this.btnRepairUpdate.IconMarginLeft = 0;
            this.btnRepairUpdate.IconMarginRight = 0;
            this.btnRepairUpdate.IconRightVisible = true;
            this.btnRepairUpdate.IconRightZoom = 0D;
            this.btnRepairUpdate.IconVisible = true;
            this.btnRepairUpdate.IconZoom = 50D;
            this.btnRepairUpdate.IsTab = false;
            this.btnRepairUpdate.Location = new System.Drawing.Point(867, 13);
            this.btnRepairUpdate.Name = "btnRepairUpdate";
            this.btnRepairUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRepairUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnRepairUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRepairUpdate.selected = false;
            this.btnRepairUpdate.Size = new System.Drawing.Size(137, 40);
            this.btnRepairUpdate.TabIndex = 139;
            this.btnRepairUpdate.Text = "BackToSales ";
            this.btnRepairUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepairUpdate.Textcolor = System.Drawing.Color.White;
            this.btnRepairUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepairUpdate.Click += new System.EventHandler(this.btnRepairUpdate_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 16);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1008, 487);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Sales_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sales_Bill";
            this.Text = "SalesBill";
            this.Load += new System.EventHandler(this.Sales_SubView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnRepairUpdate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}