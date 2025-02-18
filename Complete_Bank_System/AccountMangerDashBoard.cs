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
    public partial class AccountMangerDashBoard : Form
    {
        int empID;
        AccountManger_AccountsUserControl accountUserControl;
        AccountManger_TransactionsUserControl transactionsUserControl;
        public AccountMangerDashBoard(int iD)
        {
            InitializeComponent();
            empID = iD;
            accountUserControl = new AccountManger_AccountsUserControl();
            transactionsUserControl = new AccountManger_TransactionsUserControl();
        }
        private void LoadControl(UserControl control)
        {
            ContainerPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Add(control);
        }
        private void btn_ReturnToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btn_Accounts_Click(object sender, EventArgs e)
        {
            LoadControl(accountUserControl);
        }

        private void btn_Transactions_Click(object sender, EventArgs e)
        {
            LoadControl(transactionsUserControl);
        }

        private void ContainerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
