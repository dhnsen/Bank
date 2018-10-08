using System;
using System.Collections.Generic;
using System.Text;

namespace DataObjects.Bank
{
    public interface IInstitution
    {
        String Id { get; set; }
        String Name { get; set; }
        String Url { get; set; }
    }
}
