﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_FinancialPlanner.Models
{
    public class TransactionGroup
    {
        public DateTime Date { get; set; }
        public List<Transaction> Transactions { get; set; } = new();
    }

    public class CategoryGroup
    {
        public string Type { get; set; } = "";
        public List<Category> Categories { get; set; } = new();
    }
}
