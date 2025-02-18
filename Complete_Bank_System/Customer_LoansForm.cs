using Complete_Bank_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complete_Bank_System
{
    public partial class Customer_LoansForm : Form
    {
        int ID;
        Complete_Bank_SystemContext context;
        public Customer_LoansForm(int customerId)
        {
            InitializeComponent();
            ID = customerId;
            context = new Complete_Bank_SystemContext();
        }
        private void LoadData()
        {
            cb_LoanType.Items.Add("personal");
            cb_LoanType.Items.Add("mortgage");
            cb_LoanType.Items.Add("Auto");
            DGV_Loans.DataSource = context.loans.Where(l => l.CustomerId == ID).ToList();
            DGV_Loans.Columns[0].Visible = false;
            btn_EditLoan.Visible = false;
            btn_DeleteLoan.Visible = false;
            var c = context.accounts.Where(a => a.CustomerId == ID).ToList();
            cb_Acccounts.DataSource = c;
            cb_Acccounts.DisplayMember = "AccountNumber";
            cb_Acccounts.ValueMember = "AccountId";
        }
        private void HideRepayFields()
        {
            lbl_RepaymentAmount.Visible = false;
            nUD_RepayAmount.Visible = false;
            btn_RepayLoan.Visible = false;
            lbl_AccountNum.Visible = false;
            cb_Acccounts.Visible = false;
            lbl_LoanRepayment.Visible = false;
            panel_Loan.Visible = false;
        }
        private void showRepayFiels()
        {
            lbl_RepaymentAmount.Visible = true;
            nUD_RepayAmount.Visible = true;
            btn_RepayLoan.Visible = true;
            lbl_AccountNum.Visible = true;
            cb_Acccounts.Visible = true;
            lbl_LoanRepayment.Visible = true;
            panel_Loan.Visible = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (nUD_LoanAmount.Value == 0 | nUD_LoanTerm.Value == 0 || cb_LoanType.SelectedIndex == -1)
            {
                MessageBox.Show("All Fields are Required", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Loans loan = new Loans()
            {
                CustomerId = ID,
                LoanType = cb_LoanType.SelectedItem.ToString(),
                LoanAmount = nUD_LoanAmount.Value,
                LoanTerm = (int)nUD_LoanTerm.Value,
                RepaymentStatus = lbl_CurrentStatus.Text = "Active"
            };
            context.loans.Add(loan);
            context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Add", USerId = ID, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == ID).FullName} applied for a loan {loan.LoansId}" });
            context.SaveChanges();
            MessageBox.Show("Loan Applied Successfully");
            LoadData();
        }

        private void btn_EditLoan_Click(object sender, EventArgs e)
        {
            Loans loan = context.loans.Where(l => l.LoansId == selectedLoanID).SingleOrDefault();
            loan.LoanTerm = (int)nUD_LoanTerm.Value;
            loan.LoanType = cb_LoanType.SelectedItem.ToString();
            loan.LoanAmount = nUD_LoanAmount.Value;
            context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Update", USerId = ID, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == ID).FullName} updated his loan Info {loan.LoansId}" });
            context.SaveChanges();
            MessageBox.Show("Loan Info Updated Successfully");
            LoadData();
            cb_LoanType.SelectedItem = -1;
            nUD_LoanAmount.Value = 0;
            nUD_LoanTerm.Value = 0;
        }

        private void btn_DeleteLoan_Click(Object sender, EventArgs e)
        {
            Loans loan = context.loans.Where(l => l.LoansId == selectedLoanID).SingleOrDefault();
            context.transactions.RemoveRange(context.transactions.Where(t => t.LoanId == selectedLoanID).ToList());
            context.loans.Remove(loan);
            context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Delete", USerId = ID, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == ID).FullName} Canceled loan {loan.LoansId}" });
            context.SaveChanges();
            MessageBox.Show("Loan Canceled Successfully");
            LoadData();

            cb_LoanType.SelectedItem = -1;
            nUD_LoanAmount.Value = 0;
            nUD_LoanTerm.Value = 0;

        }
        int selectedLoanID;
        Loans SelectedLoan;
        private void DGV_Loans_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedLoanID = (int)DGV_Loans.SelectedRows[0].Cells[0].Value;
            SelectedLoan = context.loans.Where(l => l.LoansId == selectedLoanID).FirstOrDefault();
            if (SelectedLoan != null)
            {
                cb_LoanType.SelectedItem = SelectedLoan.LoanType;
                nUD_LoanAmount.Value = SelectedLoan.LoanAmount;
                nUD_LoanTerm.Value = SelectedLoan.LoanTerm;
                lbl_CurrentStatus.Text = SelectedLoan.RepaymentStatus.ToString();
            }
            showRepayFiels();
            btn_EditLoan.Visible = true;
            btn_DeleteLoan.Visible = true;

        }

        private void LoansForm_Load(object sender, EventArgs e)
        {
            LoadData();
            HideRepayFields();
        }

        private void btn_RepayLoan_Click(object sender, EventArgs e)
        {
            if (nUD_RepayAmount.Value <= 0)
            {
                MessageBox.Show("Enter a Valid Repayment Amount ");
                return;
            }
            if (context.accounts.Where(a => a.AccountId == (int)cb_Acccounts.SelectedValue).SingleOrDefault().Balance <= 0)
            {
                MessageBox.Show("This Account has no balance to withdraw from");
                nUD_RepayAmount.Value = 0;
                return;
            }
            if (nUD_RepayAmount.Value > context.accounts.Where(a => a.AccountId == (int)cb_Acccounts.SelectedValue).SingleOrDefault().Balance)
            {
                MessageBox.Show("Insufficient funds for this withdrawal");
                nUD_RepayAmount.Value = 0;
                return;
            }
            Transactions RepaymentTrans = new Transactions()
            {
                TransactionType = "loan payment",
                TransationDate = DateTime.Now,
                Amount = nUD_RepayAmount.Value,
                AccId = (int)cb_Acccounts.SelectedValue,
                LoanId = selectedLoanID
            };
            try
            {
                context.transactions.Add(RepaymentTrans);
                context.accounts.Where(a => a.AccountId == (int)cb_Acccounts.SelectedValue).SingleOrDefault().Balance -= nUD_RepayAmount.Value;
                UpdateRepaymentStatus();
                context.audit_Logs.Add(new Audit_Logs { ActionDate = DateTime.Now, ActionType = "Update", USerId = ID, UserType = "Customer", Desc = $"{context.customers.FirstOrDefault(c => c.CustomerId == ID).FullName} repayed {nUD_RepayAmount.Value} SD for loan {selectedLoanID}" });
                context.SaveChanges();
                MessageBox.Show("Loan repayment recorded successfully");
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }

        }

        private void UpdateRepaymentStatus()
        {
            var loans = context.loans.Where(l => l.CustomerId == ID).ToList();
            foreach (var loan in loans)
            {
                var LastPayment = context.transactions.Where(t => t.LoanId == selectedLoanID).OrderByDescending(t => t.TransationDate).FirstOrDefault();
                DateTime LastPaymentDate = LastPayment?.TransationDate ?? DateTime.Now;

                if (context.transactions.Where(t => t.LoanId == selectedLoanID).Sum(t => t.Amount) >= loan.LoanAmount)
                {
                    loan.RepaymentStatus = "Paid";
                }
                if (DateTime.Now > LastPaymentDate.AddMonths(loan.LoanTerm))
                {
                    loan.RepaymentStatus = "OverDue";
                }
                context.SaveChanges();
            }


        }
        private void btn_ReturnToHome_Click(object sender, EventArgs e)
        {
            CustomerDashBoard c = new CustomerDashBoard(ID);
            this.Hide();
            c.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
