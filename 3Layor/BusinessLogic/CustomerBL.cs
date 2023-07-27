using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
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

        public int UpdateCustomer(CustomerBO updateCustomer)
        {
            CustomerDA dataAccess = new CustomerDA();
            var result = dataAccess.UpdateCustomer(updateCustomer);

            return result;
        }

        public int DeleteCustomer(CustomerBO deleteCustomer)
        {
            CustomerDA dataAccess = new CustomerDA();
            var result = dataAccess.DeleteCustomer(deleteCustomer);

            return result;
        }

        //public DataTable AllCustomer()
        //{
        //    CustomerDA dataAccess = new CustomerDA();
        //    DataTable result = dataAccess.DisplayAllCustomer();

        //    return result;
        //}
    }
}
