namespace Complete_Bank_System
{
    partial class LoanOfficer_LoansUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            btn_Search = new Button();
            txt_CustomerName = new TextBox();
            dgv_Loans = new DataGridView();
            nUD_LoanTerm = new NumericUpDown();
            nUD_LoanAmount = new NumericUpDown();
            cb_LoanType = new ComboBox();
            lbl_RepaymentStatus = new Label();
            lbl_LoanTerm = new Label();
            lbl_LoanAmount = new Label();
            lbl_LoanType = new Label();
            lbl_CurrentStatus = new Label();
            btn_DeleteLoan = new Button();
            btn_EditLoan = new Button();
            btn_Add = new Button();
            cb_Customers = new ComboBox();
            lbl_Customer = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Loans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_LoanTerm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_LoanAmount).BeginInit();
            SuspendLayout();
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.DarkGreen;
            btn_Search.Cursor = Cursors.Hand;
            btn_Search.FlatAppearance.BorderColor = Color.Green;
            btn_Search.FlatAppearance.BorderSize = 0;
            btn_Search.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Search.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Search.FlatStyle = FlatStyle.Flat;
            btn_Search.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_Search.ForeColor = Color.White;
            btn_Search.Location = new Point(572, 78);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(190, 41);
            btn_Search.TabIndex = 4;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_CustomerName
            // 
            txt_CustomerName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txt_CustomerName.ForeColor = Color.Green;
            txt_CustomerName.Location = new Point(133, 88);
            txt_CustomerName.Name = "txt_CustomerName";
            txt_CustomerName.Size = new Size(368, 31);
            txt_CustomerName.TabIndex = 3;
            txt_CustomerName.TextChanged += txt_CustomerName_TextChanged;
            // 
            // dgv_Loans
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgv_Loans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgv_Loans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgv_Loans.DefaultCellStyle = dataGridViewCellStyle11;
            dgv_Loans.Location = new Point(45, 160);
            dgv_Loans.Name = "dgv_Loans";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgv_Loans.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgv_Loans.RowHeadersWidth = 51;
            dgv_Loans.Size = new Size(735, 142);
            dgv_Loans.TabIndex = 5;
            dgv_Loans.RowHeaderMouseDoubleClick += dgv_Loans_RowHeaderMouseDoubleClick;
            // 
            // nUD_LoanTerm
            // 
            nUD_LoanTerm.Location = new Point(572, 408);
            nUD_LoanTerm.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nUD_LoanTerm.Name = "nUD_LoanTerm";
            nUD_LoanTerm.Size = new Size(218, 27);
            nUD_LoanTerm.TabIndex = 19;
            // 
            // nUD_LoanAmount
            // 
            nUD_LoanAmount.Location = new Point(288, 408);
            nUD_LoanAmount.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nUD_LoanAmount.Name = "nUD_LoanAmount";
            nUD_LoanAmount.Size = new Size(227, 27);
            nUD_LoanAmount.TabIndex = 18;
            // 
            // cb_LoanType
            // 
            cb_LoanType.FormattingEnabled = true;
            cb_LoanType.Location = new Point(33, 408);
            cb_LoanType.Name = "cb_LoanType";
            cb_LoanType.Size = new Size(185, 28);
            cb_LoanType.TabIndex = 17;
            // 
            // lbl_RepaymentStatus
            // 
            lbl_RepaymentStatus.AutoSize = true;
            lbl_RepaymentStatus.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_RepaymentStatus.ForeColor = Color.DarkGreen;
            lbl_RepaymentStatus.Location = new Point(297, 461);
            lbl_RepaymentStatus.Name = "lbl_RepaymentStatus";
            lbl_RepaymentStatus.Size = new Size(175, 22);
            lbl_RepaymentStatus.TabIndex = 16;
            lbl_RepaymentStatus.Text = "Repayment Status";
            // 
            // lbl_LoanTerm
            // 
            lbl_LoanTerm.AutoSize = true;
            lbl_LoanTerm.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_LoanTerm.ForeColor = Color.DarkGreen;
            lbl_LoanTerm.Location = new Point(598, 370);
            lbl_LoanTerm.Name = "lbl_LoanTerm";
            lbl_LoanTerm.Size = new Size(106, 22);
            lbl_LoanTerm.TabIndex = 15;
            lbl_LoanTerm.Text = "Loan Term";
            // 
            // lbl_LoanAmount
            // 
            lbl_LoanAmount.AutoSize = true;
            lbl_LoanAmount.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_LoanAmount.ForeColor = Color.DarkGreen;
            lbl_LoanAmount.Location = new Point(297, 370);
            lbl_LoanAmount.Name = "lbl_LoanAmount";
            lbl_LoanAmount.Size = new Size(130, 22);
            lbl_LoanAmount.TabIndex = 14;
            lbl_LoanAmount.Text = "Loan Amount";
            // 
            // lbl_LoanType
            // 
            lbl_LoanType.AutoSize = true;
            lbl_LoanType.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_LoanType.ForeColor = Color.DarkGreen;
            lbl_LoanType.Location = new Point(45, 370);
            lbl_LoanType.Name = "lbl_LoanType";
            lbl_LoanType.Size = new Size(102, 22);
            lbl_LoanType.TabIndex = 13;
            lbl_LoanType.Text = "Loan Type";
            // 
            // lbl_CurrentStatus
            // 
            lbl_CurrentStatus.AutoSize = true;
            lbl_CurrentStatus.Location = new Point(353, 495);
            lbl_CurrentStatus.Name = "lbl_CurrentStatus";
            lbl_CurrentStatus.Size = new Size(15, 20);
            lbl_CurrentStatus.TabIndex = 23;
            lbl_CurrentStatus.Text = "_";
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
            btn_DeleteLoan.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btn_DeleteLoan.ForeColor = Color.White;
            btn_DeleteLoan.Location = new Point(551, 565);
            btn_DeleteLoan.Name = "btn_DeleteLoan";
            btn_DeleteLoan.Size = new Size(189, 39);
            btn_DeleteLoan.TabIndex = 22;
            btn_DeleteLoan.Text = "Cancel ";
            btn_DeleteLoan.UseVisualStyleBackColor = false;
            btn_DeleteLoan.Click += btn_DeleteLoan_Click;
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
            btn_EditLoan.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btn_EditLoan.ForeColor = Color.White;
            btn_EditLoan.Location = new Point(319, 565);
            btn_EditLoan.Name = "btn_EditLoan";
            btn_EditLoan.Size = new Size(189, 39);
            btn_EditLoan.TabIndex = 21;
            btn_EditLoan.Text = "Edit ";
            btn_EditLoan.UseVisualStyleBackColor = false;
            btn_EditLoan.Click += btn_EditLoan_Click;
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
            btn_Add.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(72, 565);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(189, 39);
            btn_Add.TabIndex = 20;
            btn_Add.Text = "Apply ";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // cb_Customers
            // 
            cb_Customers.FormattingEnabled = true;
            cb_Customers.Location = new Point(33, 495);
            cb_Customers.Name = "cb_Customers";
            cb_Customers.Size = new Size(184, 28);
            cb_Customers.TabIndex = 33;
            // 
            // lbl_Customer
            // 
            lbl_Customer.AutoSize = true;
            lbl_Customer.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_Customer.ForeColor = Color.DarkGreen;
            lbl_Customer.Location = new Point(55, 461);
            lbl_Customer.Name = "lbl_Customer";
            lbl_Customer.Size = new Size(97, 22);
            lbl_Customer.TabIndex = 32;
            lbl_Customer.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(55, 32);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 34;
            label2.Text = "Loans";
            // 
            // LoanOfficer_LoansUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(cb_Customers);
            Controls.Add(lbl_Customer);
            Controls.Add(lbl_CurrentStatus);
            Controls.Add(btn_DeleteLoan);
            Controls.Add(btn_EditLoan);
            Controls.Add(btn_Add);
            Controls.Add(nUD_LoanTerm);
            Controls.Add(nUD_LoanAmount);
            Controls.Add(cb_LoanType);
            Controls.Add(lbl_RepaymentStatus);
            Controls.Add(lbl_LoanTerm);
            Controls.Add(lbl_LoanAmount);
            Controls.Add(lbl_LoanType);
            Controls.Add(dgv_Loans);
            Controls.Add(btn_Search);
            Controls.Add(txt_CustomerName);
            Name = "LoanOfficer_LoansUserControl";
            Size = new Size(857, 619);
            Load += LoanOfficer_LoansUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Loans).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_LoanTerm).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_LoanAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Search;
        private TextBox txt_CustomerName;
        private DataGridView dgv_Loans;
        private NumericUpDown nUD_LoanTerm;
        private NumericUpDown nUD_LoanAmount;
        private ComboBox cb_LoanType;
        private Label lbl_RepaymentStatus;
        private Label lbl_LoanTerm;
        private Label lbl_LoanAmount;
        private Label lbl_LoanType;
        private Label lbl_CurrentStatus;
        private Button btn_DeleteLoan;
        private Button btn_EditLoan;
        private Button btn_Add;
        private ComboBox cb_Customers;
        private Label lbl_Customer;
        private Label label2;
    }
}
