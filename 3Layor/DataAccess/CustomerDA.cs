using BusinessObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
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

        public int UpdateCustomer(CustomerBO UpdateCustomer)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("spCRUDCustomer", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 2);
                cmd.Parameters.AddWithValue("@Customerid", UpdateCustomer.CustomerID);
                cmd.Parameters.AddWithValue("@Customername", UpdateCustomer.CustomerName);
                cmd.Parameters.AddWithValue("@City", UpdateCustomer.City);
                cmd.Parameters.AddWithValue("@Grade", UpdateCustomer.Grade);
                cmd.Parameters.AddWithValue("@SalesmanId", UpdateCustomer.SalesmanID);

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

        public int DeleteCustomer(CustomerBO DeleterCustomer)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("spCRUDCustomer", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 3);
                cmd.Parameters.AddWithValue("@Customerid", DeleterCustomer.CustomerID);

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

        //public DataTable DisplayAllCustomer()
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;
        //    SqlConnection connection = new SqlConnection(connectionString);

        //    SqlDataAdapter adapter = new SqlDataAdapter();  
        //    SqlCommand cmd = new SqlCommand("spCRUDCustomer", connection);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Action", 0);
        //    DataTable dt = new DataTable();
        //    adapter.SelectCommand = cmd;
        //    connection.Open();
        //    adapter.Fill(dt);

        //    connection.Close();
        //    return dt;
        //}
    }
}
