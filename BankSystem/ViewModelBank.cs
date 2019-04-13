using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace BankSystem
{
    class ViewModelBank
    {
        private TransactionRepository _tranRep = new TransactionRepository();
        private AccountRepository _accRep = new AccountRepository();

        public List<Transaction> GetAllTransactions()
        {
            return _tranRep.LoadTransactions();
        }
        public List<Account> GetAccountByID(int id)
        {
            return _accRep.SelectAccountByID(id);
        }


    }
}
