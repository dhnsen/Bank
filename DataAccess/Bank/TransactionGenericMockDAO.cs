using System;
using System.Collections.Generic;
using System.Text;
using DataObjects.Bank;

namespace DataAccess.Bank
{
    public class TransactionGenericMockDAO
    {
        public IEnumerable<TransactionGeneric> GetTransactionGenericsByDate(DateTime startDateWillBeIgnored, DateTime endDateWillBeIgnored)
        {
            List<TransactionGeneric> Transactions = new List<TransactionGeneric>{
                { new TransactionGeneric{Id="-8d2b-4859-8c1e-502009f30052", Amount=95.47m, Date="2018-07-30 22:15:59",Category="Music", Description="Suspendisse potenti", Status="true"  } },
                { new TransactionGeneric{Id="9dedf6b3 - bbac - 4781 - 8480 - 1746a5b36397", Amount=52.7m, Date="2018 - 04 - 10 07:56:31",Category="Industrial", Description="Quisque id justo sit amet sapien dignissim vestibulum", Status="true" } },
                { new TransactionGeneric{Id="6d42dc39 - 3487 - 4431 - 9b7d - e2c26bf7189e", Amount=67.25m, Date="2018 - 09 - 15 13:58:53",Category="Health", Description="Proin interdum mauris non ligula pellentesque ultrices", Status="false" } },
                { new TransactionGeneric{Id="59e55a60 - 4a41 - 4591 - 8285 - 365f59e735c0", Amount=37.75m, Date="2018 - 07 - 01 10:23:35",Category="Baby", Description="Duis mattis egestas metus", Status="true" } },
                { new TransactionGeneric{Id="70396eaa - c2ab - 4ced - 802c - b0d13c52cea3", Amount=63.59m, Date="2018 - 05 - 12 23:08:43",Category="Automotive", Description="In congue", Status="false" } },
                { new TransactionGeneric{Id="c3916be3 - c1b1 - 46c3 - 9d24 - 1cc90b179d1b", Amount=28.89m, Date="2017 - 11 - 28 01:25:19",Category="Computers", Description="Nam nulla", Status="false" } } ,
                { new TransactionGeneric{Id="900da5da - 5223 - 4aac - 9a98 - f103c5e810d2", Amount=28.71m, Date="2018 - 07 - 06 15:51:26",Category="Kids", Description="Duis aliquam convallis nunc", Status="true" } },
                { new TransactionGeneric{Id="1c7ec4d5 - 03ff - 429b - 927a - fd447f26bcb8", Amount=14.16m, Date="2017 - 11 - 27 20:35:29",Category="Computers", Description="Ut at dolor quis odio consequat varius", Status="false" } },
                { new TransactionGeneric{Id="07a77c7b - 5259 - 481f - 979b - e095438335f6", Amount=79.07m, Date="2018 - 01 - 28 18:50:34",Category="Beauty", Description="Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl", Status="false"}},
                { new TransactionGeneric{Id= "6f7ab04f - b817 - 43c3 - b27b - 95c9f253fefb", Amount = 92.6m, Date="2018 - 05 - 01 08:07:02",Category="Books", Description="Proin eu mi", Status="false" } }
            };
            return Transactions;
        }
    }
}
