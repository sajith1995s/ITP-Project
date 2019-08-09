namespace AutoCareSystem
{
    partial class Appointmet_sub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointmet_sub));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRemove = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.chkRepair = new MaterialSkin.Controls.MaterialCheckBox();
            this.labelService = new MaterialSkin.Controls.MaterialLabel();
            this.chkService = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtMobl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMobile = new MaterialSkin.Controls.MaterialLabel();
            this.txtNIC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_search = new System.Windows.Forms.PictureBox();
            this.txt_search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.chkRepair);
            this.groupBox1.Controls.Add(this.labelService);
            this.groupBox1.Controls.Add(this.chkService);
            this.groupBox1.Controls.Add(this.txtMobl);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.txtNIC);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(710, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new appointment";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(324, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 26);
            this.comboBox1.TabIndex = 136;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.BorderRadius = 7;
            this.btnRemove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRemove.ButtonText = "  Delete";
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
            this.btnRemove.Location = new System.Drawing.Point(560, 160);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(14, 11, 14, 11);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRemove.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnRemove.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemove.selected = false;
            this.btnRemove.Size = new System.Drawing.Size(132, 45);
            this.btnRemove.TabIndex = 135;
            this.btnRemove.Text = "  Delete";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Textcolor = System.Drawing.Color.White;
            this.btnRemove.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 7;
            this.btnClear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClear.ButtonText = "  Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = global::AutoCareSystem.Properties.Resources.Erase_32px;
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 50D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(560, 112);
            this.btnClear.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(132, 45);
            this.btnClear.TabIndex = 134;
            this.btnClear.Text = "  Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Textcolor = System.Drawing.Color.White;
            this.btnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 7;
            this.btnUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnUpdate.ButtonText = "  Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = global::AutoCareSystem.Properties.Resources.Available_Updates_32px;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 50D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(560, 63);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(132, 45);
            this.btnUpdate.TabIndex = 133;
            this.btnUpdate.Text = "  Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(560, 14);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(132, 45);
            this.btnAdd.TabIndex = 132;
            this.btnAdd.Text = "   Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(324, 71);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 24);
            this.dateTimePicker2.TabIndex = 125;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 124;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(379, 126);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(51, 19);
            this.materialLabel4.TabIndex = 123;
            this.materialLabel4.Text = "Repair";
            // 
            // chkRepair
            // 
            this.chkRepair.AutoSize = true;
            this.chkRepair.Depth = 0;
            this.chkRepair.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkRepair.Location = new System.Drawing.Point(324, 121);
            this.chkRepair.Margin = new System.Windows.Forms.Padding(0);
            this.chkRepair.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkRepair.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkRepair.Name = "chkRepair";
            this.chkRepair.Ripple = true;
            this.chkRepair.Size = new System.Drawing.Size(26, 30);
            this.chkRepair.TabIndex = 122;
            this.chkRepair.UseVisualStyleBackColor = true;
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Depth = 0;
            this.labelService.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelService.Location = new System.Drawing.Point(379, 172);
            this.labelService.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(58, 19);
            this.labelService.TabIndex = 121;
            this.labelService.Text = "Service";
            // 
            // chkService
            // 
            this.chkService.AutoSize = true;
            this.chkService.Depth = 0;
            this.chkService.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkService.Location = new System.Drawing.Point(324, 167);
            this.chkService.Margin = new System.Windows.Forms.Padding(0);
            this.chkService.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkService.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkService.Name = "chkService";
            this.chkService.Ripple = true;
            this.chkService.Size = new System.Drawing.Size(26, 30);
            this.chkService.TabIndex = 120;
            this.chkService.UseVisualStyleBackColor = true;
            // 
            // txtMobl
            // 
            this.txtMobl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMobl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMobl.HintForeColor = System.Drawing.Color.Empty;
            this.txtMobl.HintText = "";
            this.txtMobl.isPassword = false;
            this.txtMobl.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtMobl.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMobl.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtMobl.LineThickness = 2;
            this.txtMobl.Location = new System.Drawing.Point(132, 160);
            this.txtMobl.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobl.Name = "txtMobl";
            this.txtMobl.Size = new System.Drawing.Size(144, 31);
            this.txtMobl.TabIndex = 119;
            this.txtMobl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMobl.OnValueChanged += new System.EventHandler(this.txtMobl_OnValueChanged);
            // 
            // txtMobile
            // 
            this.txtMobile.AutoSize = true;
            this.txtMobile.Depth = 0;
            this.txtMobile.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMobile.Location = new System.Drawing.Point(14, 171);
            this.txtMobile.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(55, 19);
            this.txtMobile.TabIndex = 118;
            this.txtMobile.Text = "Mobile";
            // 
            // txtNIC
            // 
            this.txtNIC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNIC.HintForeColor = System.Drawing.Color.Empty;
            this.txtNIC.HintText = "";
            this.txtNIC.isPassword = false;
            this.txtNIC.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtNIC.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNIC.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtNIC.LineThickness = 2;
            this.txtNIC.Location = new System.Drawing.Point(132, 114);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(144, 31);
            this.txtNIC.TabIndex = 117;
            this.txtNIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(34, 19);
            this.materialLabel2.TabIndex = 116;
            this.materialLabel2.Text = "NIC";
            // 
            // txtLname
            // 
            this.txtLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLname.HintForeColor = System.Drawing.Color.Empty;
            this.txtLname.HintText = "";
            this.txtLname.isPassword = false;
            this.txtLname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtLname.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtLname.LineThickness = 2;
            this.txtLname.Location = new System.Drawing.Point(132, 64);
            this.txtLname.Margin = new System.Windows.Forms.Padding(4);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(144, 31);
            this.txtLname.TabIndex = 115;
            this.txtLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 114;
            this.materialLabel1.Text = "Last Name";
            // 
            // txtFname
            // 
            this.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFname.HintForeColor = System.Drawing.Color.Empty;
            this.txtFname.HintText = "";
            this.txtFname.isPassword = false;
            this.txtFname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtFname.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txtFname.LineThickness = 2;
            this.txtFname.Location = new System.Drawing.Point(132, 21);
            this.txtFname.Margin = new System.Windows.Forms.Padding(4);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(144, 31);
            this.txtFname.TabIndex = 113;
            this.txtFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(14, 32);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(83, 19);
            this.materialLabel5.TabIndex = 112;
            this.materialLabel5.Text = "First Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 261);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(710, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointments";
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 21;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(3, 65);
            this.bunifuCustomDataGrid1.MultiSelect = false;
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(707, 210);
            this.bunifuCustomDataGrid1.TabIndex = 144;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(643, 21);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(35, 38);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_search.TabIndex = 143;
            this.btn_search.TabStop = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_search.HintForeColor = System.Drawing.Color.Silver;
            this.txt_search.HintText = "First Name";
            this.txt_search.isPassword = false;
            this.txt_search.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txt_search.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_search.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txt_search.LineThickness = 2;
            this.txt_search.Location = new System.Drawing.Point(498, 26);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(149, 31);
            this.txt_search.TabIndex = 142;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(205, 215);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 137;
            this.materialLabel3.Text = "Technician";
            // 
            // Appointmet_sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Appointmet_sub";
            this.Size = new System.Drawing.Size(741, 550);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFname;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNIC;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLname;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckBox chkRepair;
        private MaterialSkin.Controls.MaterialLabel labelService;
        private MaterialSkin.Controls.MaterialCheckBox chkService;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMobl;
        private MaterialSkin.Controls.MaterialLabel txtMobile;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private Bunifu.Framework.UI.BunifuFlatButton btnRemove;
        private System.Windows.Forms.PictureBox btn_search;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_search;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}
