namespace HastaneOtomasyonu
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelResetBorder = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cboxUType = new System.Windows.Forms.ComboBox();
            this.lblUType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.panelResetBorder);
            this.panelLogin.Controls.Add(this.btnReset);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.tboxPassword);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.tboxUsername);
            this.panelLogin.Controls.Add(this.lblUsername);
            this.panelLogin.Controls.Add(this.cboxUType);
            this.panelLogin.Controls.Add(this.lblUType);
            this.panelLogin.Controls.Add(this.lblTitle);
            this.panelLogin.Controls.Add(this.pboxLogo);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(334, 411);
            this.panelLogin.TabIndex = 0;
            // 
            // panelResetBorder
            // 
            this.panelResetBorder.BackColor = System.Drawing.Color.Gray;
            this.panelResetBorder.Location = new System.Drawing.Point(130, 384);
            this.panelResetBorder.Name = "panelResetBorder";
            this.panelResetBorder.Size = new System.Drawing.Size(75, 1);
            this.panelResetBorder.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(130, 362);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(117, 315);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tboxPassword
            // 
            this.tboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxPassword.Location = new System.Drawing.Point(116, 267);
            this.tboxPassword.MaxLength = 8;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '•';
            this.tboxPassword.Size = new System.Drawing.Size(188, 23);
            this.tboxPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(32, 270);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // tboxUsername
            // 
            this.tboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxUsername.Location = new System.Drawing.Point(116, 238);
            this.tboxUsername.MaxLength = 11;
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(188, 23);
            this.tboxUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.Location = new System.Drawing.Point(32, 241);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // cboxUType
            // 
            this.cboxUType.BackColor = System.Drawing.Color.White;
            this.cboxUType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxUType.FormattingEnabled = true;
            this.cboxUType.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Receptionist"});
            this.cboxUType.Location = new System.Drawing.Point(116, 208);
            this.cboxUType.Name = "cboxUType";
            this.cboxUType.Size = new System.Drawing.Size(188, 24);
            this.cboxUType.TabIndex = 0;
            // 
            // lblUType
            // 
            this.lblUType.AutoSize = true;
            this.lblUType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUType.Location = new System.Drawing.Point(32, 211);
            this.lblUType.Name = "lblUType";
            this.lblUType.Size = new System.Drawing.Size(78, 17);
            this.lblUType.TabIndex = 2;
            this.lblUType.Text = "User Type:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(67, 152);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome to T Hospital";
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::HastaneOtomasyonu.Properties.Resources.icons8_caduceus_100;
            this.pboxLogo.Location = new System.Drawing.Point(117, 30);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(100, 100);
            this.pboxLogo.TabIndex = 0;
            this.pboxLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | T Hospital";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cboxUType;
        private System.Windows.Forms.Label lblUType;
        private System.Windows.Forms.Panel panelResetBorder;
        private System.Windows.Forms.Button btnReset;
    }
}

