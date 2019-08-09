namespace AutoCareSystem.Employee
{
    partial class cristalReportview
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
            this.crystalReportViewerforatt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerforatt
            // 
            this.crystalReportViewerforatt.ActiveViewIndex = -1;
            this.crystalReportViewerforatt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerforatt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerforatt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerforatt.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerforatt.Name = "crystalReportViewerforatt";
            this.crystalReportViewerforatt.Size = new System.Drawing.Size(1184, 561);
            this.crystalReportViewerforatt.TabIndex = 0;
            this.crystalReportViewerforatt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cristalReportview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.crystalReportViewerforatt);
            this.Name = "cristalReportview";
            this.Text = "cristalReportview";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerforatt;
    }
}