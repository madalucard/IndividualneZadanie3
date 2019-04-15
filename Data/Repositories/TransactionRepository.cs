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

        //public List<Transaction> LoadAllTransactionForAcc(int accId)
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
        //        {
        //            connection.Open();
        //            Debug.WriteLine("Connection to DB opened!");

        //            using (SqlCommand command = connection.CreateCommand())
        //            {
        //                command.CommandText = @"select * 
        //                                        from Transactions
        //                                        where IdFrom = @accId or idTo =@accId";
        //                command.Parameters.Add("@accId", SqlDbType.Int).Value = accId;
        //                try
        //                {
        //                    using (SqlDataReader reader = command.ExecuteReader())
        //                    {
        //                        while (reader.Read())
        //                        {
        //                            Transaction _tran = new Transaction();

        //                            _tran.IdTransaction = reader.GetInt32(0);
        //                            _tran.IdFrom = reader.GetInt32(1);
        //                            _tran.IdTo = reader.GetInt32(2);
        //                            _tran.Value = reader.GetDecimal(3);
        //                            _tran.Vs = reader.IsDBNull(4) ? "null" : reader.GetString(4);
        //                            _tran.Ss = reader.IsDBNull(5) ? "null" : reader.GetString(5);
        //                            _tran.Ks = reader.IsDBNull(6) ? "null" : reader.GetString(6);
        //                            _tran.Message = reader.IsDBNull(7) ? "null" : reader.GetString(7);

        //                            _transactions.Add(_tran);
        //                            Debug.WriteLine("Transactions loaded");
        //                        }
        //                    }
        //                }
        //                catch (Exception)
        //                {
        //                    //TODO something with Reader exceptions.... Debug.WriteLine(e.ToString());
        //                }
        //            }
        //            Debug.WriteLine("Connection to DB opened!");
        //        }
        //    }
        //    catch
        //    {
        //        //TODO something with Connection exceptions.... Debug.WriteLine(e.ToString());
        //    }
        //    return _transactions;
        //}

        public DataSet FillDataSet(int accId)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = @"select * 
                                     from Transactions
                                     where IdFrom = @accId or idTo =@accId";
            command.Parameters.Add("@accId", SqlDbType.Int).Value = accId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "Transactions for Account");

            DataTable dt = ds.Tables["Person"];
            return ds;
        }

        //public DataSet DataSetAllAccounts   ()
        //{
        //    SqlConnection connection = new SqlConnection(CONNECTION_STRING);
        //    SqlCommand command = connection.CreateCommand();
        //    command.CommandText = @"select a.IdAccount, a.IdCustomers, c.Firstname, c.Lastname, a.Iban, a.Amount, a.Overdraft
        //                            from Account a
        //                            left join Customers c on c.IdCustomer = a.IdCustomers";
        //    //command.Parameters.Add("@accId", SqlDbType.Int).Value = accId;

        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            
        //    DataSet ds = new DataSet();
        //    adapter.Fill(ds, "c.Lastname");
        //    DataTable dt = ds.Tables["c.Lastname"];
        //    return ds;


        //}


        public DataTable AllAccounts()
        {

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"select a.IdAccount, a.IdCustomers, c.Firstname, c.Lastname, a.Iban, a.Amount, a.Overdraft
                                            from Account a
                                            left join Customers c on c.IdCustomer = a.IdCustomers";
                    //command.Parameters.AddWithValue("@ID", clientID);


                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "Account");
                        DataTable dt = ds.Tables["Account"];

                        return dt;
                    }
                }
            }
        }








        // TODO inserst. updater

        public void NewTransaction(Transaction tran)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO [dbo].[Transactions]
                                                       ([IdFrom]
                                                       ,[IdTo]
                                                       ,[Value]
                                                       ,[Vs]
                                                       ,[Ss]
                                                       ,[Ks]
                                                       ,[Message])
                                                 VALUES
                                                       (@IdFrom
                                                       ,@IdTo
                                                       ,@Value
                                                       ,@Vs
                                                       ,@Ss
                                                       ,@Ks
                                                       ,@Message)";
                        command.Parameters.Add("@IdFrom", SqlDbType.Int).Value = tran.IdFrom;
                        command.Parameters.Add("@IdTo", SqlDbType.Int).Value = tran.IdTo;
                        command.Parameters.Add("@Value", SqlDbType.Int).Value = tran.Value;
                        command.Parameters.Add("@Vs", SqlDbType.NVarChar).Value = tran.Vs;
                        command.Parameters.Add("@Ss", SqlDbType.NVarChar).Value = tran.Ss;
                        command.Parameters.Add("@Ks", SqlDbType.NVarChar).Value = tran.Ks;
                        command.Parameters.Add("@Message", SqlDbType.NVarChar).Value = tran.Message;
                        command.ExecuteNonQuery();
                    }
                    Debug.WriteLine("Connection to DB opened!");
                }
            }
            catch
            {
                //TODO something with Connection exceptions.... Debug.WriteLine(e.ToString());
            }
            //return _transactions;
        }

       


    }
}
