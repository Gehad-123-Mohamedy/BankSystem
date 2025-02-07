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
    public partial class Customer_Register : Form
    {
        Complete_Bank_SystemContext context;
        public Customer_Register()
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "" || txt_Password.Text == "" || txt_PhoneNumber.Text == "" || txt_Email.Text == "" || txt_CNN.Text == "" || txt_Address.Text == "" || DateBicker_BirthDate.Value == null)
            {
                MessageBox.Show("All fields are required", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer customer = new Customer();
            customer.FullName = txt_Name.Text;
            customer.Email = txt_Email.Text;
            customer.Password = txt_Password.Text;
            customer.Address = txt_Address.Text;
            customer.PhoneNumber = txt_PhoneNumber.Text;
            customer.CNN = txt_CNN.Text;
            customer.BirthDate = DateOnly.FromDateTime(DateBicker_BirthDate.Value);

            try
            {
                context.Add(customer);
                context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Register", USerId = customer.CustomerId, UserType = "Customer", Desc = $"{customer.FullName} Registered" });
                context.SaveChanges();
                MessageBox.Show("Customer Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Address.Text = txt_CNN.Text = txt_Email.Text = txt_Password.Text = txt_PhoneNumber.Text = txt_Name.Text = " ";
                DateBicker_BirthDate.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ReturnToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

