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
    public partial class CustomerService_CustomersUserControl : UserControl
    {
        Complete_Bank_SystemContext context;
        public CustomerService_CustomersUserControl()
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
            btn_Update.Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "" || txt_Password.Text == "" || txt_PhoneNumber.Text == "" || txt_Email.Text == "" || txt_CNN.Text == "" || txt_Address.Text == "" || DateBicker_BirthDate.Value == null)
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
                context.SaveChanges();

                MessageBox.Show("Customer added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadData()
        {
            var data = context.customers.Select(c=> new {c.CustomerId,c.FullName,c.CNN,c.Email,c.Address,c.BirthDate,c.Password,c.PhoneNumber}).ToList();
            dgv_Customers.DataSource = data;
            dgv_Customers.Columns[0].Visible = false;
        }
        private void CustomerUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Name.Text = txt_Email.Text = txt_Address.Text = txt_CNN.Text = txt_Password.Text = txt_PhoneNumber.Text = txt_ConfirmPass.Text = "";
            DateBicker_BirthDate.Value = DateTime.Now;
        }
        int Selected_CustomerId;
        Customer selected_Customer;
        private void dgv_Customers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_Update.Visible = true;
            Selected_CustomerId = (int)dgv_Customers.SelectedRows[0].Cells[0].Value;
            selected_Customer = context.customers.Where(c => c.CustomerId == Selected_CustomerId).FirstOrDefault();
            if (selected_Customer != null)
            {
                txt_Name.Text = selected_Customer.FullName;
                txt_Email.Text = selected_Customer.Email;
                txt_PhoneNumber.Text = selected_Customer.PhoneNumber;
                txt_Address.Text = selected_Customer.Address;
                txt_CNN.Text = selected_Customer.CNN;
                txt_Password.Text = selected_Customer.Password;
                txt_ConfirmPass.Text = selected_Customer.Password;
                DateBicker_BirthDate.Value = selected_Customer.BirthDate.ToDateTime(TimeOnly.MinValue);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            selected_Customer.FullName = txt_Name.Text;
            selected_Customer.Email = txt_Email.Text;
            selected_Customer.BirthDate = DateOnly.FromDateTime(DateBicker_BirthDate.Value);
            selected_Customer.PhoneNumber = txt_PhoneNumber.Text;
            selected_Customer.Address = txt_Address.Text;
            selected_Customer.CNN = txt_CNN.Text;
            if (txt_Password.Text != txt_ConfirmPass.Text)
            {
                MessageBox.Show("Passwords should match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            context.SaveChanges();
            MessageBox.Show("Customer Info Updated Successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
    }
}
