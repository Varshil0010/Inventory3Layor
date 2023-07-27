using BusinessLogic;
using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace _3Layor
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    BindGridView();
            //}
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int cID = Convert.ToInt16(txtID.Text);
            string cName = txtName.Text;
            string city = txtCity.Text;
            int grade = Convert.ToInt16(txtGrade.Text);
            int sID = Convert.ToInt16(txtSalesmanID.Text);

            CustomerBO newCustomer = new CustomerBO()
            {
                CustomerID = cID,
                CustomerName = cName,
                City = city,
                Grade = grade,
                SalesmanID = sID,
            };

            CustomerBL businessLogic = new CustomerBL();
            int result = businessLogic.InsertCustomer(newCustomer);
            if (result == 0)
            {
                lblCustomer.Text = "Please try again";
            }
            else
            {
                lblCustomer.Text = "Customer Successfully inserted!";
            }
            clearAll();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int cID = Convert.ToInt16(txtID.Text);
            string cName = txtName.Text;
            string city = txtCity.Text;
            int grade = Convert.ToInt16(txtGrade.Text);
            int sID = Convert.ToInt16(txtSalesmanID.Text);

            CustomerBO updateCustomer = new CustomerBO()
            {
                CustomerID = cID,
                CustomerName = cName,
                City = city,
                Grade = grade,
                SalesmanID = sID,
            };

            CustomerBL businessLogic = new CustomerBL();
            int result = businessLogic.UpdateCustomer(updateCustomer);

            if (result == 0)
            {
                lblCustomer.Text = "Customer that you trying to update is not updated! Please try again!";
            }
            else
            {
                lblCustomer.Text = "Customer successfully updated";
            }
            clearAll();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int cID = Convert.ToInt16(txtID.Text);

            CustomerBO deleteCustomer = new CustomerBO()
            {
                CustomerID = cID
            };

            CustomerBL businessLogic = new CustomerBL();
            int result = businessLogic.DeleteCustomer(deleteCustomer);

            if (result == 0)
            {
                lblCustomer.Text = "Customer not delete! Please try again";
            }
            else
            {
                lblCustomer.Text = "Customer successfully deleted";
            }
            clearAll();
        }

        private void clearAll()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtCity.Text = "";
            txtGrade.Text = "";
            txtSalesmanID.Text = "";
            txtID.Focus();
        }

        //private void BindGridView()
        //{
        //    CustomerDA customerDA = new CustomerDA();
        //    DataTable table = customerDA.DisplayAllCustomer();

        //    if(table == null && table.Rows.Count > 0)
        //    {
        //        gvCustomer.DataSource = table;
        //        gvCustomer.DataBind();
        //    }
        //}
    }
}