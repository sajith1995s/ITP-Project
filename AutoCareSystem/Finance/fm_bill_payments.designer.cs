namespace AutoCareSystem
{
    partial class fm_bill_payments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.grpboxBillPayments = new System.Windows.Forms.GroupBox();
            this.paidDate = new System.Windows.Forms.DateTimePicker();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtPaidAmount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblIssueDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblAmount = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblType = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblBillID = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrevPaid = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.lblRemAmount = new MaterialSkin.Controls.MaterialLabel();
            this.btnMakePayment = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.grpboxBillPayments.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialRaisedButton2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Bill";
            // 
            // btnSearch
            // 
            this.btnSearch.Depth = 0;
            this.btnSearch.Location = new System.Drawing.Point(162, 19);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = true;
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.TabIndex = 159;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.HintForeColor = System.Drawing.Color.Empty;
            this.txtId.HintText = "";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtId.LineThickness = 2;
            this.txtId.Location = new System.Drawing.Point(59, 9);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(96, 33);
            this.txtId.TabIndex = 159;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(4, 23);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(48, 19);
            this.materialLabel3.TabIndex = 158;
            this.materialLabel3.Text = "Bill ID";
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGrid1.AllowUserToResizeColumns = false;
            this.bunifuCustomDataGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = false;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(2, 197);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 4;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.ShowEditingIcon = false;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(713, 337);
            this.bunifuCustomDataGrid1.TabIndex = 37;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // grpboxBillPayments
            // 
            this.grpboxBillPayments.Controls.Add(this.btnMakePayment);
            this.grpboxBillPayments.Controls.Add(this.lblRemAmount);
            this.grpboxBillPayments.Controls.Add(this.materialLabel10);
            this.grpboxBillPayments.Controls.Add(this.lblPrevPaid);
            this.grpboxBillPayments.Controls.Add(this.materialLabel9);
            this.grpboxBillPayments.Controls.Add(this.materialLabel8);
            this.grpboxBillPayments.Controls.Add(this.paidDate);
            this.grpboxBillPayments.Controls.Add(this.materialRaisedButton1);
            this.grpboxBillPayments.Controls.Add(this.txtPaidAmount);
            this.grpboxBillPayments.Controls.Add(this.materialLabel7);
            this.grpboxBillPayments.Controls.Add(this.materialLabel5);
            this.grpboxBillPayments.Controls.Add(this.lblIssueDate);
            this.grpboxBillPayments.Controls.Add(this.materialLabel6);
            this.grpboxBillPayments.Controls.Add(this.lblAmount);
            this.grpboxBillPayments.Controls.Add(this.materialLabel2);
            this.grpboxBillPayments.Controls.Add(this.lblType);
            this.grpboxBillPayments.Controls.Add(this.materialLabel4);
            this.grpboxBillPayments.Controls.Add(this.lblBillID);
            this.grpboxBillPayments.Controls.Add(this.materialLabel1);
            this.grpboxBillPayments.Location = new System.Drawing.Point(3, 58);
            this.grpboxBillPayments.Name = "grpboxBillPayments";
            this.grpboxBillPayments.Size = new System.Drawing.Size(700, 134);
            this.grpboxBillPayments.TabIndex = 38;
            this.grpboxBillPayments.TabStop = false;
            this.grpboxBillPayments.Text = "Bill Payments";
            // 
            // paidDate
            // 
            this.paidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.paidDate.Location = new System.Drawing.Point(367, 106);
            this.paidDate.Name = "paidDate";
            this.paidDate.Size = new System.Drawing.Size(96, 20);
            this.paidDate.TabIndex = 172;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(479, 74);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(132, 23);
            this.materialRaisedButton1.TabIndex = 171;
            this.materialRaisedButton1.Text = "Full Payment";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaidAmount.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPaidAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaidAmount.HintForeColor = System.Drawing.Color.Empty;
            this.txtPaidAmount.HintText = "";
            this.txtPaidAmount.isPassword = false;
            this.txtPaidAmount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtPaidAmount.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPaidAmount.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtPaidAmount.LineThickness = 2;
            this.txtPaidAmount.Location = new System.Drawing.Point(367, 65);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(96, 33);
            this.txtPaidAmount.TabIndex = 169;
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(247, 107);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(73, 19);
            this.materialLabel7.TabIndex = 168;
            this.materialLabel7.Text = "Paid Date";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(247, 79);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(95, 19);
            this.materialLabel5.TabIndex = 167;
            this.materialLabel5.Text = "Amount Paid";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Depth = 0;
            this.lblIssueDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIssueDate.Location = new System.Drawing.Point(122, 112);
            this.lblIssueDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(54, 19);
            this.lblIssueDate.TabIndex = 166;
            this.lblIssueDate.Text = "<date>";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 112);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(80, 19);
            this.materialLabel6.TabIndex = 165;
            this.materialLabel6.Text = "Issue Date";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Depth = 0;
            this.lblAmount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAmount.Location = new System.Drawing.Point(122, 84);
            this.lblAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(76, 19);
            this.lblAmount.TabIndex = 164;
            this.lblAmount.Text = "<amount>";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 84);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 19);
            this.materialLabel2.TabIndex = 163;
            this.materialLabel2.Text = "Total Amount";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Depth = 0;
            this.lblType.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblType.Location = new System.Drawing.Point(122, 55);
            this.lblType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 19);
            this.lblType.TabIndex = 162;
            this.lblType.Text = "<type>";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 55);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(41, 19);
            this.materialLabel4.TabIndex = 161;
            this.materialLabel4.Text = "Type";
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Depth = 0;
            this.lblBillID.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBillID.Location = new System.Drawing.Point(122, 27);
            this.lblBillID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(63, 19);
            this.lblBillID.TabIndex = 160;
            this.lblBillID.Text = "<bill ID>";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 27);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 19);
            this.materialLabel1.TabIndex = 159;
            this.materialLabel1.Text = "Selected Bill ID";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(247, 12);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(111, 19);
            this.materialLabel8.TabIndex = 173;
            this.materialLabel8.Text = "Previously Paid";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(268, 30);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(62, 19);
            this.materialLabel9.TabIndex = 174;
            this.materialLabel9.Text = "Amount";
            // 
            // lblPrevPaid
            // 
            this.lblPrevPaid.AutoSize = true;
            this.lblPrevPaid.Depth = 0;
            this.lblPrevPaid.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPrevPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrevPaid.Location = new System.Drawing.Point(377, 12);
            this.lblPrevPaid.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrevPaid.Name = "lblPrevPaid";
            this.lblPrevPaid.Size = new System.Drawing.Size(89, 19);
            this.lblPrevPaid.TabIndex = 175;
            this.lblPrevPaid.Text = "<prev. paid>";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(247, 55);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(136, 19);
            this.materialLabel10.TabIndex = 176;
            this.materialLabel10.Text = "Remaining Amount";
            // 
            // lblRemAmount
            // 
            this.lblRemAmount.AutoSize = true;
            this.lblRemAmount.Depth = 0;
            this.lblRemAmount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRemAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRemAmount.Location = new System.Drawing.Point(389, 55);
            this.lblRemAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRemAmount.Name = "lblRemAmount";
            this.lblRemAmount.Size = new System.Drawing.Size(112, 19);
            this.lblRemAmount.TabIndex = 177;
            this.lblRemAmount.Text = "<rem. Amount>";
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Depth = 0;
            this.btnMakePayment.Location = new System.Drawing.Point(562, 30);
            this.btnMakePayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Primary = true;
            this.btnMakePayment.Size = new System.Drawing.Size(132, 23);
            this.btnMakePayment.TabIndex = 178;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(308, 19);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(212, 23);
            this.materialRaisedButton2.TabIndex = 160;
            this.materialRaisedButton2.Text = "Display Existing Payments";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // fm_bill_payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grpboxBillPayments);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.groupBox1);
            this.Name = "fm_bill_payments";
            this.Size = new System.Drawing.Size(717, 536);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.grpboxBillPayments.ResumeLayout(false);
            this.grpboxBillPayments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        protected MaterialSkin.Controls.MaterialRaisedButton btnSearch;
        private System.Windows.Forms.GroupBox grpboxBillPayments;
        private MaterialSkin.Controls.MaterialLabel lblBillID;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblType;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblIssueDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker paidDate;
        protected MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPaidAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblRemAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel lblPrevPaid;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        protected MaterialSkin.Controls.MaterialRaisedButton btnMakePayment;
        protected MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}
