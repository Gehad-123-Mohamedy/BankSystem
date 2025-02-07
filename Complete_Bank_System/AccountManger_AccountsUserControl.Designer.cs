namespace Complete_Bank_System
{
    partial class AccountManger_AccountsUserControl
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
            dgv_Accounts = new DataGridView();
            txt_CustomerId = new TextBox();
            btn_Search = new Button();
            txt_AccNumber = new TextBox();
            label1 = new Label();
            nUD_Balance = new NumericUpDown();
            cb_AccTypes = new ComboBox();
            lbl_Balance = new Label();
            lbl_AccountType = new Label();
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_Add = new Button();
            lbl_Customer = new Label();
            cb_Customers = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Accounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Balance).BeginInit();
            SuspendLayout();
            // 
            // dgv_Accounts
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgv_Accounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgv_Accounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgv_Accounts.DefaultCellStyle = dataGridViewCellStyle11;
            dgv_Accounts.Location = new Point(52, 163);
            dgv_Accounts.Name = "dgv_Accounts";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgv_Accounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgv_Accounts.RowHeadersWidth = 51;
            dgv_Accounts.Size = new Size(769, 190);
            dgv_Accounts.TabIndex = 0;
            dgv_Accounts.RowHeaderMouseDoubleClick += dgv_Accounts_RowHeaderMouseDoubleClick;
            // 
            // txt_CustomerId
            // 
            txt_CustomerId.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txt_CustomerId.ForeColor = Color.Green;
            txt_CustomerId.Location = new Point(111, 98);
            txt_CustomerId.Name = "txt_CustomerId";
            txt_CustomerId.Size = new Size(385, 31);
            txt_CustomerId.TabIndex = 1;
            txt_CustomerId.TextChanged += txt_CustomerId_TextChanged;
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
            btn_Search.Location = new Point(551, 92);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(245, 37);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_AccNumber
            // 
            txt_AccNumber.Location = new Point(289, 452);
            txt_AccNumber.Name = "txt_AccNumber";
            txt_AccNumber.Size = new Size(224, 27);
            txt_AccNumber.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(312, 410);
            label1.Name = "label1";
            label1.Size = new Size(162, 22);
            label1.TabIndex = 25;
            label1.Text = "Account Number";
            // 
            // nUD_Balance
            // 
            nUD_Balance.Location = new Point(551, 451);
            nUD_Balance.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nUD_Balance.Name = "nUD_Balance";
            nUD_Balance.Size = new Size(197, 27);
            nUD_Balance.TabIndex = 24;
            // 
            // cb_AccTypes
            // 
            cb_AccTypes.FormattingEnabled = true;
            cb_AccTypes.Location = new Point(61, 451);
            cb_AccTypes.Name = "cb_AccTypes";
            cb_AccTypes.Size = new Size(197, 28);
            cb_AccTypes.TabIndex = 23;
            // 
            // lbl_Balance
            // 
            lbl_Balance.AutoSize = true;
            lbl_Balance.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_Balance.ForeColor = Color.DarkGreen;
            lbl_Balance.Location = new Point(551, 410);
            lbl_Balance.Name = "lbl_Balance";
            lbl_Balance.Size = new Size(82, 22);
            lbl_Balance.TabIndex = 22;
            lbl_Balance.Text = "Balance";
            // 
            // lbl_AccountType
            // 
            lbl_AccountType.AutoSize = true;
            lbl_AccountType.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_AccountType.ForeColor = Color.DarkGreen;
            lbl_AccountType.Location = new Point(52, 410);
            lbl_AccountType.Name = "lbl_AccountType";
            lbl_AccountType.Size = new Size(132, 22);
            lbl_AccountType.TabIndex = 21;
            lbl_AccountType.Text = "Account Type";
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.DarkGreen;
            btn_Delete.Cursor = Cursors.Hand;
            btn_Delete.FlatAppearance.BorderColor = Color.Green;
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(647, 542);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(140, 39);
            btn_Delete.TabIndex = 29;
            btn_Delete.Text = "Cancel Account";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
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
            btn_Update.Location = new Point(484, 541);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(134, 40);
            btn_Update.TabIndex = 28;
            btn_Update.Text = "Edit ";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
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
            btn_Add.Location = new Point(312, 542);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(139, 39);
            btn_Add.TabIndex = 27;
            btn_Add.Text = "Add ";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // lbl_Customer
            // 
            lbl_Customer.AutoSize = true;
            lbl_Customer.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_Customer.ForeColor = Color.DarkGreen;
            lbl_Customer.Location = new Point(52, 508);
            lbl_Customer.Name = "lbl_Customer";
            lbl_Customer.Size = new Size(97, 22);
            lbl_Customer.TabIndex = 30;
            lbl_Customer.Text = "Customer";
            // 
            // cb_Customers
            // 
            cb_Customers.FormattingEnabled = true;
            cb_Customers.Location = new Point(52, 542);
            cb_Customers.Name = "cb_Customers";
            cb_Customers.Size = new Size(197, 28);
            cb_Customers.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(52, 34);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 32;
            label2.Text = "Accounts";
            // 
            // AccountManger_AccountsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(cb_Customers);
            Controls.Add(lbl_Customer);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Controls.Add(txt_AccNumber);
            Controls.Add(label1);
            Controls.Add(nUD_Balance);
            Controls.Add(cb_AccTypes);
            Controls.Add(lbl_Balance);
            Controls.Add(lbl_AccountType);
            Controls.Add(btn_Search);
            Controls.Add(txt_CustomerId);
            Controls.Add(dgv_Accounts);
            Name = "AccountManger_AccountsUserControl";
            Size = new Size(857, 619);
            Load += AccountManger_AccountsUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Accounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Balance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Accounts;
        private TextBox txt_CustomerId;
        private Button btn_Search;
        private TextBox txt_AccNumber;
        private Label label1;
        private NumericUpDown nUD_Balance;
        private ComboBox cb_AccTypes;
        private Label lbl_Balance;
        private Label lbl_AccountType;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Add;
        private Label lbl_Customer;
        private ComboBox cb_Customers;
        private Label label2;
    }
}
