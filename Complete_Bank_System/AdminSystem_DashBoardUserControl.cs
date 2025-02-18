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
    public partial class AdminSystem_DashBoardUserControl : UserControl
    {
        Complete_Bank_SystemContext context;
        public AdminSystem_DashBoardUserControl()
        {
            InitializeComponent();
            context = new Complete_Bank_SystemContext();
        }

        private void AdminSystem_DashBoardUserControl_Load(object sender, EventArgs e)
        {
            Value_TotalCustomers.Text = context.customers.Count().ToString();
            Value_TotalEmployees.Text = context.employees.Count().ToString();
            Value_TotalLoans.Text = context.loans.Count().ToString();
        }
    }
}
