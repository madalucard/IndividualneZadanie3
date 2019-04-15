﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class TransactionRepository
    {
        private const string CONNECTION_STRING = "Server=TRANSFORMER3\\SQLEXPRESS2016;Database=TransformerBank;Trusted_Connection=True;";
        //private const string CONNECTION_STRING = "Server=DESKTOP-V0H80T3\\SQLEXPRESS;Database=TransformerBank;Trusted_Connection=True;";
        private List<Transaction> _transactions = new List<Transaction>();

        /// <summary>
        /// Loads all transaction from DB to List of transactions
        /// </summary>
        /// <returns>List of transactions</returns>
        public List<Transaction> LoadTransactions()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"select IdTransaction,
                                                       IdFrom,
                                                       IdTo,
                                                       Value,
                                                       Vs,
                                                       Ss,
                                                       Ks,
                                                       Message  
                                                from Transactions";
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Transaction _tran = new Transaction();

                                    _tran.IdTransaction = reader.GetInt32(0);
                                    _tran.IdFrom = reader.GetInt32(1);
                                    _tran.IdTo = reader.GetInt32(2);
                                    _tran.Value = reader.GetDecimal(3);
                                    _tran.Vs = reader.IsDBNull(4) ? "null" : reader.GetString(4);
                                    _tran.Ss = reader.IsDBNull(5) ? "null" : reader.GetString(5);
                                    _tran.Ks = reader.IsDBNull(6) ? "null" : reader.GetString(6);
                                    _tran.Message = reader.IsDBNull(7) ? "null" : reader.GetString(7);

                                    _transactions.Add(_tran);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            //TODO something with Reader exceptions.... Debug.WriteLine(e.ToString());
                        }
                    }
                    Debug.WriteLine("Connection to DB opened!");
                }
            }
            catch
            {
                //TODO something with Connection exceptions.... Debug.WriteLine(e.ToString());
            }
            return _transactions;
        }


    }
}
