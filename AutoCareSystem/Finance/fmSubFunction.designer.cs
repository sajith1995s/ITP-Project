namespace AutoCareSystem
{
    partial class fmSubFunction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.p_l_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bills_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loans_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.income_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.expenses_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fm_expenses1 = new AutoCareSystem.Financial_Statistics.fm_expenses();
            this.fm_income1 = new AutoCareSystem.Financial_Statistics.fm_income();
            this.bills1 = new AutoCareSystem.fm_main_bills();
            this.fm_profit1 = new AutoCareSystem.Financial_Statistics.fm_profit();
            this.loans1 = new AutoCareSystem.loans();
            this.reports1 = new AutoCareSystem.fm_reports();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.p_l_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bills_btn);
            this.panel1.Controls.Add(this.loans_btn);
            this.panel1.Controls.Add(this.income_btn);
            this.panel1.Controls.Add(this.expenses_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 590);
            this.panel1.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   Reports";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::AutoCareSystem.Properties.Resources.icons8_Report_Card_64;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(2, 417);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(209, 48);
            this.bunifuFlatButton1.TabIndex = 12;
            this.bunifuFlatButton1.Text = "   Reports";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // p_l_btn
            // 
            this.p_l_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.p_l_btn.BackColor = System.Drawing.Color.Transparent;
            this.p_l_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_l_btn.BorderRadius = 0;
            this.p_l_btn.ButtonText = "   Profit/Loss";
            this.p_l_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_l_btn.DisabledColor = System.Drawing.Color.Gray;
            this.p_l_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.p_l_btn.Iconimage = global::AutoCareSystem.Properties.Resources.Statistics_96px;
            this.p_l_btn.Iconimage_right = null;
            this.p_l_btn.Iconimage_right_Selected = null;
            this.p_l_btn.Iconimage_Selected = null;
            this.p_l_btn.IconMarginLeft = 0;
            this.p_l_btn.IconMarginRight = 0;
            this.p_l_btn.IconRightVisible = true;
            this.p_l_btn.IconRightZoom = 0D;
            this.p_l_btn.IconVisible = true;
            this.p_l_btn.IconZoom = 50D;
            this.p_l_btn.IsTab = true;
            this.p_l_btn.Location = new System.Drawing.Point(5, 249);
            this.p_l_btn.Margin = new System.Windows.Forms.Padding(4);
            this.p_l_btn.Name = "p_l_btn";
            this.p_l_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.p_l_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.p_l_btn.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.p_l_btn.selected = false;
            this.p_l_btn.Size = new System.Drawing.Size(209, 48);
            this.p_l_btn.TabIndex = 11;
            this.p_l_btn.Text = "   Profit/Loss";
            this.p_l_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.p_l_btn.Textcolor = System.Drawing.Color.White;
            this.p_l_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_l_btn.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 119);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AutoCareSystem.Properties.Resources.Unt5;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bills_btn
            // 
            this.bills_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.bills_btn.BackColor = System.Drawing.Color.Transparent;
            this.bills_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bills_btn.BorderRadius = 0;
            this.bills_btn.ButtonText = "   Bills";
            this.bills_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bills_btn.DisabledColor = System.Drawing.Color.Gray;
            this.bills_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.bills_btn.Iconimage = global::AutoCareSystem.Properties.Resources.Bill_96px;
            this.bills_btn.Iconimage_right = null;
            this.bills_btn.Iconimage_right_Selected = null;
            this.bills_btn.Iconimage_Selected = null;
            this.bills_btn.IconMarginLeft = 0;
            this.bills_btn.IconMarginRight = 0;
            this.bills_btn.IconRightVisible = true;
            this.bills_btn.IconRightZoom = 0D;
            this.bills_btn.IconVisible = true;
            this.bills_btn.IconZoom = 50D;
            this.bills_btn.IsTab = true;
            this.bills_btn.Location = new System.Drawing.Point(2, 361);
            this.bills_btn.Margin = new System.Windows.Forms.Padding(4);
            this.bills_btn.Name = "bills_btn";
            this.bills_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.bills_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.bills_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.bills_btn.selected = false;
            this.bills_btn.Size = new System.Drawing.Size(209, 48);
            this.bills_btn.TabIndex = 8;
            this.bills_btn.Text = "   Bills";
            this.bills_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bills_btn.Textcolor = System.Drawing.Color.White;
            this.bills_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bills_btn.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // loans_btn
            // 
            this.loans_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.loans_btn.BackColor = System.Drawing.Color.Transparent;
            this.loans_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loans_btn.BorderRadius = 0;
            this.loans_btn.ButtonText = "   Loans";
            this.loans_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loans_btn.DisabledColor = System.Drawing.Color.Gray;
            this.loans_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.loans_btn.Iconimage = global::AutoCareSystem.Properties.Resources.Debt_96px;
            this.loans_btn.Iconimage_right = null;
            this.loans_btn.Iconimage_right_Selected = null;
            this.loans_btn.Iconimage_Selected = null;
            this.loans_btn.IconMarginLeft = 0;
            this.loans_btn.IconMarginRight = 0;
            this.loans_btn.IconRightVisible = true;
            this.loans_btn.IconRightZoom = 0D;
            this.loans_btn.IconVisible = true;
            this.loans_btn.IconZoom = 50D;
            this.loans_btn.IsTab = true;
            this.loans_btn.Location = new System.Drawing.Point(2, 305);
            this.loans_btn.Margin = new System.Windows.Forms.Padding(4);
            this.loans_btn.Name = "loans_btn";
            this.loans_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.loans_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.loans_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.loans_btn.selected = false;
            this.loans_btn.Size = new System.Drawing.Size(209, 48);
            this.loans_btn.TabIndex = 7;
            this.loans_btn.Text = "   Loans";
            this.loans_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loans_btn.Textcolor = System.Drawing.Color.White;
            this.loans_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loans_btn.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // income_btn
            // 
            this.income_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.income_btn.BackColor = System.Drawing.Color.Transparent;
            this.income_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.income_btn.BorderRadius = 0;
            this.income_btn.ButtonText = "   Income";
            this.income_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income_btn.DisabledColor = System.Drawing.Color.Gray;
            this.income_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.income_btn.Iconimage = global::AutoCareSystem.Properties.Resources.Increase_96px;
            this.income_btn.Iconimage_right = null;
            this.income_btn.Iconimage_right_Selected = null;
            this.income_btn.Iconimage_Selected = null;
            this.income_btn.IconMarginLeft = 0;
            this.income_btn.IconMarginRight = 0;
            this.income_btn.IconRightVisible = true;
            this.income_btn.IconRightZoom = 0D;
            this.income_btn.IconVisible = true;
            this.income_btn.IconZoom = 50D;
            this.income_btn.IsTab = true;
            this.income_btn.Location = new System.Drawing.Point(3, 193);
            this.income_btn.Margin = new System.Windows.Forms.Padding(4);
            this.income_btn.Name = "income_btn";
            this.income_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.income_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.income_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.income_btn.selected = false;
            this.income_btn.Size = new System.Drawing.Size(209, 48);
            this.income_btn.TabIndex = 6;
            this.income_btn.Text = "   Income";
            this.income_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.income_btn.Textcolor = System.Drawing.Color.White;
            this.income_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_btn.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // expenses_btn
            // 
            this.expenses_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.expenses_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.expenses_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.expenses_btn.BorderRadius = 0;
            this.expenses_btn.ButtonText = "   Expenses";
            this.expenses_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expenses_btn.DisabledColor = System.Drawing.Color.Gray;
            this.expenses_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.expenses_btn.Iconimage = global::AutoCareSystem.Properties.Resources.Decrease_96px;
            this.expenses_btn.Iconimage_right = null;
            this.expenses_btn.Iconimage_right_Selected = null;
            this.expenses_btn.Iconimage_Selected = null;
            this.expenses_btn.IconMarginLeft = 0;
            this.expenses_btn.IconMarginRight = 0;
            this.expenses_btn.IconRightVisible = true;
            this.expenses_btn.IconRightZoom = 0D;
            this.expenses_btn.IconVisible = true;
            this.expenses_btn.IconZoom = 50D;
            this.expenses_btn.IsTab = true;
            this.expenses_btn.Location = new System.Drawing.Point(3, 137);
            this.expenses_btn.Margin = new System.Windows.Forms.Padding(4);
            this.expenses_btn.Name = "expenses_btn";
            this.expenses_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.expenses_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.expenses_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.expenses_btn.selected = true;
            this.expenses_btn.Size = new System.Drawing.Size(209, 48);
            this.expenses_btn.TabIndex = 5;
            this.expenses_btn.Text = "   Expenses";
            this.expenses_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenses_btn.Textcolor = System.Drawing.Color.White;
            this.expenses_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses_btn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.fm_expenses1);
            this.panel3.Controls.Add(this.fm_income1);
            this.panel3.Controls.Add(this.bills1);
            this.panel3.Controls.Add(this.fm_profit1);
            this.panel3.Controls.Add(this.loans1);
            this.panel3.Controls.Add(this.reports1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(214, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 590);
            this.panel3.TabIndex = 2;
            // 
            // fm_expenses1
            // 
            this.fm_expenses1.BackColor = System.Drawing.Color.White;
            this.fm_expenses1.Location = new System.Drawing.Point(0, 0);
            this.fm_expenses1.Margin = new System.Windows.Forms.Padding(2);
            this.fm_expenses1.Name = "fm_expenses1";
            this.fm_expenses1.Size = new System.Drawing.Size(737, 590);
            this.fm_expenses1.TabIndex = 7;
            // 
            // fm_income1
            // 
            this.fm_income1.BackColor = System.Drawing.Color.White;
            this.fm_income1.Location = new System.Drawing.Point(0, 0);
            this.fm_income1.Margin = new System.Windows.Forms.Padding(2);
            this.fm_income1.Name = "fm_income1";
            this.fm_income1.Size = new System.Drawing.Size(737, 590);
            this.fm_income1.TabIndex = 6;
            // 
            // bills1
            // 
            this.bills1.BackColor = System.Drawing.Color.White;
            this.bills1.Location = new System.Drawing.Point(0, 0);
            this.bills1.Name = "bills1";
            this.bills1.Size = new System.Drawing.Size(737, 590);
            this.bills1.TabIndex = 5;
            // 
            // fm_profit1
            // 
            this.fm_profit1.BackColor = System.Drawing.Color.White;
            this.fm_profit1.Location = new System.Drawing.Point(2, 0);
            this.fm_profit1.Margin = new System.Windows.Forms.Padding(2);
            this.fm_profit1.Name = "fm_profit1";
            this.fm_profit1.Size = new System.Drawing.Size(737, 590);
            this.fm_profit1.TabIndex = 8;
            // 
            // loans1
            // 
            this.loans1.Location = new System.Drawing.Point(0, 0);
            this.loans1.Name = "loans1";
            this.loans1.Size = new System.Drawing.Size(737, 590);
            this.loans1.TabIndex = 9;
            // 
            // reports1
            // 
            this.reports1.BackColor = System.Drawing.Color.White;
            this.reports1.Location = new System.Drawing.Point(0, 0);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(737, 590);
            this.reports1.TabIndex = 10;
            // 
            // fmSubFunction
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "fmSubFunction";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.Text = "Finance Management";
            this.Load += new System.EventHandler(this.SubFunc_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton bills_btn;
        private Bunifu.Framework.UI.BunifuFlatButton loans_btn;
        private Bunifu.Framework.UI.BunifuFlatButton income_btn;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton p_l_btn;
        private Bunifu.Framework.UI.BunifuFlatButton expenses_btn;
        private Financial_Statistics.fm_income fm_income1;
        private Financial_Statistics.fm_expenses fm_expenses1;
        private Financial_Statistics.fm_profit fm_profit1;
        public fm_main_bills bills1;
        private loans loans1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private fm_reports reports1;
    }
}