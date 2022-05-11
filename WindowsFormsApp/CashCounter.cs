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
    public partial class CashCounter : Form
    {
        ProductItem selectedItem = null;
        List<ProductItem> productItems = new List<ProductItem>();
        List<ProductItem> products = ManageStockLayer.GetProductItems("0");
        int oldquantity = 0;
        public CashCounter()
        {
            InitializeComponent();
        }

        private void CashCounter_Load(object sender, EventArgs e)
        {
            fillItems();
           // dataGridViewItemsDetail.DataSource = products;
            ClearFields();
            buttonSavePrint.Enabled = false;
            txtBoxCustomerId.Text = CashCounterLayer.GetCustomerId().ToString();

        }

        private void fillItems()
        {
            comboBoxItems.DisplayMember = "Name";
            comboBoxItems.ValueMember = "Id";
            comboBoxItems.DataSource = products;

        }

        private void SelectedValueChanged_Items(object sender, EventArgs e)
        {           
            selectedItem = comboBoxItems.SelectedItem as ProductItem;
            var selectedList = products.Where(a => a.Name == selectedItem.Name);
            if (selectedItem != null)
            {
                textBoxSalePrice.Text = selectedItem.SalePrice.ToString();
                textBoxBarcode.Text = selectedItem.Barcode;
                textBoxManufacturer.Text = selectedItem.ManufacturerName;
                textBoxCategory.Text = selectedItem.categoryName;
                textBoxQuantity.Focus();
            }
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            

            if (selectedItem == null)
            {
                MessageBox.Show("select item","Fields Empty!");
                textBoxBarcode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxQuantity.Text))
            {
                MessageBox.Show("Please enter Quantity");
                textBoxQuantity.Focus();
                return;
            }

            var a = productItems.Where(c=>c.Name== selectedItem.Name).FirstOrDefault();
            if (a!=null)
            {

                //productItems.Where(c => c.Name == selectedItem.Name).Select(f=>f.Quantity = f.Quantity+ Convert.ToInt32(textBoxQuantity.Text)).FirstOrDefault();
                var toRemove = productItems.Where(c => c.Name == selectedItem.Name).FirstOrDefault();
                productItems.Remove(toRemove);
                selectedItem.Quantity = Convert.ToInt32( textBoxQuantity.Text) + oldquantity;
                productItems.Add(selectedItem);

            }
            else
            {
                productItems.Add(selectedItem);
            }
            dataGridViewCustomer.DataSource = null;
            dataGridViewCustomer.DataSource = productItems;
            dataGridViewCustomer.Columns["CostPrice"].Visible = false;
            dataGridViewCustomer.Columns["Id"].Visible = false;
            dataGridViewCustomer.Columns["ManufacturerName"].Visible = false;
            dataGridViewCustomer.Columns["ManufacturerId"].Visible = false;
            dataGridViewCustomer.Columns["CostPrice"].Visible = false;
            dataGridViewCustomer.Columns["categoryId"].Visible = false;
            dataGridViewCustomer.Columns["Status"].Visible = false;
            TotalAmount.Text ="Rs." + productItems.Sum(x => x.SalePrice).ToString();
            TotalQuantity.Text = productItems.Sum(x => x.Quantity).ToString();
            ClearFields();
            if (productItems!=null && productItems.Count>0)
            {
                buttonSavePrint.Enabled = true;
            }
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxQuantity.Text) && selectedItem != null)
            {
                 oldquantity = selectedItem.Quantity;
                selectedItem.Quantity = Convert.ToInt32(textBoxQuantity.Text);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
            TotalAmount.Text = "";
            TotalQuantity.Text = "";
            productItems.Clear();
            dataGridViewCustomer.DataSource = null;

            txtBoxCustomerId.Text = CashCounterLayer.GetCustomerId().ToString(); 
            txtMobNo.Text = "";
        }

        private void ClearFields()
        {
            comboBoxItems.SelectedIndex = -1;
            comboBoxItems.Focus();           
            textBoxSalePrice.Text =
            textBoxBarcode.Text = "";
            textBoxManufacturer.Text = "";
            textBoxCategory.Text = "";
            textBoxQuantity.Text = "";
        }

        private void buttonSavePrint_Click(object sender, EventArgs e)
        {
            if (productItems != null && productItems.Count == 0)
            {
                MessageBox.Show("No record to save and print");
                return;
            }

            CashCounterModel cashCounter = new CashCounterModel();
            var item = comboBoxItems.SelectedItem as ProductItem;

            List<CashCounter> cc = new List<CashCounter>();
            foreach (var item1 in productItems)
            {
                CashCounterModel cashCounter1 = new CashCounterModel();
                cashCounter1.CustomerId = Convert.ToInt32(txtBoxCustomerId.Text);
                cashCounter1.Id = item1.Id;
                cashCounter1.Quantity = Convert.ToInt32(item1.Quantity);
                CashCounterLayer.InsertCustomerDetail(cashCounter1);
            }

          
            //cashCounter.CustomerId = Convert.ToInt32(txtBoxCustomerId.Text);
            //cashCounter.Id = item.Id;
            //cashCounter.Quantity = Convert.ToInt32(textBoxQuantity.Text);
            //var a = CashCounterLayer.InsertCustomerDetail(cashCounter);
            printPreviewDialog.Document = printDocument;
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            printPreviewDialog.Show();
            ClearFields();
            TotalAmount.Text = "";
            TotalQuantity.Text = "";
            
            dataGridViewCustomer.DataSource = null;
            txtBoxCustomerId.Text = CashCounterLayer.GetCustomerId().ToString();
            txtMobNo.Text = "";
            
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i = 0,sno=0;
            e.Graphics.DrawString("ABC Store",new Font("Arial",24,FontStyle.Bold),Brushes.Black,new Point(25,40));
            e.Graphics.DrawString("Customer Id:"+ txtBoxCustomerId.Text, new Font("Arial",8,FontStyle.Regular),Brushes.Black,new Point(10,100));
            e.Graphics.DrawString("Mobile No. :"+txtMobNo.Text, new Font("Arial",8,FontStyle.Regular),Brushes.Black,new Point(10,115));
            e.Graphics.DrawString("Date : "+DateTime.Now,new Font("Arial",8, FontStyle.Regular),Brushes.Black,new Point(10,130));
            e.Graphics.DrawString("__________________________________________", new Font("Arial",8, FontStyle.Regular),Brushes.Black,new Point(5,135));
            e.Graphics.DrawString("S.No", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, 150));
            e.Graphics.DrawString("Name", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(40, 150));
            e.Graphics.DrawString("Quantity", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(190, 150));
            e.Graphics.DrawString("Price", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(240, 150));
            e.Graphics.DrawString("__________________________________________", new Font("Arial",8, FontStyle.Regular),Brushes.Black,new Point(5,153));
            foreach (var item in productItems)
            {
                i += 15;
                sno++;
                e.Graphics.DrawString(sno.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, i+152));
                e.Graphics.DrawString(item.Name, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(40, i+152));
                e.Graphics.DrawString(item.Quantity.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(195, i+152));
                e.Graphics.DrawString(item.SalePrice.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(240, i+152));
            }
            e.Graphics.DrawString("__________________________________________", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, i+160));
            e.Graphics.DrawString("Grand Total", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(10, i+175));
            e.Graphics.DrawString(productItems.Sum(x => x.Quantity).ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(195, i+175));
            e.Graphics.DrawString("Rs. "+productItems.Sum(x => x.SalePrice).ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(240, i+175));
            e.Graphics.DrawString("__________________________________________", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, i+180));
            productItems.Clear();
            
        }

        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBoxBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                var selectedList = products.Where(a => a.Barcode == textBoxBarcode.Text);
                var m = ManageStockLayer.GetManufacturerList(selectedList.FirstOrDefault().ManufacturerId.ToString());
                var c = ManageStockLayer.GetCategoryList(selectedList.FirstOrDefault().categoryId.ToString());
                textBoxManufacturer.Text = m.FirstOrDefault().Name;
                textBoxCategory.Text = c.FirstOrDefault().Name;
                comboBoxItems.Text = selectedList.FirstOrDefault().Name;
                textBoxSalePrice.Text = selectedList.FirstOrDefault().SalePrice.ToString();;
                textBoxQuantity.Focus();
            }
            if (selectedItem != null)
            {
                
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.SelectedCells.Count == 0)
            {
                MessageBox.Show("No record to remove item");

                return;
            }
            var a = dataGridViewCustomer.SelectedCells[9].Value;
          var remove =  productItems.Where(b => b.Name == a.ToString()).FirstOrDefault();
            productItems.Remove(remove);
            dataGridViewCustomer.DataSource=null;
            dataGridViewCustomer.DataSource=productItems;
            dataGridViewCustomer.Columns["CostPrice"].Visible = false;
            dataGridViewCustomer.Columns["Id"].Visible = false;
            dataGridViewCustomer.Columns["ManufacturerName"].Visible = false;
            dataGridViewCustomer.Columns["ManufacturerId"].Visible = false;
            dataGridViewCustomer.Columns["CostPrice"].Visible = false;
            dataGridViewCustomer.Columns["categoryId"].Visible = false;
            dataGridViewCustomer.Columns["Status"].Visible = false;
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
