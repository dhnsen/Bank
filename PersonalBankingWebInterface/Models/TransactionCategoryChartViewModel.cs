﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataObjects.Bank;


namespace PersonalBankingWebInterface.Models
{
    public class TransactionCategoryChartViewModel : ITransaction
    {
		String ITransaction.Id { get; set; }
		Decimal ITransaction.Amount { get; set; }
		String ITransaction.Date { get; set; }
		String ITransaction.Category { get; set; }
		String ITransaction.Description { get; set; }
		String ITransaction.Status { get; set; }
	}
}
