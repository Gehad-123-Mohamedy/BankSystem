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
    public partial class LoanOfficer_LoanRepaymentUserControl : UserControl
    {
        Complete_Bank_SystemContext context;
        public LoanOfficer_LoanRepaymentUserControl()
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
        }

        private void LoanOfficer_LoanRepaymentUserControl_Load(object sender, EventArgs e)
        {
            dgv_Loans.DataSource = context.loans.ToList();
            cb_Acccounts.DataSource = context.accounts.ToList();
            cb_Acccounts.ValueMember = "AccountId";
            cb_Acccounts.DisplayMember = "AccountNumber";
            panel_Loan.Visible = false;
        }
        int Selected_LoanId;
        Loans Selected_Loan;
        private void dgv_Loans_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel_Loan.Visible = true;
            Selected_LoanId = (int)dgv_Loans.SelectedRows[0].Cells[0].Value;
            Selected_Loan = context.loans.FirstOrDefault(l => l.LoansId == Selected_LoanId);
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
                LoanId = Selected_LoanId
            };
            try
            {
                context.transactions.Add(RepaymentTrans);
                context.accounts.Where(a => a.AccountId == (int)cb_Acccounts.SelectedValue).SingleOrDefault().Balance -= nUD_RepayAmount.Value;
                UpdateRepaymentStatus();
                context.SaveChanges();
                MessageBox.Show("Loan repayment recorded successfully");
                cb_Acccounts.SelectedIndex = -1;
                nUD_RepayAmount.Value = 0;
                dgv_Loans.DataSource = context.accounts.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateRepaymentStatus()
        {
            var loans = context.loans.Where(l => l.CustomerId == Selected_Loan.CustomerId).ToList();
            foreach (var loan in loans)
            {
                var totalPaymentPerTrans = context.transactions.Where(t => t.LoanId == Selected_LoanId).Sum(t => t.Amount);
                var LastPayment = context.transactions.Where(t => t.LoanId == Selected_LoanId).OrderByDescending(t => t.TransationDate).FirstOrDefault();
                DateTime LastPaymentDate = LastPayment?.TransationDate ?? DateTime.Now; 

                if (totalPaymentPerTrans >= loan.LoanAmount)
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
    }
}
