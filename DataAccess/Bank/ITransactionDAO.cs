using System;
using System.Collections.Generic;
using System.Text;
using DataObjects.Bank;

namespace DataAccess.Bank
{
	public interface ITransactionDAO
	{
		IEnumerable<ITransaction> GetTransactionsByDate(DateTime startDate, DateTime endDate);
	}
}
