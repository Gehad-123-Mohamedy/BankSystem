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
    public partial class CustomerService_AccountsUserControl : UserControl
    {
        Complete_Bank_SystemContext context;

        public CustomerService_AccountsUserControl()
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
            cb_Accounts.Items.Add("Checking");
            cb_Accounts.Items.Add("Saving");
            cb_Accounts.Items.Add("Money Market");
            lbl_AccountType.Visible = false;
            lbl_AccountBalance.Visible = false;
            cb_Accounts.Visible = false;
            nUD_Balance.Visible = false;
            btn_Update.Visible = false;
        }
        int CustomerId;
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_CustomerID.Text == "")
            {
                MessageBox.Show("Enter An CustomerId", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txt_CustomerID.Text, out CustomerId))
            {
                MessageBox.Show("Enter A valid Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        int Selected_AccountId;
        Account selected_Account;
        private void dgv_Accounts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_AccountBalance.Visible = true;
            lbl_AccountType.Visible = true;
            nUD_Balance.Visible = true;
            cb_Accounts.Visible = true;
            btn_Update.Visible = true;
            Selected_AccountId = (int)dgv_Accounts.SelectedRows[0].Cells[0].Value;
            selected_Account = context.accounts.FirstOrDefault(a => a.AccountId == Selected_AccountId);
            if (selected_Account != null)
            {
                nUD_Balance.Value = selected_Account.Balance;
                cb_Accounts.SelectedItem = selected_Account.AccountType;
            }


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            selected_Account.AccountType = cb_Accounts.SelectedItem.ToString();
            selected_Account.Balance = nUD_Balance.Value;
            context.SaveChanges();
            MessageBox.Show("Account Info Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_Accounts.DataSource = context.accounts.Where(a => a.CustomerId == CustomerId).ToList();
        }

        private void txt_CustomerId_TextChanged(object sender, EventArgs e)
        {
            lbl_AccountType.Visible = false;
            lbl_AccountBalance.Visible = false;
            cb_Accounts.Visible = false;
            nUD_Balance.Visible = false;
            btn_Update.Visible = false;
        }
    }
}






