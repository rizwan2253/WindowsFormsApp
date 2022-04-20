using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.Close();

        }

        private void ClosingMainForm(object sender, FormClosingEventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void addCategoryOrItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStock manage = new ManageStock();
            manage.ShowDialog();
        }

        private void cashCounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashCounter cashCounter = new CashCounter();
            cashCounter.ShowDialog();
        }

        private void customerHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerHistory customerHistory = new CustomerHistory();
            customerHistory.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
