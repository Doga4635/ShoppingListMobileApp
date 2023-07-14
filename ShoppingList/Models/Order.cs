using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public DateTime CreatedDate { get; set; }

        public decimal TotalPrice { get; set; }

        public string Status { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<Payment> Payments { get; set; }

        public List<Invoice> Invoices { get; set; }
    }
}
