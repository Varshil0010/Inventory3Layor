using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderBO
    {
        public int OrderNO { get; set; }
        public float PurchaseAmt { get; set; }
        public DateTime Orderdate { get; set; }
        public int CustomerID { get; set; }
        public int SalesmanID { get; set; }
    }
}
