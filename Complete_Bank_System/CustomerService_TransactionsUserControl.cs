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
    public partial class CustomerService_TransactionsUserControl : UserControl
    {
        Complete_Bank_SystemContext context;
        public CustomerService_TransactionsUserControl()
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
            var accounts = context.accounts.ToList();
            cb_AccountNum.DataSource = accounts;
            cb_AccountNum.DisplayMember = "AccountNumber";
            cb_AccountNum.ValueMember = "AccountId";
            cb_TrasType.Items.Add("Deposit");
            cb_TrasType.Items.Add("Withdrawal");
        }
        int AccountNumber;
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_AccountNumber.Text == "")
            {
                MessageBox.Show("Enter An Account Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txt_AccountNumber.Text, out AccountNumber))
            {
                MessageBox.Show("Enter A valid Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int accountId = context.accounts.Where(a => a.AccountNumber == AccountNumber).Select(a => a.AccountId).FirstOrDefault();
            var transactions = context.transactions.Where(t => t.AccId == accountId).ToList();
            if (transactions.Count == 0)
            {
                MessageBox.Show("This Account has No Transactions Yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dgv_Transactions.DataSource = transactions;

        }

        private void btn_addTransaction_Click(object sender, EventArgs e)
        {
            if (cb_TrasType.SelectedIndex == -1 || cb_AccountNum.SelectedIndex == -1 || nUD_Amount.Value == 0)
            {

                MessageBox.Show("Enter All Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var Selected_Account = context.accounts.FirstOrDefault(a => a.AccountId == (int)cb_AccountNum.SelectedValue);
            if (cb_TrasType.SelectedItem.ToString() == "Deposit")
            {
               
                if (Selected_Account.Balance + nUD_Amount.Value > 500000)
                {
                    MessageBox.Show("This account cannot exceed the maximum balance of 500,000 SD");
                    nUD_Amount.Value = 0;
                    return;
                }
                Transactions transaction = new Transactions()
                {
                    TransactionType = "Deposit",
                    TransationDate = DateTime.Now,
                    Amount = nUD_Amount.Value,
                    AccId = (int)cb_AccountNum.SelectedValue
                };
                context.transactions.Add(transaction);
                Selected_Account.Balance += nUD_Amount.Value;

                context.SaveChanges();
                MessageBox.Show("Money deposited successfully.");
                dgv_Transactions.DataSource = context.transactions.Where(t => t.AccId == (int)cb_AccountNum.SelectedValue).ToList();


            }
            if (cb_TrasType.SelectedItem.ToString() == "Withdrawal")
            {
                if (nUD_Amount.Value > Selected_Account.Balance)
                {
                    MessageBox.Show("Insufficient funds for this withdrawal");
                    nUD_Amount.Value = 0;
                    return;
                }
                Transactions transaction = new Transactions()
                {
                    TransactionType = "Withdrawal",
                    TransationDate = DateTime.Now,
                    Amount = nUD_Amount.Value,
                    AccId = (int)cb_AccountNum.SelectedValue
                };
                context.transactions.Add(transaction);
                Selected_Account.Balance -= nUD_Amount.Value;
                context.SaveChanges();
                MessageBox.Show("Money withdrawn successfully");
                dgv_Transactions.DataSource = context.transactions.Where(t => t.AccId == (int)cb_AccountNum.SelectedValue).ToList();
            }
        }

        private void txt_AccountNumber_TextChanged(object sender, EventArgs e)
        {
            cb_AccountNum.SelectedIndex = -1;
            nUD_Amount.Value = 0;
           cb_TrasType.SelectedIndex = -1;
            dgv_Transactions.DataSource=null;
        }
    }
}
