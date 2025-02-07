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
    public partial class LoanOfficer_LoansUserControl : UserControl
    {
        Complete_Bank_SystemContext context;
        public LoanOfficer_LoansUserControl()
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
            btn_DeleteLoan.Visible = false;
            btn_EditLoan.Visible = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_CustomerName.Text == "")
            {
                MessageBox.Show("Enter An Customer Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Customer customer = context.customers.FirstOrDefault(c => c.FullName == txt_CustomerName.Text);
            List<Loans> loans;
            if (customer != null)
            {

                loans = context.loans.Where(l => l.CustomerId == customer.CustomerId).ToList();
                if (loans.Count == 0)
                {
                    MessageBox.Show("This Customer hasn't applied for a loan yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgv_Loans.DataSource = loans;

            }

        }
        private void clearData()
        {
            cb_LoanType.SelectedIndex = -1;
            nUD_LoanAmount.Value = 0;
            nUD_LoanTerm.Value = 0;
            cb_Customers.SelectedIndex = -1;
            lbl_CurrentStatus.Text = "_";
        }

        private void LoanOfficer_LoansUserControl_Load(object sender, EventArgs e)
        {
            cb_LoanType.Items.Add("personal");
            cb_LoanType.Items.Add("mortgage");
            cb_LoanType.Items.Add("Auto");
            cb_Customers.DataSource = context.customers.ToList();
            cb_Customers.DisplayMember = "FullName";
            cb_Customers.ValueMember = "CustomerId";
        }

        private void txt_CustomerName_TextChanged(object sender, EventArgs e)
        {
            dgv_Loans.DataSource = null;
            clearData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (nUD_LoanAmount.Value == 0 | nUD_LoanTerm.Value == 0 || cb_Customers.SelectedIndex == -1 || cb_LoanType.SelectedIndex == -1)
            {
                MessageBox.Show("All Fields are Required", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Loans loans = new Loans()
            {
                CustomerId = (int)cb_Customers.SelectedValue,
                LoanType = cb_LoanType.SelectedItem.ToString(),
                LoanAmount = nUD_LoanAmount.Value,
                LoanTerm = (int)nUD_LoanTerm.Value,
                RepaymentStatus = lbl_CurrentStatus.Text = "Active"
            };
            context.loans.Add(loans);
            context.SaveChanges();
            MessageBox.Show("Loan Applied", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearData();
            dgv_Loans.DataSource = context.loans.Where(l=>l.LoansId==Selected_LoanId).ToList();
        }

        int Selected_LoanId;
        Loans Selected_Loan;
        private void dgv_Loans_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Selected_LoanId = (int)dgv_Loans.SelectedRows[0].Cells[0].Value;
            Selected_Loan = context.loans.FirstOrDefault(l => l.LoansId == Selected_LoanId);
            if (Selected_Loan != null)
            {
                cb_Customers.SelectedValue = Selected_Loan.CustomerId;
                cb_LoanType.SelectedItem = Selected_Loan.LoanType;
                nUD_LoanTerm.Value = Selected_Loan.LoanTerm;
                nUD_LoanAmount.Value = Selected_Loan.LoanAmount;
                lbl_CurrentStatus.Text = Selected_Loan.RepaymentStatus;
            }
            btn_DeleteLoan.Visible = true;
            btn_EditLoan.Visible = true;
        }

        private void btn_EditLoan_Click(object sender, EventArgs e)
        {
            Selected_Loan.LoanType = cb_LoanType.SelectedItem.ToString();
            Selected_Loan.LoanAmount = nUD_LoanAmount.Value;
            Selected_Loan.LoanTerm = (int)nUD_LoanTerm.Value;
            Selected_Loan.CustomerId = (int)cb_Customers.SelectedValue;
            context.SaveChanges();
            MessageBox.Show("Loan Info Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearData();
            dgv_Loans.DataSource = context.loans.Where(l=>l.LoansId==Selected_LoanId).ToList();

        }

        private void btn_DeleteLoan_Click(object sender, EventArgs e)
        {
            
            var t=context.transactions.Where(t=>t.LoanId==Selected_LoanId).ToList();
            context.Remove(Selected_Loan);
            context.SaveChanges();
            MessageBox.Show("Loan Canceled ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearData();
            dgv_Loans.DataSource=context.loans.Where(l=>l.LoansId==Selected_LoanId).ToList();
        }
    }
}
