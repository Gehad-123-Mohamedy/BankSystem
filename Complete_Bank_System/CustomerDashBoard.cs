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
    public partial class CustomerDashBoard : Form
    {
        int Id;
        public CustomerDashBoard(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void btn_ShowProfile_Click(object sender, EventArgs e)
        {
            Customer_ShowProfile showProfile = new Customer_ShowProfile(Id);
            this.Hide();
            showProfile.Show();
        }

        private void btn_ReturnToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            Customer_Accounts accounts = new Customer_Accounts(Id);
            this.Hide();
            accounts.Show();
        }

        private void btn_Transactions_Click(object sender, EventArgs e)
        {
            Customer_Transcations transcations = new Customer_Transcations(Id);
            this.Hide();
            transcations.Show();
        }

        private void btn_Loans_Click(object sender, EventArgs e)
        {
            Customer_LoansForm loan = new Customer_LoansForm(Id);
            this.Hide();
            loan.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
