namespace AutoCareSystem
{
    partial class fm_reports
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
            this.btnReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMonthly = new MaterialSkin.Controls.MaterialRadioButton();
            this.radYearly = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radIncome = new MaterialSkin.Controls.MaterialRadioButton();
            this.radExpenses = new MaterialSkin.Controls.MaterialRadioButton();
            this.radProfit = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbYear = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.radTotal = new MaterialSkin.Controls.MaterialRadioButton();
            this.radSeparate = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 114);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(731, 473);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnReport
            // 
            this.btnReport.Depth = 0;
            this.btnReport.Location = new System.Drawing.Point(620, 38);
            this.btnReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReport.Name = "btnReport";
            this.btnReport.Primary = true;
            this.btnReport.Size = new System.Drawing.Size(92, 34);
            this.btnReport.TabIndex = 163;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMonthly);
            this.groupBox1.Controls.Add(this.radYearly);
            this.groupBox1.Location = new System.Drawing.Point(150, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 105);
            this.groupBox1.TabIndex = 164;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // radMonthly
            // 
            this.radMonthly.AutoSize = true;
            this.radMonthly.Depth = 0;
            this.radMonthly.Font = new System.Drawing.Font("Roboto", 10F);
            this.radMonthly.Location = new System.Drawing.Point(3, 50);
            this.radMonthly.Margin = new System.Windows.Forms.Padding(0);
            this.radMonthly.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radMonthly.MouseState = MaterialSkin.MouseState.HOVER;
            this.radMonthly.Name = "radMonthly";
            this.radMonthly.Ripple = true;
            this.radMonthly.Size = new System.Drawing.Size(79, 30);
            this.radMonthly.TabIndex = 40;
            this.radMonthly.TabStop = true;
            this.radMonthly.Text = "Monthly";
            this.radMonthly.UseVisualStyleBackColor = true;
            this.radMonthly.CheckedChanged += new System.EventHandler(this.radMonthly_CheckedChanged);
            // 
            // radYearly
            // 
            this.radYearly.AutoSize = true;
            this.radYearly.Depth = 0;
            this.radYearly.Font = new System.Drawing.Font("Roboto", 10F);
            this.radYearly.Location = new System.Drawing.Point(3, 19);
            this.radYearly.Margin = new System.Windows.Forms.Padding(0);
            this.radYearly.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radYearly.MouseState = MaterialSkin.MouseState.HOVER;
            this.radYearly.Name = "radYearly";
            this.radYearly.Ripple = true;
            this.radYearly.Size = new System.Drawing.Size(67, 30);
            this.radYearly.TabIndex = 39;
            this.radYearly.TabStop = true;
            this.radYearly.Text = "Yearly";
            this.radYearly.UseVisualStyleBackColor = true;
            this.radYearly.CheckedChanged += new System.EventHandler(this.radYearly_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radProfit);
            this.groupBox2.Controls.Add(this.radExpenses);
            this.groupBox2.Controls.Add(this.radIncome);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 105);
            this.groupBox2.TabIndex = 165;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Type";
            // 
            // radIncome
            // 
            this.radIncome.AutoSize = true;
            this.radIncome.Depth = 0;
            this.radIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radIncome.Location = new System.Drawing.Point(12, 12);
            this.radIncome.Margin = new System.Windows.Forms.Padding(0);
            this.radIncome.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radIncome.MouseState = MaterialSkin.MouseState.HOVER;
            this.radIncome.Name = "radIncome";
            this.radIncome.Ripple = true;
            this.radIncome.Size = new System.Drawing.Size(75, 30);
            this.radIncome.TabIndex = 40;
            this.radIncome.TabStop = true;
            this.radIncome.Text = "Income";
            this.radIncome.UseVisualStyleBackColor = true;
            this.radIncome.CheckedChanged += new System.EventHandler(this.radIncome_CheckedChanged);
            // 
            // radExpenses
            // 
            this.radExpenses.AutoSize = true;
            this.radExpenses.Depth = 0;
            this.radExpenses.Font = new System.Drawing.Font("Roboto", 10F);
            this.radExpenses.Location = new System.Drawing.Point(12, 42);
            this.radExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.radExpenses.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radExpenses.MouseState = MaterialSkin.MouseState.HOVER;
            this.radExpenses.Name = "radExpenses";
            this.radExpenses.Ripple = true;
            this.radExpenses.Size = new System.Drawing.Size(88, 30);
            this.radExpenses.TabIndex = 41;
            this.radExpenses.TabStop = true;
            this.radExpenses.Text = "Expenses";
            this.radExpenses.UseVisualStyleBackColor = true;
            this.radExpenses.CheckedChanged += new System.EventHandler(this.radExpenses_CheckedChanged);
            // 
            // radProfit
            // 
            this.radProfit.AutoSize = true;
            this.radProfit.Depth = 0;
            this.radProfit.Font = new System.Drawing.Font("Roboto", 10F);
            this.radProfit.Location = new System.Drawing.Point(12, 72);
            this.radProfit.Margin = new System.Windows.Forms.Padding(0);
            this.radProfit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radProfit.MouseState = MaterialSkin.MouseState.HOVER;
            this.radProfit.Name = "radProfit";
            this.radProfit.Ripple = true;
            this.radProfit.Size = new System.Drawing.Size(63, 30);
            this.radProfit.TabIndex = 42;
            this.radProfit.TabStop = true;
            this.radProfit.Text = "Profit";
            this.radProfit.UseVisualStyleBackColor = true;
            this.radProfit.CheckedChanged += new System.EventHandler(this.radProfit_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialLabel1);
            this.groupBox3.Controls.Add(this.cmbYear);
            this.groupBox3.Location = new System.Drawing.Point(278, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 100);
            this.groupBox3.TabIndex = 166;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Period";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTotal);
            this.groupBox4.Controls.Add(this.radSeparate);
            this.groupBox4.Location = new System.Drawing.Point(433, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 100);
            this.groupBox4.TabIndex = 167;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display Mode";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ItemHeight = 23;
            this.cmbYear.Items.AddRange(new object[] {
            "Select"});
            this.cmbYear.Location = new System.Drawing.Point(13, 51);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 29);
            this.cmbYear.TabIndex = 38;
            this.cmbYear.UseSelectable = true;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(45, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 19);
            this.materialLabel1.TabIndex = 39;
            this.materialLabel1.Text = "Year";
            // 
            // radTotal
            // 
            this.radTotal.AutoSize = true;
            this.radTotal.Depth = 0;
            this.radTotal.Font = new System.Drawing.Font("Roboto", 10F);
            this.radTotal.Location = new System.Drawing.Point(3, 51);
            this.radTotal.Margin = new System.Windows.Forms.Padding(0);
            this.radTotal.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.radTotal.Name = "radTotal";
            this.radTotal.Ripple = true;
            this.radTotal.Size = new System.Drawing.Size(61, 30);
            this.radTotal.TabIndex = 3;
            this.radTotal.TabStop = true;
            this.radTotal.Text = "Total";
            this.radTotal.UseVisualStyleBackColor = true;
            this.radTotal.CheckedChanged += new System.EventHandler(this.radTotal_CheckedChanged);
            // 
            // radSeparate
            // 
            this.radSeparate.AutoSize = true;
            this.radSeparate.Depth = 0;
            this.radSeparate.Font = new System.Drawing.Font("Roboto", 10F);
            this.radSeparate.Location = new System.Drawing.Point(3, 16);
            this.radSeparate.Margin = new System.Windows.Forms.Padding(0);
            this.radSeparate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radSeparate.MouseState = MaterialSkin.MouseState.HOVER;
            this.radSeparate.Name = "radSeparate";
            this.radSeparate.Ripple = true;
            this.radSeparate.Size = new System.Drawing.Size(138, 30);
            this.radSeparate.TabIndex = 2;
            this.radSeparate.TabStop = true;
            this.radSeparate.Text = "Separate Sources";
            this.radSeparate.UseVisualStyleBackColor = true;
            this.radSeparate.CheckedChanged += new System.EventHandler(this.radSeparate_CheckedChanged);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(737, 590);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        protected MaterialSkin.Controls.MaterialRaisedButton btnReport;
        private System.Windows.Forms.GroupBox groupBox1;
        protected MaterialSkin.Controls.MaterialRadioButton radMonthly;
        protected MaterialSkin.Controls.MaterialRadioButton radYearly;
        private System.Windows.Forms.GroupBox groupBox2;
        protected MaterialSkin.Controls.MaterialRadioButton radProfit;
        protected MaterialSkin.Controls.MaterialRadioButton radExpenses;
        protected MaterialSkin.Controls.MaterialRadioButton radIncome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        protected MetroFramework.Controls.MetroComboBox cmbYear;
        protected MaterialSkin.Controls.MaterialLabel materialLabel1;
        protected MaterialSkin.Controls.MaterialRadioButton radTotal;
        protected MaterialSkin.Controls.MaterialRadioButton radSeparate;
    }
}
