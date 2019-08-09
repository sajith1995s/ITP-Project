namespace AutoCareSystem
{
    partial class Stock_Manage
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.stock_Handle1 = new AutoCareSystem.Stock_Handle();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.view_Stocks1 = new AutoCareSystem.View_Stocks();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(744, 595);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.stock_Handle1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(736, 553);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Manage Stock";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // stock_Handle1
            // 
            this.stock_Handle1.BackColor = System.Drawing.Color.White;
            this.stock_Handle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stock_Handle1.Location = new System.Drawing.Point(0, 0);
            this.stock_Handle1.Name = "stock_Handle1";
            this.stock_Handle1.Size = new System.Drawing.Size(736, 553);
            this.stock_Handle1.TabIndex = 2;
            this.stock_Handle1.Load += new System.EventHandler(this.stock_Handle1_Load_1);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.view_Stocks1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(736, 553);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "View Stock Items";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // view_Stocks1
            // 
            this.view_Stocks1.BackColor = System.Drawing.Color.White;
            this.view_Stocks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_Stocks1.Location = new System.Drawing.Point(0, 0);
            this.view_Stocks1.Name = "view_Stocks1";
            this.view_Stocks1.Size = new System.Drawing.Size(736, 553);
            this.view_Stocks1.TabIndex = 2;
            // 
            // Stock_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Stock_Manage";
            this.Size = new System.Drawing.Size(744, 595);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private Stock_Handle stock_Handle1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private View_Stocks view_Stocks1;
    }
}
