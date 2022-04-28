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

        public static List<Category> GetCategories(string param)
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
                    cmd.Parameters.AddWithValue("@Type", 1);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }               
            }

            List<Category> catList = new List<Category>();

            //dt.Columns.Add("Id", typeof(Int32));
            //dt.Columns.Add("Name", typeof(string));

            //dt.Rows.Add(1, "Electronic");
            //dt.Rows.Add(2, "Sports");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Category cat = new Category();
                cat.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                cat.Name = dt.Rows[i]["Name"].ToString();
                catList.Add(cat);
            }
            return catList;
        }

        public static int InsertCategory(string param)
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
                        cmd.Parameters.AddWithValue("@Type", 2);
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

        public static int UpdateCategory(int id,string param,int status)
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
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@Type", 2);
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

        public static int InsertManufacturer(string param)
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
                        cmd.Parameters.AddWithValue("@Type", 6);
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

        public static int UpdateManufacturer(int id, string param,int status)
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
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@Type", 7);
                        isAdded = cmd.ExecuteNonQuery();
                        //if (isAdded>0)
                        //{
                        //    MessageBox.Show("Data added successfully","Success");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Something Wrong","Failed");
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return isAdded;
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
