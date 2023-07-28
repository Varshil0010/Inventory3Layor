using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class OrderBL
    {
        public int insertNewOrder(OrderBO orderBO)
        {
            OrderDA dataAccess = new OrderDA();
            var result = dataAccess.insertOrder(orderBO);

            return result;
        }

        public int updateOrder(OrderBO orderBO)
        {
            OrderDA dataAccess = new OrderDA();
            var result = dataAccess.updateOrder(orderBO);

            return result;
        }

        public int deleteOrder(OrderBO orderBO)
        {
            OrderDA dataAccess = new OrderDA();
            var result = dataAccess.deleteOrder(orderBO);

            return result;
        }


    }
}
