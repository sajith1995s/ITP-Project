namespace AutoCareSystem
{
    partial class ReturnItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnItems));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReturnDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_serch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_search = new System.Windows.Forms.PictureBox();
            this.ItemsdataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRemoveReturn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClearReturn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddReturn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Quantitytxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ResonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsdataGrid)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.ReturnDataGrid);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 226);
            this.groupBox3.TabIndex = 165;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Return Item Details";
            // 
            // ReturnDataGrid
            // 
            this.ReturnDataGrid.AllowUserToAddRows = false;
            this.ReturnDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReturnDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ReturnDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ReturnDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReturnDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ReturnDataGrid.ColumnHeadersHeight = 21;
            this.ReturnDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReturnDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ReturnDataGrid.DoubleBuffered = true;
            this.ReturnDataGrid.EnableHeadersVisualStyles = false;
            this.ReturnDataGrid.GridColor = System.Drawing.Color.White;
            this.ReturnDataGrid.HeaderBgColor = System.Drawing.Color.LightSkyBlue;
            this.ReturnDataGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.ReturnDataGrid.Location = new System.Drawing.Point(8, 22);
            this.ReturnDataGrid.MultiSelect = false;
            this.ReturnDataGrid.Name = "ReturnDataGrid";
            this.ReturnDataGrid.ReadOnly = true;
            this.ReturnDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReturnDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReturnDataGrid.Size = new System.Drawing.Size(521, 192);
            this.ReturnDataGrid.TabIndex = 158;
            this.ReturnDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnDataGrid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.txt_serch);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.ItemsdataGrid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 264);
            this.groupBox1.TabIndex = 164;
            this.groupBox1.TabStop = false;
            // 
            // txt_serch
            // 
            this.txt_serch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_serch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_serch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_serch.HintForeColor = System.Drawing.Color.Silver;
            this.txt_serch.HintText = "Search here from ReciptID";
            this.txt_serch.isPassword = false;
            this.txt_serch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txt_serch.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_serch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.txt_serch.LineThickness = 2;
            this.txt_serch.Location = new System.Drawing.Point(323, 21);
            this.txt_serch.Margin = new System.Windows.Forms.Padding(4);
            this.txt_serch.Name = "txt_serch";
            this.txt_serch.Size = new System.Drawing.Size(167, 31);
            this.txt_serch.TabIndex = 154;
            this.txt_serch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_search
            // 
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(497, 15);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(35, 38);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_search.TabIndex = 155;
            this.btn_search.TabStop = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // ItemsdataGrid
            // 
            this.ItemsdataGrid.AllowUserToAddRows = false;
            this.ItemsdataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ItemsdataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ItemsdataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ItemsdataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemsdataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsdataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ItemsdataGrid.ColumnHeadersHeight = 21;
            this.ItemsdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsdataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.ItemsdataGrid.DoubleBuffered = true;
            this.ItemsdataGrid.EnableHeadersVisualStyles = false;
            this.ItemsdataGrid.GridColor = System.Drawing.Color.White;
            this.ItemsdataGrid.HeaderBgColor = System.Drawing.Color.LightSkyBlue;
            this.ItemsdataGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.ItemsdataGrid.Location = new System.Drawing.Point(6, 59);
            this.ItemsdataGrid.MultiSelect = false;
            this.ItemsdataGrid.Name = "ItemsdataGrid";
            this.ItemsdataGrid.ReadOnly = true;
            this.ItemsdataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemsdataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsdataGrid.Size = new System.Drawing.Size(526, 193);
            this.ItemsdataGrid.TabIndex = 156;
            this.ItemsdataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsdataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 157;
            this.label1.Text = "Sales Details";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Controls.Add(this.btnRemoveReturn);
            this.groupBox5.Controls.Add(this.btnClearReturn);
            this.groupBox5.Controls.Add(this.materialLabel1);
            this.groupBox5.Controls.Add(this.btnAddReturn);
            this.groupBox5.Controls.Add(this.Quantitytxt);
            this.groupBox5.Controls.Add(this.ResonRichTextBox);
            this.groupBox5.Controls.Add(this.materialLabel3);
            this.groupBox5.Location = new System.Drawing.Point(552, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(177, 492);
            this.groupBox5.TabIndex = 163;
            this.groupBox5.TabStop = false;
            // 
            // btnRemoveReturn
            // 
            this.btnRemoveReturn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRemoveReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRemoveReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveReturn.BorderRadius = 7;
            this.btnRemoveReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRemoveReturn.ButtonText = "Remove";
            this.btnRemoveReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveReturn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnRemoveReturn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRemoveReturn.Iconimage = global::AutoCareSystem.Properties.Resources.Trash_32px;
            this.btnRemoveReturn.Iconimage_right = null;
            this.btnRemoveReturn.Iconimage_right_Selected = null;
            this.btnRemoveReturn.Iconimage_Selected = null;
            this.btnRemoveReturn.IconMarginLeft = 0;
            this.btnRemoveReturn.IconMarginRight = 0;
            this.btnRemoveReturn.IconRightVisible = true;
            this.btnRemoveReturn.IconRightZoom = 0D;
            this.btnRemoveReturn.IconVisible = true;
            this.btnRemoveReturn.IconZoom = 50D;
            this.btnRemoveReturn.IsTab = false;
            this.btnRemoveReturn.Location = new System.Drawing.Point(23, 361);
            this.btnRemoveReturn.Name = "btnRemoveReturn";
            this.btnRemoveReturn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnRemoveReturn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnRemoveReturn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRemoveReturn.selected = false;
            this.btnRemoveReturn.Size = new System.Drawing.Size(116, 40);
            this.btnRemoveReturn.TabIndex = 161;
            this.btnRemoveReturn.Text = "Remove";
            this.btnRemoveReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveReturn.Textcolor = System.Drawing.Color.White;
            this.btnRemoveReturn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveReturn.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearReturn
            // 
            this.btnClearReturn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnClearReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnClearReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearReturn.BorderRadius = 7;
            this.btnClearReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnClearReturn.ButtonText = " Clear";
            this.btnClearReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearReturn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnClearReturn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClearReturn.Iconimage = global::AutoCareSystem.Properties.Resources.Erase_32px;
            this.btnClearReturn.Iconimage_right = null;
            this.btnClearReturn.Iconimage_right_Selected = null;
            this.btnClearReturn.Iconimage_Selected = null;
            this.btnClearReturn.IconMarginLeft = 0;
            this.btnClearReturn.IconMarginRight = 0;
            this.btnClearReturn.IconRightVisible = true;
            this.btnClearReturn.IconRightZoom = 0D;
            this.btnClearReturn.IconVisible = true;
            this.btnClearReturn.IconZoom = 50D;
            this.btnClearReturn.IsTab = false;
            this.btnClearReturn.Location = new System.Drawing.Point(23, 292);
            this.btnClearReturn.Name = "btnClearReturn";
            this.btnClearReturn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnClearReturn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnClearReturn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClearReturn.selected = false;
            this.btnClearReturn.Size = new System.Drawing.Size(116, 40);
            this.btnClearReturn.TabIndex = 161;
            this.btnClearReturn.Text = " Clear";
            this.btnClearReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearReturn.Textcolor = System.Drawing.Color.White;
            this.btnClearReturn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearReturn.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 154);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 164;
            this.materialLabel1.Text = "Quantity";
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnAddReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnAddReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddReturn.BorderRadius = 7;
            this.btnAddReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAddReturn.ButtonText = "   Add";
            this.btnAddReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReturn.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnAddReturn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddReturn.Iconimage = global::AutoCareSystem.Properties.Resources.Plus_32px;
            this.btnAddReturn.Iconimage_right = null;
            this.btnAddReturn.Iconimage_right_Selected = null;
            this.btnAddReturn.Iconimage_Selected = null;
            this.btnAddReturn.IconMarginLeft = 0;
            this.btnAddReturn.IconMarginRight = 0;
            this.btnAddReturn.IconRightVisible = true;
            this.btnAddReturn.IconRightZoom = 0D;
            this.btnAddReturn.IconVisible = true;
            this.btnAddReturn.IconZoom = 50D;
            this.btnAddReturn.IsTab = false;
            this.btnAddReturn.Location = new System.Drawing.Point(24, 226);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btnAddReturn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btnAddReturn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddReturn.selected = false;
            this.btnAddReturn.Size = new System.Drawing.Size(116, 40);
            this.btnAddReturn.TabIndex = 157;
            this.btnAddReturn.Text = "   Add";
            this.btnAddReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReturn.Textcolor = System.Drawing.Color.White;
            this.btnAddReturn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReturn.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Quantitytxt
            // 
            this.Quantitytxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quantitytxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Quantitytxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Quantitytxt.HintForeColor = System.Drawing.Color.Empty;
            this.Quantitytxt.HintText = "";
            this.Quantitytxt.isPassword = false;
            this.Quantitytxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.Quantitytxt.LineIdleColor = System.Drawing.Color.Gray;
            this.Quantitytxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Quantitytxt.LineThickness = 2;
            this.Quantitytxt.Location = new System.Drawing.Point(12, 177);
            this.Quantitytxt.Margin = new System.Windows.Forms.Padding(4);
            this.Quantitytxt.Name = "Quantitytxt";
            this.Quantitytxt.Size = new System.Drawing.Size(139, 31);
            this.Quantitytxt.TabIndex = 163;
            this.Quantitytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ResonRichTextBox
            // 
            this.ResonRichTextBox.Location = new System.Drawing.Point(8, 45);
            this.ResonRichTextBox.Name = "ResonRichTextBox";
            this.ResonRichTextBox.Size = new System.Drawing.Size(146, 96);
            this.ResonRichTextBox.TabIndex = 162;
            this.ResonRichTextBox.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 21);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 161;
            this.materialLabel3.Text = "Reson";
            // 
            // ReturnItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "ReturnItems";
            this.Size = new System.Drawing.Size(737, 590);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsdataGrid)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ReturnDataGrid;
        public System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_serch;
        private System.Windows.Forms.PictureBox btn_search;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ItemsdataGrid;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox5;
        private Bunifu.Framework.UI.BunifuFlatButton btnRemoveReturn;
        private Bunifu.Framework.UI.BunifuFlatButton btnClearReturn;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddReturn;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Quantitytxt;
        private System.Windows.Forms.RichTextBox ResonRichTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}
