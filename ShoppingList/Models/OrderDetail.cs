﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int Amount { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal LineTotal { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
