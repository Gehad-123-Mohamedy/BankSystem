namespace Complete_Bank_System
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
            lbl_UserName = new Label();
            lbl_Password = new Label();
            lbl_Role = new Label();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            cb_Roles = new ComboBox();
            btn_Login = new Button();
            btn_Register = new Button();
            lbl_tocreateAcc = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            chkb_password = new CheckBox();
            exit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            lbl_UserName.ForeColor = Color.Green;
            lbl_UserName.Location = new Point(343, 199);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(103, 21);
            lbl_UserName.TabIndex = 0;
            lbl_UserName.Text = "User Name";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            lbl_Password.ForeColor = Color.Green;
            lbl_Password.Location = new Point(343, 275);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(93, 21);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password";
            // 
            // lbl_Role
            // 
            lbl_Role.AutoSize = true;
            lbl_Role.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Role.ForeColor = Color.Green;
            lbl_Role.Location = new Point(354, 116);
            lbl_Role.Name = "lbl_Role";
            lbl_Role.Size = new Size(48, 21);
            lbl_Role.TabIndex = 2;
            lbl_Role.Text = "Role";
            // 
            // txt_UserName
            // 
            txt_UserName.ForeColor = Color.Black;
            txt_UserName.Location = new Point(354, 233);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(356, 27);
            txt_UserName.TabIndex = 4;
            // 
            // txt_Password
            // 
            txt_Password.ForeColor = Color.Black;
            txt_Password.Location = new Point(354, 314);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(356, 27);
            txt_Password.TabIndex = 5;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // cb_Roles
            // 
            cb_Roles.ForeColor = Color.Black;
            cb_Roles.FormattingEnabled = true;
            cb_Roles.Location = new Point(354, 158);
            cb_Roles.Name = "cb_Roles";
            cb_Roles.Size = new Size(356, 28);
            cb_Roles.TabIndex = 6;
            cb_Roles.SelectedIndexChanged += cb_Roles_SelectedIndexChanged;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Green;
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.FlatAppearance.BorderColor = Color.Green;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatAppearance.MouseDownBackColor = Color.Green;
            btn_Login.FlatAppearance.MouseOverBackColor = Color.Green;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(354, 415);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(190, 39);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = SystemColors.Control;
            btn_Register.Cursor = Cursors.Hand;
            btn_Register.FlatAppearance.BorderSize = 0;
            btn_Register.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Register.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Register.FlatStyle = FlatStyle.Flat;
            btn_Register.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Register.ForeColor = Color.DarkGreen;
            btn_Register.Location = new Point(11, 413);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(288, 39);
            btn_Register.TabIndex = 8;
            btn_Register.Text = "Sign Up";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // lbl_tocreateAcc
            // 
            lbl_tocreateAcc.AutoSize = true;
            lbl_tocreateAcc.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tocreateAcc.ForeColor = Color.White;
            lbl_tocreateAcc.Location = new Point(55, 358);
            lbl_tocreateAcc.Name = "lbl_tocreateAcc";
            lbl_tocreateAcc.Size = new Size(64, 22);
            lbl_tocreateAcc.TabIndex = 9;
            lbl_tocreateAcc.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_Register);
            panel1.Controls.Add(lbl_tocreateAcc);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 483);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bankLogo;
            pictureBox1.Location = new Point(90, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 199);
            label1.Name = "label1";
            label1.Size = new Size(279, 24);
            label1.TabIndex = 11;
            label1.Text = "Bank Management System";
            // 
            // chkb_password
            // 
            chkb_password.AutoSize = true;
            chkb_password.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkb_password.ForeColor = Color.DarkGreen;
            chkb_password.Location = new Point(553, 359);
            chkb_password.Name = "chkb_password";
            chkb_password.Size = new Size(168, 25);
            chkb_password.TabIndex = 12;
            chkb_password.Text = "Show Password";
            chkb_password.UseVisualStyleBackColor = true;
            chkb_password.CheckedChanged += chkb_password_CheckedChanged;
            // 
            // exit
            // 
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.DarkGreen;
            exit.Location = new Point(724, 0);
            exit.Name = "exit";
            exit.Size = new Size(29, 34);
            exit.TabIndex = 13;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 483);
            Controls.Add(exit);
            Controls.Add(chkb_password);
            Controls.Add(panel1);
            Controls.Add(btn_Login);
            Controls.Add(cb_Roles);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(lbl_Role);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_UserName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_UserName;
        private Label lbl_Password;
        private Label lbl_Role;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private ComboBox cb_Roles;
        private Button btn_Login;
        private Button btn_Register;
        private Label lbl_tocreateAcc;
        private Panel panel1;
        private Label label1;
        private CheckBox chkb_password;
        private Button exit;
        private PictureBox pictureBox1;
    }
}