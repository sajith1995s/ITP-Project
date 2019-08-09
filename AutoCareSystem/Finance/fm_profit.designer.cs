namespace AutoCareSystem.Financial_Statistics
{
    partial class fm_profit
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // radBar
            // 
            this.radBar.CheckedChanged += new System.EventHandler(this.radBar_CheckedChanged);
            // 
            // radLine
            // 
            this.radLine.CheckedChanged += new System.EventHandler(this.radLine_CheckedChanged);
            // 
            // btnChart
            // 
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnTable
            // 
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // fm_profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "fm_profit";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
