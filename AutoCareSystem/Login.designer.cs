namespace AutoCareSystem
{
    partial class Login
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
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_name = new System.Windows.Forms.PictureBox();
            this.btn_add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_clear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbxUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(162, 205);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 19);
            this.materialLabel5.TabIndex = 211;
            this.materialLabel5.Text = "User Name  :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(167, 269);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(91, 19);
            this.materialLabel1.TabIndex = 212;
            this.materialLabel1.Text = "Password   :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoCareSystem.Properties.Resources.Password_32px;
            this.pictureBox1.Location = new System.Drawing.Point(121, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 216;
            this.pictureBox1.TabStop = false;
            // 
            // user_name
            // 
            this.user_name.Image = global::AutoCareSystem.Properties.Resources.Name_32px;
            this.user_name.Location = new System.Drawing.Point(121, 196);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(35, 38);
            this.user_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.user_name.TabIndex = 215;
            this.user_name.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.BorderRadius = 7;
            this.btn_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_add.ButtonText = "   Login";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btn_add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_add.Iconimage = global::AutoCareSystem.Properties.Resources.Under_Computer_32px_1;
            this.btn_add.Iconimage_right = null;
            this.btn_add.Iconimage_right_Selected = null;
            this.btn_add.Iconimage_Selected = null;
            this.btn_add.IconMarginLeft = 0;
            this.btn_add.IconMarginRight = 0;
            this.btn_add.IconRightVisible = true;
            this.btn_add.IconRightZoom = 0D;
            this.btn_add.IconVisible = true;
            this.btn_add.IconZoom = 50D;
            this.btn_add.IsTab = false;
            this.btn_add.Location = new System.Drawing.Point(143, 333);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btn_add.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btn_add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add.selected = false;
            this.btn_add.Size = new System.Drawing.Size(110, 40);
            this.btn_add.TabIndex = 213;
            this.btn_add.Text = "   Login";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Textcolor = System.Drawing.Color.White;
            this.btn_add.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.BorderRadius = 7;
            this.btn_clear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_clear.ButtonText = " Cancel";
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btn_clear.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_clear.Iconimage = global::AutoCareSystem.Properties.Resources.Logout_Rounded_Left_32px;
            this.btn_clear.Iconimage_right = null;
            this.btn_clear.Iconimage_right_Selected = null;
            this.btn_clear.Iconimage_Selected = null;
            this.btn_clear.IconMarginLeft = 0;
            this.btn_clear.IconMarginRight = 0;
            this.btn_clear.IconRightVisible = true;
            this.btn_clear.IconRightZoom = 0D;
            this.btn_clear.IconVisible = true;
            this.btn_clear.IconZoom = 50D;
            this.btn_clear.IsTab = false;
            this.btn_clear.Location = new System.Drawing.Point(265, 333);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(204)))));
            this.btn_clear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(111)))), ((int)(((byte)(194)))));
            this.btn_clear.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_clear.selected = false;
            this.btn_clear.Size = new System.Drawing.Size(111, 40);
            this.btn_clear.TabIndex = 214;
            this.btn_clear.Text = " Cancel";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Textcolor = System.Drawing.Color.White;
            this.btn_clear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::AutoCareSystem.Properties.Resources.Unt5;
            this.pictureBox2.Location = new System.Drawing.Point(0, 60);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(531, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Depth = 0;
            this.tbxPassword.Hint = "";
            this.tbxPassword.Location = new System.Drawing.Point(264, 265);
            this.tbxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.SelectedText = "";
            this.tbxPassword.SelectionLength = 0;
            this.tbxPassword.SelectionStart = 0;
            this.tbxPassword.Size = new System.Drawing.Size(135, 23);
            this.tbxPassword.TabIndex = 219;
            this.tbxPassword.Text = "admin";
            this.tbxPassword.UseSystemPasswordChar = false;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Depth = 0;
            this.tbxUsername.Hint = "";
            this.tbxUsername.Location = new System.Drawing.Point(264, 205);
            this.tbxUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.PasswordChar = '\0';
            this.tbxUsername.SelectedText = "";
            this.tbxUsername.SelectionLength = 0;
            this.tbxUsername.SelectionStart = 0;
            this.tbxUsername.Size = new System.Drawing.Size(135, 23);
            this.tbxUsername.TabIndex = 220;
            this.tbxUsername.Text = "admin";
            this.tbxUsername.UseSystemPasswordChar = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 411);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_add;
        private Bunifu.Framework.UI.BunifuFlatButton btn_clear;
        private System.Windows.Forms.PictureBox user_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbxPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbxUsername;
    }
}