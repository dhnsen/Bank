using System;
using System.Collections.Generic;
using System.Text;
using DataObjects;
using DataObjects.Abstract;

namespace DataRepositories.Abstract
{
    public interface ITransactionRepository
    {
        IEnumerable<TransactionAbstract> GetTransactionsByDate(DateTime startDate, DateTime endDate);

    }
}
