namespace Complete_Bank_System
{
    partial class Customer_LoansForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DGV_Loans = new DataGridView();
            lbl_LoanType = new Label();
            lbl_LoanAmount = new Label();
            lbl_LoanTerm = new Label();
            lbl_RepaymentStatus = new Label();
            cb_LoanType = new ComboBox();
            nUD_LoanAmount = new NumericUpDown();
            btn_Add = new Button();
            btn_EditLoan = new Button();
            btn_DeleteLoan = new Button();
            nUD_LoanTerm = new NumericUpDown();
            lbl_CurrentStatus = new Label();
            btn_RepayLoan = new Button();
            lbl_RepaymentAmount = new Label();
            nUD_RepayAmount = new NumericUpDown();
            lbl_AccountNum = new Label();
            cb_Acccounts = new ComboBox();
            btn_ReturnToHome = new Button();
            panel_Loan = new Panel();
            lbl_LoanRepayment = new Label();
            panel1 = new Panel();
            label2 = new Label();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Loans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_LoanAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_LoanTerm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_RepayAmount).BeginInit();
            panel_Loan.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_Loans
            // 
            DGV_Loans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGV_Loans.DefaultCellStyle = dataGridViewCellStyle1;
            DGV_Loans.Location = new Point(126, 422);
            DGV_Loans.Name = "DGV_Loans";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_Loans.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_Loans.RowHeadersWidth = 51;
            DGV_Loans.Size = new Size(985, 188);
            DGV_Loans.TabIndex = 0;
            DGV_Loans.RowHeaderMouseDoubleClick += DGV_Loans_RowHeaderMouseDoubleClick;
            // 
            // lbl_LoanType
            // 
            lbl_LoanType.AutoSize = true;
            lbl_LoanType.BackColor = Color.White;
            lbl_LoanType.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_LoanType.ForeColor = Color.DarkGreen;
            lbl_LoanType.Location = new Point(140, 115);
            lbl_LoanType.Name = "lbl_LoanType";
            lbl_LoanType.Size = new Size(113, 24);
            lbl_LoanType.TabIndex = 1;
            lbl_LoanType.Text = "Loan Type";
            // 
            // lbl_LoanAmount
            // 
            lbl_LoanAmount.AutoSize = true;
            lbl_LoanAmount.BackColor = Color.White;
            lbl_LoanAmount.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_LoanAmount.ForeColor = Color.DarkGreen;
            lbl_LoanAmount.Location = new Point(140, 158);
            lbl_LoanAmount.Name = "lbl_LoanAmount";
            lbl_LoanAmount.Size = new Size(143, 24);
            lbl_LoanAmount.TabIndex = 2;
            lbl_LoanAmount.Text = "Loan Amount";
            // 
            // lbl_LoanTerm
            // 
            lbl_LoanTerm.AutoSize = true;
            lbl_LoanTerm.BackColor = Color.White;
            lbl_LoanTerm.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_LoanTerm.ForeColor = Color.DarkGreen;
            lbl_LoanTerm.Location = new Point(140, 206);
            lbl_LoanTerm.Name = "lbl_LoanTerm";
            lbl_LoanTerm.Size = new Size(116, 24);
            lbl_LoanTerm.TabIndex = 3;
            lbl_LoanTerm.Text = "Loan Term";
            // 
            // lbl_RepaymentStatus
            // 
            lbl_RepaymentStatus.AutoSize = true;
            lbl_RepaymentStatus.BackColor = Color.White;
            lbl_RepaymentStatus.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_RepaymentStatus.ForeColor = Color.DarkGreen;
            lbl_RepaymentStatus.Location = new Point(140, 258);
            lbl_RepaymentStatus.Name = "lbl_RepaymentStatus";
            lbl_RepaymentStatus.Size = new Size(196, 24);
            lbl_RepaymentStatus.TabIndex = 4;
            lbl_RepaymentStatus.Text = "Repayment Status";
            // 
            // cb_LoanType
            // 
            cb_LoanType.BackColor = Color.White;
            cb_LoanType.FormattingEnabled = true;
            cb_LoanType.Location = new Point(358, 116);
            cb_LoanType.Name = "cb_LoanType";
            cb_LoanType.Size = new Size(214, 28);
            cb_LoanType.TabIndex = 5;
            // 
            // nUD_LoanAmount
            // 
            nUD_LoanAmount.BackColor = Color.White;
            nUD_LoanAmount.Location = new Point(358, 164);
            nUD_LoanAmount.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nUD_LoanAmount.Name = "nUD_LoanAmount";
            nUD_LoanAmount.Size = new Size(214, 27);
            nUD_LoanAmount.TabIndex = 6;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.DarkGreen;
            btn_Add.Cursor = Cursors.Hand;
            btn_Add.FlatAppearance.BorderColor = Color.Green;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Add.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(166, 356);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(189, 37);
            btn_Add.TabIndex = 9;
            btn_Add.Text = "Apply ";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_EditLoan
            // 
            btn_EditLoan.BackColor = Color.DarkGreen;
            btn_EditLoan.Cursor = Cursors.Hand;
            btn_EditLoan.FlatAppearance.BorderColor = Color.Green;
            btn_EditLoan.FlatAppearance.BorderSize = 0;
            btn_EditLoan.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_EditLoan.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_EditLoan.FlatStyle = FlatStyle.Flat;
            btn_EditLoan.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_EditLoan.ForeColor = Color.White;
            btn_EditLoan.Location = new Point(403, 356);
            btn_EditLoan.Name = "btn_EditLoan";
            btn_EditLoan.Size = new Size(189, 37);
            btn_EditLoan.TabIndex = 10;
            btn_EditLoan.Text = "Edit ";
            btn_EditLoan.UseVisualStyleBackColor = false;
            btn_EditLoan.Click += btn_EditLoan_Click;
            // 
            // btn_DeleteLoan
            // 
            btn_DeleteLoan.BackColor = Color.DarkGreen;
            btn_DeleteLoan.Cursor = Cursors.Hand;
            btn_DeleteLoan.FlatAppearance.BorderColor = Color.Green;
            btn_DeleteLoan.FlatAppearance.BorderSize = 0;
            btn_DeleteLoan.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_DeleteLoan.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_DeleteLoan.FlatStyle = FlatStyle.Flat;
            btn_DeleteLoan.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_DeleteLoan.ForeColor = Color.White;
            btn_DeleteLoan.Location = new Point(638, 356);
            btn_DeleteLoan.Name = "btn_DeleteLoan";
            btn_DeleteLoan.Size = new Size(189, 37);
            btn_DeleteLoan.TabIndex = 11;
            btn_DeleteLoan.Text = "Cancel ";
            btn_DeleteLoan.UseVisualStyleBackColor = false;
            btn_DeleteLoan.Click += btn_DeleteLoan_Click;
            // 
            // nUD_LoanTerm
            // 
            nUD_LoanTerm.BackColor = Color.White;
            nUD_LoanTerm.Location = new Point(358, 208);
            nUD_LoanTerm.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nUD_LoanTerm.Name = "nUD_LoanTerm";
            nUD_LoanTerm.Size = new Size(214, 27);
            nUD_LoanTerm.TabIndex = 12;
            // 
            // lbl_CurrentStatus
            // 
            lbl_CurrentStatus.AutoSize = true;
            lbl_CurrentStatus.BackColor = Color.White;
            lbl_CurrentStatus.Location = new Point(403, 262);
            lbl_CurrentStatus.Name = "lbl_CurrentStatus";
            lbl_CurrentStatus.Size = new Size(15, 20);
            lbl_CurrentStatus.TabIndex = 13;
            lbl_CurrentStatus.Text = "_";
            // 
            // btn_RepayLoan
            // 
            btn_RepayLoan.BackColor = Color.DarkGreen;
            btn_RepayLoan.FlatAppearance.BorderColor = Color.Green;
            btn_RepayLoan.FlatAppearance.BorderSize = 0;
            btn_RepayLoan.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_RepayLoan.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_RepayLoan.FlatStyle = FlatStyle.Flat;
            btn_RepayLoan.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_RepayLoan.ForeColor = Color.White;
            btn_RepayLoan.Location = new Point(265, 169);
            btn_RepayLoan.Name = "btn_RepayLoan";
            btn_RepayLoan.Size = new Size(174, 32);
            btn_RepayLoan.TabIndex = 14;
            btn_RepayLoan.Text = "Repay Loan";
            btn_RepayLoan.UseVisualStyleBackColor = false;
            btn_RepayLoan.Click += btn_RepayLoan_Click;
            // 
            // lbl_RepaymentAmount
            // 
            lbl_RepaymentAmount.AutoSize = true;
            lbl_RepaymentAmount.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_RepaymentAmount.ForeColor = Color.DarkGreen;
            lbl_RepaymentAmount.Location = new Point(56, 119);
            lbl_RepaymentAmount.Name = "lbl_RepaymentAmount";
            lbl_RepaymentAmount.Size = new Size(211, 24);
            lbl_RepaymentAmount.TabIndex = 15;
            lbl_RepaymentAmount.Text = "Repayment Amount";
            // 
            // nUD_RepayAmount
            // 
            nUD_RepayAmount.Location = new Point(282, 116);
            nUD_RepayAmount.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nUD_RepayAmount.Name = "nUD_RepayAmount";
            nUD_RepayAmount.Size = new Size(193, 27);
            nUD_RepayAmount.TabIndex = 16;
            // 
            // lbl_AccountNum
            // 
            lbl_AccountNum.AutoSize = true;
            lbl_AccountNum.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_AccountNum.ForeColor = Color.DarkGreen;
            lbl_AccountNum.Location = new Point(66, 73);
            lbl_AccountNum.Name = "lbl_AccountNum";
            lbl_AccountNum.Size = new Size(179, 24);
            lbl_AccountNum.TabIndex = 17;
            lbl_AccountNum.Text = "Account Number";
            // 
            // cb_Acccounts
            // 
            cb_Acccounts.FormattingEnabled = true;
            cb_Acccounts.Location = new Point(282, 70);
            cb_Acccounts.Name = "cb_Acccounts";
            cb_Acccounts.Size = new Size(193, 28);
            cb_Acccounts.TabIndex = 18;
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
            btn_ReturnToHome.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_ReturnToHome.ForeColor = Color.White;
            btn_ReturnToHome.Location = new Point(915, 356);
            btn_ReturnToHome.Name = "btn_ReturnToHome";
            btn_ReturnToHome.Size = new Size(128, 37);
            btn_ReturnToHome.TabIndex = 19;
            btn_ReturnToHome.Text = "Home";
            btn_ReturnToHome.UseVisualStyleBackColor = false;
            btn_ReturnToHome.Click += btn_ReturnToHome_Click;
            // 
            // panel_Loan
            // 
            panel_Loan.BorderStyle = BorderStyle.FixedSingle;
            panel_Loan.Controls.Add(lbl_LoanRepayment);
            panel_Loan.Controls.Add(btn_RepayLoan);
            panel_Loan.Controls.Add(lbl_RepaymentAmount);
            panel_Loan.Controls.Add(cb_Acccounts);
            panel_Loan.Controls.Add(nUD_RepayAmount);
            panel_Loan.Controls.Add(lbl_AccountNum);
            panel_Loan.Location = new Point(612, 92);
            panel_Loan.Name = "panel_Loan";
            panel_Loan.Size = new Size(499, 222);
            panel_Loan.TabIndex = 20;
            // 
            // lbl_LoanRepayment
            // 
            lbl_LoanRepayment.AutoSize = true;
            lbl_LoanRepayment.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_LoanRepayment.ForeColor = Color.DarkGreen;
            lbl_LoanRepayment.Location = new Point(25, 23);
            lbl_LoanRepayment.Name = "lbl_LoanRepayment";
            lbl_LoanRepayment.Size = new Size(180, 24);
            lbl_LoanRepayment.TabIndex = 19;
            lbl_LoanRepayment.Text = "Loan Repayment";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(79, 634);
            panel1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(428, 9);
            label2.Name = "label2";
            label2.Size = new Size(235, 34);
            label2.TabIndex = 23;
            label2.Text = "New Loan Form";
            // 
            // exit
            // 
            exit.BackColor = Color.DarkGreen;
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(1105, 0);
            exit.Name = "exit";
            exit.Size = new Size(29, 34);
            exit.TabIndex = 24;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // Customer_LoansForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1133, 634);
            Controls.Add(exit);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel_Loan);
            Controls.Add(btn_ReturnToHome);
            Controls.Add(lbl_CurrentStatus);
            Controls.Add(nUD_LoanTerm);
            Controls.Add(btn_DeleteLoan);
            Controls.Add(btn_EditLoan);
            Controls.Add(btn_Add);
            Controls.Add(nUD_LoanAmount);
            Controls.Add(cb_LoanType);
            Controls.Add(lbl_RepaymentStatus);
            Controls.Add(lbl_LoanTerm);
            Controls.Add(lbl_LoanAmount);
            Controls.Add(lbl_LoanType);
            Controls.Add(DGV_Loans);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer_LoansForm";
            Text = "LoansForm";
            Load += LoansForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Loans).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_LoanAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_LoanTerm).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_RepayAmount).EndInit();
            panel_Loan.ResumeLayout(false);
            panel_Loan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_Loans;
        private Label lbl_LoanType;
        private Label lbl_LoanAmount;
        private Label lbl_LoanTerm;
        private Label lbl_RepaymentStatus;
        private ComboBox cb_LoanType;
        private NumericUpDown nUD_LoanAmount;
        private Button btn_Add;
        private Button btn_EditLoan;
        private Button btn_DeleteLoan;
        private NumericUpDown nUD_LoanTerm;
        private Label lbl_CurrentStatus;
        private Button btn_RepayLoan;
        private Label lbl_RepaymentAmount;
        private NumericUpDown nUD_RepayAmount;
        private Label lbl_AccountNum;
        private ComboBox cb_Acccounts;
        private Button btn_ReturnToHome;
        private Panel panel_Loan;
        private Label lbl_LoanRepayment;
        private Panel panel1;
        private Label label2;
        private Button exit;
    }
}