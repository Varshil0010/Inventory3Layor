using BusinessObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDA
    {
        public int InsertNewCustomer(CustomerBO Customer)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("spCRUDCustomer", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 1);
                cmd.Parameters.AddWithValue("@Customerid", Customer.CustomerID);
                cmd.Parameters.AddWithValue("@Customername", Customer.CustomerName);
                cmd.Parameters.AddWithValue("@City", Customer.City);
                cmd.Parameters.AddWithValue("@Grade", Customer.Grade);
                cmd.Parameters.AddWithValue("@SalesmanId", Customer.SalesmanID);

                connection.Open();
                int result = cmd.ExecuteNonQuery();

                return result;
                //BindGridView();
                //clearAll();
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
    }
}
