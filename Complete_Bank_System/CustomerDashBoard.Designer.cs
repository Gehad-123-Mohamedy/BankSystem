namespace Complete_Bank_System
{
    partial class CustomerDashBoard
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
            btn_ShowProfile = new Button();
            btn_Account = new Button();
            btn_Transactions = new Button();
            btn_ReturnToLogin = new Button();
            btn_Loans = new Button();
            panel1 = new Panel();
            exit = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_ShowProfile
            // 
            btn_ShowProfile.BackColor = SystemColors.Control;
            btn_ShowProfile.Cursor = Cursors.Hand;
            btn_ShowProfile.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_ShowProfile.FlatAppearance.BorderSize = 0;
            btn_ShowProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_ShowProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_ShowProfile.FlatStyle = FlatStyle.Flat;
            btn_ShowProfile.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ShowProfile.ForeColor = Color.DarkGreen;
            btn_ShowProfile.Location = new Point(335, 71);
            btn_ShowProfile.Name = "btn_ShowProfile";
            btn_ShowProfile.Size = new Size(205, 31);
            btn_ShowProfile.TabIndex = 0;
            btn_ShowProfile.Text = "Show Profile";
            btn_ShowProfile.UseVisualStyleBackColor = false;
            btn_ShowProfile.Click += btn_ShowProfile_Click;
            // 
            // btn_Account
            // 
            btn_Account.BackColor = SystemColors.Control;
            btn_Account.Cursor = Cursors.Hand;
            btn_Account.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_Account.FlatAppearance.BorderSize = 0;
            btn_Account.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Account.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Account.FlatStyle = FlatStyle.Flat;
            btn_Account.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btn_Account.ForeColor = Color.DarkGreen;
            btn_Account.Location = new Point(335, 225);
            btn_Account.Name = "btn_Account";
            btn_Account.Size = new Size(205, 29);
            btn_Account.TabIndex = 2;
            btn_Account.Text = "Accounts";
            btn_Account.UseVisualStyleBackColor = false;
            btn_Account.Click += btn_Account_Click;
            // 
            // btn_Transactions
            // 
            btn_Transactions.BackColor = SystemColors.Control;
            btn_Transactions.Cursor = Cursors.Hand;
            btn_Transactions.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_Transactions.FlatAppearance.BorderSize = 0;
            btn_Transactions.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Transactions.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Transactions.FlatStyle = FlatStyle.Flat;
            btn_Transactions.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btn_Transactions.ForeColor = Color.DarkGreen;
            btn_Transactions.Location = new Point(335, 125);
            btn_Transactions.Name = "btn_Transactions";
            btn_Transactions.Size = new Size(205, 29);
            btn_Transactions.TabIndex = 3;
            btn_Transactions.Text = "Transactions";
            btn_Transactions.UseVisualStyleBackColor = false;
            btn_Transactions.Click += btn_Transactions_Click;
            // 
            // btn_ReturnToLogin
            // 
            btn_ReturnToLogin.BackColor = SystemColors.Control;
            btn_ReturnToLogin.Cursor = Cursors.Hand;
            btn_ReturnToLogin.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_ReturnToLogin.FlatAppearance.BorderSize = 0;
            btn_ReturnToLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_ReturnToLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_ReturnToLogin.FlatStyle = FlatStyle.Flat;
            btn_ReturnToLogin.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btn_ReturnToLogin.ForeColor = Color.DarkGreen;
            btn_ReturnToLogin.Location = new Point(335, 280);
            btn_ReturnToLogin.Name = "btn_ReturnToLogin";
            btn_ReturnToLogin.Size = new Size(205, 33);
            btn_ReturnToLogin.TabIndex = 4;
            btn_ReturnToLogin.Text = "Logout";
            btn_ReturnToLogin.UseVisualStyleBackColor = false;
            btn_ReturnToLogin.Click += btn_ReturnToLogin_Click;
            // 
            // btn_Loans
            // 
            btn_Loans.BackColor = SystemColors.Control;
            btn_Loans.Cursor = Cursors.Hand;
            btn_Loans.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_Loans.FlatAppearance.BorderSize = 0;
            btn_Loans.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Loans.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Loans.FlatStyle = FlatStyle.Flat;
            btn_Loans.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btn_Loans.ForeColor = Color.DarkGreen;
            btn_Loans.Location = new Point(335, 175);
            btn_Loans.Name = "btn_Loans";
            btn_Loans.Size = new Size(205, 29);
            btn_Loans.TabIndex = 5;
            btn_Loans.Text = "Loans";
            btn_Loans.UseVisualStyleBackColor = false;
            btn_Loans.Click += btn_Loans_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(exit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_ShowProfile);
            panel1.Controls.Add(btn_Account);
            panel1.Controls.Add(btn_ReturnToLogin);
            panel1.Controls.Add(btn_Loans);
            panel1.Controls.Add(btn_Transactions);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 357);
            panel1.TabIndex = 6;
            // 
            // exit
            // 
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(556, 3);
            exit.Name = "exit";
            exit.Size = new Size(29, 34);
            exit.TabIndex = 18;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 214);
            label1.Name = "label1";
            label1.Size = new Size(279, 24);
            label1.TabIndex = 16;
            label1.Text = "Bank Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bankLogo;
            pictureBox1.Location = new Point(79, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // CustomerDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(610, 380);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerDashBoard";
            Text = "CustomerDashBoard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ShowProfile;
        private Button btn_Account;
        private Button btn_Transactions;
        private Button btn_ReturnToLogin;
        private Button btn_Loans;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button exit;
    }
}