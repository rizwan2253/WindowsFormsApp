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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();
                
                Dashboard f = new Dashboard();
                f.Show();
            }
            else
            {
                MessageBox.Show("Wrong credential contact your administrator");
            }
        }

        public  void show1()
        {
            this.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }
    }
}
