﻿namespace Complete_Bank_System
{
    partial class AccountMangerDashBoard
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
            btn_ReturnToLogin = new Button();
            btn_Accounts = new Button();
            ContainerPanel = new Panel();
            exit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ContainerPanel.SuspendLayout();
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
            btn_Transactions.Location = new Point(31, 459);
            btn_Transactions.Name = "btn_Transactions";
            btn_Transactions.Size = new Size(256, 37);
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
            panel1.Controls.Add(btn_ReturnToLogin);
            panel1.Controls.Add(btn_Transactions);
            panel1.Controls.Add(btn_Accounts);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 617);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bankLogo;
            pictureBox1.Location = new Point(99, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 234);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 14;
            label1.Text = "Account Manager";
            // 
            // btn_ReturnToLogin
            // 
            btn_ReturnToLogin.BackColor = SystemColors.Control;
            btn_ReturnToLogin.Cursor = Cursors.Hand;
            btn_ReturnToLogin.FlatAppearance.BorderColor = Color.Green;
            btn_ReturnToLogin.FlatAppearance.BorderSize = 0;
            btn_ReturnToLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_ReturnToLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_ReturnToLogin.FlatStyle = FlatStyle.Flat;
            btn_ReturnToLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_ReturnToLogin.ForeColor = Color.DarkGreen;
            btn_ReturnToLogin.Location = new Point(31, 514);
            btn_ReturnToLogin.Name = "btn_ReturnToLogin";
            btn_ReturnToLogin.Size = new Size(256, 38);
            btn_ReturnToLogin.TabIndex = 5;
            btn_ReturnToLogin.Text = "Signout";
            btn_ReturnToLogin.UseVisualStyleBackColor = false;
            btn_ReturnToLogin.Click += btn_ReturnToLogin_Click;
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
            btn_Accounts.Location = new Point(31, 403);
            btn_Accounts.Name = "btn_Accounts";
            btn_Accounts.Size = new Size(256, 37);
            btn_Accounts.TabIndex = 1;
            btn_Accounts.Text = "Accounts";
            btn_Accounts.UseVisualStyleBackColor = false;
            btn_Accounts.Click += btn_Accounts_Click;
            // 
            // ContainerPanel
            // 
            ContainerPanel.BackColor = Color.White;
            ContainerPanel.Controls.Add(exit);
            ContainerPanel.Location = new Point(342, 0);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(861, 619);
            ContainerPanel.TabIndex = 2;
            ContainerPanel.Paint += ContainerPanel_Paint;
            // 
            // exit
            // 
            exit.BackColor = Color.DarkGreen;
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(828, 0);
            exit.Name = "exit";
            exit.Size = new Size(29, 34);
            exit.TabIndex = 27;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // AccountMangerDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 617);
            Controls.Add(ContainerPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountMangerDashBoard";
            Text = "AccountMangerDashBoard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ContainerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Transactions;
        private Panel panel1;
        private Button btn_ReturnToLogin;
        private Button btn_Accounts;
        private Panel ContainerPanel;
        private Button exit;
        private PictureBox pictureBox1;
        private Label label1;
    }
}