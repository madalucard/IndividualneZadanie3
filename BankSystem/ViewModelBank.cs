using System;
using System.Collections.Generic;
using System.Data;
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

        public DataSet FillDataSet(int accId)
        {
            return _tranRep.FillDataSet(accId);
        }




        #region frmAccount
        /// <summary>
        /// Register customer
        /// </summary>
        /// <param name="title"></param>
        /// <param name="fName"></param>
        /// <param name="mName"></param>
        /// <param name="lName"></param>
        /// <param name="suffix"></param>
        /// <param name="birthdate"></param>
        /// <param name="idCardPers"></param>
        /// <param name="address"></param>
        /// <param name="postcode"></param>
        /// <param name="cityId"></param>
        /// <param name="country"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <returns>Id of registered customer</returns>
        public int RegisterCustomers(string title, string fName, string mName, string lName, string suffix, DateTime birthdate, string idCardPers, string address, string postcode, int cityId, string country, string phone, string email)
        {
            return _custRep.RegisterCustomer(title, fName, mName, lName, suffix, birthdate, idCardPers, address, postcode, cityId, country, phone, email);
        }
        /// <summary>
        /// Register Accout
        /// </summary>
        /// <param name="idCustomer"></param>
        /// <param name="accName"></param>
        /// <param name="overdraft"></param>
        /// <returns>Id of registerd account</returns>
        public int RegisterAccount(int idCustomer, string accName, int overdraft)
        {
            return _accRep.RegisterAccount(idCustomer, accName, overdraft);
        }

        /// <summary>
        /// Select Account by CustomerId
        /// </summary>
        /// <param name="idCustomer"></param>
        /// <returns>Account selected by ID</returns>
        public Account GetAccountByCustomerID( int idCustomer)
        {
            return _accRep.SelectAccountByCustomerID(idCustomer);
        }
        /// <summary>
        /// Update / change Account activity of by Idcustomer
        /// </summary>
        /// <param name="idCustomer">Customer id (owner of account)</param>
        public void UpdateAccountActivityByIdCustomer(int idCustomer)
        {
            _accRep.UpdateAccountActivityByIdCustomer(idCustomer);
        }
        /// <summary>
        /// Update / change Customer activity of by Idcustomer
        /// </summary>
        /// <param name="idCustomer">Customer id </param>
        public void UpdateCustomerActivityByIdCustomer(int idCustomer)
        {
            _custRep.UpdateCustomerActivityByIdCustomer(idCustomer);
        }
        /// <summary>
        /// Update customers info
        /// </summary>
        /// <param name="idCustomer">CustomerId</param>
        /// <param name="title">Title</param>
        /// <param name="fName">FirstName</param>
        /// <param name="mName">MiddleName</param>
        /// <param name="lName">Lastname</param>
        /// <param name="suffix">Suffix</param>
        /// <param name="birthdate">BirthDate</param>
        /// <param name="idCardPers">IdCard of person</param>
        /// <param name="address">Address</param>
        /// <param name="postcode">Postcode</param>
        /// <param name="cityId">Id of city</param>
        /// <param name="country">Country</param>
        /// <param name="phone">Phone number</param>
        /// <param name="email">Email</param>
        public void UpdateCustomer(int idCustomer, string title, string fName, string mName, string lName, string suffix, DateTime birthdate, string idCardPers, string address, string postcode, int cityId, string country, string phone, string email)
        {
            _custRep.UpdateCustomer(idCustomer, title, fName, mName, lName, suffix, birthdate, idCardPers, address, postcode, cityId, country, phone, email);
        }

        public void UpdateAccount(int idCustomer, string accName, decimal overdraf)
        {
            _accRep.UpdateAccount(idCustomer, accName, overdraf);
        }
        
        #endregion



    }
}
