namespace AutoCareSystem
{
    partial class add_repair_faults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.tbxVehicleNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblModel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.repairDate = new System.Windows.Forms.DateTimePicker();
            this.lblBrand = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.tbxErrorCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tbxRemark = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxErrorDesc = new System.Windows.Forms.RichTextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTechnician = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblErrorCount = new MaterialSkin.Controls.MaterialLabel();
            this.btnRepairAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRemove = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.materialLabel1);
            this.groupBox4.Controls.Add(this.materialLabel14);
            this.groupBox4.Controls.Add(this.tbxVehicleNumber);
            this.groupBox4.Controls.Add(this.lblModel);
            this.groupBox4.Controls.Add(this.materialLabel12);
            this.groupBox4.Controls.Add(this.materialLabel13);
            this.groupBox4.Controls.Add(this.materialLabel4);
            this.groupBox4.Controls.Add(this.repairDate);
            this.groupBox4.Controls.Add(this.lblBrand);
            this.groupBox4.Controls.Add(this.materialLabel8);
            this.groupBox4.Location = new System.Drawing.Point(13, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(703, 58);
            this.groupBox4.TabIndex = 96;
            this.groupBox4.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "Vehicle No";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(620, 21);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(13, 19);
            this.materialLabel14.TabIndex = 46;
            this.materialLabel14.Text = ":";
            // 
            // tbxVehicleNumber
            // 
            this.tbxVehicleNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxVehicleNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxVehicleNumber.ForeColor = System.Drawing.Color.Black;
            this.tbxVehicleNumber.HintForeColor = System.Drawing.Color.Black;
            this.tbxVehicleNumber.HintText = "Vehicle Number";
            this.tbxVehicleNumber.isPassword = false;
            this.tbxVehicleNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.tbxVehicleNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxVehicleNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.tbxVehicleNumber.LineThickness = 2;
            this.tbxVehicleNumber.Location = new System.Drawing.Point(91, 14);
            this.tbxVehicleNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbxVehicleNumber.Name = "tbxVehicleNumber";
            this.tbxVehicleNumber.Size = new System.Drawing.Size(129, 33);
            this.tbxVehicleNumber.TabIndex = 35;
            this.tbxVehicleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxVehicleNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVehicleNumber_KeyPress);
            this.tbxVehicleNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxVehicleNumber_KeyUp);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Depth = 0;
            this.lblModel.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblModel.Location = new System.Drawing.Point(631, 22);
            this.lblModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(43, 19);
            this.lblModel.TabIndex = 44;
            this.lblModel.Text = "Prius";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(572, 22);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(51, 19);
            this.materialLabel12.TabIndex = 43;
            this.materialLabel12.Text = "Model";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(477, 22);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(13, 19);
            this.materialLabel13.TabIndex = 45;
            this.materialLabel13.Text = ":";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(258, 22);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(40, 19);
            this.materialLabel4.TabIndex = 41;
            this.materialLabel4.Text = "Date";
            // 
            // repairDate
            // 
            this.repairDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.repairDate.Location = new System.Drawing.Point(304, 22);
            this.repairDate.Name = "repairDate";
            this.repairDate.Size = new System.Drawing.Size(94, 20);
            this.repairDate.TabIndex = 51;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Depth = 0;
            this.lblBrand.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBrand.Location = new System.Drawing.Point(488, 22);
            this.lblBrand.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(56, 19);
            this.lblBrand.TabIndex = 42;
            this.lblBrand.Text = "Toyota";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(431, 22);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(47, 19);
            this.materialLabel8.TabIndex = 39;
            this.materialLabel8.Text = "Brand";
            // 
            // tbxErrorCode
            // 
            this.tbxErrorCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxErrorCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxErrorCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxErrorCode.HintForeColor = System.Drawing.Color.Empty;
            this.tbxErrorCode.HintText = "";
            this.tbxErrorCode.isPassword = false;
            this.tbxErrorCode.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.tbxErrorCode.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxErrorCode.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.tbxErrorCode.LineThickness = 2;
            this.tbxErrorCode.Location = new System.Drawing.Point(121, 93);
            this.tbxErrorCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxErrorCode.Name = "tbxErrorCode";
            this.tbxErrorCode.Size = new System.Drawing.Size(92, 33);
            this.tbxErrorCode.TabIndex = 99;
            this.tbxErrorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxErrorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxErrorCode_KeyPress);
            this.tbxErrorCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxErrorCode_KeyUp);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(35, 102);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(81, 19);
            this.materialLabel2.TabIndex = 98;
            this.materialLabel2.Text = "Error Code";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(288, 93);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 19);
            this.materialLabel5.TabIndex = 100;
            this.materialLabel5.Text = "Description";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox2.Location = new System.Drawing.Point(13, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 238);
            this.groupBox2.TabIndex = 130;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fault List";
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 21;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.LightSkyBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(15, 21);
            this.bunifuCustomDataGrid1.MultiSelect = false;
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(677, 201);
            this.bunifuCustomDataGrid1.TabIndex = 60;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Error Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Remark";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(35, 157);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(60, 19);
            this.materialLabel6.TabIndex = 133;
            this.materialLabel6.Text = "Remark";
            // 
            // tbxRemark
            // 
            this.tbxRemark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxRemark.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxRemark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxRemark.HintForeColor = System.Drawing.Color.Empty;
            this.tbxRemark.HintText = "";
            this.tbxRemark.isPassword = false;
            this.tbxRemark.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.tbxRemark.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxRemark.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.tbxRemark.LineThickness = 2;
            this.tbxRemark.Location = new System.Drawing.Point(121, 145);
            this.tbxRemark.Margin = new System.Windows.Forms.Padding(4);
            this.tbxRemark.Name = "tbxRemark";
            this.tbxRemark.Size = new System.Drawing.Size(163, 33);
            this.tbxRemark.TabIndex = 134;
            this.tbxRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbxErrorDesc
            // 
            this.tbxErrorDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxErrorDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxErrorDesc.Location = new System.Drawing.Point(380, 92);
            this.tbxErrorDesc.Name = "tbxErrorDesc";
            this.tbxErrorDesc.Size = new System.Drawing.Size(183, 104);
            this.tbxErrorDesc.TabIndex = 135;
            this.tbxErrorDesc.Text = "";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(13, 71);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(703, 15);
            this.bunifuSeparator2.TabIndex = 97;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 200);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(703, 15);
            this.bunifuSeparator1.TabIndex = 136;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTechnician);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel15);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.lblErrorCount);
            this.groupBox1.Location = new System.Drawing.Point(13, 474);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 58);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            // 
            // cmbTechnician
            // 
            this.cmbTechnician.DropDownHeight = 200;
            this.cmbTechnician.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbTechnician.FormattingEnabled = true;
            this.cmbTechnician.IntegralHeight = false;
            this.cmbTechnician.ItemHeight = 19;
            this.cmbTechnician.Location = new System.Drawing.Point(183, 19);
            this.cmbTechnician.Name = "cmbTechnician";
            this.cmbTechnician.Size = new System.Drawing.Size(192, 25);
            this.cmbTechnician.TabIndex = 102;
            this.cmbTechnician.UseSelectable = true;
            this.cmbTechnician.Click += new System.EventHandler(this.cmbTechnician_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(32, 22);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(132, 19);
            this.materialLabel3.TabIndex = 48;
            this.materialLabel3.Text = "Assign Technician";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(527, 22);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(13, 19);
            this.materialLabel15.TabIndex = 47;
            this.materialLabel15.Text = ":";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(438, 22);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(89, 19);
            this.materialLabel7.TabIndex = 34;
            this.materialLabel7.Text = "Total Errors";
            // 
            // lblErrorCount
            // 
            this.lblErrorCount.AutoSize = true;
            this.lblErrorCount.Depth = 0;
            this.lblErrorCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblErrorCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorCount.Location = new System.Drawing.Point(541, 23);
            this.lblErrorCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblErrorCount.Name = "lblErrorCount";
            this.lblErrorCount.Size = new System.Drawing.Size(17, 19);
            this.lblErrorCount.TabIndex = 41;
            this.lblErrorCount.Text = "0";
            // 
            // btnRepairAdd
            // 
            this.btnRepairAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRepairAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRepairAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRepairAdd.BorderRadius = 7;
            this.btnRepairAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRepairAdd.ButtonText = "   Add";
            this.btnRepairAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepairAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnRepairAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRepairAdd.Iconimage = global::AutoCareSystem.Properties.Resources.Plus_32px;
            this.btnRepairAdd.Iconimage_right = null;
            this.btnRepairAdd.Iconimage_right_Selected = null;
            this.btnRepairAdd.Iconimage_Selected = null;
            this.btnRepairAdd.IconMarginLeft = 0;
            this.btnRepairAdd.IconMarginRight = 0;
            this.btnRepairAdd.IconRightVisible = true;
            this.btnRepairAdd.IconRightZoom = 0D;
            this.btnRepairAdd.IconVisible = true;
            this.btnRepairAdd.IconZoom = 50D;
            this.btnRepairAdd.IsTab = false;
            this.btnRepairAdd.Location = new System.Drawing.Point(618, 485);
            this.btnRepairAdd.Name = "btnRepairAdd";
            this.btnRepairAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRepairAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnRepairAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRepairAdd.selected = false;
            this.btnRepairAdd.Size = new System.Drawing.Size(100, 40);
            this.btnRepairAdd.TabIndex = 137;
            this.btnRepairAdd.Text = "   Add";
            this.btnRepairAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepairAdd.Textcolor = System.Drawing.Color.White;
            this.btnRepairAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepairAdd.Click += new System.EventHandler(this.btnRepairAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 7;
            this.btnAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAdd.ButtonText = "   Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = global::AutoCareSystem.Properties.Resources.Plus_32px;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 50D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(605, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 129;
            this.btnAdd.Text = "   Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.BorderRadius = 7;
            this.btnRemove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRemove.ButtonText = "Remove";
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.DisabledColor = System.Drawing.Color.Gray;
            this.btnRemove.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRemove.Iconimage = global::AutoCareSystem.Properties.Resources.Trash_32px;
            this.btnRemove.Iconimage_right = null;
            this.btnRemove.Iconimage_right_Selected = null;
            this.btnRemove.Iconimage_Selected = null;
            this.btnRemove.IconMarginLeft = 0;
            this.btnRemove.IconMarginRight = 0;
            this.btnRemove.IconRightVisible = true;
            this.btnRemove.IconRightZoom = 0D;
            this.btnRemove.IconVisible = true;
            this.btnRemove.IconZoom = 50D;
            this.btnRemove.IsTab = false;
            this.btnRemove.Location = new System.Drawing.Point(605, 153);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRemove.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnRemove.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemove.selected = false;
            this.btnRemove.Size = new System.Drawing.Size(100, 40);
            this.btnRemove.TabIndex = 128;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Textcolor = System.Drawing.Color.White;
            this.btnRemove.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // add_repair_faults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRepairAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.tbxErrorDesc);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.tbxRemark);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.tbxErrorCode);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.groupBox4);
            this.Name = "add_repair_faults";
            this.Size = new System.Drawing.Size(729, 549);
            this.Load += new System.EventHandler(this.new_add_repair_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxVehicleNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker repairDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxErrorCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnRemove;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxRemark;
        private System.Windows.Forms.RichTextBox tbxErrorDesc;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lblErrorCount;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel lblModel;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel lblBrand;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MetroFramework.Controls.MetroComboBox cmbTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Bunifu.Framework.UI.BunifuFlatButton btnRepairAdd;
    }
}
