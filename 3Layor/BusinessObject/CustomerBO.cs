using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class CustomerBO
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public int Grade { get; set; }
        public int SalesmanID { get; set; }
    }
}
