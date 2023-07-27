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
    public class SalesmanBL
    {
        public int InsertSalesman(SalesmanBO salesmanBO)
        {
            SalesmanDA salesmanDA = new SalesmanDA();
            var result = salesmanDA.InsertSalesman(salesmanBO);

            return result;
        }

        public int updateSaleman(SalesmanBO salesmanBO)
        {
            SalesmanDA dataAccess = new SalesmanDA();   
            var result = dataAccess.updateSalesman(salesmanBO);

            return result;
        }

        public int daleteSalesman(SalesmanBO salesmanBO)
        {
            SalesmanDA dataAccess = new SalesmanDA();
            var result = dataAccess.deleteSalesman(salesmanBO);

            return result;
        }

        //public DataTable SelectAllSalesman()
        //{
        //    SalesmanDA salesmanDA = new SalesmanDA();
        //    DataTable result = salesmanDA.SelectSalesman();

        //    return result;
        //}
    }
}
