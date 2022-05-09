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
        #region Category
        public static List<Category> GetCategoryList(string id)
        {
            DataTable dt = Get(id,1);
            List<Category> catList = new List<Category>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Category cat = new Category();
                cat.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                cat.Name = dt.Rows[i]["Name"].ToString();
                catList.Add(cat);
            }
            return catList;
        }

        public static int AddCategory(string name)
        {
            return Add(name,2);
        }
        public static int EditCategory(int id,string name)
        {
            return Update(id,name,3);
        }
        public static int RemoveCategory(int id)
        {
            return Delete(id,4);
        }
        #endregion

        #region Manufacturer
        public static List<Manufacturer> GetManufacturerList(string id)
        {
            DataTable dt = Get(id,5);
            List<Manufacturer> catList = new List<Manufacturer>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Manufacturer cat = new Manufacturer();
                cat.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                cat.Name = dt.Rows[i]["Name"].ToString();
                catList.Add(cat);
            }
            return catList;
        }

        public static int AddManufacturer(string name)
        {
            return Add(name,6);
        }
        public static int EditManufacturer(int id, string name)
        {
            return Update(id, name,7);
        }
        public static int RemoveManufacturer(int id)
        {
            return Delete(id,8);
        }
        #endregion

        #region Product
        public static List<ProductItem> GetProductItems(string id)
        {
            DataTable dt = Get(id, 9);
            List<ProductItem> productItems = new List<ProductItem>();

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
                productItem.categoryId = Convert.ToInt32(dt.Rows[i]["CategoryId"]);
                productItem.ManufacturerId = Convert.ToInt32(dt.Rows[i]["ManufacturerId"]);
                productItems.Add(productItem);
            }
            return productItems;
        }
        public static int AddProduct(ProductItem productItem)
        {
            return Add(productItem,10);
        }
        public static int EditProduct(ProductItem productItem)
        {
            return Update(productItem,11);
        }

        public static int RemoveProduct(int id)
        {
            return Delete(id, 12);
        }
        #endregion
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
        public int categoryId { get; set; }
        public string ManufacturerName { get; set; }
        public int ManufacturerId { get; set; }
        public List<Category> cat { get; set; }
        public List<Manufacturer> man { get; set; }
    }

    public class Manufacturer : DataBaseAccess
    {
        public List<Manufacturer> man  { get; set; }
    }
}
