using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class Payment
    {

        public int Id { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int PaymentTypeId { get; set; }

        public PaymentType PaymentType { get; set; }

        public DateTime Date { get; set; }

        public bool IsApproved { get; set; }

        public int ApproveCode { get; set; }

        public decimal PaymentTotal { get; set; }
    }
}
