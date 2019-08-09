namespace AutoCareSystem
{
    partial class loans
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
            this.manageLoans = new MetroFramework.Controls.MetroTabPage();
            this.loanPayments = new MetroFramework.Controls.MetroTabPage();
            this.fm_loans1 = new AutoCareSystem.fm_loans();
            this.manage_loans1 = new AutoCareSystem.fm_loan_payments();
            this.metroTabControl1.SuspendLayout();
            this.manageLoans.SuspendLayout();
            this.loanPayments.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.manageLoans);
            this.metroTabControl1.Controls.Add(this.loanPayments);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(731, 584);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // manageLoans
            // 
            this.manageLoans.Controls.Add(this.fm_loans1);
            this.manageLoans.HorizontalScrollbarBarColor = true;
            this.manageLoans.HorizontalScrollbarHighlightOnWheel = false;
            this.manageLoans.HorizontalScrollbarSize = 10;
            this.manageLoans.Location = new System.Drawing.Point(4, 38);
            this.manageLoans.Name = "manageLoans";
            this.manageLoans.Size = new System.Drawing.Size(723, 542);
            this.manageLoans.TabIndex = 0;
            this.manageLoans.Text = "Manage Loans";
            this.manageLoans.VerticalScrollbarBarColor = true;
            this.manageLoans.VerticalScrollbarHighlightOnWheel = false;
            this.manageLoans.VerticalScrollbarSize = 10;
            // 
            // loanPayments
            // 
            this.loanPayments.Controls.Add(this.manage_loans1);
            this.loanPayments.HorizontalScrollbarBarColor = true;
            this.loanPayments.HorizontalScrollbarHighlightOnWheel = false;
            this.loanPayments.HorizontalScrollbarSize = 10;
            this.loanPayments.Location = new System.Drawing.Point(4, 38);
            this.loanPayments.Name = "loanPayments";
            this.loanPayments.Size = new System.Drawing.Size(723, 542);
            this.loanPayments.TabIndex = 1;
            this.loanPayments.Text = "Manage Loan Payments";
            this.loanPayments.VerticalScrollbarBarColor = true;
            this.loanPayments.VerticalScrollbarHighlightOnWheel = false;
            this.loanPayments.VerticalScrollbarSize = 10;
            // 
            // fm_loans1
            // 
            this.fm_loans1.BackColor = System.Drawing.Color.White;
            this.fm_loans1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fm_loans1.Location = new System.Drawing.Point(0, 3);
            this.fm_loans1.Name = "fm_loans1";
            this.fm_loans1.Size = new System.Drawing.Size(717, 536);
            this.fm_loans1.TabIndex = 2;
            // 
            // manage_loans1
            // 
            this.manage_loans1.BackColor = System.Drawing.Color.White;
            this.manage_loans1.Location = new System.Drawing.Point(-4, 3);
            this.manage_loans1.Name = "manage_loans1";
            this.manage_loans1.Size = new System.Drawing.Size(717, 536);
            this.manage_loans1.TabIndex = 2;
            // 
            // loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "loans";
            this.Size = new System.Drawing.Size(737, 590);
            this.metroTabControl1.ResumeLayout(false);
            this.manageLoans.ResumeLayout(false);
            this.loanPayments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage manageLoans;
        private MetroFramework.Controls.MetroTabPage loanPayments;
        private fm_loans fm_loans1;
        private fm_loan_payments manage_loans1;
    }
}
