namespace Complete_Bank_System
{
    partial class CustomerService_AccountsUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            txt_CustomerID = new TextBox();
            btn_Search = new Button();
            dgv_Accounts = new DataGridView();
            lbl_AccountType = new Label();
            lbl_AccountBalance = new Label();
            cb_Accounts = new ComboBox();
            nUD_Balance = new NumericUpDown();
            btn_Update = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Accounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Balance).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(55, 34);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 0;
            label1.Text = "Accounts";
            // 
            // txt_CustomerID
            // 
            txt_CustomerID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_CustomerID.ForeColor = Color.Green;
            txt_CustomerID.Location = new Point(90, 114);
            txt_CustomerID.Name = "txt_CustomerID";
            txt_CustomerID.Size = new Size(385, 31);
            txt_CustomerID.TabIndex = 1;
            txt_CustomerID.TextChanged += txt_CustomerId_TextChanged;
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
            btn_Search.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Search.ForeColor = Color.White;
            btn_Search.Location = new Point(539, 105);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(259, 41);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // dgv_Accounts
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Accounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Accounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Accounts.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Accounts.Location = new Point(34, 216);
            dgv_Accounts.Name = "dgv_Accounts";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_Accounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_Accounts.RowHeadersWidth = 51;
            dgv_Accounts.Size = new Size(764, 227);
            dgv_Accounts.TabIndex = 3;
            dgv_Accounts.RowHeaderMouseDoubleClick += dgv_Accounts_RowHeaderMouseDoubleClick;
            // 
            // lbl_AccountType
            // 
            lbl_AccountType.AutoSize = true;
            lbl_AccountType.BackColor = Color.White;
            lbl_AccountType.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AccountType.ForeColor = Color.DarkGreen;
            lbl_AccountType.Location = new Point(55, 522);
            lbl_AccountType.Name = "lbl_AccountType";
            lbl_AccountType.Size = new Size(132, 22);
            lbl_AccountType.TabIndex = 4;
            lbl_AccountType.Text = "Account Type";
            // 
            // lbl_AccountBalance
            // 
            lbl_AccountBalance.AutoSize = true;
            lbl_AccountBalance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_AccountBalance.ForeColor = Color.DarkGreen;
            lbl_AccountBalance.Location = new Point(298, 522);
            lbl_AccountBalance.Name = "lbl_AccountBalance";
            lbl_AccountBalance.Size = new Size(161, 22);
            lbl_AccountBalance.TabIndex = 5;
            lbl_AccountBalance.Text = "Account Balance";
            // 
            // cb_Accounts
            // 
            cb_Accounts.FormattingEnabled = true;
            cb_Accounts.Location = new Point(34, 562);
            cb_Accounts.Name = "cb_Accounts";
            cb_Accounts.Size = new Size(196, 28);
            cb_Accounts.TabIndex = 6;
            // 
            // nUD_Balance
            // 
            nUD_Balance.Location = new Point(298, 562);
            nUD_Balance.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nUD_Balance.Name = "nUD_Balance";
            nUD_Balance.Size = new Size(217, 27);
            nUD_Balance.TabIndex = 7;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.DarkGreen;
            btn_Update.FlatAppearance.BorderColor = Color.Green;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Update.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(593, 549);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(167, 41);
            btn_Update.TabIndex = 8;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // CustomerService_AccountsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_Update);
            Controls.Add(nUD_Balance);
            Controls.Add(cb_Accounts);
            Controls.Add(lbl_AccountBalance);
            Controls.Add(lbl_AccountType);
            Controls.Add(dgv_Accounts);
            Controls.Add(btn_Search);
            Controls.Add(txt_CustomerID);
            Controls.Add(label1);
            Name = "CustomerService_AccountsUserControl";
            Size = new Size(856, 618);
            ((System.ComponentModel.ISupportInitialize)dgv_Accounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Balance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_CustomerID;
        private Button btn_Search;
        private DataGridView dgv_Accounts;
        private Label lbl_AccountType;
        private Label lbl_AccountBalance;
        private ComboBox cb_Accounts;
        private NumericUpDown nUD_Balance;
        private Button btn_Update;
    }
}
