namespace Complete_Bank_System
{
    partial class Customer_Accounts
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
            DGV_Accounts = new DataGridView();
            lbl_AccountType = new Label();
            lbl_Balance = new Label();
            cb_AccTypes = new ComboBox();
            nUD_Balance = new NumericUpDown();
            btn_Add = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_ReturnToHome = new Button();
            label1 = new Label();
            txt_AccNumber = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_Accounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Balance).BeginInit();
            SuspendLayout();
            // 
            // DGV_Accounts
            // 
            DGV_Accounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGV_Accounts.DefaultCellStyle = dataGridViewCellStyle1;
            DGV_Accounts.Location = new Point(113, 341);
            DGV_Accounts.Name = "DGV_Accounts";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_Accounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_Accounts.RowHeadersWidth = 51;
            DGV_Accounts.Size = new Size(944, 229);
            DGV_Accounts.TabIndex = 0;
            DGV_Accounts.RowHeaderMouseDoubleClick += DGV_Accounts_RowHeaderMouseDoubleClick;
            // 
            // lbl_AccountType
            // 
            lbl_AccountType.AutoSize = true;
            lbl_AccountType.BackColor = Color.White;
            lbl_AccountType.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_AccountType.ForeColor = Color.DarkGreen;
            lbl_AccountType.Location = new Point(139, 133);
            lbl_AccountType.Name = "lbl_AccountType";
            lbl_AccountType.Size = new Size(147, 24);
            lbl_AccountType.TabIndex = 1;
            lbl_AccountType.Text = "Account Type";
            // 
            // lbl_Balance
            // 
            lbl_Balance.AutoSize = true;
            lbl_Balance.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lbl_Balance.ForeColor = Color.DarkGreen;
            lbl_Balance.Location = new Point(423, 133);
            lbl_Balance.Name = "lbl_Balance";
            lbl_Balance.Size = new Size(90, 24);
            lbl_Balance.TabIndex = 2;
            lbl_Balance.Text = "Balance";
            // 
            // cb_AccTypes
            // 
            cb_AccTypes.ForeColor = Color.Green;
            cb_AccTypes.FormattingEnabled = true;
            cb_AccTypes.Location = new Point(131, 187);
            cb_AccTypes.Name = "cb_AccTypes";
            cb_AccTypes.Size = new Size(249, 28);
            cb_AccTypes.TabIndex = 4;
            // 
            // nUD_Balance
            // 
            nUD_Balance.ForeColor = Color.Green;
            nUD_Balance.Location = new Point(423, 187);
            nUD_Balance.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            nUD_Balance.Name = "nUD_Balance";
            nUD_Balance.Size = new Size(249, 27);
            nUD_Balance.TabIndex = 5;
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
            btn_Add.Location = new Point(162, 268);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(189, 37);
            btn_Add.TabIndex = 7;
            btn_Add.Text = "Add ";
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
            btn_Update.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(394, 268);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(189, 37);
            btn_Update.TabIndex = 8;
            btn_Update.Text = "Edit ";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.DarkGreen;
            btn_Delete.Cursor = Cursors.Hand;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(617, 268);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(189, 37);
            btn_Delete.TabIndex = 9;
            btn_Delete.Text = "Cancel ";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
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
            btn_ReturnToHome.Location = new Point(842, 268);
            btn_ReturnToHome.Name = "btn_ReturnToHome";
            btn_ReturnToHome.Size = new Size(189, 37);
            btn_ReturnToHome.TabIndex = 18;
            btn_ReturnToHome.Text = " Home";
            btn_ReturnToHome.UseVisualStyleBackColor = false;
            btn_ReturnToHome.Click += btn_ReturnToHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(729, 133);
            label1.Name = "label1";
            label1.Size = new Size(179, 24);
            label1.TabIndex = 19;
            label1.Text = "Account Number";
            // 
            // txt_AccNumber
            // 
            txt_AccNumber.ForeColor = Color.Green;
            txt_AccNumber.Location = new Point(729, 186);
            txt_AccNumber.Name = "txt_AccNumber";
            txt_AccNumber.Size = new Size(249, 27);
            txt_AccNumber.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(79, 582);
            panel1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(394, 19);
            label2.Name = "label2";
            label2.Size = new Size(281, 34);
            label2.TabIndex = 22;
            label2.Text = "New Account Form";
            // 
            // exit
            // 
            exit.BackColor = Color.DarkGreen;
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(1104, 0);
            exit.Name = "exit";
            exit.Size = new Size(29, 34);
            exit.TabIndex = 23;
            exit.Text = "X";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // Customer_Accounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1132, 582);
            Controls.Add(exit);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(txt_AccNumber);
            Controls.Add(label1);
            Controls.Add(btn_ReturnToHome);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Add);
            Controls.Add(nUD_Balance);
            Controls.Add(cb_AccTypes);
            Controls.Add(lbl_Balance);
            Controls.Add(lbl_AccountType);
            Controls.Add(DGV_Accounts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer_Accounts";
            Text = "Accounts";
            Load += Accounts_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Accounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Balance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_Accounts;
        private Label lbl_AccountType;
        private Label lbl_Balance;
        private ComboBox cb_AccTypes;
        private NumericUpDown nUD_Balance;
        private Button btn_Add;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_ReturnToHome;
        private Label label1;
        private TextBox txt_AccNumber;
        private Panel panel1;
        private Label label2;
        private Button exit;
    }
}