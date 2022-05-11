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
            userLogin userLogin = new userLogin(textBox2.Text, textBox1.Text);
            if (userLogin.ChechCredential())
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

    public class userLogin:DataBaseAccess
    {
         //string UserName="";

        //string Password="";

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        public userLogin(string userName,string password)
        {
            _userName = userName;
            _password = password;

        }

        public bool ChechCredential()
        {

           var getCred = DataBaseAccess.Get(UserName, Password);
            if (getCred != null && getCred.Rows.Count>0)
            {
                return true;
            }           
             return false;            
        }

    }
}
