namespace HastaneOtomasyonu
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxAllergies = new System.Windows.Forms.TextBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.tboxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dtpDOF = new System.Windows.Forms.DateTimePicker();
            this.lblDOF = new System.Windows.Forms.Label();
            this.cboxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReception = new System.Windows.Forms.Button();
            this.btnLabTests = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.panelPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSideMenu.Controls.Add(this.btnLogOut);
            this.panelSideMenu.Controls.Add(this.btnReception);
            this.panelSideMenu.Controls.Add(this.btnLabTests);
            this.panelSideMenu.Controls.Add(this.btnDoctors);
            this.panelSideMenu.Controls.Add(this.btnHome);
            this.panelSideMenu.Controls.Add(this.pboxLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dgvPatients);
            this.panelContent.Controls.Add(this.btnDelete);
            this.panelContent.Controls.Add(this.btnEdit);
            this.panelContent.Controls.Add(this.btnAdd);
            this.panelContent.Controls.Add(this.tboxAllergies);
            this.panelContent.Controls.Add(this.lblAllergies);
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
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AllowUserToResizeColumns = false;
            this.dgvPatients.AllowUserToResizeRows = false;
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(26, 260);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersVisible = false;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(733, 289);
            this.dgvPatients.TabIndex = 18;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(474, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(351, 201);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(230, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxAllergies
            // 
            this.tboxAllergies.Location = new System.Drawing.Point(547, 96);
            this.tboxAllergies.Multiline = true;
            this.tboxAllergies.Name = "tboxAllergies";
            this.tboxAllergies.Size = new System.Drawing.Size(192, 77);
            this.tboxAllergies.TabIndex = 14;
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAllergies.Location = new System.Drawing.Point(544, 76);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(66, 17);
            this.lblAllergies.TabIndex = 13;
            this.lblAllergies.Text = "Allergies:";
            // 
            // tboxPhone
            // 
            this.tboxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxPhone.Location = new System.Drawing.Point(186, 150);
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(121, 23);
            this.tboxPhone.TabIndex = 12;
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
            // tboxAddress
            // 
            this.tboxAddress.Location = new System.Drawing.Point(333, 96);
            this.tboxAddress.Multiline = true;
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(192, 77);
            this.tboxAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Location = new System.Drawing.Point(330, 76);
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
            this.dtpDOF.TabIndex = 8;
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
            this.cboxGender.TabIndex = 6;
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
            this.tboxName.TabIndex = 4;
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
            // panelPatient
            // 
            this.panelPatient.BackColor = System.Drawing.Color.White;
            this.panelPatient.Controls.Add(this.panelContent);
            this.panelPatient.Controls.Add(this.panelSideMenu);
            this.panelPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPatient.Location = new System.Drawing.Point(0, 0);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(984, 561);
            this.panelPatient.TabIndex = 1;
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
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_hospital_3_42;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 158);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 40, 0);
            this.btnHome.Size = new System.Drawing.Size(175, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient | T Hospital";
            this.panelSideMenu.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.panelPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Button btnLabTests;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.DateTimePicker dtpDOF;
        private System.Windows.Forms.Label lblDOF;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tboxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tboxAllergies;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPatients;
    }
}