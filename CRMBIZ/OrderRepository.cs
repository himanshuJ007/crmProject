using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crmProject;

namespace CRMBIZ
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
 
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2019, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }
 
        public bool Save()
        {
            return true;
        }
    }
}