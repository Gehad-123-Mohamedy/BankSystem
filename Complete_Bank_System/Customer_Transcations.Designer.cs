namespace Complete_Bank_System
{
    partial class Customer_Transcations
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
            lbl_Deposit = new Label();
            lbl_Withdraw = new Label();
            lbl_Transfer = new Label();
            panel_Deposit = new Panel();
            btn_Deposite = new Button();
            nUD_Deposite_Amount = new NumericUpDown();
            txt_Deposit_ACCNUM = new TextBox();
            lbl_Deposite_Amount = new Label();
            lbl_Deposit_ACCNUM = new Label();
            panel_Withdraw = new Panel();
            nUD_Withdraw_Amount = new NumericUpDown();
            btn_Withdraw = new Button();
            txt_Withdraw_ACCNUM = new TextBox();
            lbl_Amount = new Label();
            lbl_AccNum = new Label();
            panel_Transfer = new Panel();
            btn_Transfer = new Button();
            lbl_Transfer_Amount = new Label();
            nUD_Transfer_Amount = new NumericUpDown();
            txt_RecipientAcc = new TextBox();
            txt_SenderAcc = new TextBox();
            lbl_To = new Label();
            lbl_From = new Label();
            panel_Transactions = new Panel();
            txt_Transactions_AccNum = new TextBox();
            lbl_Actual_Balance = new Label();
            btn_CheckBalance = new Button();
            lbl_Balace = new Label();
            lbl_CheckYourBalnce = new Label();
            lbl_Transactions = new Label();
            btn_ReturnToHome = new Button();
            panel1 = new Panel();
            label2 = new Label();
            exit = new Button();
            panel_Deposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Deposite_Amount).BeginInit();
            panel_Withdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Withdraw_Amount).BeginInit();
            panel_Transfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Transfer_Amount).BeginInit();
            panel_Transactions.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Deposit
            // 
            lbl_Deposit.AutoSize = true;
            lbl_Deposit.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_Deposit.ForeColor = Color.Olive;
            lbl_Deposit.Location = new Point(15, 16);
            lbl_Deposit.Name = "lbl_Deposit";
            lbl_Deposit.Size = new Size(86, 24);
            lbl_Deposit.TabIndex = 0;
            lbl_Deposit.Text = "Deposit";
            // 
            // lbl_Withdraw
            // 
            lbl_Withdraw.AutoSize = true;
            lbl_Withdraw.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_Withdraw.ForeColor = Color.Olive;
            lbl_Withdraw.Location = new Point(31, 16);
            lbl_Withdraw.Name = "lbl_Withdraw";
            lbl_Withdraw.Size = new Size(110, 24);
            lbl_Withdraw.TabIndex = 1;
            lbl_Withdraw.Text = "Withdraw";
            // 
            // lbl_Transfer
            // 
            lbl_Transfer.AutoSize = true;
            lbl_Transfer.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_Transfer.ForeColor = Color.Olive;
            lbl_Transfer.Location = new Point(20, 18);
            lbl_Transfer.Name = "lbl_Transfer";
            lbl_Transfer.Size = new Size(95, 24);
            lbl_Transfer.TabIndex = 2;
            lbl_Transfer.Text = "Transfer";
            // 
            // panel_Deposit
            // 
            panel_Deposit.BorderStyle = BorderStyle.FixedSingle;
            panel_Deposit.Controls.Add(btn_Deposite);
            panel_Deposit.Controls.Add(nUD_Deposite_Amount);
            panel_Deposit.Controls.Add(txt_Deposit_ACCNUM);
            panel_Deposit.Controls.Add(lbl_Deposite_Amount);
            panel_Deposit.Controls.Add(lbl_Deposit_ACCNUM);
            panel_Deposit.Controls.Add(lbl_Deposit);
            panel_Deposit.Location = new Point(610, 253);
            panel_Deposit.Name = "panel_Deposit";
            panel_Deposit.Size = new Size(469, 146);
            panel_Deposit.TabIndex = 3;
            // 
            // btn_Deposite
            // 
            btn_Deposite.BackColor = Color.DarkGreen;
            btn_Deposite.Cursor = Cursors.Hand;
            btn_Deposite.FlatAppearance.BorderColor = Color.Green;
            btn_Deposite.FlatAppearance.BorderSize = 0;
            btn_Deposite.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Deposite.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Deposite.FlatStyle = FlatStyle.Flat;
            btn_Deposite.ForeColor = Color.White;
            btn_Deposite.Location = new Point(351, 64);
            btn_Deposite.Name = "btn_Deposite";
            btn_Deposite.Size = new Size(94, 29);
            btn_Deposite.TabIndex = 11;
            btn_Deposite.Text = "Deposite";
            btn_Deposite.UseVisualStyleBackColor = false;
            btn_Deposite.Click += btn_Deposite_Click;
            // 
            // nUD_Deposite_Amount
            // 
            nUD_Deposite_Amount.Location = new Point(178, 90);
            nUD_Deposite_Amount.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            nUD_Deposite_Amount.Name = "nUD_Deposite_Amount";
            nUD_Deposite_Amount.Size = new Size(125, 27);
            nUD_Deposite_Amount.TabIndex = 10;
            // 
            // txt_Deposit_ACCNUM
            // 
            txt_Deposit_ACCNUM.Location = new Point(178, 51);
            txt_Deposit_ACCNUM.Name = "txt_Deposit_ACCNUM";
            txt_Deposit_ACCNUM.Size = new Size(125, 27);
            txt_Deposit_ACCNUM.TabIndex = 9;
            // 
            // lbl_Deposite_Amount
            // 
            lbl_Deposite_Amount.AutoSize = true;
            lbl_Deposite_Amount.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            lbl_Deposite_Amount.ForeColor = Color.Green;
            lbl_Deposite_Amount.Location = new Point(25, 92);
            lbl_Deposite_Amount.Name = "lbl_Deposite_Amount";
            lbl_Deposite_Amount.Size = new Size(78, 21);
            lbl_Deposite_Amount.TabIndex = 8;
            lbl_Deposite_Amount.Text = "Amount";
            // 
            // lbl_Deposit_ACCNUM
            // 
            lbl_Deposit_ACCNUM.AutoSize = true;
            lbl_Deposit_ACCNUM.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            lbl_Deposit_ACCNUM.ForeColor = Color.Green;
            lbl_Deposit_ACCNUM.Location = new Point(19, 53);
            lbl_Deposit_ACCNUM.Name = "lbl_Deposit_ACCNUM";
            lbl_Deposit_ACCNUM.Size = new Size(153, 21);
            lbl_Deposit_ACCNUM.TabIndex = 7;
            lbl_Deposit_ACCNUM.Text = "Account Number";
            // 
            // panel_Withdraw
            // 
            panel_Withdraw.BorderStyle = BorderStyle.FixedSingle;
            panel_Withdraw.Controls.Add(nUD_Withdraw_Amount);
            panel_Withdraw.Controls.Add(btn_Withdraw);
            panel_Withdraw.Controls.Add(txt_Withdraw_ACCNUM);
            panel_Withdraw.Controls.Add(lbl_Amount);
            panel_Withdraw.Controls.Add(lbl_AccNum);
            panel_Withdraw.Controls.Add(lbl_Withdraw);
            panel_Withdraw.Location = new Point(124, 253);
            panel_Withdraw.Name = "panel_Withdraw";
            panel_Withdraw.Size = new Size(435, 146);
            panel_Withdraw.TabIndex = 4;
            // 
            // nUD_Withdraw_Amount
            // 
            nUD_Withdraw_Amount.Location = new Point(183, 84);
            nUD_Withdraw_Amount.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            nUD_Withdraw_Amount.Name = "nUD_Withdraw_Amount";
            nUD_Withdraw_Amount.Size = new Size(125, 27);
            nUD_Withdraw_Amount.TabIndex = 6;
            // 
            // btn_Withdraw
            // 
            btn_Withdraw.BackColor = Color.DarkGreen;
            btn_Withdraw.Cursor = Cursors.Hand;
            btn_Withdraw.FlatAppearance.BorderColor = Color.Green;
            btn_Withdraw.FlatAppearance.BorderSize = 0;
            btn_Withdraw.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Withdraw.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Withdraw.FlatStyle = FlatStyle.Flat;
            btn_Withdraw.ForeColor = Color.White;
            btn_Withdraw.Location = new Point(324, 64);
            btn_Withdraw.Name = "btn_Withdraw";
            btn_Withdraw.Size = new Size(94, 29);
            btn_Withdraw.TabIndex = 5;
            btn_Withdraw.Text = "Withdraw";
            btn_Withdraw.UseVisualStyleBackColor = false;
            btn_Withdraw.Click += btn_Withdraw_Click;
            // 
            // txt_Withdraw_ACCNUM
            // 
            txt_Withdraw_ACCNUM.Location = new Point(183, 46);
            txt_Withdraw_ACCNUM.Name = "txt_Withdraw_ACCNUM";
            txt_Withdraw_ACCNUM.Size = new Size(125, 27);
            txt_Withdraw_ACCNUM.TabIndex = 4;
            // 
            // lbl_Amount
            // 
            lbl_Amount.AutoSize = true;
            lbl_Amount.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            lbl_Amount.ForeColor = Color.Green;
            lbl_Amount.Location = new Point(48, 88);
            lbl_Amount.Name = "lbl_Amount";
            lbl_Amount.Size = new Size(78, 21);
            lbl_Amount.TabIndex = 3;
            lbl_Amount.Text = "Amount";
            // 
            // lbl_AccNum
            // 
            lbl_AccNum.AutoSize = true;
            lbl_AccNum.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AccNum.ForeColor = Color.Green;
            lbl_AccNum.Location = new Point(20, 48);
            lbl_AccNum.Name = "lbl_AccNum";
            lbl_AccNum.Size = new Size(153, 21);
            lbl_AccNum.TabIndex = 2;
            lbl_AccNum.Text = "Account Number";
            // 
            // panel_Transfer
            // 
            panel_Transfer.BorderStyle = BorderStyle.FixedSingle;
            panel_Transfer.Controls.Add(btn_Transfer);
            panel_Transfer.Controls.Add(lbl_Transfer_Amount);
            panel_Transfer.Controls.Add(nUD_Transfer_Amount);
            panel_Transfer.Controls.Add(txt_RecipientAcc);
            panel_Transfer.Controls.Add(txt_SenderAcc);
            panel_Transfer.Controls.Add(lbl_To);
            panel_Transfer.Controls.Add(lbl_From);
            panel_Transfer.Controls.Add(lbl_Transfer);
            panel_Transfer.Location = new Point(124, 447);
            panel_Transfer.Name = "panel_Transfer";
            panel_Transfer.Size = new Size(783, 152);
            panel_Transfer.TabIndex = 5;
            // 
            // btn_Transfer
            // 
            btn_Transfer.BackColor = Color.DarkGreen;
            btn_Transfer.Cursor = Cursors.Hand;
            btn_Transfer.FlatAppearance.BorderColor = Color.Green;
            btn_Transfer.FlatAppearance.BorderSize = 0;
            btn_Transfer.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Transfer.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Transfer.FlatStyle = FlatStyle.Flat;
            btn_Transfer.ForeColor = Color.White;
            btn_Transfer.Location = new Point(668, 61);
            btn_Transfer.Name = "btn_Transfer";
            btn_Transfer.Size = new Size(94, 29);
            btn_Transfer.TabIndex = 12;
            btn_Transfer.Text = "Transfer";
            btn_Transfer.UseVisualStyleBackColor = false;
            btn_Transfer.Click += btn_Transfer_Click;
            // 
            // lbl_Transfer_Amount
            // 
            lbl_Transfer_Amount.AutoSize = true;
            lbl_Transfer_Amount.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            lbl_Transfer_Amount.ForeColor = Color.Green;
            lbl_Transfer_Amount.Location = new Point(409, 64);
            lbl_Transfer_Amount.Name = "lbl_Transfer_Amount";
            lbl_Transfer_Amount.Size = new Size(78, 21);
            lbl_Transfer_Amount.TabIndex = 9;
            lbl_Transfer_Amount.Text = "Amount";
            // 
            // nUD_Transfer_Amount
            // 
            nUD_Transfer_Amount.Location = new Point(511, 62);
            nUD_Transfer_Amount.Maximum = new decimal(new int[] { 30000, 0, 0, 0 });
            nUD_Transfer_Amount.Name = "nUD_Transfer_Amount";
            nUD_Transfer_Amount.Size = new Size(125, 27);
            nUD_Transfer_Amount.TabIndex = 7;
            // 
            // txt_RecipientAcc
            // 
            txt_RecipientAcc.Location = new Point(113, 107);
            txt_RecipientAcc.Name = "txt_RecipientAcc";
            txt_RecipientAcc.Size = new Size(237, 27);
            txt_RecipientAcc.TabIndex = 8;
            // 
            // txt_SenderAcc
            // 
            txt_SenderAcc.Location = new Point(113, 61);
            txt_SenderAcc.Name = "txt_SenderAcc";
            txt_SenderAcc.Size = new Size(237, 27);
            txt_SenderAcc.TabIndex = 7;
            // 
            // lbl_To
            // 
            lbl_To.AutoSize = true;
            lbl_To.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            lbl_To.ForeColor = Color.Green;
            lbl_To.Location = new Point(31, 107);
            lbl_To.Name = "lbl_To";
            lbl_To.Size = new Size(31, 21);
            lbl_To.TabIndex = 4;
            lbl_To.Text = "To";
            // 
            // lbl_From
            // 
            lbl_From.AutoSize = true;
            lbl_From.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            lbl_From.ForeColor = Color.Green;
            lbl_From.Location = new Point(31, 61);
            lbl_From.Name = "lbl_From";
            lbl_From.Size = new Size(54, 21);
            lbl_From.TabIndex = 3;
            lbl_From.Text = "From";
            // 
            // panel_Transactions
            // 
            panel_Transactions.BorderStyle = BorderStyle.FixedSingle;
            panel_Transactions.Controls.Add(txt_Transactions_AccNum);
            panel_Transactions.Controls.Add(lbl_Actual_Balance);
            panel_Transactions.Controls.Add(btn_CheckBalance);
            panel_Transactions.Controls.Add(lbl_Balace);
            panel_Transactions.Controls.Add(lbl_CheckYourBalnce);
            panel_Transactions.Controls.Add(lbl_Transactions);
            panel_Transactions.Location = new Point(145, 70);
            panel_Transactions.Name = "panel_Transactions";
            panel_Transactions.Size = new Size(847, 142);
            panel_Transactions.TabIndex = 6;
            // 
            // txt_Transactions_AccNum
            // 
            txt_Transactions_AccNum.Location = new Point(51, 101);
            txt_Transactions_AccNum.Name = "txt_Transactions_AccNum";
            txt_Transactions_AccNum.Size = new Size(125, 27);
            txt_Transactions_AccNum.TabIndex = 8;
            // 
            // lbl_Actual_Balance
            // 
            lbl_Actual_Balance.AutoSize = true;
            lbl_Actual_Balance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Actual_Balance.ForeColor = Color.Green;
            lbl_Actual_Balance.Location = new Point(636, 71);
            lbl_Actual_Balance.Name = "lbl_Actual_Balance";
            lbl_Actual_Balance.Size = new Size(86, 28);
            lbl_Actual_Balance.TabIndex = 7;
            lbl_Actual_Balance.Text = "Balance";
            // 
            // btn_CheckBalance
            // 
            btn_CheckBalance.BackColor = Color.DarkGreen;
            btn_CheckBalance.Cursor = Cursors.Hand;
            btn_CheckBalance.FlatAppearance.BorderColor = Color.Green;
            btn_CheckBalance.FlatAppearance.BorderSize = 0;
            btn_CheckBalance.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_CheckBalance.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_CheckBalance.FlatStyle = FlatStyle.Flat;
            btn_CheckBalance.ForeColor = Color.White;
            btn_CheckBalance.Location = new Point(303, 60);
            btn_CheckBalance.Name = "btn_CheckBalance";
            btn_CheckBalance.Size = new Size(122, 29);
            btn_CheckBalance.TabIndex = 6;
            btn_CheckBalance.Text = "Check";
            btn_CheckBalance.UseVisualStyleBackColor = false;
            btn_CheckBalance.Click += btn_CheckBalance_Click;
            // 
            // lbl_Balace
            // 
            lbl_Balace.AutoSize = true;
            lbl_Balace.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_Balace.ForeColor = Color.DarkGreen;
            lbl_Balace.Location = new Point(621, 25);
            lbl_Balace.Name = "lbl_Balace";
            lbl_Balace.Size = new Size(143, 24);
            lbl_Balace.TabIndex = 4;
            lbl_Balace.Text = "Your Balance";
            // 
            // lbl_CheckYourBalnce
            // 
            lbl_CheckYourBalnce.AutoSize = true;
            lbl_CheckYourBalnce.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_CheckYourBalnce.ForeColor = Color.Green;
            lbl_CheckYourBalnce.Location = new Point(24, 67);
            lbl_CheckYourBalnce.Name = "lbl_CheckYourBalnce";
            lbl_CheckYourBalnce.Size = new Size(191, 22);
            lbl_CheckYourBalnce.TabIndex = 3;
            lbl_CheckYourBalnce.Text = "Check Your Balance";
            // 
            // lbl_Transactions
            // 
            lbl_Transactions.AutoSize = true;
            lbl_Transactions.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Transactions.ForeColor = Color.Olive;
            lbl_Transactions.Location = new Point(24, 21);
            lbl_Transactions.Name = "lbl_Transactions";
            lbl_Transactions.Size = new Size(138, 24);
            lbl_Transactions.TabIndex = 2;
            lbl_Transactions.Text = "Transactions";
            // 
            // btn_ReturnToHome
            // 
            btn_ReturnToHome.BackColor = Color.DarkGreen;
            btn_ReturnToHome.Cursor = Cursors.Hand;
            btn_ReturnToHome.FlatAppearance.BorderColor = Color.Green;
            btn_ReturnToHome.FlatAppearance.BorderSize = 0;
            btn_ReturnToHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_ReturnToHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_ReturnToHome.FlatStyle = FlatStyle.Flat;
            btn_ReturnToHome.ForeColor = Color.White;
            btn_ReturnToHome.Location = new Point(942, 546);
            btn_ReturnToHome.Name = "btn_ReturnToHome";
            btn_ReturnToHome.Size = new Size(128, 29);
            btn_ReturnToHome.TabIndex = 18;
            btn_ReturnToHome.Text = "Home";
            btn_ReturnToHome.UseVisualStyleBackColor = false;
            btn_ReturnToHome.Click += btn_ReturnToHome_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(79, 625);
            panel1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(380, 9);
            label2.Name = "label2";
            label2.Size = new Size(332, 34);
            label2.TabIndex = 24;
            label2.Text = "New Transaction Form";
            // 
            // exit
            // 
            exit.BackColor = Color.DarkGreen;
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(1076, 0);
            exit.Name = "exit";
            exit.Size = new Size(29, 34);
            exit.TabIndex = 25;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // Customer_Transcations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1104, 625);
            Controls.Add(exit);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btn_ReturnToHome);
            Controls.Add(panel_Transactions);
            Controls.Add(panel_Transfer);
            Controls.Add(panel_Withdraw);
            Controls.Add(panel_Deposit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer_Transcations";
            Text = "Transcations";
            panel_Deposit.ResumeLayout(false);
            panel_Deposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Deposite_Amount).EndInit();
            panel_Withdraw.ResumeLayout(false);
            panel_Withdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Withdraw_Amount).EndInit();
            panel_Transfer.ResumeLayout(false);
            panel_Transfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Transfer_Amount).EndInit();
            panel_Transactions.ResumeLayout(false);
            panel_Transactions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Deposit;
        private Label lbl_Withdraw;
        private Label lbl_Transfer;
        private Panel panel_Deposit;
        private Panel panel_Withdraw;
        private Panel panel_Transfer;
        private Panel panel_Transactions;
        private Label lbl_Actual_Balance;
        private Button btn_CheckBalance;
        private Label lbl_Balace;
        private Label lbl_CheckYourBalnce;
        private Label lbl_Transactions;
        private TextBox txt_Transactions_AccNum;
        private TextBox txt_Withdraw_ACCNUM;
        private Label lbl_Amount;
        private Label lbl_AccNum;
        private NumericUpDown nUD_Withdraw_Amount;
        private Button btn_Withdraw;
        private Button btn_Deposite;
        private NumericUpDown nUD_Deposite_Amount;
        private TextBox txt_Deposit_ACCNUM;
        private Label lbl_Deposite_Amount;
        private Label lbl_Deposit_ACCNUM;
        private Button btn_Transfer;
        private Label lbl_Transfer_Amount;
        private NumericUpDown nUD_Transfer_Amount;
        private TextBox txt_RecipientAcc;
        private TextBox txt_SenderAcc;
        private Label lbl_To;
        private Label lbl_From;
        private Button btn_ReturnToHome;
        private Panel panel1;
        private Label label2;
        private Button exit;
    }
}