using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects.Bank
{
    public interface ITransaction
    {
        String Id { get; set; }
        Decimal Amount { get; set; }
        String Date { get; set; }
        String Category { get; set; }
        String Description { get; set; }
        String Status { get; set; }
    }
}
