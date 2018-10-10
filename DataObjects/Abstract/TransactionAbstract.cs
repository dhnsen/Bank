using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects.Abstract
{
    public abstract class TransactionAbstract
    {
        String Id { get; set; }
        Decimal Amount { get; set; }
        String Date { get; set; }
        String Category { get; set; }
        String Description { get; set; }
        String Status { get; set; }
    }
}
