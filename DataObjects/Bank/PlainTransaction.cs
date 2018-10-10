using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataObjects.Bank
{
    public class PlainTransaction : ITransaction, IEnumerable
    {
		String ITransaction.Id { get; set; }
		Decimal ITransaction.Amount { get; set; }
		String ITransaction.Date { get; set; }
		String ITransaction.Category { get; set; }
		String ITransaction.Description { get; set; }
		String ITransaction.Status { get; set; }

		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
