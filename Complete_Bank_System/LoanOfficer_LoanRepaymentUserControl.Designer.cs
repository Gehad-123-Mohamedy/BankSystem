namespace Complete_Bank_System
{
    partial class LoanOfficer_LoanRepaymentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dgv_Loans = new DataGridView();
            panel_Loan = new Panel();
            lbl_LoanRepayment = new Label();
            btn_RepayLoan = new Button();
            lbl_RepaymentAmount = new Label();
            cb_Acccounts = new ComboBox();
            nUD_RepayAmount = new NumericUpDown();
            lbl_AccountNum = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Loans).BeginInit();
            panel_Loan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_RepayAmount).BeginInit();
            SuspendLayout();
            // 
            // dgv_Loans
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgv_Loans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv_Loans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv_Loans.DefaultCellStyle = dataGridViewCellStyle8;
            dgv_Loans.Location = new Point(80, 123);
            dgv_Loans.Name = "dgv_Loans";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv_Loans.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv_Loans.RowHeadersWidth = 51;
            dgv_Loans.Size = new Size(618, 170);
            dgv_Loans.TabIndex = 6;
            dgv_Loans.RowHeaderMouseDoubleClick += dgv_Loans_RowHeaderMouseDoubleClick;
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
            panel_Loan.Location = new Point(70, 349);
            panel_Loan.Name = "panel_Loan";
            panel_Loan.Size = new Size(665, 237);
            panel_Loan.TabIndex = 21;
            // 
            // lbl_LoanRepayment
            // 
            lbl_LoanRepayment.AutoSize = true;
            lbl_LoanRepayment.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_LoanRepayment.ForeColor = Color.FromArgb(192, 192, 0);
            lbl_LoanRepayment.Location = new Point(26, 30);
            lbl_LoanRepayment.Name = "lbl_LoanRepayment";
            lbl_LoanRepayment.Size = new Size(162, 22);
            lbl_LoanRepayment.TabIndex = 19;
            lbl_LoanRepayment.Text = "Loan Repayment";
            // 
            // btn_RepayLoan
            // 
            btn_RepayLoan.BackColor = Color.DarkGreen;
            btn_RepayLoan.Cursor = Cursors.Hand;
            btn_RepayLoan.FlatAppearance.BorderColor = Color.Green;
            btn_RepayLoan.FlatAppearance.BorderSize = 0;
            btn_RepayLoan.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_RepayLoan.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_RepayLoan.FlatStyle = FlatStyle.Flat;
            btn_RepayLoan.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btn_RepayLoan.ForeColor = Color.White;
            btn_RepayLoan.Location = new Point(202, 174);
            btn_RepayLoan.Name = "btn_RepayLoan";
            btn_RepayLoan.Size = new Size(202, 44);
            btn_RepayLoan.TabIndex = 14;
            btn_RepayLoan.Text = "Repay Loan";
            btn_RepayLoan.UseVisualStyleBackColor = false;
            btn_RepayLoan.Click += btn_RepayLoan_Click;
            // 
            // lbl_RepaymentAmount
            // 
            lbl_RepaymentAmount.AutoSize = true;
            lbl_RepaymentAmount.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_RepaymentAmount.ForeColor = Color.DarkGreen;
            lbl_RepaymentAmount.Location = new Point(126, 121);
            lbl_RepaymentAmount.Name = "lbl_RepaymentAmount";
            lbl_RepaymentAmount.Size = new Size(180, 21);
            lbl_RepaymentAmount.TabIndex = 15;
            lbl_RepaymentAmount.Text = "Repayment Amount";
            // 
            // cb_Acccounts
            // 
            cb_Acccounts.FormattingEnabled = true;
            cb_Acccounts.Location = new Point(368, 69);
            cb_Acccounts.Name = "cb_Acccounts";
            cb_Acccounts.Size = new Size(219, 28);
            cb_Acccounts.TabIndex = 18;
            // 
            // nUD_RepayAmount
            // 
            nUD_RepayAmount.Location = new Point(368, 120);
            nUD_RepayAmount.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nUD_RepayAmount.Name = "nUD_RepayAmount";
            nUD_RepayAmount.Size = new Size(219, 27);
            nUD_RepayAmount.TabIndex = 16;
            // 
            // lbl_AccountNum
            // 
            lbl_AccountNum.AutoSize = true;
            lbl_AccountNum.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AccountNum.ForeColor = Color.DarkGreen;
            lbl_AccountNum.Location = new Point(126, 76);
            lbl_AccountNum.Name = "lbl_AccountNum";
            lbl_AccountNum.Size = new Size(153, 21);
            lbl_AccountNum.TabIndex = 17;
            lbl_AccountNum.Text = "Account Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(70, 35);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 33;
            label2.Text = "Loans ";
            // 
            // LoanOfficer_LoanRepaymentUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(panel_Loan);
            Controls.Add(dgv_Loans);
            Name = "LoanOfficer_LoanRepaymentUserControl";
            Size = new Size(857, 619);
            Load += LoanOfficer_LoanRepaymentUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Loans).EndInit();
            panel_Loan.ResumeLayout(false);
            panel_Loan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_RepayAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Loans;
        private Panel panel_Loan;
        private Label lbl_LoanRepayment;
        private Button btn_RepayLoan;
        private Label lbl_RepaymentAmount;
        private ComboBox cb_Acccounts;
        private NumericUpDown nUD_RepayAmount;
        private Label lbl_AccountNum;
        private Label label2;
    }
}
