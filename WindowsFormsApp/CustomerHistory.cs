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
    public partial class CustomerHistory : Form
    {
        List<Customer> custList = new List<Customer>();

        public CustomerHistory()
        {
            InitializeComponent();
        }

        private void CustomerHistory_Load(object sender, EventArgs e)
        {
            
            var dt = Customer.getCustHistory("0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Customer cat = new Customer();
                cat.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                cat.CustomerId = Convert.ToInt32(dt.Rows[i]["CustomerId"]);
                cat.Name = dt.Rows[i]["Name"].ToString();
                cat.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"]);
                cat.SalePrice = Convert.ToInt32(dt.Rows[i]["SalePrice"]);
                cat.TotalPrice = Convert.ToInt32(dt.Rows[i]["TotalPrice"]);

                custList.Add(cat);
            }

            comboBoxCustId.DisplayMember = "CustomerId";
            comboBoxCustId.ValueMember = "Id";
            comboBoxCustId.DataSource = custList.Select(a => a.CustomerId).Distinct().ToList();        
        }

        private void comboBoxCustId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = comboBoxCustId.SelectedItem as Customer;
            var collectList = custList.Where(z => z.CustomerId == Convert.ToInt32(comboBoxCustId.SelectedItem)).Select(n => new { n.Name, n.Quantity, n.SalePrice, n.TotalPrice }).ToList();
            dataGridView1.DataSource = collectList;
            label3.Text = collectList.Sum(n => n.Quantity).ToString();
            label6.Text = collectList.Sum(n => n.TotalPrice).ToString();
        }
    }

    public class Customer:ProductItem
    {
        public int CustomerId { get; set; }
        public int TotalPrice { get; set; }
        public static DataTable getCustHistory(string param)
        {
            return Get(param, 16);
        }
    }
}
