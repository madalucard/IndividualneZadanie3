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
    public class CardRepository
    {
        //TODO IF conection to work now working then use home connection string in all cases
        private const string CONNECTION_STRING = "Server=TRANSFORMER3\\SQLEXPRESS2016;Database=TransformerBank;Trusted_Connection=True;";
        //private const string CONNECTION_STRING = "Server=DESKTOP-V0H80T3\\SQLEXPRESS;Database=TransformerBank;Trusted_Connection=True;";

        public List<Cards> SelectAllCardsByAccID(int accId)
        {
            List<Cards> _cards = new List<Cards>();

            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");


                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"select *
                                                from Cards
                                                Where IdAccount = @filteredID";
                        command.Parameters.Add("@filteredID", SqlDbType.Int).Value = accId;
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Cards _card = new Cards();
                                    _card.IdCard = reader.GetInt32(0);
                                    _card.ExpireDate = reader.GetDateTime(1);
                                    _card.IdAccount = reader.GetInt32(2);
                                    _card.CardNumber = reader.GetString(3);
                                    _card.Pin = reader.GetString(4);
                                    _card.Blocked = reader.GetBoolean(5);
                                    _card.Active = reader.GetBoolean(6);

                                    _cards.Add(_card);
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
            return _cards;
        }
    }
}
