using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects.Bank
{
    public class TransactionGeneric : ITransaction
    {
        public string Id {get; set;}
        public decimal Amount {get; set;}
        public string Date {get; set;}
        public string Category {get; set;}
        public string Description {get; set;}
        public string Status {get; set;}
    }
}
