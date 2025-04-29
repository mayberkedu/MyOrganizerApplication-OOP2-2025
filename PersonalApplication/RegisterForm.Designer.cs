namespace MyOrganizerApplication
{
    partial class RegisterForm
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.MTxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.BtnImagePath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LblPath = new System.Windows.Forms.Label();
            this.PicPhoto = new System.Windows.Forms.PictureBox();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LnlName = new System.Windows.Forms.Label();
            this.lblnewPassword = new System.Windows.Forms.Label();
            this.lblNewKayıt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.Location = new System.Drawing.Point(175, 584);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(217, 42);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewName.Location = new System.Drawing.Point(175, 179);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(217, 36);
            this.txtNewName.TabIndex = 1;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPass.Location = new System.Drawing.Point(175, 225);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(217, 36);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(392, 628);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 29);
            this.lblState.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::OOP2_2_PreLab.Properties.Resources.ProfileLogo;
            this.pictureBox3.Location = new System.Drawing.Point(205, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSurname.Location = new System.Drawing.Point(175, 316);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(217, 36);
            this.TxtSurname.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtName.Location = new System.Drawing.Point(175, 270);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(217, 36);
            this.TxtName.TabIndex = 3;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAddress.Location = new System.Drawing.Point(175, 405);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(217, 73);
            this.TxtAddress.TabIndex = 6;
            this.TxtAddress.UseSystemPasswordChar = true;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.BackColor = System.Drawing.Color.Transparent;
            this.LblAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAddress.Location = new System.Drawing.Point(86, 412);
            this.LblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(82, 24);
            this.LblAddress.TabIndex = 31;
            this.LblAddress.Text = "Address:";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.LblPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPhoneNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPhoneNumber.Location = new System.Drawing.Point(27, 372);
            this.LblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(141, 24);
            this.LblPhoneNumber.TabIndex = 30;
            this.LblPhoneNumber.Text = "Phone Number:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEmail.Location = new System.Drawing.Point(175, 495);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(217, 36);
            this.TxtEmail.TabIndex = 7;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.Color.Transparent;
            this.LblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.LblEmail.Location = new System.Drawing.Point(100, 502);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(68, 24);
            this.LblEmail.TabIndex = 36;
            this.LblEmail.Text = "E-Mail:";
            // 
            // MTxtPhoneNumber
            // 
            this.MTxtPhoneNumber.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MTxtPhoneNumber.Location = new System.Drawing.Point(175, 365);
            this.MTxtPhoneNumber.Mask = "(999) 000-0000";
            this.MTxtPhoneNumber.Name = "MTxtPhoneNumber";
            this.MTxtPhoneNumber.Size = new System.Drawing.Size(217, 36);
            this.MTxtPhoneNumber.TabIndex = 5;
            // 
            // BtnImagePath
            // 
            this.BtnImagePath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnImagePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImagePath.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnImagePath.Location = new System.Drawing.Point(175, 535);
            this.BtnImagePath.Name = "BtnImagePath";
            this.BtnImagePath.Size = new System.Drawing.Size(217, 42);
            this.BtnImagePath.TabIndex = 8;
            this.BtnImagePath.Text = "Choose Profile Photo";
            this.BtnImagePath.UseVisualStyleBackColor = false;
            this.BtnImagePath.Click += new System.EventHandler(this.BtnImagePath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(392, 527);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(0, 29);
            this.LblPath.TabIndex = 42;
            this.LblPath.Visible = false;
            // 
            // PicPhoto
            // 
            this.PicPhoto.BackColor = System.Drawing.Color.Transparent;
            this.PicPhoto.Location = new System.Drawing.Point(205, 12);
            this.PicPhoto.Name = "PicPhoto";
            this.PicPhoto.Size = new System.Drawing.Size(150, 150);
            this.PicPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPhoto.TabIndex = 43;
            this.PicPhoto.TabStop = false;
            this.PicPhoto.Click += new System.EventHandler(this.PicPhoto_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.BackgroundImage = global::OOP2_2_PreLab.Properties.Resources.exitXLogo;
            this.btn_kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kapat.Location = new System.Drawing.Point(478, 12);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(55, 45);
            this.btn_kapat.TabIndex = 67;
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.BackColor = System.Drawing.Color.Transparent;
            this.LblSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSurname.ForeColor = System.Drawing.SystemColors.Control;
            this.LblSurname.Location = new System.Drawing.Point(79, 323);
            this.LblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(89, 24);
            this.LblSurname.TabIndex = 25;
            this.LblSurname.Text = "Surname:";
            // 
            // LnlName
            // 
            this.LnlName.AutoSize = true;
            this.LnlName.BackColor = System.Drawing.Color.Transparent;
            this.LnlName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnlName.ForeColor = System.Drawing.SystemColors.Control;
            this.LnlName.Location = new System.Drawing.Point(104, 277);
            this.LnlName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LnlName.Name = "LnlName";
            this.LnlName.Size = new System.Drawing.Size(64, 24);
            this.LnlName.TabIndex = 24;
            this.LnlName.Text = "Name:";
            // 
            // lblnewPassword
            // 
            this.lblnewPassword.AutoSize = true;
            this.lblnewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblnewPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnewPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnewPassword.Location = new System.Drawing.Point(74, 232);
            this.lblnewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewPassword.Name = "lblnewPassword";
            this.lblnewPassword.Size = new System.Drawing.Size(94, 24);
            this.lblnewPassword.TabIndex = 2;
            this.lblnewPassword.Text = "Password:";
            // 
            // lblNewKayıt
            // 
            this.lblNewKayıt.AutoSize = true;
            this.lblNewKayıt.BackColor = System.Drawing.Color.Transparent;
            this.lblNewKayıt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewKayıt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNewKayıt.Location = new System.Drawing.Point(68, 186);
            this.lblNewKayıt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewKayıt.Name = "lblNewKayıt";
            this.lblNewKayıt.Size = new System.Drawing.Size(100, 24);
            this.lblNewKayıt.TabIndex = 1;
            this.lblNewKayıt.Text = "Username:";
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::OOP2_2_PreLab.Properties.Resources.login_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 665);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.PicPhoto);
            this.Controls.Add(this.LblPath);
            this.Controls.Add(this.BtnImagePath);
            this.Controls.Add(this.MTxtPhoneNumber);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblPhoneNumber);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LnlName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblnewPassword);
            this.Controls.Add(this.lblNewKayıt);
            this.Controls.Add(this.btnRegister);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.KayıtFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.MaskedTextBox MTxtPhoneNumber;
        private System.Windows.Forms.Button BtnImagePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.PictureBox PicPhoto;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LnlName;
        private System.Windows.Forms.Label lblnewPassword;
        private System.Windows.Forms.Label lblNewKayıt;
    }
}