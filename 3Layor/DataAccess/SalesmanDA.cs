using BusinessObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SalesmanDA
    {
        string connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;
        public int InsertSalesman(SalesmanBO salesmanBO)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("spCRUDSalesman", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 1);
                cmd.Parameters.AddWithValue("@SalesmanId", salesmanBO.SalesmanID);
                cmd.Parameters.AddWithValue("@SalesmanName", salesmanBO.SalesmanName);
                cmd.Parameters.AddWithValue("@City", salesmanBO.city);
                cmd.Parameters.AddWithValue("@Commission", salesmanBO.commission);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result;

            }
            catch(Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message, ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public int updateSalesman (SalesmanBO salesmanBO)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("spCRUDSalesman", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 2);
                cmd.Parameters.AddWithValue("@SalesmanId", salesmanBO.SalesmanID);
                cmd.Parameters.AddWithValue("@SalesmanName", salesmanBO.SalesmanName);
                cmd.Parameters.AddWithValue("@City", salesmanBO.city);
                cmd.Parameters.AddWithValue("@Commission", salesmanBO.commission);

                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch(Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message, ex);
            }
            finally 
            { 
                connection.Close(); 
            }
        }

        public int deleteSalesman(SalesmanBO salesmanBO)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("spCRUDSalesman", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 3);
                cmd.Parameters.AddWithValue("@SalesmanId", salesmanBO.SalesmanID);

                connection.Open();
                int result = cmd.ExecuteNonQuery();

                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message, ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectSalesman()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = $"select * from salesman";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable table = new DataTable();
            adapter.SelectCommand = cmd;
            connection.Open();
            adapter.Fill(table);

            connection.Close();
            return table;
        }
    }
}
