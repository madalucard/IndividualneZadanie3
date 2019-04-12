using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class ViewModelBank
    {
        private TransactionRepository _tranRep = new TransactionRepository();

        public List<Transaction> GetTransactions()
        {
            return _tranRep.LoadTransactions();
        }
    }
}
