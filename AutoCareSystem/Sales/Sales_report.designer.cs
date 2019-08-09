namespace AutoCareSystem
{
    partial class Sales_report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenarete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DPenddate = new System.Windows.Forms.DateTimePicker();
            this.DPstartdate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialRadioButton5 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chart1);
            this.groupBox6.Location = new System.Drawing.Point(8, 198);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(719, 366);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(691, 341);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(719, 190);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Report Types";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenarete);
            this.groupBox2.Controls.Add(this.bunifuFlatButton1);
            this.groupBox2.Location = new System.Drawing.Point(484, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 166);
            this.groupBox2.TabIndex = 165;
            this.groupBox2.TabStop = false;
            // 
            // btnGenarete
            // 
            this.btnGenarete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnGenarete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnGenarete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenarete.BorderRadius = 7;
            this.btnGenarete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGenarete.ButtonText = "Genarate";
            this.btnGenarete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenarete.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnGenarete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenarete.Iconimage = global::AutoCareSystem.Properties.Resources.icons8_Process_Filled_32;
            this.btnGenarete.Iconimage_right = null;
            this.btnGenarete.Iconimage_right_Selected = null;
            this.btnGenarete.Iconimage_Selected = null;
            this.btnGenarete.IconMarginLeft = 0;
            this.btnGenarete.IconMarginRight = 0;
            this.btnGenarete.IconRightVisible = true;
            this.btnGenarete.IconRightZoom = 0D;
            this.btnGenarete.IconVisible = true;
            this.btnGenarete.IconZoom = 50D;
            this.btnGenarete.IsTab = false;
            this.btnGenarete.Location = new System.Drawing.Point(58, 34);
            this.btnGenarete.Name = "btnGenarete";
            this.btnGenarete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnGenarete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnGenarete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGenarete.selected = false;
            this.btnGenarete.Size = new System.Drawing.Size(116, 43);
            this.btnGenarete.TabIndex = 159;
            this.btnGenarete.Text = "Genarate";
            this.btnGenarete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenarete.Textcolor = System.Drawing.Color.White;
            this.btnGenarete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarete.Click += new System.EventHandler(this.btnGenarete_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "Print";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::AutoCareSystem.Properties.Resources.Print_32px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(58, 87);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(116, 43);
            this.bunifuFlatButton1.TabIndex = 152;
            this.bunifuFlatButton1.Text = "Print";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DPenddate);
            this.groupBox5.Controls.Add(this.DPstartdate);
            this.groupBox5.Controls.Add(this.materialLabel3);
            this.groupBox5.Controls.Add(this.materialLabel4);
            this.groupBox5.Location = new System.Drawing.Point(211, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(263, 166);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // DPenddate
            // 
            this.DPenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPenddate.Location = new System.Drawing.Point(115, 93);
            this.DPenddate.Name = "DPenddate";
            this.DPenddate.Size = new System.Drawing.Size(136, 21);
            this.DPenddate.TabIndex = 57;
            this.DPenddate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DPstartdate
            // 
            this.DPstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPstartdate.Location = new System.Drawing.Point(115, 50);
            this.DPstartdate.Name = "DPstartdate";
            this.DPstartdate.Size = new System.Drawing.Size(136, 21);
            this.DPstartdate.TabIndex = 56;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(7, 94);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(97, 19);
            this.materialLabel3.TabIndex = 55;
            this.materialLabel3.Text = "Ending Date :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(7, 50);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(104, 19);
            this.materialLabel4.TabIndex = 54;
            this.materialLabel4.Text = "Starting Date :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialRadioButton5);
            this.groupBox1.Controls.Add(this.materialRadioButton4);
            this.groupBox1.Controls.Add(this.materialRadioButton3);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // materialRadioButton5
            // 
            this.materialRadioButton5.AutoSize = true;
            this.materialRadioButton5.Depth = 0;
            this.materialRadioButton5.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton5.Location = new System.Drawing.Point(39, 109);
            this.materialRadioButton5.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton5.Name = "materialRadioButton5";
            this.materialRadioButton5.Ripple = true;
            this.materialRadioButton5.Size = new System.Drawing.Size(92, 30);
            this.materialRadioButton5.TabIndex = 6;
            this.materialRadioButton5.TabStop = true;
            this.materialRadioButton5.Text = "Line Chart";
            this.materialRadioButton5.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton4
            // 
            this.materialRadioButton4.AutoSize = true;
            this.materialRadioButton4.Depth = 0;
            this.materialRadioButton4.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton4.Location = new System.Drawing.Point(39, 67);
            this.materialRadioButton4.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton4.Name = "materialRadioButton4";
            this.materialRadioButton4.Ripple = true;
            this.materialRadioButton4.Size = new System.Drawing.Size(85, 30);
            this.materialRadioButton4.TabIndex = 5;
            this.materialRadioButton4.TabStop = true;
            this.materialRadioButton4.Text = "Pie Chart";
            this.materialRadioButton4.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton3
            // 
            this.materialRadioButton3.AutoSize = true;
            this.materialRadioButton3.Depth = 0;
            this.materialRadioButton3.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton3.Location = new System.Drawing.Point(39, 27);
            this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton3.Name = "materialRadioButton3";
            this.materialRadioButton3.Ripple = true;
            this.materialRadioButton3.Size = new System.Drawing.Size(87, 30);
            this.materialRadioButton3.TabIndex = 4;
            this.materialRadioButton3.TabStop = true;
            this.materialRadioButton3.Text = "Bar Chart";
            this.materialRadioButton3.UseVisualStyleBackColor = true;
            // 
            // Sales_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Name = "Sales_report";
            this.Size = new System.Drawing.Size(737, 590);
            this.Load += new System.EventHandler(this.Sales_report_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker DPenddate;
        private System.Windows.Forms.DateTimePicker DPstartdate;
        public MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton5;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btnGenarete;
    }
}
