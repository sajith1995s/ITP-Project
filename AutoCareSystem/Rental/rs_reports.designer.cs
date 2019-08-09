namespace AutoCareSystem
{
    partial class rs_reports
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
            this.cmb_rpt_type = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cmb_rpt_type
            // 
            this.cmb_rpt_type.FormattingEnabled = true;
            this.cmb_rpt_type.ItemHeight = 23;
            this.cmb_rpt_type.Items.AddRange(new object[] {
            "Select Report Type ",
            "Rental Vehicle Details",
            "Rental Information"});
            this.cmb_rpt_type.Location = new System.Drawing.Point(246, 16);
            this.cmb_rpt_type.Name = "cmb_rpt_type";
            this.cmb_rpt_type.Size = new System.Drawing.Size(231, 29);
            this.cmb_rpt_type.TabIndex = 246;
            this.cmb_rpt_type.UseSelectable = true;
            this.cmb_rpt_type.SelectedIndexChanged += new System.EventHandler(this.cmb_rpt_type_SelectedIndexChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(96, 26);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(101, 19);
            this.materialLabel7.TabIndex = 245;
            this.materialLabel7.Text = "Report Type  :";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 66);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(741, 459);
            this.crystalReportViewer1.TabIndex = 247;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rs_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.cmb_rpt_type);
            this.Controls.Add(this.materialLabel7);
            this.Name = "rs_reports";
            this.Size = new System.Drawing.Size(741, 550);
            this.Load += new System.EventHandler(this.rs_reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmb_rpt_type;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
