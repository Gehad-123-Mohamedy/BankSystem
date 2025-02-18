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
    public partial class Customer_Accounts : Form
    {
        int Customer_Id;
        int Selected_ACC_Id;
        Complete_Bank_SystemContext context;
        public Customer_Accounts(int id)
        {
            InitializeComponent();
            Customer_Id = id;
            context = new Complete_Bank_SystemContext();
            btn_Delete.Visible= false;
            btn_Update.Visible= false;

        }
        private void LoadAccounts()
        {
            DGV_Accounts.DataSource = context.accounts.Where(a => a.CustomerId == Customer_Id).Select(a => new { AccountID = a.AccountId, AccountNumber = a.AccountNumber, AccountOwner = a.customer.FullName, AccountType = a.AccountType, a.OpeningDate, Balance = a.Balance, Owner = a.customer }).ToList();
            DGV_Accounts.Columns[0].Visible = false;
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            cb_AccTypes.Items.Add("Saving");
            cb_AccTypes.Items.Add("Checking");
            cb_AccTypes.Items.Add("Money Market");
            LoadAccounts();
        }
        

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (validateInputs() == false)
            {
                return;
            }
            Account a = new Account();
            a.CustomerId = Customer_Id;
            a.OpeningDate = DateTime.Now;
            a.Balance = nUD_Balance.Value;
            a.AccountType = cb_AccTypes.SelectedItem.ToString();
            int accNum;
            if(!int.TryParse(txt_AccNumber.Text,out accNum))
            {
                MessageBox.Show("please Enter a Valid Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var isUnique = !(context.accounts.Any(a => a.AccountNumber == accNum));
            if (!isUnique)
            {
                MessageBox.Show("Account Number Must be Unique", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_AccNumber.Text.Length != 6)
            {
                MessageBox.Show("Account Number Must be 6 digits", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            a.AccountNumber = accNum;
            context.accounts.Add(a);
            context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Add ", USerId = Customer_Id, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == Customer_Id).FullName} Added new Account" });
            context.SaveChanges();

            MessageBox.Show("Account Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAccounts();
            cb_AccTypes.SelectedIndex = -1;
            nUD_Balance.Value = 0;
            txt_AccNumber.Text = "";
        }

        private void DGV_Accounts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Selected_ACC_Id = (int)DGV_Accounts.SelectedRows[0].Cells[0].Value;
            Account Selected_Acc = context.accounts.Where(a => a.AccountId == Selected_ACC_Id).SingleOrDefault();
            if (Selected_Acc != null)
            {
                nUD_Balance.Value = Selected_Acc.Balance;
                cb_AccTypes.SelectedItem = Selected_Acc.AccountType;
                txt_AccNumber.Text = Selected_Acc.AccountNumber.ToString();

            }
            btn_Delete.Visible = true;
            btn_Update.Visible = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (validateInputs() == false)
            {
                return;
            }
            var a = context.accounts.Where(a => a.AccountId == Selected_ACC_Id).SingleOrDefault();
            a.Balance = nUD_Balance.Value;
            a.AccountType = cb_AccTypes.SelectedItem.ToString();

            int accNum = int.Parse(txt_AccNumber.Text);
            var isUnique = !(context.accounts.Any(a => a.AccountNumber == accNum));
            if (!isUnique)
            {
                MessageBox.Show("Account Number Must be Unique", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_AccNumber.Text.Length != 6)
            {
                MessageBox.Show("Account Number Must be 6 digits", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            a.AccountNumber = accNum;
            context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Update", USerId = Customer_Id, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == Customer_Id).FullName} Updated Account {a.AccountNumber}" });
            context.SaveChanges();
            MessageBox.Show("Account Info Updated ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAccounts();
            cb_AccTypes.SelectedIndex = -1;
            nUD_Balance.Value = 0;
            txt_AccNumber.Text = "";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var a = context.accounts.Where(a => a.AccountId == Selected_ACC_Id).SingleOrDefault();
            var t = context.transactions.Where(t => t.AccId == Selected_ACC_Id).ToList();
            context.transactions.RemoveRange(t);
            context.accounts.Remove(a);
            context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Delete", USerId = Customer_Id, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == Customer_Id).FullName} Canceled Account {a.AccountNumber}" });
            context.SaveChanges();
            MessageBox.Show("Account Canceled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAccounts();
            cb_AccTypes.SelectedIndex = -1;
            nUD_Balance.Value = 0;
            txt_AccNumber.Text = "";
        }

        private void btn_ReturnToHome_Click(object sender, EventArgs e)
        {
            CustomerDashBoard c = new CustomerDashBoard(Customer_Id);
            this.Hide();
            c.Show();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool validateInputs()
        {
            if (cb_AccTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Account Type", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nUD_Balance.Value == 0)
            {
                MessageBox.Show("Balance can't be 0", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (txt_AccNumber.Text == "")
            {
                MessageBox.Show("Please enter account number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
