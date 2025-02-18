namespace Complete_Bank_System
{
    partial class CustomerServiceDashBoard
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
            btn_Transactions = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_Accounts = new Button();
            btn_AddCustomer = new Button();
            btn_ReturnToLogin = new Button();
            panel_Container = new Panel();
            exit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_Container.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Transactions
            // 
            btn_Transactions.BackColor = SystemColors.Control;
            btn_Transactions.Cursor = Cursors.Hand;
            btn_Transactions.FlatAppearance.BorderColor = Color.Green;
            btn_Transactions.FlatAppearance.BorderSize = 0;
            btn_Transactions.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Transactions.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Transactions.FlatStyle = FlatStyle.Flat;
            btn_Transactions.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_Transactions.ForeColor = Color.DarkGreen;
            btn_Transactions.Location = new Point(25, 498);
            btn_Transactions.Name = "btn_Transactions";
            btn_Transactions.Size = new Size(256, 39);
            btn_Transactions.TabIndex = 2;
            btn_Transactions.Text = "Transactions";
            btn_Transactions.UseVisualStyleBackColor = false;
            btn_Transactions.Click += btn_Transactions_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Accounts);
            panel1.Controls.Add(btn_AddCustomer);
            panel1.Controls.Add(btn_ReturnToLogin);
            panel1.Controls.Add(btn_Transactions);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 636);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bankLogo;
            pictureBox1.Location = new Point(83, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 194);
            label1.Name = "label1";
            label1.Size = new Size(216, 28);
            label1.TabIndex = 12;
            label1.Text = "Customer Service";
            // 
            // btn_Accounts
            // 
            btn_Accounts.BackColor = SystemColors.Control;
            btn_Accounts.Cursor = Cursors.Hand;
            btn_Accounts.FlatAppearance.BorderColor = Color.Green;
            btn_Accounts.FlatAppearance.BorderSize = 0;
            btn_Accounts.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Accounts.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Accounts.FlatStyle = FlatStyle.Flat;
            btn_Accounts.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_Accounts.ForeColor = Color.DarkGreen;
            btn_Accounts.Location = new Point(25, 443);
            btn_Accounts.Name = "btn_Accounts";
            btn_Accounts.Size = new Size(256, 37);
            btn_Accounts.TabIndex = 7;
            btn_Accounts.Text = "Accounts";
            btn_Accounts.UseVisualStyleBackColor = false;
            btn_Accounts.Click += btn_Accounts_Click;
            // 
            // btn_AddCustomer
            // 
            btn_AddCustomer.BackColor = SystemColors.Control;
            btn_AddCustomer.Cursor = Cursors.Hand;
            btn_AddCustomer.FlatAppearance.BorderColor = Color.Green;
            btn_AddCustomer.FlatAppearance.BorderSize = 0;
            btn_AddCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_AddCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_AddCustomer.FlatStyle = FlatStyle.Flat;
            btn_AddCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_AddCustomer.ForeColor = Color.DarkGreen;
            btn_AddCustomer.Location = new Point(25, 375);
            btn_AddCustomer.Name = "btn_AddCustomer";
            btn_AddCustomer.Size = new Size(256, 42);
            btn_AddCustomer.TabIndex = 6;
            btn_AddCustomer.Text = "Customers";
            btn_AddCustomer.UseVisualStyleBackColor = false;
            btn_AddCustomer.Click += btn_AddCustomer_Click;
            // 
            // btn_ReturnToLogin
            // 
            btn_ReturnToLogin.BackColor = SystemColors.Control;
            btn_ReturnToLogin.FlatAppearance.BorderColor = Color.Green;
            btn_ReturnToLogin.FlatAppearance.BorderSize = 0;
            btn_ReturnToLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_ReturnToLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_ReturnToLogin.FlatStyle = FlatStyle.Flat;
            btn_ReturnToLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_ReturnToLogin.ForeColor = Color.DarkGreen;
            btn_ReturnToLogin.Location = new Point(25, 563);
            btn_ReturnToLogin.Name = "btn_ReturnToLogin";
            btn_ReturnToLogin.Size = new Size(256, 34);
            btn_ReturnToLogin.TabIndex = 5;
            btn_ReturnToLogin.Text = "Logout";
            btn_ReturnToLogin.UseVisualStyleBackColor = false;
            btn_ReturnToLogin.Click += btn_ReturnToLogin_Click;
            // 
            // panel_Container
            // 
            panel_Container.BackColor = Color.White;
            panel_Container.BorderStyle = BorderStyle.FixedSingle;
            panel_Container.Controls.Add(exit);
            panel_Container.Location = new Point(325, 0);
            panel_Container.Name = "panel_Container";
            panel_Container.Size = new Size(858, 639);
            panel_Container.TabIndex = 2;
            // 
            // exit
            // 
            exit.BackColor = Color.DarkGreen;
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(828, -1);
            exit.Name = "exit";
            exit.Size = new Size(29, 34);
            exit.TabIndex = 26;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // CustomerServiceDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 636);
            Controls.Add(panel_Container);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerServiceDashBoard";
            Text = "CustomerServiceDashBoard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_Container.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Transactions;
        private Panel panel1;
        private Button btn_ReturnToLogin;
        private Button btn_AddCustomer;
        private Panel panel_Container;
        private Button btn_Accounts;
        private Button exit;
        private Label label1;
        private PictureBox pictureBox1;
    }
}