﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class PaymentType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Payment> Payments { get; set; }
    }
    }
