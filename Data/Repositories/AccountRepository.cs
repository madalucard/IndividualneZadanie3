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
        private const string CONNECTION_STRING_HOME_DB = "Server=DESKTOP-V0H80T3\\SQLEXPRESS;Database=TransformerBank;Trusted_Connection=True;";
        /// <summary>
        /// Load account from DB by ID
        /// </summary>
        /// <param name="id">Id of account</param>
        /// <returns>Account</returns>
        public List<Account> SelectAccountByID(int id)
        {
            List<Account> _account = new List<Account>();

            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING_HOME_DB))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");


                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"select *
                                                from Account
                                                Where IdAccount = @filteredID";
                        command.Parameters.Add("@filteredID",SqlDbType.Int).Value = id;
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Account _acc = new Account();
                                    _acc.IdAccount = reader.GetInt32(0);
                                    _acc.IdCustomer = reader.GetInt32(1);
                                    _acc.Iban =  reader.GetString(2);
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
    }
}
