using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace crmProject
{
    public class Ordero
    {
        public Ordero()
        {
 
        }
 
        public Ordero(int orderId)
        {
            this.OrderId = orderId;
        }
 
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
 
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> orderItems { get; set; }
 
        public bool Validate()
        {
            var isValid = true;
 
            if (OrderDate == null) isValid = false;
 
            return isValid;
        }
    }
}