namespace Complete_Bank_System
{
    partial class EmployeeUserControl
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
            dgv_Employee = new DataGridView();
            panel1 = new Panel();
            cb_JobTitle = new ComboBox();
            nUD_Salary = new NumericUpDown();
            btn_delete = new Button();
            btn_Reset = new Button();
            btn_Update = new Button();
            btn_Add = new Button();
            txt_ConfirmPass = new TextBox();
            lbl_confirmPass = new Label();
            txt_Password = new TextBox();
            lbl_Password = new Label();
            DateBicker_HireDate = new DateTimePicker();
            lbl_HireDate = new Label();
            txt_Name = new TextBox();
            lbl_Salary = new Label();
            lbl_JobTitle = new Label();
            lbl_name = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Employee).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Salary).BeginInit();
            SuspendLayout();
            // 
            // dgv_Employee
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Control;
            dataGridViewCellStyle13.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgv_Employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgv_Employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgv_Employee.DefaultCellStyle = dataGridViewCellStyle14;
            dgv_Employee.Location = new Point(43, 60);
            dgv_Employee.Name = "dgv_Employee";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgv_Employee.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgv_Employee.RowHeadersWidth = 51;
            dgv_Employee.Size = new Size(767, 188);
            dgv_Employee.TabIndex = 0;
            dgv_Employee.RowHeaderMouseDoubleClick += dgv_Employee_RowHeaderMouseDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(cb_JobTitle);
            panel1.Controls.Add(nUD_Salary);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_Reset);
            panel1.Controls.Add(btn_Update);
            panel1.Controls.Add(btn_Add);
            panel1.Controls.Add(txt_ConfirmPass);
            panel1.Controls.Add(lbl_confirmPass);
            panel1.Controls.Add(txt_Password);
            panel1.Controls.Add(lbl_Password);
            panel1.Controls.Add(DateBicker_HireDate);
            panel1.Controls.Add(lbl_HireDate);
            panel1.Controls.Add(txt_Name);
            panel1.Controls.Add(lbl_Salary);
            panel1.Controls.Add(lbl_JobTitle);
            panel1.Controls.Add(lbl_name);
            panel1.Location = new Point(3, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(851, 344);
            panel1.TabIndex = 2;
            // 
            // cb_JobTitle
            // 
            cb_JobTitle.FormattingEnabled = true;
            cb_JobTitle.Location = new Point(144, 133);
            cb_JobTitle.Name = "cb_JobTitle";
            cb_JobTitle.Size = new Size(252, 28);
            cb_JobTitle.TabIndex = 31;
            // 
            // nUD_Salary
            // 
            nUD_Salary.Location = new Point(582, 131);
            nUD_Salary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nUD_Salary.Name = "nUD_Salary";
            nUD_Salary.Size = new Size(252, 27);
            nUD_Salary.TabIndex = 30;
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
            btn_delete.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(438, 276);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(130, 29);
            btn_delete.TabIndex = 29;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
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
            btn_Reset.Location = new Point(610, 277);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(110, 29);
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
            btn_Update.Location = new Point(283, 276);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(118, 29);
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
            btn_Add.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(131, 276);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(115, 29);
            btn_Add.TabIndex = 26;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_ConfirmPass
            // 
            txt_ConfirmPass.Location = new Point(582, 192);
            txt_ConfirmPass.Name = "txt_ConfirmPass";
            txt_ConfirmPass.Size = new Size(252, 27);
            txt_ConfirmPass.TabIndex = 25;
            // 
            // lbl_confirmPass
            // 
            lbl_confirmPass.AutoSize = true;
            lbl_confirmPass.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_confirmPass.ForeColor = Color.DarkGreen;
            lbl_confirmPass.Location = new Point(402, 193);
            lbl_confirmPass.Name = "lbl_confirmPass";
            lbl_confirmPass.Size = new Size(174, 22);
            lbl_confirmPass.TabIndex = 24;
            lbl_confirmPass.Text = "Confirm Password";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(144, 195);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(252, 27);
            txt_Password.TabIndex = 23;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_Password.ForeColor = Color.DarkGreen;
            lbl_Password.Location = new Point(20, 195);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(97, 22);
            lbl_Password.TabIndex = 22;
            lbl_Password.Text = "Password";
            // 
            // DateBicker_HireDate
            // 
            DateBicker_HireDate.Location = new Point(582, 65);
            DateBicker_HireDate.Name = "DateBicker_HireDate";
            DateBicker_HireDate.Size = new Size(252, 27);
            DateBicker_HireDate.TabIndex = 19;
            // 
            // lbl_HireDate
            // 
            lbl_HireDate.AutoSize = true;
            lbl_HireDate.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_HireDate.ForeColor = Color.DarkGreen;
            lbl_HireDate.Location = new Point(423, 68);
            lbl_HireDate.Name = "lbl_HireDate";
            lbl_HireDate.Size = new Size(91, 22);
            lbl_HireDate.TabIndex = 16;
            lbl_HireDate.Text = "HireDate";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(144, 68);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(252, 27);
            txt_Name.TabIndex = 13;
            // 
            // lbl_Salary
            // 
            lbl_Salary.AutoSize = true;
            lbl_Salary.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_Salary.ForeColor = Color.DarkGreen;
            lbl_Salary.Location = new Point(433, 131);
            lbl_Salary.Name = "lbl_Salary";
            lbl_Salary.Size = new Size(66, 22);
            lbl_Salary.TabIndex = 12;
            lbl_Salary.Text = "Salary";
            // 
            // lbl_JobTitle
            // 
            lbl_JobTitle.AutoSize = true;
            lbl_JobTitle.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_JobTitle.ForeColor = Color.DarkGreen;
            lbl_JobTitle.Location = new Point(20, 136);
            lbl_JobTitle.Name = "lbl_JobTitle";
            lbl_JobTitle.Size = new Size(85, 22);
            lbl_JobTitle.TabIndex = 11;
            lbl_JobTitle.Text = "Job Title";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lbl_name.ForeColor = Color.DarkGreen;
            lbl_name.Location = new Point(11, 73);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(100, 22);
            lbl_name.TabIndex = 10;
            lbl_name.Text = "Full Name";
            // 
            // EmployeeUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(dgv_Employee);
            Name = "EmployeeUserControl";
            Size = new Size(857, 619);
            Load += EmployeeUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Employee).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_Salary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Employee;
        private Panel panel1;
        private Button btn_delete;
        private Button btn_Reset;
        private Button btn_Update;
        private Button btn_Add;
        private TextBox txt_ConfirmPass;
        private Label lbl_confirmPass;
        private TextBox txt_Password;
        private Label lbl_Password;
        private DateTimePicker DateBicker_HireDate;
        private Label lbl_HireDate;
        private TextBox txt_Name;
        private Label lbl_Salary;
        private Label lbl_JobTitle;
        private Label lbl_name;
        private ComboBox cb_JobTitle;
        private NumericUpDown nUD_Salary;
    }
}
