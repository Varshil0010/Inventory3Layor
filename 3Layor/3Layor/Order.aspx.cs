using BusinessLogic;
using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace _3Layor
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindOrderData();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int ONO = Convert.ToInt32(orderID.Text.Trim());
            float PAmt = float.Parse(txtAmt.Text.Trim());
            DateTime orderDate = Convert.ToDateTime(txtDate.Text.Trim());
            int cID = Convert.ToInt32(txtCustomerID.Text.Trim());
            int sID = Convert.ToInt32(txtSalesmanID.Text.Trim());

            OrderBO orderBO = new OrderBO()
            {
                OrderNO = ONO,
                PurchaseAmt = PAmt,
                Orderdate = orderDate,
                CustomerID = cID,
                SalesmanID = sID,
            };

            OrderBL orderBL = new OrderBL();
            int result = orderBL.insertNewOrder(orderBO);

            if (result == 0)
            {
                lblOrder.Text = "Order not inserted! Try again";
            }
            else
            {
                lblOrder.Text = "Order successfully inserted";
            }
            clearAll();
            BindOrderData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int ONO = Convert.ToInt32(orderID.Text.Trim());
            float PAmt = float.Parse(txtAmt.Text.Trim());
            DateTime orderDate = Convert.ToDateTime(txtDate.Text.Trim());
            int cID = Convert.ToInt32(txtCustomerID.Text.Trim());
            int sID = Convert.ToInt32(txtSalesmanID.Text.Trim());

            OrderBO orderBO = new OrderBO()
            {
                OrderNO = ONO,
                PurchaseAmt = PAmt,
                Orderdate = orderDate,
                CustomerID = cID,
                SalesmanID = sID,
            };

            OrderBL orderBL = new OrderBL();
            int result = orderBL.updateOrder(orderBO);

            if(result == 0)
            {
                lblOrder.Text = "Order not successfully updated! Please try again";
            }
            else
            {
                lblOrder.Text = "Order successfully updated";
            }
            clearAll();
            BindOrderData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int ONO = Convert.ToInt32(orderID.Text.Trim());

            OrderBO orderBO = new OrderBO()
            {
                OrderNO = ONO,
            };

            OrderBL orderBL = new OrderBL();
            int result = orderBL.deleteOrder(orderBO);

            if(result == 0)
            {
                lblOrder.Text = "Order not successfully deleted! Please try again";
            }
            else
            {
                lblOrder.Text = "Order successfully deleted";
            }
            clearAll();
            BindOrderData();
        }

        public void clearAll()
        {
            orderID.Text = "";
            txtAmt.Text = "";
            txtDate.Text = "";
            txtCustomerID.Text = "";
            txtSalesmanID.Text = "";
        } 

        private void BindOrderData()
        {
            OrderDA dataAccess = new OrderDA();
            DataTable dt = dataAccess.DisplayAllOrder();

            if (dt != null && dt.Rows.Count > 0)
            {
                gvOrders.DataSource = dt;
                gvOrders.DataBind();
            }
        }
    }
}