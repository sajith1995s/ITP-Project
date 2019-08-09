namespace AutoCareSystem
{
    partial class Report1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rbLineChart = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbPieChart = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbBarChart = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dpStartdate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbRType = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(34, 46);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Orders";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(437, 314);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGenerate);
            this.groupBox5.Location = new System.Drawing.Point(520, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 69);
            this.groupBox5.TabIndex = 78;
            this.groupBox5.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerate.BorderRadius = 7;
            this.btnGenerate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGenerate.ButtonText = "Generate";
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnGenerate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerate.Iconimage = global::AutoCareSystem.Properties.Resources.Print_32px;
            this.btnGenerate.Iconimage_right = null;
            this.btnGenerate.Iconimage_right_Selected = null;
            this.btnGenerate.Iconimage_Selected = null;
            this.btnGenerate.IconMarginLeft = 0;
            this.btnGenerate.IconMarginRight = 0;
            this.btnGenerate.IconRightVisible = true;
            this.btnGenerate.IconRightZoom = 0D;
            this.btnGenerate.IconVisible = true;
            this.btnGenerate.IconZoom = 50D;
            this.btnGenerate.IsTab = false;
            this.btnGenerate.Location = new System.Drawing.Point(15, 17);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnGenerate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnGenerate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenerate.selected = false;
            this.btnGenerate.Size = new System.Drawing.Size(108, 40);
            this.btnGenerate.TabIndex = 133;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Textcolor = System.Drawing.Color.White;
            this.btnGenerate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rbLineChart
            // 
            this.rbLineChart.AutoSize = true;
            this.rbLineChart.Depth = 0;
            this.rbLineChart.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbLineChart.Location = new System.Drawing.Point(28, 115);
            this.rbLineChart.Margin = new System.Windows.Forms.Padding(0);
            this.rbLineChart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbLineChart.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbLineChart.Name = "rbLineChart";
            this.rbLineChart.Ripple = true;
            this.rbLineChart.Size = new System.Drawing.Size(92, 30);
            this.rbLineChart.TabIndex = 3;
            this.rbLineChart.TabStop = true;
            this.rbLineChart.Text = "Line Chart";
            this.rbLineChart.UseVisualStyleBackColor = true;
            // 
            // rbPieChart
            // 
            this.rbPieChart.AutoSize = true;
            this.rbPieChart.Depth = 0;
            this.rbPieChart.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbPieChart.Location = new System.Drawing.Point(26, 74);
            this.rbPieChart.Margin = new System.Windows.Forms.Padding(0);
            this.rbPieChart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPieChart.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPieChart.Name = "rbPieChart";
            this.rbPieChart.Ripple = true;
            this.rbPieChart.Size = new System.Drawing.Size(85, 30);
            this.rbPieChart.TabIndex = 2;
            this.rbPieChart.TabStop = true;
            this.rbPieChart.Text = "Pie Chart";
            this.rbPieChart.UseVisualStyleBackColor = true;
            // 
            // rbBarChart
            // 
            this.rbBarChart.AutoSize = true;
            this.rbBarChart.Depth = 0;
            this.rbBarChart.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbBarChart.Location = new System.Drawing.Point(26, 33);
            this.rbBarChart.Margin = new System.Windows.Forms.Padding(0);
            this.rbBarChart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBarChart.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBarChart.Name = "rbBarChart";
            this.rbBarChart.Ripple = true;
            this.rbBarChart.Size = new System.Drawing.Size(87, 30);
            this.rbBarChart.TabIndex = 1;
            this.rbBarChart.TabStop = true;
            this.rbBarChart.Text = "Bar Chart";
            this.rbBarChart.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbLineChart);
            this.groupBox3.Controls.Add(this.rbPieChart);
            this.groupBox3.Controls.Add(this.rbBarChart);
            this.groupBox3.Location = new System.Drawing.Point(25, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 166);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chart Types";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chart1);
            this.groupBox6.Location = new System.Drawing.Point(220, 139);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(500, 432);
            this.groupBox6.TabIndex = 75;
            this.groupBox6.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpEndDate);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.dpStartdate);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Location = new System.Drawing.Point(39, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 69);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            // 
            // dpEndDate
            // 
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEndDate.Location = new System.Drawing.Point(315, 29);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(113, 20);
            this.dpEndDate.TabIndex = 141;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(240, 30);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 19);
            this.materialLabel2.TabIndex = 140;
            this.materialLabel2.Text = "End Date";
            // 
            // dpStartdate
            // 
            this.dpStartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStartdate.Location = new System.Drawing.Point(97, 28);
            this.dpStartdate.Name = "dpStartdate";
            this.dpStartdate.Size = new System.Drawing.Size(113, 20);
            this.dpStartdate.TabIndex = 139;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 30);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 137;
            this.materialLabel1.Text = "Start Date";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Location = new System.Drawing.Point(28, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(689, 111);
            this.groupBox7.TabIndex = 80;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Control Panel";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.bunifuFlatButton2);
            this.groupBox8.Controls.Add(this.cmbRType);
            this.groupBox8.Location = new System.Drawing.Point(10, 224);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(174, 187);
            this.groupBox8.TabIndex = 81;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Other Reports";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton2.ButtonText = "   Print";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::AutoCareSystem.Properties.Resources.Print_32px;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(41, 117);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(100, 40);
            this.bunifuFlatButton2.TabIndex = 132;
            this.bunifuFlatButton2.Text = "   Print";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // cmbRType
            // 
            this.cmbRType.FormattingEnabled = true;
            this.cmbRType.ItemHeight = 23;
            this.cmbRType.Items.AddRange(new object[] {
            "Stock Items List",
            "Out Of Stock Items List",
            "Full Orders Report",
            ""});
            this.cmbRType.Location = new System.Drawing.Point(7, 36);
            this.cmbRType.Name = "cmbRType";
            this.cmbRType.Size = new System.Drawing.Size(159, 29);
            this.cmbRType.TabIndex = 0;
            this.cmbRType.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Location = new System.Drawing.Point(20, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 432);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Name = "Report1";
            this.Size = new System.Drawing.Size(754, 595);
            this.Load += new System.EventHandler(this.Report1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialRadioButton rbLineChart;
        private MaterialSkin.Controls.MaterialRadioButton rbPieChart;
        private MaterialSkin.Controls.MaterialRadioButton rbBarChart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dpStartdate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private MetroFramework.Controls.MetroComboBox cmbRType;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenerate;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}
