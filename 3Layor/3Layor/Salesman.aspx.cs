using BusinessObject;
using System;
using System.Collections.Generic;
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
        }
    }
}