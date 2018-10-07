using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects.Bank
{
    interface IAccount
    {
        String Id { get; set; }
        String Name { get; set; }
        String Type { get; set; }
        decimal Balance { get; set; }
    }
}
