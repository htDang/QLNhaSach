﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNhaSach.Models.Responses
{
    public class CustomerReceiptInfo
    {
        public int id { get; set; }
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public DateTime dateCreated { get; set; }
        public double customerPaid { get; set; }
        public double total { get; set; }
        public double dept { get; set; }
    }
}
