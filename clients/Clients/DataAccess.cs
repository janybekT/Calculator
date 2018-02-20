using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Clients
{
    public static class DataAccess
    {
        public static void Store(Client client)
        {
            const string sql =
                @"insert 
                    dbo.clients(
                        FirstName, 
                        LastName,
                        DateOfBirth, 
                        Region, 
                        Address, 
                        PhoneNumber, 
                        Sex, 
                        Email, 
                        Nationality) 
                    values(
                        @FirstName,
                        @LastName,
                        @DateOfBirth,
                        @Region,
                        @Address, 
                        @PhoneNumber,
                        @Sex, 
                        @Email, 
                        @Nationality
                        )";
            var conn = GetConnectrion();
            conn.Open();
            conn.Query(sql, client);
            conn.Close();
        }

        public static List<Client> GetClients()
        {
            const string sql = @"select * from dbo.clients";
            using (var conn = GetConnectrion())
            {
                conn.Open();
                var clients = conn.Query<Client>(sql).ToList();
                conn.Close();
                return clients;
            }
        }


        private static SqlConnection GetConnectrion()
        {
            return new SqlConnection
            {
                ConnectionString = @"Data Source=DESKTOP-PQ9UK2G\SQLEXPRESS;" +
                                   "Initial Catalog=Test;" +
                                   "User id=sa;" +
                                   "Password=123;"
            };
        }
    }
}