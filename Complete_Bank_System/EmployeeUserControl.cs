using Complete_Bank_System.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complete_Bank_System
{
    public partial class EmployeeUserControl : UserControl
    {
        static IDbConnection connection;
        public EmployeeUserControl()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=.\\SQLexpress ;Database=Bank;Trusted_Connection = True;Trust Server Certificate=True");
        }


        private void EmployeeUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
            btn_delete.Visible = false;
            btn_Update.Visible = false;
        }
        private void LoadData()
        {
            dgv_Employee.DataSource = connection.Query<Employee>("Select * from employees").ToList();
            cb_JobTitle.Items.Add("Account Manager");
            cb_JobTitle.Items.Add("Customer Service");
            cb_JobTitle.Items.Add("Loan Officer");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "" || txt_Password.Text == "" || nUD_Salary.Value == 0 || DateBicker_HireDate.Value == null || cb_JobTitle.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_ConfirmPass.Text == "")
            {
                txt_ConfirmPass.PlaceholderText = "This field is Required";
                return;
            }
            if (txt_Password.Text != txt_ConfirmPass.Text)
            {
                MessageBox.Show("Passwords should match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int affectedRows = connection.Execute("insert into employees values(@Employee_Name,@JobTitle,@hireDate,@salary,@password)",
                new { Employee_Name = txt_Name.Text, JobTitle = cb_JobTitle.SelectedItem, hireDate = DateBicker_HireDate.Value, salary = nUD_Salary.Value, password = txt_Password.Text }
                );
            if (affectedRows > 0)
            {
                MessageBox.Show("Employee Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Success();

            }
        }
        private void Success()
        {

            LoadData();
            txt_Name.Text = " ";
            nUD_Salary.Value = 0;
            cb_JobTitle.SelectedValue = -1;

        }
        int Selected_EmpId;
        private void dgv_Employee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Selected_EmpId = (int)dgv_Employee.SelectedRows[0].Cells[0].Value;
            txt_Name.Text = dgv_Employee.SelectedRows[0].Cells["Employee_Name"].Value.ToString();
            nUD_Salary.Value = (decimal)dgv_Employee.SelectedRows[0].Cells["salary"].Value;
            cb_JobTitle.SelectedItem = dgv_Employee.SelectedRows[0].Cells["JobTitle"].Value.ToString();
            txt_Password.Text = dgv_Employee.SelectedRows[0].Cells["password"].Value.ToString();
            txt_ConfirmPass.Text = dgv_Employee.SelectedRows[0].Cells["password"].Value.ToString();
            DateBicker_HireDate.Value = (DateTime)dgv_Employee.SelectedRows[0].Cells["hireDate"].Value;
            btn_delete.Visible = true;
            btn_Update.Visible = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_ConfirmPass.Text == "")
            {
                txt_ConfirmPass.PlaceholderText = "This field is Required";
                return;
            }
            if (txt_Password.Text != txt_ConfirmPass.Text)
            {
                MessageBox.Show("Passwords should match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int affected_rows = connection.Execute("update employees set Employee_Name=@Employee_Name ,JobTitle=@JobTitle ,hireDate=@hireDate ,salary=@salary where Id=@Id",
               new { Employee_Name = txt_Name.Text, JobTitle = cb_JobTitle.SelectedItem, hireDate = DateBicker_HireDate.Value, salary = nUD_Salary.Value, Id = Selected_EmpId }
                );
            if (affected_rows > 0)
            {
                MessageBox.Show("Employee Info Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Success();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                int affected_rows = connection.Execute($"delete from employees where Id={Selected_EmpId}");
                if (affected_rows > 0)
                {
                    MessageBox.Show("Employee Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Success();
                }
            }
            else
            {
                MessageBox.Show("No employee was deleted, Please check if the ID is valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Name.Text = txt_Password.Text = txt_ConfirmPass.Text = "";
            nUD_Salary.Value = 0;
            cb_JobTitle.SelectedIndex = -1;
            DateBicker_HireDate.Value=DateTime.Now.Date;
        }
    }
}
