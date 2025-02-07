using Complete_Bank_System.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Complete_Bank_System
{
    public partial class Customer_Transcations : Form
    {
        Complete_Bank_SystemContext context;
        int CustomerID;
        public Customer_Transcations(int id)
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
            CustomerID = id;
            lbl_Actual_Balance.Text = "";
        }

        private void btn_CheckBalance_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Transactions_AccNum.Text))
            {
                MessageBox.Show("Please enter An Account Number !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int ACCNum;
            if (!int.TryParse(txt_Transactions_AccNum.Text, out ACCNum))
            {
                MessageBox.Show("Please Enter A Valid Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Transactions_AccNum.Text = "";
                return;
            }
            if (context.accounts.Where(a => a.AccountNumber == ACCNum).SingleOrDefault() != null)
            {
                lbl_Actual_Balance.Text = context.accounts.Where(a => a.AccountNumber == ACCNum).SingleOrDefault().Balance.ToString() + "SD";
            }
            else
            {
                lbl_Actual_Balance.Text = "";
                MessageBox.Show("Invalid Account Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btn_ReturnToHome_Click(object sender, EventArgs e)
        {
            CustomerDashBoard c = new CustomerDashBoard(CustomerID);
            this.Hide();
            c.Show();
        }
        private void btn_Deposite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Deposit_ACCNUM.Text))
            {
                MessageBox.Show("Please enter An Account Number to depose money", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int AccountNum;
            if (!int.TryParse(txt_Deposit_ACCNUM.Text, out AccountNum))
            {

                MessageBox.Show("Please Enter A Valid Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Deposit_ACCNUM.Text = "";
                return;
            }
            try
            {
                var account = context.accounts.SingleOrDefault(a => a.AccountNumber == AccountNum);
                if (account == null)
                {
                    MessageBox.Show("Invalid Account Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Deposit_ACCNUM.Text = "";
                    return;
                }
                if (nUD_Deposite_Amount.Value <= 0)
                {
                    MessageBox.Show("Deposit amount must be greater than zero", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (account.Balance + nUD_Deposite_Amount.Value > 500000)
                {
                    MessageBox.Show("This account cannot exceed the maximum balance of 500,000 SD", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nUD_Deposite_Amount.Value = 0;
                    return;
                }

                Transactions transaction = new Transactions()
                {
                    TransactionType = "Deposit",
                    TransationDate = DateTime.Now,
                    Amount = nUD_Deposite_Amount.Value,
                    AccId = account.AccountId
                };
                context.transactions.Add(transaction);
                account.Balance += nUD_Deposite_Amount.Value;
                context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Deposit", USerId = CustomerID, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == CustomerID).FullName} deopsied Money" });
                context.SaveChanges();
                MessageBox.Show("Money deposited", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Deposit_ACCNUM.Text = "";
                nUD_Deposite_Amount.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the transaction");
            }
        }
        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Withdraw_ACCNUM.Text))
            {
                MessageBox.Show("Please enter Account Number to withdraw from", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int AccountNum;
            if (!int.TryParse(txt_Withdraw_ACCNUM.Text, out AccountNum))
            {
                MessageBox.Show("Please Enter A Valid Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Withdraw_ACCNUM.Text = "";
                return;
            }
            try
            {
                var account = context.accounts.SingleOrDefault(a => a.AccountNumber == AccountNum);
                if (account == null)
                {
                    MessageBox.Show("Invalid Account Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Withdraw_ACCNUM.Text = "";
                    return;
                }
                if (nUD_Withdraw_Amount.Value <= 0)
                {
                    MessageBox.Show("Withdrawal amount must be greater than zero", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (account.Balance <= 0)
                {
                    MessageBox.Show("This Account has no balance to withdraw from", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nUD_Withdraw_Amount.Value = 0;
                    return;
                }
                if (nUD_Withdraw_Amount.Value > account.Balance)
                {
                    MessageBox.Show("Insufficient funds for this withdrawal", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nUD_Withdraw_Amount.Value = 0;
                    return;
                }
                Transactions transaction = new Transactions()
                {
                    TransactionType = "Withdrawal",
                    TransationDate = DateTime.Now,
                    Amount = nUD_Withdraw_Amount.Value,
                    AccId = account.AccountId
                };
                context.transactions.Add(transaction);
                account.Balance -= nUD_Withdraw_Amount.Value;
                context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Withdraw", USerId = CustomerID, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == CustomerID).FullName} witdrawn Money" });
                context.SaveChanges();
                MessageBox.Show("Money withdrawn", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Withdraw_ACCNUM.Text = "";
                nUD_Withdraw_Amount.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the transaction");
            }
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_RecipientAcc.Text) || string.IsNullOrWhiteSpace(txt_SenderAcc.Text))
            {
                MessageBox.Show("Please enter both sender and recipient account numbers to transfer money", "Waning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int SenderAccNum, RecientAccNum;
            if ((!int.TryParse(txt_SenderAcc.Text, out SenderAccNum)) || (!int.TryParse(txt_RecipientAcc.Text, out RecientAccNum)))
            {
                MessageBox.Show("Please Enter a Valid Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SenderAcc.Text = "";
                txt_RecipientAcc.Text = "";
                return;
            }
            try
            {
                var senderAccount = context.accounts.Where(a => a.AccountNumber == SenderAccNum).SingleOrDefault();
                var reciepentAccount = context.accounts.Where(a => a.AccountNumber == RecientAccNum).SingleOrDefault();
                if (senderAccount == null || reciepentAccount == null)
                {

                    MessageBox.Show("Invalid Account Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (nUD_Transfer_Amount.Value <= 0)
                {
                    MessageBox.Show("Transfer amount must be greater than zero", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (nUD_Transfer_Amount.Value > senderAccount.Balance)
                {
                    MessageBox.Show("Insufficient funds in the source account", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nUD_Transfer_Amount.Value = 0;
                    return;
                }
                Transactions transaction1 = new Transactions()
                {
                    TransactionType = "withdrawal",
                    TransationDate = DateTime.Now,
                    Amount = nUD_Transfer_Amount.Value,
                    AccId = senderAccount.AccountId

                };
                context.transactions.Add(transaction1);

                Transactions transaction2 = new Transactions()
                {

                    TransactionType = "Deposit",
                    TransationDate = DateTime.Now,
                    Amount = nUD_Transfer_Amount.Value,
                    AccId = reciepentAccount.AccountId
                };
                context.transactions.Add(transaction2);

                senderAccount.Balance -= nUD_Transfer_Amount.Value;
                reciepentAccount.Balance += nUD_Transfer_Amount.Value;
                context.SaveChanges();
                context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Transfer", USerId = CustomerID, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == CustomerID).FullName} transfered Money from {senderAccount.AccountNumber} to {reciepentAccount.AccountNumber}" });
                MessageBox.Show("Transfer completed ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SenderAcc.Text = "";
                txt_RecipientAcc.Text = "";
                nUD_Transfer_Amount.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the transfer: " + ex.Message);
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
