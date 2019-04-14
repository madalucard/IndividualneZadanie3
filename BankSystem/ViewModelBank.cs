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
        private CardRepository _cardRep = new CardRepository();
        private CustomerRepository _custRep = new CustomerRepository();
        private TransactionRepository _tranRep = new TransactionRepository();

        #region frmTransactions (all transactions)
        /// <summary>
        /// Returns list of transactions
        /// </summary>
        /// <returns>Transactions</returns>
        public List<Transaction> GetAllTransactions()
        {
            return _tranRep.LoadTransactions();
        }
        #endregion
        #region frmAccounts
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
        /// <summary>
        /// Returns list of customers selected by Fullname
        /// </summary>
        /// <param name="fname">Firstname parameter for filter</param>
        /// <param name="lname">Lastname parameter for filter</param>
        /// <returns>List of account by fullname</returns>
        public List<Customers> GetCustomerByFullname(string fname, string lname)
        {
            return _custRep.SelectCustomersByFullname(fname, lname);
        }
        #endregion

        #region frmClientsManagment
        /// <summary>
        /// Returns list of Cards selected by ID
        /// </summary>
        /// <param name="id">ID parameter for filter</param>
        /// <returns>List of cards</returns>
        public List<Cards> GetAllCardsByAccID(int accId)
        {
            return _cardRep.SelectAllCardsByAccID(accId);
        }



        #endregion

        #region frmAccount



        #endregion



    }
}
