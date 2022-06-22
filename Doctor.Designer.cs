namespace HastaneOtomasyonu
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReception = new System.Windows.Forms.Button();
            this.btnLabTests = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxPhone = new System.Windows.Forms.TextBox();
            this.btnPatients = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dtpDOF = new System.Windows.Forms.DateTimePicker();
            this.lblDOF = new System.Windows.Forms.Label();
            this.cboxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelDoctor = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cboxProfession = new System.Windows.Forms.ComboBox();
            this.lblProfession = new System.Windows.Forms.Label();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.panelDoctor.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_logout_42;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(12, 386);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.btnLogOut.Size = new System.Drawing.Size(175, 50);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(474, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(351, 201);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(230, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxPhone
            // 
            this.tboxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxPhone.Location = new System.Drawing.Point(186, 150);
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(121, 23);
            this.tboxPhone.TabIndex = 4;
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
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Location = new System.Drawing.Point(183, 130);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 17);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(507, 76);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address:";
            // 
            // dtpDOF
            // 
            this.dtpDOF.CustomFormat = "yyyy-MM-dd";
            this.dtpDOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDOF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOF.Location = new System.Drawing.Point(26, 150);
            this.dtpDOF.Name = "dtpDOF";
            this.dtpDOF.Size = new System.Drawing.Size(140, 23);
            this.dtpDOF.TabIndex = 3;
            // 
            // lblDOF
            // 
            this.lblDOF.AutoSize = true;
            this.lblDOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDOF.Location = new System.Drawing.Point(23, 130);
            this.lblDOF.Name = "lblDOF";
            this.lblDOF.Size = new System.Drawing.Size(91, 17);
            this.lblDOF.TabIndex = 7;
            this.lblDOF.Text = "Date of Birth:";
            // 
            // cboxGender
            // 
            this.cboxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxGender.FormattingEnabled = true;
            this.cboxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cboxGender.Location = new System.Drawing.Point(221, 96);
            this.cboxGender.Name = "cboxGender";
            this.cboxGender.Size = new System.Drawing.Size(86, 24);
            this.cboxGender.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.Location = new System.Drawing.Point(218, 76);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxName.Location = new System.Drawing.Point(26, 96);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(181, 23);
            this.tboxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(23, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // panelDoctor
            // 
            this.panelDoctor.BackColor = System.Drawing.Color.White;
            this.panelDoctor.Controls.Add(this.panelContent);
            this.panelDoctor.Controls.Add(this.panelSideMenu);
            this.panelDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDoctor.Location = new System.Drawing.Point(0, 0);
            this.panelDoctor.Name = "panelDoctor";
            this.panelDoctor.Size = new System.Drawing.Size(984, 561);
            this.panelDoctor.TabIndex = 2;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dgvDoctors);
            this.panelContent.Controls.Add(this.tboxPassword);
            this.panelContent.Controls.Add(this.lblPassword);
            this.panelContent.Controls.Add(this.cboxProfession);
            this.panelContent.Controls.Add(this.lblProfession);
            this.panelContent.Controls.Add(this.btnDelete);
            this.panelContent.Controls.Add(this.btnEdit);
            this.panelContent.Controls.Add(this.btnAdd);
            this.panelContent.Controls.Add(this.tboxPhone);
            this.panelContent.Controls.Add(this.lblPhone);
            this.panelContent.Controls.Add(this.tboxAddress);
            this.panelContent.Controls.Add(this.lblAddress);
            this.panelContent.Controls.Add(this.dtpDOF);
            this.panelContent.Controls.Add(this.lblDOF);
            this.panelContent.Controls.Add(this.cboxGender);
            this.panelContent.Controls.Add(this.lblGender);
            this.panelContent.Controls.Add(this.tboxName);
            this.panelContent.Controls.Add(this.lblName);
            this.panelContent.Controls.Add(this.lblTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(784, 561);
            this.panelContent.TabIndex = 1;
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.AllowUserToResizeColumns = false;
            this.dgvDoctors.AllowUserToResizeRows = false;
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Location = new System.Drawing.Point(26, 260);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.RowHeadersVisible = false;
            this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.Size = new System.Drawing.Size(733, 289);
            this.dgvDoctors.TabIndex = 10;
            this.dgvDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellContentClick);
            // 
            // tboxPassword
            // 
            this.tboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxPassword.Location = new System.Drawing.Point(325, 150);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(163, 23);
            this.tboxPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(322, 130);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Password:";
            // 
            // cboxProfession
            // 
            this.cboxProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxProfession.FormattingEnabled = true;
            this.cboxProfession.Items.AddRange(new object[] {
            "Allergists/Immunologists",
            "Anesthesiologists",
            "Cardiologists",
            "Colon and Rectal Surgeons",
            "Dermatologist",
            "Endocrinologist",
            "Emergency Medicine Specialist",
            "Family Physician",
            "Gastroenterologist",
            "General Surgeon",
            "Hematologist",
            "Infectious Disease Specialist",
            "Medical Geneticist",
            "Neurologist",
            "Oncologist",
            "Pathologist",
            "Pediatrician",
            "Physiatrist",
            "Plastic Surgeon",
            "Psychiatrist",
            "Radiologist",
            "Sports Medicine Specialist"});
            this.cboxProfession.Location = new System.Drawing.Point(325, 96);
            this.cboxProfession.Name = "cboxProfession";
            this.cboxProfession.Size = new System.Drawing.Size(163, 24);
            this.cboxProfession.TabIndex = 2;
            // 
            // lblProfession
            // 
            this.lblProfession.AutoSize = true;
            this.lblProfession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProfession.Location = new System.Drawing.Point(322, 76);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(79, 17);
            this.lblProfession.TabIndex = 18;
            this.lblProfession.Text = "Profession:";
            // 
            // tboxAddress
            // 
            this.tboxAddress.Location = new System.Drawing.Point(510, 96);
            this.tboxAddress.Multiline = true;
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(192, 77);
            this.tboxAddress.TabIndex = 6;
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
            this.panelSideMenu.Controls.Add(this.btnLogOut);
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
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelDoctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor | T Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.panelDoctor.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Button btnLabTests;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxPhone;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DateTimePicker dtpDOF;
        private System.Windows.Forms.Label lblDOF;
        private System.Windows.Forms.ComboBox cboxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelDoctor;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.ComboBox cboxProfession;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.DataGridView dgvDoctors;
    }
}