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
    public partial class AdminDashboard : Form
    {
        int EmpID;
        CustomerService_CustomersUserControl CustomerUserControl;
        AccountManger_AccountsUserControl accountManger_AccountsUserControl;
        AccountManger_TransactionsUserControl accountManger_TransactionsUserControl;
        LoanOfficer_LoansUserControl loanOfficer_LoansUserControl;
        EmployeeUserControl employeeUserControl;
        AdminSystem_DashBoardUserControl adminSystem_DashBoardUserControl;
        public AdminDashboard(int empID)
        {
            InitializeComponent();
            this.EmpID = empID;
            CustomerUserControl = new CustomerService_CustomersUserControl();
            accountManger_AccountsUserControl = new AccountManger_AccountsUserControl();
            accountManger_TransactionsUserControl = new AccountManger_TransactionsUserControl();
            loanOfficer_LoansUserControl = new LoanOfficer_LoansUserControl();
            employeeUserControl = new EmployeeUserControl();
            adminSystem_DashBoardUserControl = new AdminSystem_DashBoardUserControl();
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

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            LoadControl(CustomerUserControl);
        }

        private void btn_Accounts_Click(object sender, EventArgs e)
        {
            LoadControl(accountManger_AccountsUserControl);

        }

        private void btn_Transactions_Click(object sender, EventArgs e)
        {
            LoadControl(accountManger_TransactionsUserControl);

        }

        private void btn_Loans_Click(object sender, EventArgs e)
        {
            LoadControl(loanOfficer_LoansUserControl);


        }

        private void btn_Employees_Click(object sender, EventArgs e)
        {
            LoadControl(employeeUserControl);
        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            LoadControl(adminSystem_DashBoardUserControl);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
