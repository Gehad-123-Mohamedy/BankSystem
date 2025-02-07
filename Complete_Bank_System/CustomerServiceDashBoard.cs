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
    public partial class CustomerServiceDashBoard : Form
    {
        int empId;
        Complete_Bank_SystemContext context;
        CustomerService_CustomersUserControl customerUserControl;
        CustomerService_AccountsUserControl accountsUserControl;
        CustomerService_TransactionsUserControl transactionsUserControl;
        public CustomerServiceDashBoard(int iD)
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
            empId = iD;
            customerUserControl = new CustomerService_CustomersUserControl();
            accountsUserControl = new CustomerService_AccountsUserControl();
            transactionsUserControl = new CustomerService_TransactionsUserControl();
        }

        private void btn_ReturnToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        private void LoadControl(UserControl control)
        {
            panel_Container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel_Container.Controls.Add(control);
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            LoadControl(customerUserControl);
        }

        private void btn_Accounts_Click(object sender, EventArgs e)
        {
            LoadControl(accountsUserControl);
        }

        private void btn_Transactions_Click(object sender, EventArgs e)
        {
            LoadControl(transactionsUserControl);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
