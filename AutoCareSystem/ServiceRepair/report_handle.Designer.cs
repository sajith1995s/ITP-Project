namespace AutoCareSystem
{
    partial class report_handle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cmbReportType = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReceipt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 56);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(754, 539);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cmbReportType
            // 
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.ItemHeight = 23;
            this.cmbReportType.Items.AddRange(new object[] {
            "Full Service Report",
            "Full Repair Report",
            "Provided Repair List",
            "Provided Services List"});
            this.cmbReportType.Location = new System.Drawing.Point(136, 11);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(283, 29);
            this.cmbReportType.TabIndex = 1;
            this.cmbReportType.UseSelectable = true;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(14, 14);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(89, 19);
            this.materialLabel9.TabIndex = 144;
            this.materialLabel9.Text = "Report Type";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "View FullScreen";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::AutoCareSystem.Properties.Resources.Fit_to_Width_32px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 45D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(582, 7);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(147, 40);
            this.bunifuFlatButton1.TabIndex = 135;
            this.bunifuFlatButton1.Text = "View FullScreen";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReceipt.BorderRadius = 7;
            this.btnReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnReceipt.ButtonText = "Generate";
            this.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceipt.DisabledColor = System.Drawing.Color.Gray;
            this.btnReceipt.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReceipt.Iconimage = global::AutoCareSystem.Properties.Resources.Ratings_32px;
            this.btnReceipt.Iconimage_right = null;
            this.btnReceipt.Iconimage_right_Selected = null;
            this.btnReceipt.Iconimage_Selected = null;
            this.btnReceipt.IconMarginLeft = 0;
            this.btnReceipt.IconMarginRight = 0;
            this.btnReceipt.IconRightVisible = true;
            this.btnReceipt.IconRightZoom = 0D;
            this.btnReceipt.IconVisible = true;
            this.btnReceipt.IconZoom = 45D;
            this.btnReceipt.IsTab = false;
            this.btnReceipt.Location = new System.Drawing.Point(460, 7);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnReceipt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnReceipt.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReceipt.selected = false;
            this.btnReceipt.Size = new System.Drawing.Size(108, 40);
            this.btnReceipt.TabIndex = 134;
            this.btnReceipt.Text = "Generate";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.Textcolor = System.Drawing.Color.White;
            this.btnReceipt.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // report_handle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "report_handle";
            this.Size = new System.Drawing.Size(754, 595);
            this.Load += new System.EventHandler(this.report_handle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MetroFramework.Controls.MetroComboBox cmbReportType;
        private Bunifu.Framework.UI.BunifuFlatButton btnReceipt;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}
