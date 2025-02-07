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
    public partial class AccountManger_TransactionsUserControl : UserControl
    {
        Complete_Bank_SystemContext context;
        int AccountNumber;
        public AccountManger_TransactionsUserControl()
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
            btn_delete.Visible = false;
            btn_Update.Visible = false;
            var accounts = context.accounts.ToList();
            cb_AccountNum.DataSource = accounts;
            cb_AccountNum.DisplayMember = "AccountNumber";
            cb_AccountNum.ValueMember = "AccountId";
            cb_TrasType.Items.Add("Deposit");
            cb_TrasType.Items.Add("Withdrawal");
            cb_TrasType.Items.Add("loan payment");
        }

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
            MessageBox.Show($"Account Id {accountId}");
            if (transactions.Count == 0)
            {
                MessageBox.Show("This Account has No Transactions Yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgv_Transactions.DataSource = transactions;
        }

        private void txt_AccountNumber_TextChanged(object sender, EventArgs e)
        {
            dgv_Transactions.DataSource = null;
            ClearData();
            btn_delete.Visible = false;
            btn_Update.Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
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

        int Selected_TransId;
        Transactions Selected_Transaction;
        private void dgv_Transactions_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Selected_TransId = (int)dgv_Transactions.SelectedRows[0].Cells[0].Value;
            Selected_Transaction = context.transactions.FirstOrDefault(t => t.TransactionsId == Selected_TransId);
            if (Selected_Transaction != null)
            {

                cb_TrasType.SelectedItem = Selected_Transaction.TransactionType;
                nUD_Amount.Value = Selected_Transaction.Amount;
                cb_AccountNum.SelectedValue = Selected_Transaction.AccId;

            }
            btn_delete.Visible = true;
            btn_Update.Visible = true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (cb_TrasType.SelectedItem.ToString() == "Deposit")
            {
                if (context.accounts.FirstOrDefault(a => a.AccountId == (int)cb_AccountNum.SelectedValue).Balance + nUD_Amount.Value > 500000)
                {
                    MessageBox.Show("This account cannot exceed the maximum balance of 500,000 SD","Validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    nUD_Amount.Value = 0;
                    return;
                }
                context.accounts.FirstOrDefault(a => a.AccountId == (int)cb_AccountNum.SelectedValue).Balance += nUD_Amount.Value;
                Selected_Transaction.TransactionType = cb_TrasType.SelectedItem.ToString();
                Selected_Transaction.Amount = nUD_Amount.Value;
                Selected_Transaction.AccId = (int)cb_AccountNum.SelectedValue;
                Selected_Transaction.TransationDate = DateTime.Now;
                context.SaveChanges();
                MessageBox.Show("Money deposited", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_Transactions.DataSource = context.transactions.Where(t => t.AccId == (int)cb_AccountNum.SelectedValue).ToList();

            }
            if (cb_TrasType.SelectedItem.ToString() == "Withdrawal")
            {
                if (nUD_Amount.Value > context.accounts.FirstOrDefault(a => a.AccountId == (int)cb_AccountNum.SelectedValue).Balance)
                {
                    MessageBox.Show("Insufficient funds for this withdrawal","Validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    nUD_Amount.Value = 0;
                    return;
                }
                context.accounts.FirstOrDefault(a => a.AccountId == (int)cb_AccountNum.SelectedValue).Balance -= nUD_Amount.Value;
                Selected_Transaction.TransactionType = cb_TrasType.SelectedItem.ToString();
                Selected_Transaction.Amount = nUD_Amount.Value;
                Selected_Transaction.AccId = (int)cb_AccountNum.SelectedValue;
                Selected_Transaction.TransationDate = DateTime.Now;
                context.SaveChanges();
                MessageBox.Show("Money withdrawn", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_Transactions.DataSource = context.transactions.Where(t => t.AccId == (int)cb_AccountNum.SelectedValue).ToList();
                ClearData();
            }


        }
        private void ClearData()
        {
            cb_AccountNum.SelectedIndex = -1;
            cb_TrasType.SelectedIndex = -1;
            nUD_Amount.Value = 0;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(Selected_Transaction.TransactionType== "Deposit")
            {
                context.accounts.FirstOrDefault(a => a.AccountId == Selected_Transaction.AccId).Balance -= Selected_Transaction.Amount;
                context.SaveChanges();
            }
            if(Selected_Transaction.TransactionType== "Withdrawal")
            {
                context.accounts.FirstOrDefault(a => a.AccountId == Selected_Transaction.AccId).Balance += Selected_Transaction.Amount;
                context.SaveChanges();

            }
            if (Selected_Transaction.TransactionType== "loan payment")
            {
                context.accounts.FirstOrDefault(a => a.AccountId == Selected_Transaction.AccId).Balance += Selected_Transaction.Amount;
                context.SaveChanges();
            }
            context.transactions.Remove(Selected_Transaction);
            context.SaveChanges();
            MessageBox.Show("Transaction Canceled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
            dgv_Transactions.DataSource = context.transactions.ToList();
        }
       
    }
}
