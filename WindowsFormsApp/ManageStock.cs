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
    public partial class ManageStock : Form
    {
        public ManageStock()
        {
            InitializeComponent();
        }

        private void ManageStock_Load(object sender, EventArgs e)
        {
            fillCategory();
            fillManufacturer();
            FillProductItem();
        }

        private void FillProductItem()
        {
            dtProductItem.DataSource = ManageStockLayer.GetProductItems();
        }
        private void fillCategory()
        {
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Id";            
            comboBoxCategory.DataSource = ManageStockLayer.GetCategories();
        }

        private void fillManufacturer()
        {
            comboBoxManufacturer.DisplayMember = "Name";
            comboBoxManufacturer.ValueMember = "Id";
            comboBoxManufacturer.DataSource = ManageStockLayer.GetManufacturer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }        

        private void ManageStockTabSelect(object sender, TabControlEventArgs e)
        {
            if (tabManageStock.SelectedIndex == 0)
            {
                FillProductItem();
            }
            else if (tabManageStock.SelectedIndex == 1)
            {               
              dtProductItem.DataSource = ManageStockLayer.GetCategories();                
            }
        }

        private void CatAndManufTabSelected(object sender, TabControlEventArgs e)
        {            
            if (CatAndManuf.SelectedIndex == 0)
            {
                dtProductItem.DataSource = ManageStockLayer.GetCategories();
            }
            else if (CatAndManuf.SelectedIndex == 1)
            {
                dtProductItem.DataSource = ManageStockLayer.GetManufacturer();
            }
        }
    }
}
