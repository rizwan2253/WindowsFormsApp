using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public abstract class DataBaseAccess
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        static string  connString = ConfigurationManager.ConnectionStrings["CashFlowApp"].ConnectionString;

        public static  bool Insert(string param, object val,int type)
        {
            
            int isdone = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("storeProcedure", conn);
                cmd.CommandType = CommandType.StoredProcedure;               
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue(param, val);
                conn.Open();
               isdone = cmd.ExecuteNonQuery();
                conn.Close();
                if (isdone > 0)
                {
                    return true;
                }
                return false;
            }
        }

        

        // get category and manufacturing
        #region category and manufacturing
        public static DataTable Get(string param,int type)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable("Category");

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("storeProcedure", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", param);
                    cmd.Parameters.AddWithValue("@Type", type);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
           
            return dt;
        }

        public static int Add(string param,int type)
        {
            var isAdded = 0;
            try
            {
                DataTable dt = new DataTable("Category");
                
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("storeProcedure", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", param);
                        cmd.Parameters.AddWithValue("@Type", type);
                        isAdded = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
                return isAdded;
        }

        public static int Update(int id,string param,int type)
        {
            var isAdded = 0;
            try
            {
                DataTable dt = new DataTable("Category");

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("storeProcedure", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", param);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@Type", type);
                        isAdded = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return isAdded;
        }

        public static int Delete(int id,int type)
        {
            var isAdded = 0;
            try
            {
                DataTable dt = new DataTable("Category");

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("storeProcedure", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@status", 0);
                        cmd.Parameters.AddWithValue("@Type", type);
                        isAdded = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return isAdded;
        }
        #endregion
        
        public static int Add(ProductItem param,int type)
        {
            var isAdded = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("storeProcedure", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", param.Name);
                        cmd.Parameters.AddWithValue("@Barcode", param.Barcode);
                        cmd.Parameters.AddWithValue("@SalePrice", param.SalePrice);
                        cmd.Parameters.AddWithValue("@CostPrice", param.CostPrice);
                        cmd.Parameters.AddWithValue("@CategoryId", param.categoryId);
                        cmd.Parameters.AddWithValue("@ManufacturerId", param.ManufacturerId);
                        cmd.Parameters.AddWithValue("@Type", type);
                        isAdded = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return isAdded;
        }

        public static int Update(ProductItem param, int type)
        {
            var isAdded = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("storeProcedure", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", param.Id);
                        cmd.Parameters.AddWithValue("@status", param.Status);
                        cmd.Parameters.AddWithValue("@Name", param.Name);
                        cmd.Parameters.AddWithValue("@Barcode", param.Barcode);
                        cmd.Parameters.AddWithValue("@SalePrice", param.SalePrice);
                        cmd.Parameters.AddWithValue("@CostPrice", param.CostPrice);
                        cmd.Parameters.AddWithValue("@CategoryId", param.categoryId);
                        cmd.Parameters.AddWithValue("@ManufacturerId", param.ManufacturerId);
                        cmd.Parameters.AddWithValue("@Type", type);
                        isAdded = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return isAdded;
        }

        public static List<Manufacturer> GetManufacturer(string param)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable("Manufacturer");

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("storeProcedure", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", param);
                    cmd.Parameters.AddWithValue("@Type", 5);

                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            List<Manufacturer> Manufact = new List<Manufacturer>();

            // dt = new DataTable("Manufacturer");
            //dt.Columns.Add("Id", typeof(Int32));
            //dt.Columns.Add("Name", typeof(string));

            //dt.Rows.Add(1, "Hilal");
            //dt.Rows.Add(2, "English");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Manufacturer cat = new Manufacturer();
                cat.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                cat.Name = dt.Rows[i]["Name"].ToString();
                Manufact.Add(cat);
            }
            return Manufact;
        }      

        public static DataTable GetData(string sp, string param)
        {
            SqlDataAdapter da;
            string connString = ConfigurationManager.ConnectionStrings["CashFlowApp"].ConnectionString;


            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sp, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", param);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }


    }
}
