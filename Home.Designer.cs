namespace HastaneOtomasyonu
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelLabTests = new System.Windows.Forms.Panel();
            this.lblLabTestsCount = new System.Windows.Forms.Label();
            this.lblLabTests = new System.Windows.Forms.Label();
            this.panelDoctors = new System.Windows.Forms.Panel();
            this.lblDocCount = new System.Windows.Forms.Label();
            this.lblDoctors = new System.Windows.Forms.Label();
            this.panelPatients = new System.Windows.Forms.Panel();
            this.lblPatCount = new System.Windows.Forms.Label();
            this.lblPatients = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.pboxLabTests = new System.Windows.Forms.PictureBox();
            this.pboxDoctors = new System.Windows.Forms.PictureBox();
            this.pboxPatients = new System.Windows.Forms.PictureBox();
            this.pboxBanner = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReception = new System.Windows.Forms.Button();
            this.btnLabTests = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.panelHome.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelLabTests.SuspendLayout();
            this.panelDoctors.SuspendLayout();
            this.panelPatients.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLabTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.White;
            this.panelHome.Controls.Add(this.panelContent);
            this.panelHome.Controls.Add(this.panelSideMenu);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(984, 561);
            this.panelHome.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelBottom);
            this.panelContent.Controls.Add(this.pboxBanner);
            this.panelContent.Controls.Add(this.lblTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(784, 561);
            this.panelContent.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Gray;
            this.panelBottom.Controls.Add(this.panelLabTests);
            this.panelBottom.Controls.Add(this.panelDoctors);
            this.panelBottom.Controls.Add(this.panelPatients);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 405);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(784, 156);
            this.panelBottom.TabIndex = 2;
            // 
            // panelLabTests
            // 
            this.panelLabTests.BackColor = System.Drawing.Color.White;
            this.panelLabTests.Controls.Add(this.lblLabTestsCount);
            this.panelLabTests.Controls.Add(this.lblLabTests);
            this.panelLabTests.Controls.Add(this.pboxLabTests);
            this.panelLabTests.Location = new System.Drawing.Point(551, 31);
            this.panelLabTests.Name = "panelLabTests";
            this.panelLabTests.Size = new System.Drawing.Size(200, 100);
            this.panelLabTests.TabIndex = 2;
            // 
            // lblLabTestsCount
            // 
            this.lblLabTestsCount.AutoSize = true;
            this.lblLabTestsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLabTestsCount.Location = new System.Drawing.Point(82, 43);
            this.lblLabTestsCount.Name = "lblLabTestsCount";
            this.lblLabTestsCount.Size = new System.Drawing.Size(100, 17);
            this.lblLabTestsCount.TabIndex = 2;
            this.lblLabTestsCount.Text = "lab tests count";
            // 
            // lblLabTests
            // 
            this.lblLabTests.AutoSize = true;
            this.lblLabTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLabTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLabTests.Location = new System.Drawing.Point(91, 11);
            this.lblLabTests.Name = "lblLabTests";
            this.lblLabTests.Size = new System.Drawing.Size(80, 17);
            this.lblLabTests.TabIndex = 1;
            this.lblLabTests.Text = "Lab Tests";
            // 
            // panelDoctors
            // 
            this.panelDoctors.BackColor = System.Drawing.Color.White;
            this.panelDoctors.Controls.Add(this.lblDocCount);
            this.panelDoctors.Controls.Add(this.lblDoctors);
            this.panelDoctors.Controls.Add(this.pboxDoctors);
            this.panelDoctors.Location = new System.Drawing.Point(293, 31);
            this.panelDoctors.Name = "panelDoctors";
            this.panelDoctors.Size = new System.Drawing.Size(200, 100);
            this.panelDoctors.TabIndex = 1;
            // 
            // lblDocCount
            // 
            this.lblDocCount.AutoSize = true;
            this.lblDocCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDocCount.Location = new System.Drawing.Point(87, 43);
            this.lblDocCount.Name = "lblDocCount";
            this.lblDocCount.Size = new System.Drawing.Size(94, 17);
            this.lblDocCount.TabIndex = 2;
            this.lblDocCount.Text = "doctors count";
            // 
            // lblDoctors
            // 
            this.lblDoctors.AutoSize = true;
            this.lblDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoctors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDoctors.Location = new System.Drawing.Point(99, 11);
            this.lblDoctors.Name = "lblDoctors";
            this.lblDoctors.Size = new System.Drawing.Size(64, 17);
            this.lblDoctors.TabIndex = 1;
            this.lblDoctors.Text = "Doctors";
            // 
            // panelPatients
            // 
            this.panelPatients.BackColor = System.Drawing.Color.White;
            this.panelPatients.Controls.Add(this.lblPatCount);
            this.panelPatients.Controls.Add(this.lblPatients);
            this.panelPatients.Controls.Add(this.pboxPatients);
            this.panelPatients.Location = new System.Drawing.Point(35, 31);
            this.panelPatients.Name = "panelPatients";
            this.panelPatients.Size = new System.Drawing.Size(200, 100);
            this.panelPatients.TabIndex = 0;
            // 
            // lblPatCount
            // 
            this.lblPatCount.AutoSize = true;
            this.lblPatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatCount.Location = new System.Drawing.Point(86, 43);
            this.lblPatCount.Name = "lblPatCount";
            this.lblPatCount.Size = new System.Drawing.Size(97, 17);
            this.lblPatCount.TabIndex = 2;
            this.lblPatCount.Text = "patients count";
            // 
            // lblPatients
            // 
            this.lblPatients.AutoSize = true;
            this.lblPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPatients.Location = new System.Drawing.Point(99, 11);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(67, 17);
            this.lblPatients.TabIndex = 1;
            this.lblPatients.Text = "Patients";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(347, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "T Hospital";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnReception);
            this.panelSideMenu.Controls.Add(this.btnLabTests);
            this.panelSideMenu.Controls.Add(this.btnDoctors);
            this.panelSideMenu.Controls.Add(this.btnPatients);
            this.panelSideMenu.Controls.Add(this.pboxLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // pboxLabTests
            // 
            this.pboxLabTests.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_laboratory_50;
            this.pboxLabTests.Location = new System.Drawing.Point(13, 25);
            this.pboxLabTests.Name = "pboxLabTests";
            this.pboxLabTests.Size = new System.Drawing.Size(50, 50);
            this.pboxLabTests.TabIndex = 0;
            this.pboxLabTests.TabStop = false;
            // 
            // pboxDoctors
            // 
            this.pboxDoctors.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_doctor_female_skin_type_1_50;
            this.pboxDoctors.Location = new System.Drawing.Point(15, 25);
            this.pboxDoctors.Name = "pboxDoctors";
            this.pboxDoctors.Size = new System.Drawing.Size(50, 50);
            this.pboxDoctors.TabIndex = 0;
            this.pboxDoctors.TabStop = false;
            // 
            // pboxPatients
            // 
            this.pboxPatients.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_nurse_call_50;
            this.pboxPatients.Location = new System.Drawing.Point(16, 25);
            this.pboxPatients.Name = "pboxPatients";
            this.pboxPatients.Size = new System.Drawing.Size(50, 50);
            this.pboxPatients.TabIndex = 0;
            this.pboxPatients.TabStop = false;
            // 
            // pboxBanner
            // 
            this.pboxBanner.Image = global::HastaneOtomasyonu.Properties.Resources.online_marketing_hIgeoQjS_iE_unsplash__1_;
            this.pboxBanner.Location = new System.Drawing.Point(114, 52);
            this.pboxBanner.Name = "pboxBanner";
            this.pboxBanner.Size = new System.Drawing.Size(572, 327);
            this.pboxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBanner.TabIndex = 1;
            this.pboxBanner.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_logout_42;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(12, 386);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.btnLogout.Size = new System.Drawing.Size(175, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReception
            // 
            this.btnReception.FlatAppearance.BorderSize = 0;
            this.btnReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReception.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_front_desk_42;
            this.btnReception.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReception.Location = new System.Drawing.Point(12, 329);
            this.btnReception.Name = "btnReception";
            this.btnReception.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReception.Size = new System.Drawing.Size(175, 50);
            this.btnReception.TabIndex = 4;
            this.btnReception.Text = "Reception";
            this.btnReception.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReception.UseVisualStyleBackColor = true;
            this.btnReception.Click += new System.EventHandler(this.btnReception_Click);
            // 
            // btnLabTests
            // 
            this.btnLabTests.FlatAppearance.BorderSize = 0;
            this.btnLabTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLabTests.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_laboratory_42;
            this.btnLabTests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLabTests.Location = new System.Drawing.Point(12, 272);
            this.btnLabTests.Name = "btnLabTests";
            this.btnLabTests.Padding = new System.Windows.Forms.Padding(10, 0, 24, 0);
            this.btnLabTests.Size = new System.Drawing.Size(175, 50);
            this.btnLabTests.TabIndex = 3;
            this.btnLabTests.Text = "Lab Tests";
            this.btnLabTests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLabTests.UseVisualStyleBackColor = true;
            this.btnLabTests.Click += new System.EventHandler(this.btnLabTests_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.FlatAppearance.BorderSize = 0;
            this.btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoctors.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_doctor_female_skin_type_1_42;
            this.btnDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctors.Location = new System.Drawing.Point(12, 215);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Padding = new System.Windows.Forms.Padding(10, 0, 40, 0);
            this.btnDoctors.Size = new System.Drawing.Size(175, 50);
            this.btnDoctors.TabIndex = 2;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoctors.UseVisualStyleBackColor = true;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.FlatAppearance.BorderSize = 0;
            this.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatients.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_nurse_call_42;
            this.btnPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatients.Location = new System.Drawing.Point(12, 158);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Padding = new System.Windows.Forms.Padding(10, 0, 40, 0);
            this.btnPatients.Size = new System.Drawing.Size(175, 50);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Patients";
            this.btnPatients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_caduceus_100;
            this.pboxLogo.Location = new System.Drawing.Point(52, 12);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(96, 96);
            this.pboxLogo.TabIndex = 0;
            this.pboxLogo.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home | T Hospital";
            this.panelHome.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelLabTests.ResumeLayout(false);
            this.panelLabTests.PerformLayout();
            this.panelDoctors.ResumeLayout(false);
            this.panelDoctors.PerformLayout();
            this.panelPatients.ResumeLayout(false);
            this.panelPatients.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLabTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pboxBanner;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelLabTests;
        private System.Windows.Forms.Panel panelDoctors;
        private System.Windows.Forms.Panel panelPatients;
        private System.Windows.Forms.PictureBox pboxLabTests;
        private System.Windows.Forms.PictureBox pboxDoctors;
        private System.Windows.Forms.PictureBox pboxPatients;
        private System.Windows.Forms.Label lblDoctors;
        private System.Windows.Forms.Label lblPatCount;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.Label lblLabTestsCount;
        private System.Windows.Forms.Label lblLabTests;
        private System.Windows.Forms.Label lblDocCount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Button btnLabTests;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnPatients;
    }
}