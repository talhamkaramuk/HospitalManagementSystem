namespace HastaneOtomasyonu
{
    partial class Prescriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescriptions));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReception = new System.Windows.Forms.Button();
            this.btnLabTests = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.tboxMedicines = new System.Windows.Forms.TextBox();
            this.lblMedicines = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxPatName = new System.Windows.Forms.TextBox();
            this.lblPatName = new System.Windows.Forms.Label();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.rtboxPrescription = new System.Windows.Forms.RichTextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tboxCost = new System.Windows.Forms.TextBox();
            this.tboxTest = new System.Windows.Forms.TextBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.cboxTestID = new System.Windows.Forms.ComboBox();
            this.lblTestID = new System.Windows.Forms.Label();
            this.cboxPatID = new System.Windows.Forms.ComboBox();
            this.lblPatID = new System.Windows.Forms.Label();
            this.cboxDocID = new System.Windows.Forms.ComboBox();
            this.lblDocID = new System.Windows.Forms.Label();
            this.tboxDocName = new System.Windows.Forms.TextBox();
            this.lblDocName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelPrescription = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.panelPrescription.SuspendLayout();
            this.SuspendLayout();
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
            // pboxLogo
            // 
            this.pboxLogo.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_caduceus_100;
            this.pboxLogo.Location = new System.Drawing.Point(52, 12);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(96, 96);
            this.pboxLogo.TabIndex = 0;
            this.pboxLogo.TabStop = false;
            // 
            // tboxMedicines
            // 
            this.tboxMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxMedicines.Location = new System.Drawing.Point(26, 258);
            this.tboxMedicines.Multiline = true;
            this.tboxMedicines.Name = "tboxMedicines";
            this.tboxMedicines.Size = new System.Drawing.Size(180, 64);
            this.tboxMedicines.TabIndex = 6;
            // 
            // lblMedicines
            // 
            this.lblMedicines.AutoSize = true;
            this.lblMedicines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMedicines.Location = new System.Drawing.Point(23, 238);
            this.lblMedicines.Name = "lblMedicines";
            this.lblMedicines.Size = new System.Drawing.Size(75, 17);
            this.lblMedicines.TabIndex = 20;
            this.lblMedicines.Text = "Medicines:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(131, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxPatName
            // 
            this.tboxPatName.Enabled = false;
            this.tboxPatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxPatName.Location = new System.Drawing.Point(126, 150);
            this.tboxPatName.Name = "tboxPatName";
            this.tboxPatName.Size = new System.Drawing.Size(181, 23);
            this.tboxPatName.TabIndex = 3;
            // 
            // lblPatName
            // 
            this.lblPatName.AutoSize = true;
            this.lblPatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatName.Location = new System.Drawing.Point(123, 130);
            this.lblPatName.Name = "lblPatName";
            this.lblPatName.Size = new System.Drawing.Size(97, 17);
            this.lblPatName.TabIndex = 11;
            this.lblPatName.Text = "Patient Name:";
            // 
            // lblPrescription
            // 
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrescription.Location = new System.Drawing.Point(333, 76);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(87, 17);
            this.lblPrescription.TabIndex = 9;
            this.lblPrescription.Text = "Prescription:";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dgvPrescriptions);
            this.panelContent.Controls.Add(this.rtboxPrescription);
            this.panelContent.Controls.Add(this.tboxMedicines);
            this.panelContent.Controls.Add(this.lblCost);
            this.panelContent.Controls.Add(this.lblMedicines);
            this.panelContent.Controls.Add(this.btnPrint);
            this.panelContent.Controls.Add(this.btnAdd);
            this.panelContent.Controls.Add(this.tboxCost);
            this.panelContent.Controls.Add(this.tboxTest);
            this.panelContent.Controls.Add(this.lblTest);
            this.panelContent.Controls.Add(this.tboxPatName);
            this.panelContent.Controls.Add(this.lblPatName);
            this.panelContent.Controls.Add(this.lblPrescription);
            this.panelContent.Controls.Add(this.cboxTestID);
            this.panelContent.Controls.Add(this.lblTestID);
            this.panelContent.Controls.Add(this.cboxPatID);
            this.panelContent.Controls.Add(this.lblPatID);
            this.panelContent.Controls.Add(this.cboxDocID);
            this.panelContent.Controls.Add(this.lblDocID);
            this.panelContent.Controls.Add(this.tboxDocName);
            this.panelContent.Controls.Add(this.lblDocName);
            this.panelContent.Controls.Add(this.lblTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(784, 561);
            this.panelContent.TabIndex = 1;
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.AllowUserToAddRows = false;
            this.dgvPrescriptions.AllowUserToDeleteRows = false;
            this.dgvPrescriptions.AllowUserToResizeColumns = false;
            this.dgvPrescriptions.AllowUserToResizeRows = false;
            this.dgvPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptions.Location = new System.Drawing.Point(26, 386);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.RowHeadersVisible = false;
            this.dgvPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrescriptions.Size = new System.Drawing.Size(737, 163);
            this.dgvPrescriptions.TabIndex = 9;
            this.dgvPrescriptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrescriptions_CellContentClick);
            // 
            // rtboxPrescription
            // 
            this.rtboxPrescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtboxPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtboxPrescription.Location = new System.Drawing.Point(336, 98);
            this.rtboxPrescription.Name = "rtboxPrescription";
            this.rtboxPrescription.ReadOnly = true;
            this.rtboxPrescription.Size = new System.Drawing.Size(427, 224);
            this.rtboxPrescription.TabIndex = 24;
            this.rtboxPrescription.Text = "";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCost.Location = new System.Drawing.Point(213, 238);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 17);
            this.lblCost.TabIndex = 20;
            this.lblCost.Text = "Cost:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Red;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(499, 340);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tboxCost
            // 
            this.tboxCost.Enabled = false;
            this.tboxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxCost.Location = new System.Drawing.Point(216, 258);
            this.tboxCost.Name = "tboxCost";
            this.tboxCost.Size = new System.Drawing.Size(91, 23);
            this.tboxCost.TabIndex = 7;
            // 
            // tboxTest
            // 
            this.tboxTest.Enabled = false;
            this.tboxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxTest.Location = new System.Drawing.Point(126, 205);
            this.tboxTest.Name = "tboxTest";
            this.tboxTest.Size = new System.Drawing.Size(181, 23);
            this.tboxTest.TabIndex = 5;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTest.Location = new System.Drawing.Point(123, 185);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(40, 17);
            this.lblTest.TabIndex = 11;
            this.lblTest.Text = "Test:";
            // 
            // cboxTestID
            // 
            this.cboxTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxTestID.FormattingEnabled = true;
            this.cboxTestID.Location = new System.Drawing.Point(26, 205);
            this.cboxTestID.Name = "cboxTestID";
            this.cboxTestID.Size = new System.Drawing.Size(86, 24);
            this.cboxTestID.TabIndex = 4;
            this.cboxTestID.SelectionChangeCommitted += new System.EventHandler(this.cboxTestID_SelectionChangeCommitted);
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTestID.Location = new System.Drawing.Point(23, 185);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(85, 17);
            this.lblTestID.TabIndex = 5;
            this.lblTestID.Text = "Lab Test ID:";
            // 
            // cboxPatID
            // 
            this.cboxPatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxPatID.FormattingEnabled = true;
            this.cboxPatID.Location = new System.Drawing.Point(26, 150);
            this.cboxPatID.Name = "cboxPatID";
            this.cboxPatID.Size = new System.Drawing.Size(86, 24);
            this.cboxPatID.TabIndex = 2;
            this.cboxPatID.SelectionChangeCommitted += new System.EventHandler(this.cboxPatID_SelectionChangeCommitted);
            // 
            // lblPatID
            // 
            this.lblPatID.AutoSize = true;
            this.lblPatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatID.Location = new System.Drawing.Point(23, 130);
            this.lblPatID.Name = "lblPatID";
            this.lblPatID.Size = new System.Drawing.Size(73, 17);
            this.lblPatID.TabIndex = 5;
            this.lblPatID.Text = "Patient ID:";
            // 
            // cboxDocID
            // 
            this.cboxDocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxDocID.FormattingEnabled = true;
            this.cboxDocID.Location = new System.Drawing.Point(26, 96);
            this.cboxDocID.Name = "cboxDocID";
            this.cboxDocID.Size = new System.Drawing.Size(86, 24);
            this.cboxDocID.TabIndex = 0;
            this.cboxDocID.SelectionChangeCommitted += new System.EventHandler(this.cboxDocID_SelectionChangeCommitted);
            // 
            // lblDocID
            // 
            this.lblDocID.AutoSize = true;
            this.lblDocID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDocID.Location = new System.Drawing.Point(23, 76);
            this.lblDocID.Name = "lblDocID";
            this.lblDocID.Size = new System.Drawing.Size(71, 17);
            this.lblDocID.TabIndex = 5;
            this.lblDocID.Text = "Doctor ID:";
            // 
            // tboxDocName
            // 
            this.tboxDocName.Enabled = false;
            this.tboxDocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxDocName.Location = new System.Drawing.Point(126, 96);
            this.tboxDocName.Name = "tboxDocName";
            this.tboxDocName.Size = new System.Drawing.Size(181, 23);
            this.tboxDocName.TabIndex = 1;
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDocName.Location = new System.Drawing.Point(123, 76);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(95, 17);
            this.lblDocName.TabIndex = 3;
            this.lblDocName.Text = "Doctor Name:";
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
            // panelPrescription
            // 
            this.panelPrescription.BackColor = System.Drawing.Color.White;
            this.panelPrescription.Controls.Add(this.panelContent);
            this.panelPrescription.Controls.Add(this.panelSideMenu);
            this.panelPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrescription.Location = new System.Drawing.Point(0, 0);
            this.panelPrescription.Name = "panelPrescription";
            this.panelPrescription.Size = new System.Drawing.Size(984, 561);
            this.panelPrescription.TabIndex = 3;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // Prescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelPrescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prescriptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescriptions | T Hospital";
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.panelPrescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Button btnLabTests;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.TextBox tboxMedicines;
        private System.Windows.Forms.Label lblMedicines;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxPatName;
        private System.Windows.Forms.Label lblPatName;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ComboBox cboxDocID;
        private System.Windows.Forms.Label lblDocID;
        private System.Windows.Forms.TextBox tboxDocName;
        private System.Windows.Forms.Label lblDocName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelPrescription;
        private System.Windows.Forms.ComboBox cboxPatID;
        private System.Windows.Forms.Label lblPatID;
        private System.Windows.Forms.ComboBox cboxTestID;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.TextBox tboxTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox tboxCost;
        private System.Windows.Forms.RichTextBox rtboxPrescription;
        private System.Windows.Forms.DataGridView dgvPrescriptions;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}