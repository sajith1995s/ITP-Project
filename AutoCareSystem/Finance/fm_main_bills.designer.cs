namespace AutoCareSystem
{
    partial class fm_main_bills
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
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.bills_manage1 = new AutoCareSystem.fm_manage_bills();
            this.bill_payments = new MetroFramework.Controls.MetroTabPage();
            this.fm_bill_payments1 = new AutoCareSystem.fm_bill_payments();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.bill_payments.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.bill_payments);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(731, 584);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.bills_manage1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(723, 542);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Manage Other Bills";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // bills_manage1
            // 
            this.bills_manage1.BackColor = System.Drawing.Color.White;
            this.bills_manage1.Location = new System.Drawing.Point(3, 3);
            this.bills_manage1.Name = "bills_manage1";
            this.bills_manage1.Size = new System.Drawing.Size(717, 536);
            this.bills_manage1.TabIndex = 2;
            // 
            // bill_payments
            // 
            this.bill_payments.Controls.Add(this.fm_bill_payments1);
            this.bill_payments.HorizontalScrollbarBarColor = true;
            this.bill_payments.HorizontalScrollbarHighlightOnWheel = false;
            this.bill_payments.HorizontalScrollbarSize = 10;
            this.bill_payments.Location = new System.Drawing.Point(4, 38);
            this.bill_payments.Name = "bill_payments";
            this.bill_payments.Size = new System.Drawing.Size(723, 542);
            this.bill_payments.TabIndex = 3;
            this.bill_payments.Text = "Manage Bill Payments";
            this.bill_payments.VerticalScrollbarBarColor = true;
            this.bill_payments.VerticalScrollbarHighlightOnWheel = false;
            this.bill_payments.VerticalScrollbarSize = 10;
            // 
            // fm_bill_payments1
            // 
            this.fm_bill_payments1.BackColor = System.Drawing.Color.White;
            this.fm_bill_payments1.Location = new System.Drawing.Point(3, 3);
            this.fm_bill_payments1.Name = "fm_bill_payments1";
            this.fm_bill_payments1.Size = new System.Drawing.Size(717, 536);
            this.fm_bill_payments1.TabIndex = 2;
            // 
            // fm_main_bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "fm_main_bills";
            this.Size = new System.Drawing.Size(737, 590);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.bill_payments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private fm_manage_bills bills_manage1;
        private MetroFramework.Controls.MetroTabPage bill_payments;
        private fm_bill_payments fm_bill_payments1;
    }
}
