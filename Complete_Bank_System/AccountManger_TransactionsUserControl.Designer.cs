namespace Complete_Bank_System
{
    partial class AccountManger_TransactionsUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            btn_Search = new Button();
            txt_AccountNumber = new TextBox();
            dgv_Transactions = new DataGridView();
            nUD_Amount = new NumericUpDown();
            cb_AccountNum = new ComboBox();
            cb_TrasType = new ComboBox();
            btn_Add = new Button();
            btn_Update = new Button();
            btn_delete = new Button();
            lbl_Transactions = new Label();
            lbl_TransactionType = new Label();
            lbl_Amount = new Label();
            lbl_AccNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Transactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Amount).BeginInit();
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
            btn_Search.Location = new Point(566, 95);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(226, 39);
            btn_Search.TabIndex = 19;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_AccountNumber
            // 
            txt_AccountNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txt_AccountNumber.ForeColor = Color.Green;
            txt_AccountNumber.Location = new Point(122, 103);
            txt_AccountNumber.Name = "txt_AccountNumber";
            txt_AccountNumber.Size = new Size(385, 31);
            txt_AccountNumber.TabIndex = 18;
            txt_AccountNumber.TextChanged += txt_AccountNumber_TextChanged;
            // 
            // dgv_Transactions
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgv_Transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgv_Transactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgv_Transactions.DefaultCellStyle = dataGridViewCellStyle14;
            dgv_Transactions.Location = new Point(37, 182);
            dgv_Transactions.Name = "dgv_Transactions";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgv_Transactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgv_Transactions.RowHeadersWidth = 51;
            dgv_Transactions.Size = new Size(776, 182);
            dgv_Transactions.TabIndex = 17;
            dgv_Transactions.RowHeaderMouseDoubleClick += dgv_Transactions_RowHeaderMouseDoubleClick;
            // 
            // nUD_Amount
            // 
            nUD_Amount.Location = new Point(307, 491);
            nUD_Amount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nUD_Amount.Name = "nUD_Amount";
            nUD_Amount.Size = new Size(213, 27);
            nUD_Amount.TabIndex = 16;
            // 
            // cb_AccountNum
            // 
            cb_AccountNum.FormattingEnabled = true;
            cb_AccountNum.Location = new Point(575, 491);
            cb_AccountNum.Name = "cb_AccountNum";
            cb_AccountNum.Size = new Size(194, 28);
            cb_AccountNum.TabIndex = 15;
            // 
            // cb_TrasType
            // 
            cb_TrasType.FormattingEnabled = true;
            cb_TrasType.Location = new Point(44, 491);
            cb_TrasType.Name = "cb_TrasType";
            cb_TrasType.Size = new Size(190, 28);
            cb_TrasType.TabIndex = 14;
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
            btn_Add.Location = new Point(108, 560);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(144, 39);
            btn_Add.TabIndex = 20;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.DarkGreen;
            btn_Update.Cursor = Cursors.Hand;
            btn_Update.FlatAppearance.BorderColor = Color.Green;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Update.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(298, 562);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(139, 37);
            btn_Update.TabIndex = 21;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DarkGreen;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatAppearance.BorderColor = Color.Green;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(483, 562);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(134, 37);
            btn_delete.TabIndex = 22;
            btn_delete.Text = "Cancel";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // lbl_Transactions
            // 
            lbl_Transactions.AutoSize = true;
            lbl_Transactions.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            lbl_Transactions.ForeColor = Color.DarkGreen;
            lbl_Transactions.Location = new Point(37, 35);
            lbl_Transactions.Name = "lbl_Transactions";
            lbl_Transactions.Size = new Size(161, 28);
            lbl_Transactions.TabIndex = 23;
            lbl_Transactions.Text = "Transactions";
            // 
            // lbl_TransactionType
            // 
            lbl_TransactionType.AutoSize = true;
            lbl_TransactionType.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_TransactionType.ForeColor = Color.DarkGreen;
            lbl_TransactionType.Location = new Point(44, 441);
            lbl_TransactionType.Name = "lbl_TransactionType";
            lbl_TransactionType.Size = new Size(165, 22);
            lbl_TransactionType.TabIndex = 24;
            lbl_TransactionType.Text = "Transaction Type";
            // 
            // lbl_Amount
            // 
            lbl_Amount.AutoSize = true;
            lbl_Amount.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_Amount.ForeColor = Color.DarkGreen;
            lbl_Amount.Location = new Point(307, 441);
            lbl_Amount.Name = "lbl_Amount";
            lbl_Amount.Size = new Size(81, 22);
            lbl_Amount.TabIndex = 25;
            lbl_Amount.Text = "Amount";
            // 
            // lbl_AccNumber
            // 
            lbl_AccNumber.AutoSize = true;
            lbl_AccNumber.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_AccNumber.ForeColor = Color.DarkGreen;
            lbl_AccNumber.Location = new Point(554, 441);
            lbl_AccNumber.Name = "lbl_AccNumber";
            lbl_AccNumber.Size = new Size(162, 22);
            lbl_AccNumber.TabIndex = 26;
            lbl_AccNumber.Text = "Account Number";
            // 
            // AccountManger_TransactionsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbl_AccNumber);
            Controls.Add(lbl_Amount);
            Controls.Add(lbl_TransactionType);
            Controls.Add(lbl_Transactions);
            Controls.Add(btn_delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Controls.Add(btn_Search);
            Controls.Add(txt_AccountNumber);
            Controls.Add(dgv_Transactions);
            Controls.Add(nUD_Amount);
            Controls.Add(cb_AccountNum);
            Controls.Add(cb_TrasType);
            Name = "AccountManger_TransactionsUserControl";
            Size = new Size(857, 619);
            ((System.ComponentModel.ISupportInitialize)dgv_Transactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Amount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Search;
        private TextBox txt_AccountNumber;
        private DataGridView dgv_Transactions;
        private NumericUpDown nUD_Amount;
        private ComboBox cb_AccountNum;
        private ComboBox cb_TrasType;
        private Button btn_Add;
        private Button btn_Update;
        private Button btn_delete;
        private Label lbl_Transactions;
        private Label lbl_TransactionType;
        private Label lbl_Amount;
        private Label lbl_AccNumber;
    }
}
