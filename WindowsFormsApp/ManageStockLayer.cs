using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class ManageStockLayer : DataBaseAccess
    {
        public static List<Category> GetCategoryList(string id)
        {
            return GetCategories(id);
        }

        public static int AddCategory(string name)
        {
            return InsertCategory(name);
        }
        public static int EditCategory(int id,string name, int status)
        {
            return UpdateCategory(id,name,status);
        }
        public static List<Manufacturer> GetManufacturerList(string id)
        {
            return GetManufacturer(id);
        }

        public static int AddManufacturer(string name)
        {
            return InsertManufacturer(name);
        }
        public static int EditManufacturer(int id, string name, int status)
        {
            return UpdateManufacturer(id, name, status);
        }

        public static List<ProductItem> GetProductItems()
        {
            List<ProductItem> productItems = new List<ProductItem>();

            DataTable dt = new DataTable("Manufacturer");
            dt.Columns.Add("Id", typeof(Int32));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Barcode", typeof(string));
            dt.Columns.Add("SalePrice", typeof(string));
            dt.Columns.Add("CostPrice", typeof(string));
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Columns.Add("ManufacturerName", typeof(string));

            dt.Rows.Add(1, "Dingdong", "a123", 50, 40, "Electronic", "Hilal");
            dt.Rows.Add(2, "Nimco", "a124", 10, 20, "Sport", "English");
            dt.Rows.Add(3, "Tuc", "a125", 30, 25, "Electronic", "Hilal");
            dt.Rows.Add(4, "Bat", "a126", 100, 200, "Sport", "English");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ProductItem productItem = new ProductItem();
                productItem.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                productItem.Name = dt.Rows[i]["Name"].ToString();
                productItem.Barcode = dt.Rows[i]["Barcode"].ToString();
                productItem.SalePrice = Convert.ToInt32(dt.Rows[i]["SalePrice"]);
                productItem.CostPrice = Convert.ToInt32(dt.Rows[i]["CostPrice"]);
                productItem.categoryName = dt.Rows[i]["CategoryName"].ToString();
                productItem.ManufacturerName = dt.Rows[i]["ManufacturerName"].ToString();
                productItems.Add(productItem);
            }
            return productItems;
        }
    

        public static void insert(string param, string name, int type)
        {
            Insert(param, name, type);
        }
    }

    public class Category : DataBaseAccess
    {
        public List<Category> cat { get; set; }
    }

    public class ProductItem : DataBaseAccess
    {
        public string Barcode { get; set; }
        public int SalePrice { get; set; }
        public int Quantity { get; set; }
        public int CostPrice { get; set; }
        public string categoryName { get; set; }
        public string ManufacturerName { get; set; }
        public List<Category> cat { get; set; }
        public List<Manufacturer> man { get; set; }
    }

    public class Manufacturer : DataBaseAccess
    {
        public List<Manufacturer> man  { get; set; }
    }
}
