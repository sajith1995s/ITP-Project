namespace AutoCareSystem
{
    partial class MyPrompt
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnRemindLater = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIgnore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(40, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(122, 19);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Out Of Stock";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 21;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(6, 11);
            this.bunifuCustomDataGrid1.MultiSelect = false;
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(462, 178);
            this.bunifuCustomDataGrid1.TabIndex = 64;
            // 
            // btnRemindLater
            // 
            this.btnRemindLater.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemindLater.BackColor = System.Drawing.Color.White;
            this.btnRemindLater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemindLater.BorderRadius = 5;
            this.btnRemindLater.ButtonText = "REMIND ME LATER";
            this.btnRemindLater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemindLater.DisabledColor = System.Drawing.Color.Gray;
            this.btnRemindLater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemindLater.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRemindLater.Iconimage = null;
            this.btnRemindLater.Iconimage_right = null;
            this.btnRemindLater.Iconimage_right_Selected = null;
            this.btnRemindLater.Iconimage_Selected = null;
            this.btnRemindLater.IconMarginLeft = 0;
            this.btnRemindLater.IconMarginRight = 0;
            this.btnRemindLater.IconRightVisible = true;
            this.btnRemindLater.IconRightZoom = 0D;
            this.btnRemindLater.IconVisible = true;
            this.btnRemindLater.IconZoom = 90D;
            this.btnRemindLater.IsTab = false;
            this.btnRemindLater.Location = new System.Drawing.Point(254, 251);
            this.btnRemindLater.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemindLater.Name = "btnRemindLater";
            this.btnRemindLater.Normalcolor = System.Drawing.Color.White;
            this.btnRemindLater.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemindLater.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnRemindLater.selected = false;
            this.btnRemindLater.Size = new System.Drawing.Size(140, 50);
            this.btnRemindLater.TabIndex = 5;
            this.btnRemindLater.Text = "REMIND ME LATER";
            this.btnRemindLater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemindLater.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemindLater.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemindLater.Click += new System.EventHandler(this.btnRemindLater_Click);
            // 
            // btnIgnore
            // 
            this.btnIgnore.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIgnore.BackColor = System.Drawing.Color.White;
            this.btnIgnore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIgnore.BorderRadius = 5;
            this.btnIgnore.ButtonText = "IGNORE";
            this.btnIgnore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIgnore.DisabledColor = System.Drawing.Color.Gray;
            this.btnIgnore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgnore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIgnore.Iconimage = null;
            this.btnIgnore.Iconimage_right = null;
            this.btnIgnore.Iconimage_right_Selected = null;
            this.btnIgnore.Iconimage_Selected = null;
            this.btnIgnore.IconMarginLeft = 0;
            this.btnIgnore.IconMarginRight = 0;
            this.btnIgnore.IconRightVisible = true;
            this.btnIgnore.IconRightZoom = 0D;
            this.btnIgnore.IconVisible = true;
            this.btnIgnore.IconZoom = 90D;
            this.btnIgnore.IsTab = false;
            this.btnIgnore.Location = new System.Drawing.Point(402, 251);
            this.btnIgnore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Normalcolor = System.Drawing.Color.White;
            this.btnIgnore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIgnore.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.btnIgnore.selected = false;
            this.btnIgnore.Size = new System.Drawing.Size(84, 50);
            this.btnIgnore.TabIndex = 6;
            this.btnIgnore.Text = "IGNORE";
            this.btnIgnore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIgnore.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIgnore.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click_1);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(15, 268);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(162, 15);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "More - Inventory -> Notification";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoCareSystem.Properties.Resources.black_blue_warning_1_hi;
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MyPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(499, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btnIgnore);
            this.Controls.Add(this.btnRemindLater);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyPrompt";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Dialog";
            this.Load += new System.EventHandler(this.MyPrompt_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnRemindLater;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuFlatButton btnIgnore;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}