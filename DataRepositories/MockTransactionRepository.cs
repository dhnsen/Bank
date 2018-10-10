using DataObjects;
using DataObjects.Abstract;
using DataRepositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepositories
{
    public class MockTransactionRepository : ITransactionRepository
    {
        public IEnumerable<TransactionAbstract> GetTransactionsByDate(DateTime startDate, DateTime endDate)
        {
            return new List<Transaction>
            {
                //{ new PlainTransaction{ITransaction.Id="-8d2b-4859-8c1e-502009f30052", ITransaction.Amount=95.47m, ITransaction.Date="2018-07-30 22:15:59",ITransaction.Category="Music", ITransaction.Description="Suspendisse potenti", ITransaction.Status="true"  } },
                //{ new PlainTransaction{ITransaction.Id="9dedf6b3 - bbac - 4781 - 8480 - 1746a5b36397", ITransaction.Amount=52.7m, ITransaction.Date="2018 - 04 - 10 07:56:31",ITransaction.Category="Industrial", ITransaction.Description="Quisque ITransaction.Id justo sit amet sapien dignissim vestibulum", ITransaction.Status="true" } },
                //{ new PlainTransaction{ITransaction.Id="6d42dc39 - 3487 - 4431 - 9b7d - e2c26bf7189e", ITransaction.Amount=67.25m, ITransaction.Date="2018 - 09 - 15 13:58:53",ITransaction.Category="Health", ITransaction.Description="Proin interdum mauris non ligula pellentesque ultrices", ITransaction.Status="false" } },
                //{ new PlainTransaction{ITransaction.Id="59e55a60 - 4a41 - 4591 - 8285 - 365f59e735c0", ITransaction.Amount=37.75m, ITransaction.Date="2018 - 07 - 01 10:23:35",ITransaction.Category="Baby", ITransaction.Description="Duis mattis egestas metus", ITransaction.Status="true" } },
                //{ new PlainTransaction{ITransaction.Id="70396eaa - c2ab - 4ced - 802c - b0d13c52cea3", ITransaction.Amount=63.59m, ITransaction.Date="2018 - 05 - 12 23:08:43",ITransaction.Category="Automotive", ITransaction.Description="In congue", ITransaction.Status="false" } },
                //{ new PlainTransaction{ITransaction.Id="c3916be3 - c1b1 - 46c3 - 9d24 - 1cc90b179d1b", ITransaction.Amount=28.89m, ITransaction.Date="2017 - 11 - 28 01:25:19",ITransaction.Category="Computers", ITransaction.Description="Nam nulla", ITransaction.Status="false" } } ,
                //{ new PlainTransaction{ITransaction.Id="900da5da - 5223 - 4aac - 9a98 - f103c5e810d2", ITransaction.Amount=28.71m, ITransaction.Date="2018 - 07 - 06 15:51:26",ITransaction.Category="KITransaction.Ids", ITransaction.Description="Duis aliquam convallis nunc", ITransaction.Status="true" } },
                //{ new PlainTransaction{ITransaction.Id="1c7ec4d5 - 03ff - 429b - 927a - fd447f26bcb8", ITransaction.Amount=14.16m, ITransaction.Date="2017 - 11 - 27 20:35:29",ITransaction.Category="Computers", ITransaction.Description="Ut at dolor quis odio consequat varius", ITransaction.Status="false" } },
                //{ new PlainTransaction{ITransaction.Id="07a77c7b - 5259 - 481f - 979b - e095438335f6", ITransaction.Amount=79.07m, ITransaction.Date="2018 - 01 - 28 18:50:34",ITransaction.Category="Beauty", ITransaction.Description="Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl", ITransaction.Status="false"}},
                //{ new PlainTransaction{ITransaction.Id= "6f7ab04f - b817 - 43c3 - b27b - 95c9f253fefb", ITransaction.Amount = 92.6m, ITransaction.Date="2018 - 05 - 01 08:07:02",ITransaction.Category="Books", ITransaction.Description="Proin eu mi", ITransaction.Status="false" } }

            };
        }
    }
}
