﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ManageStock : Form
    {
        int id = 0,catId=0,ManufId=0;
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
            dtProductItem.DataSource = ManageStockLayer.GetProductItems("0");
            dtProductItem.Columns["ManufacturerId"].Visible = false;
            dtProductItem.Columns["CategoryId"].Visible = false;
            dtProductItem.Columns["Quantity"].Visible = false;
            dtProductItem.Columns["Status"].Visible = false;
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
                if (isValidate())
                {
                    var categoryId = comboBoxCategory.SelectedItem as Category;
                    var manufactId  = comboBoxManufacturer.SelectedItem as Manufacturer;
                    ProductItem item = new ProductItem();
                    item.Name = txtProductName.Text;
                    item.Barcode = string.IsNullOrEmpty(txtBarcode.Text)?"": txtBarcode.Text;
                    item.CostPrice = Convert.ToInt32(txtCostPrice.Text);
                    item.SalePrice = Convert.ToInt32(txtSalePrice.Text);
                    item.ManufacturerId = manufactId.Id;
                    item.categoryId = categoryId.Id;
                    Message(ManageStockLayer.AddProduct(item), "added");
                    dtProductItem.DataSource = ManageStockLayer.GetProductItems("0");
                    dtProductItem.Columns["ManufacturerId"].Visible = false;
                    dtProductItem.Columns["CategoryId"].Visible = false;
                    dtProductItem.Columns["Quantity"].Visible = false;
                    dtProductItem.Columns["Status"].Visible = false;
                    txtBarcode.Text = "";
                    txtSalePrice.Text = "";
                    txtCostPrice.Text = "";
                    txtProductName.Text = "";
                    comboBoxCategory.SelectedIndex = -1;
                    comboBoxManufacturer.SelectedIndex = -1;


                }
            }
            else if (tabManageStock.SelectedIndex == 1)
            {
                if (CatAndManuf.SelectedIndex == 0)
                {
                  Message(ManageStockLayer.AddCategory(txtboxCategory.Text),"added");
                    
                    dtProductItem.DataSource = ManageStockLayer.GetCategoryList("0");
                    fillCategory();
                    txtboxCategory.Text = String.Empty;
                    txtboxCategory.Focus();

                }
                else if (CatAndManuf.SelectedIndex == 1)
                {
                  Message(ManageStockLayer.AddManufacturer(txtboxManufacturer.Text),"added");                   
                    dtProductItem.DataSource = ManageStockLayer.GetManufacturerList("0");
                    fillManufacturer();
                    txtboxManufacturer.Text = String.Empty;
                    txtboxManufacturer.Focus();
                }
            }
        }

        private bool isValidate()
        {
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Enter product name");
                return false;
            }
            if (string.IsNullOrEmpty(txtCostPrice.Text))
            {
                MessageBox.Show("Enter Cost Price");
                return false;
            }
            if (string.IsNullOrEmpty(txtSalePrice.Text))
            {
                MessageBox.Show("Enter Sale Price");
                return false;
            }

            return true;
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
                dtProductItem.Columns["Status"].Visible = false;

            }
        }

        private void CatAndManufTabSelected(object sender, TabControlEventArgs e)
        {            
            if (CatAndManuf.SelectedIndex == 0)
            {
                dtProductItem.DataSource = ManageStockLayer.GetCategoryList("0");
                dtProductItem.Columns["Status"].Visible = false;

            }
            else if (CatAndManuf.SelectedIndex == 1)
            {
                dtProductItem.DataSource = ManageStockLayer.GetManufacturerList("0");
                dtProductItem.Columns["Status"].Visible = false;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tabManageStock.SelectedIndex == 0)
            {
                if (isValidate())
                {
                    var categoryId = comboBoxCategory.SelectedItem as Category;
                    var manufactId  = comboBoxManufacturer.SelectedItem as Manufacturer;
                    ProductItem item = new ProductItem();
                    item.Id = id;
                    item.Name = txtProductName.Text;
                    item.Status = 1;
                    item.Barcode = string.IsNullOrEmpty(txtBarcode.Text) ? "" : txtBarcode.Text;
                    item.CostPrice = Convert.ToInt32(txtCostPrice.Text);
                    item.SalePrice = Convert.ToInt32(txtSalePrice.Text);
                    item.ManufacturerId = manufactId.Id;
                    item.categoryId = categoryId.Id;
                    Message(ManageStockLayer.EditProduct(item), "updated");
                    dtProductItem.DataSource = ManageStockLayer.GetProductItems("0");
                  

                    dtProductItem.Columns["ManufacturerId"].Visible = false;
                    dtProductItem.Columns["CategoryId"].Visible = false;
                    dtProductItem.Columns["Quantity"].Visible = false;
                    dtProductItem.Columns["Status"].Visible = false;
                    txtBarcode.Text = "";
                    txtSalePrice.Text = "";
                    txtCostPrice.Text = "";
                    txtProductName.Text = "";
                    comboBoxCategory.SelectedIndex = -1;
                    comboBoxManufacturer.SelectedIndex = -1;
                }

            }
            else if (tabManageStock.SelectedIndex == 1)
            {
                if (CatAndManuf.SelectedIndex == 0)
                {
                    Message(ManageStockLayer.EditCategory(id,txtboxCategory.Text),"updated");
                    dtProductItem.DataSource = ManageStockLayer.GetCategoryList("0");
                    fillCategory();
                    txtboxCategory.Text = String.Empty;
                    txtboxCategory.Focus();
                }
                else if (CatAndManuf.SelectedIndex == 1)
                {
                    Message(ManageStockLayer.EditManufacturer(id,txtboxManufacturer.Text),"updated");
                    dtProductItem.DataSource = ManageStockLayer.GetManufacturerList("0");
                    fillManufacturer();
                    txtboxManufacturer.Text = String.Empty;
                    txtboxManufacturer.Focus();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tabManageStock.SelectedIndex == 0)
            {
                Message(ManageStockLayer.RemoveProduct(id), "deleted");
                dtProductItem.DataSource = ManageStockLayer.GetProductItems("0");

             
                dtProductItem.Columns["ManufacturerId"].Visible = false;
                dtProductItem.Columns["CategoryId"].Visible = false;
                dtProductItem.Columns["Quantity"].Visible = false;
                dtProductItem.Columns["Status"].Visible = false;
            }
            else if (tabManageStock.SelectedIndex == 1)
            {
                if (CatAndManuf.SelectedIndex == 0)
                {
                    Message(ManageStockLayer.RemoveCategory(id), "deleted");
                    dtProductItem.DataSource = ManageStockLayer.GetCategoryList("0");
                    dtProductItem.Columns["Status"].Visible = false;


                }
                else if (CatAndManuf.SelectedIndex == 1)
                {
                    Message(ManageStockLayer.RemoveManufacturer(id), "deleted");
                    dtProductItem.DataSource = ManageStockLayer.GetManufacturerList("0");
                    dtProductItem.Columns["Status"].Visible = false;

                }
            }
        }

        private void txtSearchId_KeyDown(object sender, KeyEventArgs e)
        {
           // txtSearchId.SelectAll();
        }

        private void txtSearchId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (tabManageStock.SelectedIndex == 0)
            {
                var val = ManageStockLayer.GetProductItems(txtSearchId.Text);
                if (val != null)
                {
                    
                    var fetchVal = val.FirstOrDefault();
                    id = fetchVal.Id;
                    var a = ManageStockLayer.GetCategoryList(fetchVal.categoryId.ToString());
                    var b = ManageStockLayer.GetManufacturerList(fetchVal.ManufacturerId.ToString());
                    txtBarcode.Text = fetchVal.Barcode;
                    txtCostPrice.Text = fetchVal.CostPrice.ToString();
                    txtSalePrice.Text = fetchVal.SalePrice.ToString();
                    txtProductName.Text = fetchVal.Name;
                    comboBoxCategory.Text = a.FirstOrDefault().Name;
                    comboBoxManufacturer.Text = b.FirstOrDefault().Name;
                    catId = fetchVal.categoryId;
                    ManufId = fetchVal.ManufacturerId;

                }

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
                    var val = ManageStockLayer.GetManufacturerList(txtSearchId.Text);
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
            //txtSearchId.SelectAll();
            //btnSearch.Focus();
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

        private void txtCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
