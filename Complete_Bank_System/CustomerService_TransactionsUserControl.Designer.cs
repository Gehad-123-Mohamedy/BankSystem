namespace Complete_Bank_System
{
    partial class CustomerService_TransactionsUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lbl_Transactions = new Label();
            lbl_TransactionType = new Label();
            lbl_Amount = new Label();
            lbl_AccNumber = new Label();
            cb_TrasType = new ComboBox();
            nUD_Amount = new NumericUpDown();
            btn_addTransaction = new Button();
            dgv_Transactions = new DataGridView();
            btn_Search = new Button();
            txt_AccountNumber = new TextBox();
            cb_AccountNum = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nUD_Amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Transactions).BeginInit();
            SuspendLayout();
            // 
            // lbl_Transactions
            // 
            lbl_Transactions.AutoSize = true;
            lbl_Transactions.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            lbl_Transactions.ForeColor = Color.DarkGreen;
            lbl_Transactions.Location = new Point(46, 35);
            lbl_Transactions.Name = "lbl_Transactions";
            lbl_Transactions.Size = new Size(161, 28);
            lbl_Transactions.TabIndex = 0;
            lbl_Transactions.Text = "Transactions";
            // 
            // lbl_TransactionType
            // 
            lbl_TransactionType.AutoSize = true;
            lbl_TransactionType.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_TransactionType.ForeColor = Color.DarkGreen;
            lbl_TransactionType.Location = new Point(35, 485);
            lbl_TransactionType.Name = "lbl_TransactionType";
            lbl_TransactionType.Size = new Size(165, 22);
            lbl_TransactionType.TabIndex = 1;
            lbl_TransactionType.Text = "Transaction Type";
            // 
            // lbl_Amount
            // 
            lbl_Amount.AutoSize = true;
            lbl_Amount.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_Amount.ForeColor = Color.DarkGreen;
            lbl_Amount.Location = new Point(259, 485);
            lbl_Amount.Name = "lbl_Amount";
            lbl_Amount.Size = new Size(81, 22);
            lbl_Amount.TabIndex = 2;
            lbl_Amount.Text = "Amount";
            // 
            // lbl_AccNumber
            // 
            lbl_AccNumber.AutoSize = true;
            lbl_AccNumber.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_AccNumber.ForeColor = Color.DarkGreen;
            lbl_AccNumber.Location = new Point(429, 485);
            lbl_AccNumber.Name = "lbl_AccNumber";
            lbl_AccNumber.Size = new Size(162, 22);
            lbl_AccNumber.TabIndex = 3;
            lbl_AccNumber.Text = "Account Number";
            // 
            // cb_TrasType
            // 
            cb_TrasType.FormattingEnabled = true;
            cb_TrasType.Location = new Point(35, 539);
            cb_TrasType.Name = "cb_TrasType";
            cb_TrasType.Size = new Size(172, 28);
            cb_TrasType.TabIndex = 4;
            // 
            // nUD_Amount
            // 
            nUD_Amount.Location = new Point(231, 541);
            nUD_Amount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nUD_Amount.Name = "nUD_Amount";
            nUD_Amount.Size = new Size(182, 27);
            nUD_Amount.TabIndex = 6;
            // 
            // btn_addTransaction
            // 
            btn_addTransaction.BackColor = Color.DarkGreen;
            btn_addTransaction.FlatStyle = FlatStyle.Flat;
            btn_addTransaction.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btn_addTransaction.ForeColor = Color.White;
            btn_addTransaction.Location = new Point(673, 530);
            btn_addTransaction.Name = "btn_addTransaction";
            btn_addTransaction.Size = new Size(169, 37);
            btn_addTransaction.TabIndex = 7;
            btn_addTransaction.Text = "Add";
            btn_addTransaction.UseVisualStyleBackColor = false;
            btn_addTransaction.Click += btn_addTransaction_Click;
            // 
            // dgv_Transactions
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Transactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Transactions.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Transactions.Location = new Point(35, 199);
            dgv_Transactions.Name = "dgv_Transactions";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Transactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Transactions.RowHeadersWidth = 51;
            dgv_Transactions.Size = new Size(762, 188);
            dgv_Transactions.TabIndex = 8;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.DarkGreen;
            btn_Search.Cursor = Cursors.Hand;
            btn_Search.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btn_Search.FlatAppearance.BorderSize = 0;
            btn_Search.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Search.FlatStyle = FlatStyle.Flat;
            btn_Search.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_Search.ForeColor = Color.White;
            btn_Search.Location = new Point(513, 104);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(256, 39);
            btn_Search.TabIndex = 10;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_AccountNumber
            // 
            txt_AccountNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txt_AccountNumber.ForeColor = Color.Green;
            txt_AccountNumber.Location = new Point(66, 112);
            txt_AccountNumber.Name = "txt_AccountNumber";
            txt_AccountNumber.Size = new Size(385, 31);
            txt_AccountNumber.TabIndex = 9;
            txt_AccountNumber.TextChanged += txt_AccountNumber_TextChanged;
            // 
            // cb_AccountNum
            // 
            cb_AccountNum.FormattingEnabled = true;
            cb_AccountNum.Location = new Point(429, 538);
            cb_AccountNum.Name = "cb_AccountNum";
            cb_AccountNum.Size = new Size(210, 28);
            cb_AccountNum.TabIndex = 5;
            // 
            // CustomerService_TransactionsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_Search);
            Controls.Add(txt_AccountNumber);
            Controls.Add(dgv_Transactions);
            Controls.Add(btn_addTransaction);
            Controls.Add(nUD_Amount);
            Controls.Add(cb_AccountNum);
            Controls.Add(cb_TrasType);
            Controls.Add(lbl_AccNumber);
            Controls.Add(lbl_Amount);
            Controls.Add(lbl_TransactionType);
            Controls.Add(lbl_Transactions);
            Name = "CustomerService_TransactionsUserControl";
            Size = new Size(856, 618);
            ((System.ComponentModel.ISupportInitialize)nUD_Amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Transactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Transactions;
        private Label lbl_TransactionType;
        private Label lbl_Amount;
        private Label lbl_AccNumber;
        private ComboBox cb_TrasType;
        private NumericUpDown nUD_Amount;
        private Button btn_addTransaction;
        private DataGridView dgv_Transactions;
        private Button btn_Search;
        private TextBox txt_AccountNumber;
        private ComboBox cb_AccountNum;
    }
}
