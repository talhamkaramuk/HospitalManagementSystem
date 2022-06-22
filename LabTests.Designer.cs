namespace HastaneOtomasyonu
{
    partial class LabTests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabTests));
            this.panelLabTests = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.panelLabTests.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLabTests
            // 
            this.panelLabTests.BackColor = System.Drawing.Color.White;
            this.panelLabTests.Controls.Add(this.panelContent);
            this.panelLabTests.Controls.Add(this.panelSideMenu);
            this.panelLabTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLabTests.Location = new System.Drawing.Point(0, 0);
            this.panelLabTests.Name = "panelLabTests";
            this.panelLabTests.Size = new System.Drawing.Size(624, 441);
            this.panelLabTests.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.dgvTests);
            this.panelContent.Controls.Add(this.btnDelete);
            this.panelContent.Controls.Add(this.btnEdit);
            this.panelContent.Controls.Add(this.btnAdd);
            this.panelContent.Controls.Add(this.tboxCost);
            this.panelContent.Controls.Add(this.lblCost);
            this.panelContent.Controls.Add(this.tboxName);
            this.panelContent.Controls.Add(this.lblName);
            this.panelContent.Controls.Add(this.lblTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(424, 441);
            this.panelContent.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(275, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 20;
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
            this.btnEdit.Location = new System.Drawing.Point(154, 142);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 19;
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
            this.btnAdd.Location = new System.Drawing.Point(33, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxCost
            // 
            this.tboxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxCost.Location = new System.Drawing.Point(254, 94);
            this.tboxCost.Name = "tboxCost";
            this.tboxCost.Size = new System.Drawing.Size(121, 23);
            this.tboxCost.TabIndex = 14;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCost.Location = new System.Drawing.Point(251, 74);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 17);
            this.lblCost.TabIndex = 13;
            this.lblCost.Text = "Cost:";
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxName.Location = new System.Drawing.Point(33, 94);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(181, 23);
            this.tboxName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(30, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Test Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(171, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "T Hospital";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.pboxLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 441);
            this.panelSideMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_logout_42;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(12, 381);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.btnLogout.Size = new System.Drawing.Size(175, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
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
            // dgvTests
            // 
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.AllowUserToDeleteRows = false;
            this.dgvTests.AllowUserToResizeColumns = false;
            this.dgvTests.AllowUserToResizeRows = false;
            this.dgvTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Location = new System.Drawing.Point(28, 194);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.RowHeadersVisible = false;
            this.dgvTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTests.Size = new System.Drawing.Size(373, 235);
            this.dgvTests.TabIndex = 21;
            this.dgvTests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellContentClick);
            // 
            // LabTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panelLabTests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LabTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Tests | T Hospital";
            this.panelLabTests.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLabTests;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tboxCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTests;
    }
}