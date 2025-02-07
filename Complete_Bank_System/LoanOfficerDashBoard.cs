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
    public partial class LoanOfficerDashBoard : Form
    {
        int empId;
        LoanOfficer_LoansUserControl loansUserControl;
        LoanOfficer_LoanRepaymentUserControl loanOfficer_LoanRepaymentUserControl;
        public LoanOfficerDashBoard(int iD)
        {
            InitializeComponent();
            empId = iD;
            loansUserControl = new LoanOfficer_LoansUserControl();
            loanOfficer_LoanRepaymentUserControl = new LoanOfficer_LoanRepaymentUserControl();
        }

        private void btn_ReturnToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        private void LoadControl(UserControl control)
        {
            ContainerPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Add(control);
        }
        private void btn_Loans_Click(object sender, EventArgs e)
        {
            LoadControl(loansUserControl);
        }

        private void btn_LoanRepayment_Click(object sender, EventArgs e)
        {
            LoadControl(loanOfficer_LoanRepaymentUserControl);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
