using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataObjects.Bank;
using DataAccess.Bank;

namespace PersonalBankingWebInterface.Models
{
    public class TransactionCategoryChartViewModel
    {
        TransactionGenericMockDAO DAO = new TransactionGenericMockDAO();
        List<ITransaction> TransactionList = new List<ITransaction>();
        //TransactionList = DAO.GetTransactionGenericsByDate(DateTime.Now, DateTime.Now);

    }
}
