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

        // get category , manufacturing and product
        #region category and manufacturing
        protected static DataTable Get(string param,int type)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

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
        
        protected static int Add(string param,int type)
        {
            var isAdded = 0;
            try
            {
                DataTable dt = new DataTable();
                
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
        protected static int Add(ProductItem param, int type)
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
        protected static int Add(CashCounterModel param, int type)
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
                        cmd.Parameters.AddWithValue("@CustomerId", param.CustomerId);
                        cmd.Parameters.AddWithValue("@Quantity", param.Quantity);
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
        protected static int Update(int id,string param,int type)
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
        protected static int Update(ProductItem param, int type)
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
        protected static int Delete(int id,int type)
        {
            var isAdded = 0;
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("storeProcedure", conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
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
        
        #endregion

    }
}
