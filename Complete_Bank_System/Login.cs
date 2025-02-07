using Castle.Core.Resource;
using Complete_Bank_System.Models;
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
    public partial class Login : Form
    {
        int Customer_Id;
        Complete_Bank_SystemContext context;
        public Login()
        {
            InitializeComponent();
            HideCustomerComponent();
            context = new Complete_Bank_SystemContext();
        }
        private void HideCustomerComponent()
        {
            btn_Register.Visible = false;
            lbl_tocreateAcc.Visible = false;
        }
        private void ShowCustomerComponents()
        {
            lbl_tocreateAcc.Visible = true;
            btn_Register.Visible = true;
            lbl_tocreateAcc.Text = "Create An Account";
        }
        private void loadData()
        {
            cb_Roles.Items.Add("Customer");
            cb_Roles.Items.Add("Employee");

        }
        private void Login_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cb_Roles.Text) || txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please Enter a valid userName and password", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cb_Roles.SelectedItem == "Customer")
            {
                try
                {
                    var u = context.customers.Where(c => c.FullName == txt_UserName.Text && c.Password == txt_Password.Text).SingleOrDefault();
                    if (u != null)
                    {
                        MessageBox.Show("Valid Login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Customer_Id = u.CustomerId;
                        HideCustomerComponent();
                        CustomerDashBoard c = new CustomerDashBoard(Customer_Id);
                        this.Hide();
                        c.Show();
                        LogUserAction(u.CustomerId, "Customer", u.FullName);
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserName or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ShowCustomerComponents();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }
            if (cb_Roles.SelectedItem == "Employee")
            {
                try
                {
                    var emp = context.employees.Where(c => c.Employee_Name == txt_UserName.Text && c.password == txt_Password.Text).SingleOrDefault();
                    if (emp != null)
                    {
                        if (emp.JobTitle == "Admin")
                        {
                            AdminDashboard adminDashBoard = new AdminDashboard(emp.Id);
                            this.Hide();
                            adminDashBoard.Show();
                        }
                        else if (emp.JobTitle == "Customer Service")
                        {
                            CustomerServiceDashBoard customerService = new CustomerServiceDashBoard(emp.Id);
                            this.Hide();
                            customerService.Show();

                        }
                        else if (emp.JobTitle == "Account Manager")
                        {
                            AccountMangerDashBoard accountManger = new AccountMangerDashBoard(emp.Id);
                            this.Hide();
                            accountManger.Show();
                        }
                        else if (emp.JobTitle == "Loan Officer")
                        {
                            LoanOfficerDashBoard loanOfficer = new LoanOfficerDashBoard(emp.Id);
                            this.Hide();
                            loanOfficer.Show();

                        }
                        LogUserAction(emp.Id, emp.JobTitle, emp.Employee_Name);
                        context.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("Invalid UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Register register = new Customer_Register();
            register.Show();
        }

        private void LogUserAction(int userId, string userType, string userName)
        {
            context.audit_Logs.Add(new Audit_Logs
            {
                ActionDate = DateTime.Now,
                ActionType = "Login",
                USerId = userId,
                UserType = userType,
                Desc = $"{userName} logged in"
            });
            context.SaveChanges();
        }
        private void cb_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Roles.SelectedItem.ToString() == "Employee")
            {
                HideCustomerComponent();
            }
            else if (cb_Roles.SelectedItem.ToString() == "Customer")
            {
                HideCustomerComponent();
            }
        }

        private void chkb_password_CheckedChanged(object sender, EventArgs e)
        {
            if (chkb_password.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
                txt_Password.UseSystemPasswordChar = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



