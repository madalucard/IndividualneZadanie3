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
        private AccountRepository _accRep = new AccountRepository();
        private CustomerRepository _custRep = new CustomerRepository();
        private TransactionRepository _tranRep = new TransactionRepository();


        /// <summary>
        /// Returns list of transactions
        /// </summary>
        /// <returns>Transactions</returns>
        public List<Transaction> GetAllTransactions()
        {
            return _tranRep.LoadTransactions();
        }


        /// <summary>
        /// Returns list of account selected by Id
        /// </summary>
        /// <param name="id">Int for filter</param>
        /// <returns>List of account</returns>
        public List<Account> GetAccountByID(int id)
        {
            return _accRep.SelectAccountByID(id);
        }
        /// <summary>
        /// Returns list of accounts selected by name(string)
        /// </summary>
        /// <param name="name">String for filer</param>
        /// <returns>List of accounts</returns>
        public List<Account> GetAccountsByName(string name)
        {
            return _accRep.SelectAccountByName(name);
        }
        /// <summary>
        /// Returns list of customers selected by Id
        /// </summary>
        /// <param name="id">Int for filter</param>
        /// <returns>List of customers</returns>
        public List<Customers> GetCustomerByID(int id)
        {
            return _custRep.SelectCustomerByID(id);
        }
        /// <summary>
        /// Returns list of customers selected by Firstname
        /// </summary>
        /// <param name="name">String for filer</param>
        /// <returns>List of accounts</returns>
        public List<Customers> GetCustomerByFirstname(string name)
        {
            return _custRep.SelectCustomersByFirstname(name);
        }
        /// <summary>
        /// Returns list of customers selected by Lastname
        /// </summary>
        /// <param name="name">String for filer</param>
        /// <returns>List of accounts</returns>
        public List<Customers> GetCustomerByLastname(string name)
        {
            return _custRep.SelectCustomersByLastname(name);
        }

        public List<Customers> GetCustomerByLastname(string fname, string lname)
        {
            return _custRep.SelectCustomersByFullname(fname, lname);
        }



    }
}
