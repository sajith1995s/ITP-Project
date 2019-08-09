namespace AutoCareSystem
{
    partial class rs_Rental_Vehicle
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
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.rs_Rental_Vehicle_sub_manageVehicle1 = new AutoCareSystem.rs_Rental_Vehicle_sub_manageVehicle();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.rs_Rental_Vehicle_sub_viewVEhicles1 = new AutoCareSystem.rs_Rental_Vehicle_sub_viewVEhicles();
            this.Tab_Manage_Vehicles = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.Tab_Manage_Vehicles.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.rs_Rental_Vehicle_sub_manageVehicle1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(809, 546);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Manage Rental Vehicles";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // rs_Rental_Vehicle_sub_manageVehicle1
            // 
            this.rs_Rental_Vehicle_sub_manageVehicle1.BackColor = System.Drawing.Color.White;
            this.rs_Rental_Vehicle_sub_manageVehicle1.Location = new System.Drawing.Point(-4, -3);
            this.rs_Rental_Vehicle_sub_manageVehicle1.Name = "rs_Rental_Vehicle_sub_manageVehicle1";
            this.rs_Rental_Vehicle_sub_manageVehicle1.Size = new System.Drawing.Size(809, 546);
            this.rs_Rental_Vehicle_sub_manageVehicle1.TabIndex = 2;
            this.rs_Rental_Vehicle_sub_manageVehicle1.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.rs_Rental_Vehicle_sub_viewVEhicles1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(809, 546);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "View Rental Vehicles";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // rs_Rental_Vehicle_sub_viewVEhicles1
            // 
            this.rs_Rental_Vehicle_sub_viewVEhicles1.BackColor = System.Drawing.Color.White;
            this.rs_Rental_Vehicle_sub_viewVEhicles1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rs_Rental_Vehicle_sub_viewVEhicles1.Location = new System.Drawing.Point(-4, -3);
            this.rs_Rental_Vehicle_sub_viewVEhicles1.Name = "rs_Rental_Vehicle_sub_viewVEhicles1";
            this.rs_Rental_Vehicle_sub_viewVEhicles1.Size = new System.Drawing.Size(809, 546);
            this.rs_Rental_Vehicle_sub_viewVEhicles1.TabIndex = 1;
            // 
            // Tab_Manage_Vehicles
            // 
            this.Tab_Manage_Vehicles.Controls.Add(this.metroTabPage1);
            this.Tab_Manage_Vehicles.Controls.Add(this.metroTabPage2);
            this.Tab_Manage_Vehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Manage_Vehicles.Location = new System.Drawing.Point(0, 0);
            this.Tab_Manage_Vehicles.Name = "Tab_Manage_Vehicles";
            this.Tab_Manage_Vehicles.SelectedIndex = 1;
            this.Tab_Manage_Vehicles.Size = new System.Drawing.Size(817, 588);
            this.Tab_Manage_Vehicles.TabIndex = 1;
            this.Tab_Manage_Vehicles.UseSelectable = true;
            // 
            // rs_Rental_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tab_Manage_Vehicles);
            this.Name = "rs_Rental_Vehicle";
            this.Size = new System.Drawing.Size(817, 588);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.Tab_Manage_Vehicles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabControl Tab_Manage_Vehicles;
        private rs_Rental_Vehicle_sub_manageVehicle rs_Rental_Vehicle_sub_manageVehicle1;
        private rs_Rental_Vehicle_sub_viewVEhicles rs_Rental_Vehicle_sub_viewVEhicles1;
    }
}
