using BusinessLogic;
using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3Layor
{
    public partial class Salesman : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindSalesmanData();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int sID = Convert.ToInt16(txtID.Text);
            string sName = txtSalesmanName.Text;
            string City = txtCity.Text;
            float commission = float.Parse(txtCommission.Text);

            SalesmanBO newSalesman = new SalesmanBO()
            {
                SalesmanID = sID,
                SalesmanName = sName,
                city = City,
                commission = commission,
            };

            SalesmanBL salesmanBL = new SalesmanBL();
            int result = salesmanBL.InsertSalesman(newSalesman);

            if (result == 0)
            {
                lblSalesmanResult.Text = "Please try again";
            }
            else
            {
                lblSalesmanResult.Text = "Salesman inserted successfully";
            }
            BindSalesmanData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int sID = Convert.ToInt16(txtID.Text);
            string sName = txtSalesmanName.Text;
            string City = txtCity.Text;
            float commission = float.Parse(txtCommission.Text);

            SalesmanBO updateSalesman = new SalesmanBO()
            {
                SalesmanID = sID,
                SalesmanName = sName,
                city = City,
                commission = commission,
            };

            SalesmanBL salesmanBL = new SalesmanBL();
            int result = salesmanBL.updateSaleman(updateSalesman);

            if(result == 0)
            {
                lblSalesmanResult.Text = "Salesman not updated";
            }
            else
            {
                lblSalesmanResult.Text = "Successfully updated";
            }
            BindSalesmanData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int sID = Convert.ToInt16(txtID.Text);

            SalesmanBO deleteSalesman = new SalesmanBO()
            {
                SalesmanID = sID,
            };

            SalesmanBL salesmanBL = new SalesmanBL();
            int result = salesmanBL.daleteSalesman(deleteSalesman);

            if(result == 0)
            {
                lblSalesmanResult.Text = "Salesman not delete! Please try again";
            }
            else
            {
                lblSalesmanResult.Text = "Successfully deleted";
            }
            BindSalesmanData();
        }

        private void BindSalesmanData()
        {
            SalesmanDA salesmanDA = new SalesmanDA();

            DataTable table = salesmanDA.SelectSalesman();

            if(table != null && table.Rows.Count > 0)
            {
                gvSalesman.DataSource = table;
                gvSalesman.DataBind();
            }
        }
    }
}