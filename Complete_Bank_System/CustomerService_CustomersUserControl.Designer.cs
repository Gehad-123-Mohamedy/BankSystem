namespace Complete_Bank_System
{
    partial class CustomerService_CustomersUserControl
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
            dgv_Customers = new DataGridView();
            panel1 = new Panel();
            btn_Reset = new Button();
            btn_Update = new Button();
            btn_Add = new Button();
            txt_ConfirmPass = new TextBox();
            lbl_confirmPass = new Label();
            txt_Password = new TextBox();
            lbl_Password = new Label();
            txt_CNN = new TextBox();
            txt_PhoneNumber = new TextBox();
            DateBicker_BirthDate = new DateTimePicker();
            lbl_CNN = new Label();
            lbl_PhoneNumber = new Label();
            lbl_BirthDate = new Label();
            txt_Email = new TextBox();
            txt_Address = new TextBox();
            txt_Name = new TextBox();
            lbl_Email = new Label();
            lbl_Address = new Label();
            lbl_name = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Customers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Customers
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Customers.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Customers.Location = new Point(57, 61);
            dgv_Customers.Name = "dgv_Customers";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Customers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Customers.RowHeadersWidth = 51;
            dgv_Customers.Size = new Size(710, 195);
            dgv_Customers.TabIndex = 0;
            dgv_Customers.RowHeaderMouseClick += dgv_Customers_RowHeaderMouseClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Reset);
            panel1.Controls.Add(btn_Update);
            panel1.Controls.Add(btn_Add);
            panel1.Controls.Add(txt_ConfirmPass);
            panel1.Controls.Add(lbl_confirmPass);
            panel1.Controls.Add(txt_Password);
            panel1.Controls.Add(lbl_Password);
            panel1.Controls.Add(txt_CNN);
            panel1.Controls.Add(txt_PhoneNumber);
            panel1.Controls.Add(DateBicker_BirthDate);
            panel1.Controls.Add(lbl_CNN);
            panel1.Controls.Add(lbl_PhoneNumber);
            panel1.Controls.Add(lbl_BirthDate);
            panel1.Controls.Add(txt_Email);
            panel1.Controls.Add(txt_Address);
            panel1.Controls.Add(txt_Name);
            panel1.Controls.Add(lbl_Email);
            panel1.Controls.Add(lbl_Address);
            panel1.Controls.Add(lbl_name);
            panel1.Location = new Point(3, 294);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 321);
            panel1.TabIndex = 1;
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = Color.DarkGreen;
            btn_Reset.Cursor = Cursors.Hand;
            btn_Reset.FlatAppearance.BorderColor = Color.Green;
            btn_Reset.FlatAppearance.BorderSize = 0;
            btn_Reset.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btn_Reset.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btn_Reset.FlatStyle = FlatStyle.Flat;
            btn_Reset.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btn_Reset.ForeColor = Color.White;
            btn_Reset.Location = new Point(465, 274);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(100, 29);
            btn_Reset.TabIndex = 28;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = false;
            btn_Reset.Click += btn_Reset_Click;
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
            btn_Update.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(311, 274);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(110, 29);
            btn_Update.TabIndex = 27;
            btn_Update.Text = "Update";
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
            btn_Add.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(133, 274);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(120, 29);
            btn_Add.TabIndex = 26;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_ConfirmPass
            // 
            txt_ConfirmPass.Location = new Point(584, 195);
            txt_ConfirmPass.Name = "txt_ConfirmPass";
            txt_ConfirmPass.Size = new Size(252, 27);
            txt_ConfirmPass.TabIndex = 25;
            // 
            // lbl_confirmPass
            // 
            lbl_confirmPass.AutoSize = true;
            lbl_confirmPass.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_confirmPass.ForeColor = Color.DarkGreen;
            lbl_confirmPass.Location = new Point(391, 200);
            lbl_confirmPass.Name = "lbl_confirmPass";
            lbl_confirmPass.Size = new Size(174, 22);
            lbl_confirmPass.TabIndex = 24;
            lbl_confirmPass.Text = "Confirm Password";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(133, 204);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(252, 27);
            txt_Password.TabIndex = 23;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_Password.ForeColor = Color.DarkGreen;
            lbl_Password.Location = new Point(9, 204);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(97, 22);
            lbl_Password.TabIndex = 22;
            lbl_Password.Text = "Password";
            // 
            // txt_CNN
            // 
            txt_CNN.Location = new Point(584, 148);
            txt_CNN.Name = "txt_CNN";
            txt_CNN.Size = new Size(252, 27);
            txt_CNN.TabIndex = 21;
            // 
            // txt_PhoneNumber
            // 
            txt_PhoneNumber.Location = new Point(584, 98);
            txt_PhoneNumber.Name = "txt_PhoneNumber";
            txt_PhoneNumber.Size = new Size(252, 27);
            txt_PhoneNumber.TabIndex = 20;
            // 
            // DateBicker_BirthDate
            // 
            DateBicker_BirthDate.Location = new Point(584, 46);
            DateBicker_BirthDate.Name = "DateBicker_BirthDate";
            DateBicker_BirthDate.Size = new Size(252, 27);
            DateBicker_BirthDate.TabIndex = 19;
            // 
            // lbl_CNN
            // 
            lbl_CNN.AutoSize = true;
            lbl_CNN.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_CNN.ForeColor = Color.DarkGreen;
            lbl_CNN.Location = new Point(425, 155);
            lbl_CNN.Name = "lbl_CNN";
            lbl_CNN.Size = new Size(50, 22);
            lbl_CNN.TabIndex = 18;
            lbl_CNN.Text = "CNN";
            // 
            // lbl_PhoneNumber
            // 
            lbl_PhoneNumber.AutoSize = true;
            lbl_PhoneNumber.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_PhoneNumber.ForeColor = Color.DarkGreen;
            lbl_PhoneNumber.Location = new Point(418, 104);
            lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            lbl_PhoneNumber.Size = new Size(141, 22);
            lbl_PhoneNumber.TabIndex = 17;
            lbl_PhoneNumber.Text = "PhoneNumber";
            // 
            // lbl_BirthDate
            // 
            lbl_BirthDate.AutoSize = true;
            lbl_BirthDate.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_BirthDate.ForeColor = Color.DarkGreen;
            lbl_BirthDate.Location = new Point(425, 49);
            lbl_BirthDate.Name = "lbl_BirthDate";
            lbl_BirthDate.Size = new Size(97, 22);
            lbl_BirthDate.TabIndex = 16;
            lbl_BirthDate.Text = "BirthDate";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(133, 148);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(252, 27);
            txt_Email.TabIndex = 15;
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(133, 94);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(252, 27);
            txt_Address.TabIndex = 14;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(133, 48);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(252, 27);
            txt_Name.TabIndex = 13;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Email.ForeColor = Color.DarkGreen;
            lbl_Email.Location = new Point(9, 154);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(59, 22);
            lbl_Email.TabIndex = 12;
            lbl_Email.Text = "Email";
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Address.ForeColor = Color.DarkGreen;
            lbl_Address.Location = new Point(9, 99);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(81, 22);
            lbl_Address.TabIndex = 11;
            lbl_Address.Text = "Address";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.ForeColor = Color.DarkGreen;
            lbl_name.Location = new Point(9, 49);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(100, 22);
            lbl_name.TabIndex = 10;
            lbl_name.Text = "Full Name";
            // 
            // CustomerService_CustomersUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(dgv_Customers);
            Name = "CustomerService_CustomersUserControl";
            Size = new Size(857, 619);
            Load += CustomerUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Customers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Customers;
        private Panel panel1;
        private TextBox txt_Email;
        private TextBox txt_Address;
        private TextBox txt_Name;
        private Label lbl_Email;
        private Label lbl_Address;
        private Label lbl_name;
        private TextBox txt_CNN;
        private TextBox txt_PhoneNumber;
        private DateTimePicker DateBicker_BirthDate;
        private Label lbl_CNN;
        private Label lbl_PhoneNumber;
        private Label lbl_BirthDate;
        private TextBox txt_ConfirmPass;
        private Label lbl_confirmPass;
        private TextBox txt_Password;
        private Label lbl_Password;
        private Button btn_Reset;
        private Button btn_Update;
        private Button btn_Add;
    }
}
