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
    public class OrderDA
    {
        string connectionString = ConfigurationManager.ConnectionStrings["InventoryConnectionString"].ConnectionString;

        public int insertOrder(OrderBO orderBO)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("CRUDOrder", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 1);
                cmd.Parameters.AddWithValue("@OrderNo", orderBO.OrderNO);
                cmd.Parameters.AddWithValue("@PurchAmt", orderBO.PurchaseAmt);
                cmd.Parameters.AddWithValue("@OrderDate", orderBO.Orderdate);
                cmd.Parameters.AddWithValue("@CustomerID", orderBO.CustomerID);
                cmd.Parameters.AddWithValue("@SalesmanID", orderBO.SalesmanID);

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

        public int updateOrder(OrderBO updaetOrder)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("CRUDOrder", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 2);
                cmd.Parameters.AddWithValue("@OrderNo", updaetOrder.OrderNO);
                cmd.Parameters.AddWithValue("@PurchAmt", updaetOrder.PurchaseAmt);
                cmd.Parameters.AddWithValue("@OrderDate", updaetOrder.Orderdate);
                cmd.Parameters.AddWithValue("@CustomerID", updaetOrder.CustomerID);
                cmd.Parameters.AddWithValue("@SalesmanID", updaetOrder.SalesmanID);

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

        public int deleteOrder(OrderBO deleteOrder) 
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("CRUDOrder", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 3);
                cmd.Parameters.AddWithValue("@OrderNo", deleteOrder.OrderNO);

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

        public DataTable DisplayAllOrder()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = $"select * from orders";
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
