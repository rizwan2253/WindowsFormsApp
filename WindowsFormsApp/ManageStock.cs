using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ManageStock : Form
    {
        int id = 0;
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
            comboBoxCategory.DataSource = ManageStockLayer.GetCategoryList("0");
        }

        private void fillManufacturer()
        {
            comboBoxManufacturer.DisplayMember = "Name";
            comboBoxManufacturer.ValueMember = "Id";
            comboBoxManufacturer.DataSource = ManageStockLayer.GetManufacturerList("0");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tabManageStock.SelectedIndex == 0)
            {
                
            }
            else if (tabManageStock.SelectedIndex == 1)
            {
                if (CatAndManuf.SelectedIndex == 0)
                {
                  Message(ManageStockLayer.AddCategory(txtboxCategory.Text),"added");
                }
                else if (CatAndManuf.SelectedIndex == 1)
                {
                  Message(ManageStockLayer.AddManufacturer(txtboxManufacturer.Text),"added");
                }
            }
        }        

        private void ManageStockTabSelect(object sender, TabControlEventArgs e)
        {
            if (tabManageStock.SelectedIndex == 0)
            {
                FillProductItem();
            }
            else if (tabManageStock.SelectedIndex == 1)
            {               
              dtProductItem.DataSource = ManageStockLayer.GetCategoryList("0");                
            }
        }

        private void CatAndManufTabSelected(object sender, TabControlEventArgs e)
        {            
            if (CatAndManuf.SelectedIndex == 0)
            {
                dtProductItem.DataSource = ManageStockLayer.GetCategoryList("0");
            }
            else if (CatAndManuf.SelectedIndex == 1)
            {
                dtProductItem.DataSource = ManageStockLayer.GetManufacturerList("0");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tabManageStock.SelectedIndex == 0)
            {

            }
            else if (tabManageStock.SelectedIndex == 1)
            {
                if (CatAndManuf.SelectedIndex == 0)
                {
                    Message(ManageStockLayer.EditCategory(id,txtboxCategory.Text,1),"update");
                }
                else if (CatAndManuf.SelectedIndex == 1)
                {
                    Message(ManageStockLayer.EditManufacturer(id,txtboxManufacturer.Text,1),"update");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tabManageStock.SelectedIndex == 0)
            {

            }
            else if (tabManageStock.SelectedIndex == 1)
            {
                if (CatAndManuf.SelectedIndex == 0)
                {
                    Message(ManageStockLayer.EditCategory(1, txtboxCategory.Text, 0), "deleted");
                }
                else if (CatAndManuf.SelectedIndex == 1)
                {
                    Message(ManageStockLayer.EditManufacturer(1, txtboxManufacturer.Text, 0), "deleted");
                }
            }
        }

        private void txtSearchId_KeyDown(object sender, KeyEventArgs e)
        {
            txtSearchId.SelectAll();
        }

        private void txtSearchId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (tabManageStock.SelectedIndex == 0)
            {

            }
            else if (tabManageStock.SelectedIndex == 1)
            {
                if (CatAndManuf.SelectedIndex == 0)
                {
                    var val = ManageStockLayer.GetCategoryList(txtSearchId.Text);
                    dtProductItem.DataSource = val;
                    txtboxCategory.Text = txtSearchId.Text != "" ? val.FirstOrDefault().Name : "";
                    txtSearchId.Text = "";
                    id = val.FirstOrDefault().Id;
                }
                else if (CatAndManuf.SelectedIndex == 1)
                {
                    var val = ManageStockLayer.GetManufacturer(txtSearchId.Text);
                    if (val != null && val.Count > 0)
                    {
                        dtProductItem.DataSource = val;
                        txtboxManufacturer.Text =txtSearchId.Text != "" ? val.FirstOrDefault().Name : "";
                        txtSearchId.Text = "";
                        id = val.FirstOrDefault().Id;
                    }
                    else
                    {
                        MessageBox.Show("Not found","Result");
                    }
                    
                    txtSearchId.Text = "";
                }
            }
            txtSearchId.Focus();
        }

        private void txtSearchId_TextChanged(object sender, EventArgs e)
        {
            txtSearchId.SelectAll();
            btnSearch.Focus();
        }

        private void Message(int isAdded,string status)
        {
            if (isAdded > 0)
            {
                MessageBox.Show("Data "+status+" successfully", "Success");
            }
            else
            {
                MessageBox.Show("Something Wrong", "Failed");
            }
        }
    }
}
