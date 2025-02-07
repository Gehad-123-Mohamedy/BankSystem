namespace Complete_Bank_System
{
    partial class LoanOfficerDashBoard
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
            panel1 = new Panel();
            btn_LoanRepayment = new Button();
            btn_ReturnToLogin = new Button();
            btn_Loans = new Button();
            ContainerPanel = new Panel();
            exit = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_LoanRepayment);
            panel1.Controls.Add(btn_ReturnToLogin);
            panel1.Controls.Add(btn_Loans);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 621);
            panel1.TabIndex = 1;
            // 
            // btn_LoanRepayment
            // 
            btn_LoanRepayment.BackColor = SystemColors.Control;
            btn_LoanRepayment.Cursor = Cursors.Hand;
            btn_LoanRepayment.FlatAppearance.BorderColor = Color.Green;
            btn_LoanRepayment.FlatAppearance.BorderSize = 0;
            btn_LoanRepayment.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_LoanRepayment.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_LoanRepayment.FlatStyle = FlatStyle.Flat;
            btn_LoanRepayment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_LoanRepayment.ForeColor = Color.DarkGreen;
            btn_LoanRepayment.Location = new Point(11, 425);
            btn_LoanRepayment.Name = "btn_LoanRepayment";
            btn_LoanRepayment.Size = new Size(256, 42);
            btn_LoanRepayment.TabIndex = 6;
            btn_LoanRepayment.Text = "Loans Repayment";
            btn_LoanRepayment.UseVisualStyleBackColor = false;
            btn_LoanRepayment.Click += btn_LoanRepayment_Click;
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
            btn_ReturnToLogin.Location = new Point(11, 484);
            btn_ReturnToLogin.Name = "btn_ReturnToLogin";
            btn_ReturnToLogin.Size = new Size(256, 37);
            btn_ReturnToLogin.TabIndex = 5;
            btn_ReturnToLogin.Text = "Signout";
            btn_ReturnToLogin.UseVisualStyleBackColor = false;
            btn_ReturnToLogin.Click += btn_ReturnToLogin_Click;
            // 
            // btn_Loans
            // 
            btn_Loans.BackColor = SystemColors.Control;
            btn_Loans.Cursor = Cursors.Hand;
            btn_Loans.FlatAppearance.BorderColor = Color.Green;
            btn_Loans.FlatAppearance.BorderSize = 0;
            btn_Loans.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Loans.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Loans.FlatStyle = FlatStyle.Flat;
            btn_Loans.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_Loans.ForeColor = Color.DarkGreen;
            btn_Loans.Location = new Point(11, 368);
            btn_Loans.Name = "btn_Loans";
            btn_Loans.Size = new Size(256, 38);
            btn_Loans.TabIndex = 3;
            btn_Loans.Text = "Loans";
            btn_Loans.UseVisualStyleBackColor = false;
            btn_Loans.Click += btn_Loans_Click;
            // 
            // ContainerPanel
            // 
            ContainerPanel.BackColor = Color.White;
            ContainerPanel.Controls.Add(exit);
            ContainerPanel.Location = new Point(301, 0);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(857, 619);
            ContainerPanel.TabIndex = 2;
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bankLogo;
            pictureBox1.Location = new Point(66, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 216);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 15;
            label1.Text = "Loan Officer";
            // 
            // LoanOfficerDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 621);
            Controls.Add(ContainerPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoanOfficerDashBoard";
            Text = "LoanOfficerDashBoard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_ReturnToLogin;
        private Button btn_Loans;
        private Panel ContainerPanel;
        private Button btn_LoanRepayment;
        private Button exit;
        private PictureBox pictureBox1;
        private Label label1;
    }
}