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
    public partial class AccountManger_AccountsUserControl : UserControl
    {
        Complete_Bank_SystemContext context;
        int accNum;
        public AccountManger_AccountsUserControl()
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
            btn_Delete.Visible = false;
            btn_Update.Visible = false;
        }
        private void LoadData()
        {
            cb_AccTypes.Items.Add("Checking");
            cb_AccTypes.Items.Add("Money Market");
            cb_AccTypes.Items.Add("Saving");
            cb_Customers.DataSource = context.customers.ToList();
            cb_Customers.DisplayMember = "FullName";
            cb_Customers.ValueMember = "CustomerId";
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cb_AccTypes.SelectedIndex == -1 || nUD_Balance.Value <= 0 || cb_Customers.SelectedIndex == -1 || txt_AccNumber.Text == "")
            {
                MessageBox.Show("Please Enter All fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ValidateAccNumber() == false)
            {
                return;
            }
            Account account = new Account();
            account.CustomerId = (int)cb_Customers.SelectedValue;
            account.Balance = nUD_Balance.Value;
            account.AccountNumber = accNum;
            account.AccountType = cb_AccTypes.SelectedItem.ToString();
            account.OpeningDate = DateTime.Now;
            context.Add(account);
            context.SaveChanges();
            MessageBox.Show("Account Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_Accounts.DataSource = context.accounts.Where(a => a.CustomerId == (int)cb_Customers.SelectedValue).ToList();
            ClearData();
        }
        int CustomerId;
        private void ClearData()
        {
            txt_AccNumber.Text = "";
            nUD_Balance.Value = 0;
            cb_AccTypes.SelectedIndex = -1;
            cb_Customers.SelectedIndex = -1;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_CustomerId.Text == "")
            {
                MessageBox.Show("Enter An CustomerId", "Validation ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txt_CustomerId.Text, out CustomerId))
            {
                MessageBox.Show("Enter A valid Number", "Validation ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var accounts = context.accounts.Where(a => a.CustomerId == CustomerId).ToList();
            if (accounts.Count == 0)
            {
                MessageBox.Show("This Customer has No Accounts", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgv_Accounts.DataSource = accounts;
        }

        private void txt_CustomerId_TextChanged(object sender, EventArgs e)
        {
            dgv_Accounts.DataSource = null;
        }

        private void AccountManger_AccountsUserControl_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        int Selected_AccId;
        Account Selected_Account;
        private void dgv_Accounts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Selected_AccId = (int)dgv_Accounts.SelectedRows[0].Cells[0].Value;
            Selected_Account = context.accounts.FirstOrDefault(a => a.AccountId == Selected_AccId);
            if (Selected_Account != null)
            {

                nUD_Balance.Value = Selected_Account.Balance;
                cb_AccTypes.SelectedItem = Selected_Account.AccountType;
                txt_AccNumber.Text = Selected_Account.AccountNumber.ToString();
                cb_Customers.SelectedValue = Selected_Account.CustomerId;
            }
            btn_Delete.Visible = true;
            btn_Update.Visible = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Selected_Account.CustomerId = (int)cb_Customers.SelectedValue;
            if (ValidateAccNumber() == false)
            {
                return;
            }
            Selected_Account.AccountType = cb_AccTypes.SelectedItem.ToString();
            Selected_Account.AccountNumber = accNum;
            Selected_Account.Balance = nUD_Balance.Value;
            context.SaveChanges();
            MessageBox.Show("Account Info Updated ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_Accounts.DataSource = context.accounts.Where(a => a.CustomerId == (int)cb_Customers.SelectedValue).ToList();
            ClearData();

        }

        private bool ValidateAccNumber()
        {
            if (!int.TryParse(txt_AccNumber.Text, out accNum))
            {
                MessageBox.Show("Enter A Valid Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var isUnique = !(context.accounts.Any(a => a.AccountNumber == accNum));
            if (!isUnique)
            {
                MessageBox.Show("Account Number Must be Unique");
                return false;
            }
            if (txt_AccNumber.Text.Length != 6)
            {
                MessageBox.Show("Account Number Must be 6 digits");
                return false;
            }
            return true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var t = context.transactions.Where(t => t.AccId == Selected_AccId).ToList();
            context.transactions.RemoveRange(t);
            context.accounts.Remove(Selected_Account);
            context.SaveChanges();
            MessageBox.Show("Account Canceled","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dgv_Accounts.DataSource = context.accounts.ToList();
            ClearData();
        }
    }
}
