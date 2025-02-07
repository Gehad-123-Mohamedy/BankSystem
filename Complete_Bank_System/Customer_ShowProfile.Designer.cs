namespace Complete_Bank_System
{
    partial class Customer_ShowProfile
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
            pictureBox1 = new PictureBox();
            lbl_Name = new Label();
            lbl_BirthDate = new Label();
            lbl_CNN = new Label();
            lbl_OldPassword = new Label();
            lbl_Email = new Label();
            lbl_Address = new Label();
            lbl_PhoneNum = new Label();
            txt_Address = new TextBox();
            txt_Email = new TextBox();
            txt_OldPassword = new TextBox();
            txt_Name = new TextBox();
            txt_CNN = new TextBox();
            txt_PhoneNumber = new TextBox();
            DatePicker_BD = new DateTimePicker();
            btn_UploadPic = new Button();
            btn_EditProfile = new Button();
            btn_ReturnToHome = new Button();
            txt_NewPassword = new TextBox();
            lbl_NewPassword = new Label();
            txt_ConfirmPassword = new TextBox();
            lbl_ConfirmPassword = new Label();
            panel_PasswordContainer = new Panel();
            btn_ChangePassword = new Button();
            panel1 = new Panel();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_PasswordContainer.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userrr;
            pictureBox1.Location = new Point(58, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Name.ForeColor = Color.DarkGreen;
            lbl_Name.Location = new Point(385, 110);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(111, 24);
            lbl_Name.TabIndex = 1;
            lbl_Name.Text = "Full Name";
            // 
            // lbl_BirthDate
            // 
            lbl_BirthDate.AutoSize = true;
            lbl_BirthDate.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BirthDate.ForeColor = Color.DarkGreen;
            lbl_BirthDate.Location = new Point(385, 388);
            lbl_BirthDate.Name = "lbl_BirthDate";
            lbl_BirthDate.Size = new Size(107, 24);
            lbl_BirthDate.TabIndex = 2;
            lbl_BirthDate.Text = "BirthDate";
            // 
            // lbl_CNN
            // 
            lbl_CNN.AutoSize = true;
            lbl_CNN.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CNN.ForeColor = Color.DarkGreen;
            lbl_CNN.Location = new Point(385, 331);
            lbl_CNN.Name = "lbl_CNN";
            lbl_CNN.Size = new Size(53, 24);
            lbl_CNN.TabIndex = 3;
            lbl_CNN.Text = "CNN";
            // 
            // lbl_OldPassword
            // 
            lbl_OldPassword.AutoSize = true;
            lbl_OldPassword.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_OldPassword.ForeColor = Color.DarkGreen;
            lbl_OldPassword.Location = new Point(385, 449);
            lbl_OldPassword.Name = "lbl_OldPassword";
            lbl_OldPassword.Size = new Size(132, 22);
            lbl_OldPassword.TabIndex = 4;
            lbl_OldPassword.Text = "Old Password";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Email.ForeColor = Color.DarkGreen;
            lbl_Email.Location = new Point(385, 158);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(65, 24);
            lbl_Email.TabIndex = 5;
            lbl_Email.Text = "Email";
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Address.ForeColor = Color.DarkGreen;
            lbl_Address.Location = new Point(385, 212);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(91, 24);
            lbl_Address.TabIndex = 6;
            lbl_Address.Text = "Address";
            // 
            // lbl_PhoneNum
            // 
            lbl_PhoneNum.AutoSize = true;
            lbl_PhoneNum.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PhoneNum.ForeColor = Color.DarkGreen;
            lbl_PhoneNum.Location = new Point(385, 272);
            lbl_PhoneNum.Name = "lbl_PhoneNum";
            lbl_PhoneNum.Size = new Size(160, 24);
            lbl_PhoneNum.TabIndex = 7;
            lbl_PhoneNum.Text = "Phone Number";
            // 
            // txt_Address
            // 
            txt_Address.Font = new Font("Segoe UI", 10.8F);
            txt_Address.ForeColor = Color.ForestGreen;
            txt_Address.Location = new Point(598, 216);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(319, 31);
            txt_Address.TabIndex = 8;
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI", 10.8F);
            txt_Email.ForeColor = Color.ForestGreen;
            txt_Email.Location = new Point(598, 162);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(319, 31);
            txt_Email.TabIndex = 9;
            // 
            // txt_OldPassword
            // 
            txt_OldPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_OldPassword.ForeColor = Color.ForestGreen;
            txt_OldPassword.Location = new Point(598, 445);
            txt_OldPassword.Name = "txt_OldPassword";
            txt_OldPassword.Size = new Size(250, 31);
            txt_OldPassword.TabIndex = 10;
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Segoe UI", 10.8F);
            txt_Name.ForeColor = Color.ForestGreen;
            txt_Name.Location = new Point(598, 110);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(319, 31);
            txt_Name.TabIndex = 11;
            // 
            // txt_CNN
            // 
            txt_CNN.Font = new Font("Segoe UI", 10.8F);
            txt_CNN.ForeColor = Color.ForestGreen;
            txt_CNN.Location = new Point(598, 331);
            txt_CNN.Name = "txt_CNN";
            txt_CNN.Size = new Size(319, 31);
            txt_CNN.TabIndex = 12;
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Font = new Font("Segoe UI", 10.8F);
            txt_PhoneNumber.ForeColor = Color.ForestGreen;
            txt_PhoneNumber.Location = new Point(598, 272);
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.Size = new Size(319, 31);
            txt_PhoneNumber.TabIndex = 13;
            // 
            // DatePicker_BD
            // 
            DatePicker_BD.CalendarForeColor = Color.ForestGreen;
            DatePicker_BD.CalendarTitleForeColor = Color.ForestGreen;
            DatePicker_BD.Font = new Font("Segoe UI", 10.8F);
            DatePicker_BD.Location = new Point(598, 390);
            DatePicker_BD.Name = "DatePicker_BD";
            DatePicker_BD.Size = new Size(319, 31);
            DatePicker_BD.TabIndex = 14;
            // 
            // btn_UploadPic
            // 
            btn_UploadPic.BackColor = SystemColors.Control;
            btn_UploadPic.Cursor = Cursors.Hand;
            btn_UploadPic.FlatAppearance.BorderSize = 0;
            btn_UploadPic.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_UploadPic.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_UploadPic.FlatStyle = FlatStyle.Flat;
            btn_UploadPic.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_UploadPic.ForeColor = Color.DarkGreen;
            btn_UploadPic.Location = new Point(70, 249);
            btn_UploadPic.Name = "btn_UploadPic";
            btn_UploadPic.Size = new Size(182, 34);
            btn_UploadPic.TabIndex = 15;
            btn_UploadPic.Text = "Upload Picture";
            btn_UploadPic.UseVisualStyleBackColor = false;
            btn_UploadPic.Click += btn_UploadPic_Click;
            // 
            // btn_EditProfile
            // 
            btn_EditProfile.BackColor = SystemColors.Control;
            btn_EditProfile.Cursor = Cursors.Hand;
            btn_EditProfile.FlatAppearance.BorderSize = 0;
            btn_EditProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_EditProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_EditProfile.FlatStyle = FlatStyle.Flat;
            btn_EditProfile.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditProfile.ForeColor = Color.DarkGreen;
            btn_EditProfile.Location = new Point(22, 449);
            btn_EditProfile.Name = "btn_EditProfile";
            btn_EditProfile.Size = new Size(256, 43);
            btn_EditProfile.TabIndex = 16;
            btn_EditProfile.Text = "Edit Profile";
            btn_EditProfile.UseVisualStyleBackColor = false;
            btn_EditProfile.Click += btn_EditProfile_Click;
            // 
            // btn_ReturnToHome
            // 
            btn_ReturnToHome.BackColor = SystemColors.Control;
            btn_ReturnToHome.Cursor = Cursors.Hand;
            btn_ReturnToHome.FlatAppearance.BorderSize = 0;
            btn_ReturnToHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_ReturnToHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_ReturnToHome.FlatStyle = FlatStyle.Flat;
            btn_ReturnToHome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_ReturnToHome.ForeColor = Color.DarkGreen;
            btn_ReturnToHome.Location = new Point(22, 572);
            btn_ReturnToHome.Name = "btn_ReturnToHome";
            btn_ReturnToHome.Size = new Size(256, 37);
            btn_ReturnToHome.TabIndex = 17;
            btn_ReturnToHome.Text = "Home";
            btn_ReturnToHome.UseVisualStyleBackColor = false;
            btn_ReturnToHome.Click += btn_ReturnToHome_Click;
            // 
            // txt_NewPassword
            // 
            txt_NewPassword.Font = new Font("Segoe UI", 10.8F);
            txt_NewPassword.ForeColor = Color.ForestGreen;
            txt_NewPassword.Location = new Point(213, 30);
            txt_NewPassword.Name = "txt_NewPassword";
            txt_NewPassword.Size = new Size(250, 31);
            txt_NewPassword.TabIndex = 20;
            // 
            // lbl_NewPassword
            // 
            lbl_NewPassword.AutoSize = true;
            lbl_NewPassword.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NewPassword.ForeColor = Color.DarkGreen;
            lbl_NewPassword.Location = new Point(10, 35);
            lbl_NewPassword.Name = "lbl_NewPassword";
            lbl_NewPassword.Size = new Size(143, 22);
            lbl_NewPassword.TabIndex = 19;
            lbl_NewPassword.Text = "New Password";
            // 
            // txt_ConfirmPassword
            // 
            txt_ConfirmPassword.Font = new Font("Segoe UI", 10.8F);
            txt_ConfirmPassword.ForeColor = Color.ForestGreen;
            txt_ConfirmPassword.Location = new Point(213, 73);
            txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            txt_ConfirmPassword.Size = new Size(250, 31);
            txt_ConfirmPassword.TabIndex = 22;
            // 
            // lbl_ConfirmPassword
            // 
            lbl_ConfirmPassword.AutoSize = true;
            lbl_ConfirmPassword.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ConfirmPassword.ForeColor = Color.DarkGreen;
            lbl_ConfirmPassword.Location = new Point(10, 75);
            lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            lbl_ConfirmPassword.Size = new Size(174, 22);
            lbl_ConfirmPassword.TabIndex = 21;
            lbl_ConfirmPassword.Text = "Confirm Password";
            // 
            // panel_PasswordContainer
            // 
            panel_PasswordContainer.BorderStyle = BorderStyle.FixedSingle;
            panel_PasswordContainer.Controls.Add(lbl_NewPassword);
            panel_PasswordContainer.Controls.Add(txt_ConfirmPassword);
            panel_PasswordContainer.Controls.Add(txt_NewPassword);
            panel_PasswordContainer.Controls.Add(lbl_ConfirmPassword);
            panel_PasswordContainer.Location = new Point(373, 496);
            panel_PasswordContainer.Name = "panel_PasswordContainer";
            panel_PasswordContainer.Size = new Size(485, 129);
            panel_PasswordContainer.TabIndex = 23;
            // 
            // btn_ChangePassword
            // 
            btn_ChangePassword.BackColor = SystemColors.Control;
            btn_ChangePassword.Cursor = Cursors.Hand;
            btn_ChangePassword.FlatAppearance.BorderSize = 0;
            btn_ChangePassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_ChangePassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_ChangePassword.FlatStyle = FlatStyle.Flat;
            btn_ChangePassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_ChangePassword.ForeColor = Color.DarkGreen;
            btn_ChangePassword.Location = new Point(22, 510);
            btn_ChangePassword.Name = "btn_ChangePassword";
            btn_ChangePassword.Size = new Size(256, 44);
            btn_ChangePassword.TabIndex = 24;
            btn_ChangePassword.Text = "Change Password";
            btn_ChangePassword.UseVisualStyleBackColor = false;
            btn_ChangePassword.Click += btn_ChangePassword_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_ChangePassword);
            panel1.Controls.Add(btn_UploadPic);
            panel1.Controls.Add(btn_EditProfile);
            panel1.Controls.Add(btn_ReturnToHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 652);
            panel1.TabIndex = 25;
            // 
            // exit
            // 
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.DarkGreen;
            exit.Location = new Point(912, 0);
            exit.Name = "exit";
            exit.Size = new Size(29, 34);
            exit.TabIndex = 26;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Customer_ShowProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(940, 652);
            Controls.Add(exit);
            Controls.Add(panel1);
            Controls.Add(panel_PasswordContainer);
            Controls.Add(DatePicker_BD);
            Controls.Add(txt_PhoneNumber);
            Controls.Add(txt_CNN);
            Controls.Add(txt_Name);
            Controls.Add(txt_OldPassword);
            Controls.Add(txt_Email);
            Controls.Add(txt_Address);
            Controls.Add(lbl_PhoneNum);
            Controls.Add(lbl_Address);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_OldPassword);
            Controls.Add(lbl_CNN);
            Controls.Add(lbl_BirthDate);
            Controls.Add(lbl_Name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer_ShowProfile";
            Text = "ShowProfile";
            Load += ShowProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_PasswordContainer.ResumeLayout(false);
            panel_PasswordContainer.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_Name;
        private Label lbl_BirthDate;
        private Label lbl_CNN;
        private Label lbl_OldPassword;
        private Label lbl_Email;
        private Label lbl_Address;
        private Label lbl_PhoneNum;
        private TextBox txt_Address;
        private TextBox txt_Email;
        private TextBox txt_OldPassword;
        private TextBox txt_Name;
        private TextBox txt_CNN;
        private TextBox txt_PhoneNumber;
        private DateTimePicker DatePicker_BD;
        private Button btn_UploadPic;
        private Button btn_EditProfile;
        private Button btn_ReturnToHome;
        private TextBox txt_NewPassword;
        private Label lbl_NewPassword;
        private TextBox txt_ConfirmPassword;
        private Label lbl_ConfirmPassword;
        private Panel panel_PasswordContainer;
        private Button btn_ChangePassword;
        private Panel panel1;
        private Button exit;
    }
}