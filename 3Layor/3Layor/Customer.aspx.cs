using BusinessLogic;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3Layor
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        }
    }
}