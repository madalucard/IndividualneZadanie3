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
    public class CustomerRepository
    {
        //TODO IF conection to work now working then use home connection string in all cases
        private const string CONNECTION_STRING = "Server=TRANSFORMER3\\SQLEXPRESS2016;Database=TransformerBank;Trusted_Connection=True;";
        //private const string CONNECTION_STRING = "Server=DESKTOP-V0H80T3\\SQLEXPRESS;Database=TransformerBank;Trusted_Connection=True;";

        /// <summary>
        /// Return list of customers selected by ID
        /// </summary>
        /// <param name="id">ID of customers</param>
        /// <returns>Customers by ID</returns>
        public List<Customers> SelectCustomerByID(int id)
        {
            List<Customers> _customers = new List<Customers>();

            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");


                    using (SqlCommand command = connection.CreateCommand())
                    {
                        ///TODO Select with city name instead of ID
                        command.CommandText = @"select *
                                                from Customers
                                                Where IdCustomer = @filteredID";
                        command.Parameters.Add("@filteredID", SqlDbType.Int).Value = id;
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Customers _cust = new Customers();
                                    _cust.IdCustomer = reader.GetInt32(0);
                                    _cust.Title = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                                    _cust.Firstname = reader.GetString(2);
                                    _cust.Middlename = reader.IsDBNull(3) ? "null" : reader.GetString(3);
                                    _cust.Lastname = reader.GetString(4);
                                    _cust.Suffix = reader.IsDBNull(5) ? "null" : reader.GetString(5);
                                    _cust.Birthdate = reader.GetDateTime(6);
                                    _cust.IdCardPersonal = reader.GetString(7);
                                    _cust.Address = reader.GetString(8);
                                    _cust.Postcode = reader.GetString(9);
                                    _cust.CityId = reader.GetInt32(10);
                                    _cust.Country = reader.GetString(11);
                                    _cust.Phone = reader.GetString(12);
                                    _cust.Email = reader.IsDBNull(13) ? "null" : reader.GetString(13);
                                    _cust.Active = reader.GetBoolean(14);

                                    _customers.Add(_cust);
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
            return _customers;
        }

        /// <summary>
        /// Return list of customers selected by firstname
        /// </summary>
        /// <param name="name">Firstname of customers</param>
        /// <returns>Customers by fitstname</returns>
        public List<Customers> SelectCustomersByFirstname(string name)
        {
            List<Customers> _customers = new List<Customers>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"select *
                                                from Customers
                                                where Firstname like @filteredName";
                        command.Parameters.Add("@filteredName", SqlDbType.NVarChar).Value = $"%{name}%";
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Customers _cust = new Customers();
                                    _cust.IdCustomer = reader.GetInt32(0);
                                    _cust.Title = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                                    _cust.Firstname = reader.GetString(2);
                                    _cust.Middlename = reader.IsDBNull(3) ? "null" : reader.GetString(3);
                                    _cust.Lastname = reader.GetString(4);
                                    _cust.Suffix = reader.IsDBNull(5) ? "null" : reader.GetString(5);
                                    _cust.Birthdate = reader.GetDateTime(6);
                                    _cust.IdCardPersonal = reader.GetString(7);
                                    _cust.Address = reader.GetString(8);
                                    _cust.Postcode = reader.GetString(9);
                                    _cust.CityId = reader.GetInt32(10);
                                    _cust.Country = reader.GetString(11);
                                    _cust.Phone = reader.GetString(12);
                                    _cust.Country = reader.IsDBNull(13) ? "null" : reader.GetString(13);
                                    _cust.Active = reader.GetBoolean(14);

                                    _customers.Add(_cust);
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
            return _customers;
        }

        /// <summary>
        /// Return list of customers selected by lastname
        /// </summary>
        /// <param name="name">Lastname of customers</param>
        /// <returns>Customers by lastname</returns>
        public List<Customers> SelectCustomersByLastname(string name)
        {
            List<Customers> _customers = new List<Customers>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"select *
                                                from Customers
                                                where Lastname like @filteredName";
                        command.Parameters.Add("@filteredName", SqlDbType.NVarChar).Value = $"%{name}%";
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Customers _cust = new Customers();
                                    _cust.IdCustomer = reader.GetInt32(0);
                                    _cust.Title = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                                    _cust.Firstname = reader.GetString(2);
                                    _cust.Middlename = reader.IsDBNull(3) ? "null" : reader.GetString(3);
                                    _cust.Lastname = reader.GetString(4);
                                    _cust.Suffix = reader.IsDBNull(5) ? "null" : reader.GetString(5);
                                    _cust.Birthdate = reader.GetDateTime(6);
                                    _cust.IdCardPersonal = reader.GetString(7);
                                    _cust.Address = reader.GetString(8);
                                    _cust.Postcode = reader.GetString(9);
                                    _cust.CityId = reader.GetInt32(10);
                                    _cust.Country = reader.GetString(11);
                                    _cust.Phone = reader.GetString(12);
                                    _cust.Country = reader.IsDBNull(13) ? "null" : reader.GetString(13);
                                    _cust.Active = reader.GetBoolean(14);

                                    _customers.Add(_cust);
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
            return _customers;
        }

        /// <summary>
        /// Return list of customers selected by Fullname
        /// </summary>
        /// <param name="fname">Firstname of customers</param>
        /// <param name="lname">Lastname of customers/param>
        /// <returns>Customers by Fullname</returns>
        public List<Customers> SelectCustomersByFullname(string fname, string lname)
        {
            List<Customers> _customers = new List<Customers>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"select *
                                                from Customers
                                                where Firstname like @filteredFName and Lastname like @filteredLName";
                        command.Parameters.Add("@filteredFName", SqlDbType.NVarChar).Value = $"%{fname}%";
                        command.Parameters.Add("@filteredLName", SqlDbType.NVarChar).Value = $"%{lname}%";
                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Customers _cust = new Customers();
                                    _cust.IdCustomer = reader.GetInt32(0);
                                    _cust.Title = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                                    _cust.Firstname = reader.GetString(2);
                                    _cust.Middlename = reader.IsDBNull(3) ? "null" : reader.GetString(3);
                                    _cust.Lastname = reader.GetString(4);
                                    _cust.Suffix = reader.IsDBNull(5) ? "null" : reader.GetString(5);
                                    _cust.Birthdate = reader.GetDateTime(6);
                                    _cust.IdCardPersonal = reader.GetString(7);
                                    _cust.Address = reader.GetString(8);
                                    _cust.Postcode = reader.GetString(9);
                                    _cust.CityId = reader.GetInt32(10);
                                    _cust.Country = reader.GetString(11);
                                    _cust.Phone = reader.GetString(12);
                                    _cust.Country = reader.IsDBNull(13) ? "null" : reader.GetString(13);
                                    _cust.Active = reader.GetBoolean(14);

                                    _customers.Add(_cust);
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
            return _customers;
        }

        /// <summary>
        /// Return last customer
        /// </summary>
        /// <returns>Last Customer</returns>
        public int SelectLastCustomer()
        {
            //Customers _cust = new Customers();
            int newId=0;
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");


                    using (SqlCommand command = connection.CreateCommand())
                    {
                        ///TODO Select with city name instead of ID
                        command.CommandText = @"select max(IdCustomer)
                                                from Customers";
                        newId = int.Parse(command.ExecuteScalar().ToString());
                        //try
                        //{
                            //using (SqlDataReader reader = command.ExecuteReader())
                            //{
                                //while (reader.Read())
                                //{
                                    
                                //    _cust.IdCustomer = reader.GetInt32(0);
                                //    _cust.Title = reader.IsDBNull(1) ? "null" : reader.GetString(1);
                                //    _cust.Firstname = reader.GetString(2);
                                //    _cust.Middlename = reader.IsDBNull(3) ? "null" : reader.GetString(3);
                                //    _cust.Lastname = reader.GetString(4);
                                //    _cust.Suffix = reader.IsDBNull(5) ? "null" : reader.GetString(5);
                                //    _cust.Birthdate = reader.GetDateTime(6);
                                //    _cust.IdCardPersonal = reader.GetString(7);
                                //    _cust.Address = reader.GetString(8);
                                //    _cust.Postcode = reader.GetString(9);
                                //    _cust.CityId = reader.GetInt32(10);
                                //    _cust.Country = reader.GetString(11);
                                //    _cust.Phone = reader.GetString(12);
                                //    _cust.Email = reader.IsDBNull(13) ? "null" : reader.GetString(13);
                                //    _cust.Active = reader.GetBoolean(14);

                                //}
                            //}
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
        /// Return last Customer
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="fName">Firstname</param>
        /// <param name="mName">Middlename</param>
        /// <param name="lName">Lastname</param>
        /// <param name="suffix">Suffix</param>
        /// <param name="birthdate">Birthdate</param>
        /// <param name="idCardPers">IDCard of person</param>
        /// <param name="address">Address</param>
        /// <param name="postcode">Postcode</param>
        /// <param name="cityId">City Id</param>
        /// <param name="country">Country</param>
        /// <param name="phone">Phone number</param>
        /// <param name="email">Email</param>
        /// <returns>Last created customer</returns>
        public int RegisterCustomer(string title, string fName, string mName, string lName, string suffix, DateTime birthdate, string idCardPers, string address, string postcode, int cityId, string country, string phone, string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    Debug.WriteLine("Connection to DB opened!");
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = @"INSERT INTO [dbo].[Customers]
                                                           ([Title]
                                                           ,[Firstname]
                                                           ,[Middlename]
                                                           ,[Lastname]
                                                           ,[Suffix]
                                                           ,[Birthdate]
                                                           ,[IdCardPersonal]
                                                           ,[Address]
                                                           ,[Postcode]
                                                           ,[CityID]
                                                           ,[Country]
                                                           ,[Phone]
                                                           ,[Email]
                                                           ,[Active])
                                                     VALUES
                                                           (@title
                                                           ,@fName
                                                           ,@mName
                                                           ,@lName
                                                           ,@suffix
                                                           ,@birthdate
                                                           ,@idCardPers
                                                           ,@address
                                                           ,@postcode
                                                           ,@cityId
                                                           ,@country
                                                           ,@phone
                                                           ,@email
                                                           ,1)";
                        command.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
                        command.Parameters.Add("@fName", SqlDbType.NVarChar).Value = fName;
                        command.Parameters.Add("@mName", SqlDbType.NVarChar).Value = mName;
                        command.Parameters.Add("@lName", SqlDbType.NVarChar).Value = lName;
                        command.Parameters.Add("@suffix", SqlDbType.NVarChar).Value = suffix;
                        command.Parameters.Add("@birthdate", SqlDbType.Date).Value = birthdate;
                        command.Parameters.Add("@idCardPers", SqlDbType.NVarChar).Value = idCardPers;
                        command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                        command.Parameters.Add("@postcode", SqlDbType.NVarChar).Value = postcode;
                        command.Parameters.Add("@cityId", SqlDbType.Int).Value = cityId;
                        command.Parameters.Add("@country", SqlDbType.NVarChar).Value = country;
                        command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
                        command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

                        command.ExecuteNonQuery();
                        Debug.Write("Customer registered!");
                        Debug.WriteLine("Connection to DB Closed!");
                    }
                }
            }
            catch
            {
                //TODO something with Connection exceptions.... Debug.WriteLine(e.ToString());
            }

            return SelectLastCustomer();
        }
    }
}
