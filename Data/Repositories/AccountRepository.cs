using Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class AccountRepository
    {
        private const string CONNECTION_STRING = "Server=TRANSFORMER3\\SQLEXPRESS2016;Database=TransformerBank;Trusted_Connection=True;";
        //private const string CONNECTION_STRING = "Server=DESKTOP-V0H80T3\\SQLEXPRESS;Database=TransformerBank;Trusted_Connection=True;";

        /// <summary>
        /// Generate random slovak 24 spaces Iban in form SK+random numbers
        /// </summary>
        /// <returns>Slovak Iban</returns>
        private string IbanGenerator()
        {
            StringBuilder sb = new StringBuilder().Append("SK");
            Random rand = new Random();

            for (int i = 0; i < 21; i++)
            {
                sb.Append(rand.Next(9));
            }
            return sb.ToString();
        }



        /// <summary>
        /// Load account from DB by ID
        /// </summary>
        /// <param name="id">Id of account</param>
        /// <returns>Account by ID</returns>
        public List<Account> SelectAccountByID(int id)
        {
            List<Account> _account = new List<Account>();

            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"select *
                                                from Account
                                                Where IdAccount = @filteredID";
                        command.Parameters.Add("@filteredID", SqlDbType.Int).Value = id;
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Account _acc = new Account();
                                    _acc.IdAccount = reader.GetInt32(0);
                                    _acc.IdCustomer = reader.GetInt32(1);
                                    _acc.Iban = reader.GetString(2);
                                    _acc.AccName = reader.GetString(3);
                                    _acc.Amount = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                                    _acc.Overdraft = reader.GetDecimal(5);
                                    _acc.IdCompany = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                                    _acc.Active = reader.GetBoolean(7);

                                    _account.Add(_acc);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            //TODO something with Reader exceptions.... Debug.WriteLine(e.ToString());
                        }
                        Debug.WriteLine("Connection to DB Closed!");
                    }
                }
            }
            catch
            {
                //TODO something with Connection exceptions.... Debug.WriteLine(e.ToString());
            }
            return _account;
        }

        /// <summary>
        /// Return list of account selected by name
        /// </summary>
        /// <param name="name">Name of account</param>
        /// <returns>Accounts by name</returns>
        public List<Account> SelectAccountByName(string name)
        {
            List<Account> _accounts = new List<Account>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"select *
                                                from Account
                                                where AccName like @filteredName";
                        command.Parameters.Add("@filteredName", SqlDbType.NVarChar).Value = $"%{name}%";
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Account _acc = new Account();
                                    _acc.IdAccount = reader.GetInt32(0);
                                    _acc.IdCustomer = reader.GetInt32(1);
                                    _acc.Iban = reader.GetString(2);
                                    _acc.AccName = reader.GetString(3);
                                    _acc.Amount = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                                    _acc.Overdraft = reader.GetDecimal(5);
                                    _acc.IdCompany = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                                    _acc.Active = reader.GetBoolean(7);

                                    _accounts.Add(_acc);
                                }
                            }
                        }

                        catch (Exception)
                        {
                            //TODO something with Reader exceptions.... Debug.WriteLine(e.ToString());
                        }
                        Debug.WriteLine("Connection to DB Closed!");
                    }
                }
            }
            catch
            {
                //TODO something with Connection exceptions.... Debug.WriteLine(e.ToString());
            }
            return _accounts;
        }

        /// <summary>
        /// Returns last created Account
        /// </summary>
        /// <returns>Last created Account</returns>
        public int SelectLastAccount()
        {
            int newId = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"select max(IdAccount)
                                                from Account";
                        newId = int.Parse(command.ExecuteScalar().ToString());
                        //try
                        //{
                        //    using (SqlDataReader reader = command.ExecuteReader())
                        //    {
                        //        while (reader.Read())
                        //        {
                                    
                        //            _acc.IdAccount = reader.GetInt32(0);
                        //            _acc.IdCustomer = reader.GetInt32(1);
                        //            _acc.Iban = reader.GetString(2);
                        //            _acc.AccName = reader.GetString(3);
                        //            _acc.Amount = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                        //            _acc.Overdraft = reader.GetDecimal(5);
                        //            _acc.IdCompany = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                        //            _acc.Active = reader.GetBoolean(7);                                }
                        //    }
                        //}
                        //catch (Exception)
                        //{
                        //    //TODO something with Reader exceptions.... Debug.WriteLine(e.ToString());
                        //}
                        Debug.WriteLine("Connection to DB Closed!");
                    }
                }
            }
            catch
            {
                //TODO something with Connection exceptions.... Debug.WriteLine(e.ToString());
            }
            return newId;
        }

        /// <summary>
        /// Register account.
        /// </summary>
        /// <param name="idCustomer">Id of customer</param>
        /// <param name="accName">Name of account</param>
        /// <param name="overdraft">Maximal overdraft</param>
        /// <returns>New account</returns>
        public int RegisterAccount(int idCustomer, string accName, int overdraft)
        {
            string iban = IbanGenerator();
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO [dbo].[Account]
                                                       ([IdCustomers]
                                                       ,[Iban]
                                                       ,[AccName]
                                                       ,[Amount]
                                                       ,[Overdraft]
                                                       ,[IdCompany]
                                                       ,[Active])
                                                
                                                VALUES
                                                       (@idCustomer
                                                       ,@iban
                                                       ,@accName
                                                       ,0
                                                       ,@overdraft
                                                       ,null
                                                       ,1)";
                        command.Parameters.Add("@idCustomer", SqlDbType.Int).Value = idCustomer;
                        command.Parameters.Add("@iban", SqlDbType.NVarChar).Value = iban;
                        command.Parameters.Add("@accName", SqlDbType.NVarChar).Value = accName;
                        command.Parameters.Add("@overdraft", SqlDbType.Decimal).Value = overdraft;
                        command.ExecuteNonQuery();

                        Debug.Write("Account registered!");
                        Debug.WriteLine("Connection to DB Closed!");
                    }
                }
            }
            catch
            {
                //TODO something with Connection exceptions.... Debug.WriteLine(e.ToString());
            }
            return SelectLastAccount();
        }
    }
}
