using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CustomerBL
    {
        public int InsertCustomer(CustomerBO newCustomer)
        {
            CustomerDA dataaccess = new CustomerDA();
            var result = dataaccess.InsertNewCustomer(newCustomer);

            return result;
        }
    }
}
