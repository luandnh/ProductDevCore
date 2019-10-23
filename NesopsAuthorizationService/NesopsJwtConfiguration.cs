using System;
using System.Collections.Generic;
using System.Text;

namespace NesopsAuthorizationService
{
    public static class NesopsJwtConfiguration
    {
        public static string Nesops_SecretKey = "NesopsPrivateKey";
        public static string Nesops_Issuer = "http://api.nesops.xyz";
        public static string Nesops_Audience = "http://api.nesops.xyz";
        public static string Nesops_ExpireDays = "5";
    }
    public static class NesopsSqlServerConnection
    {
        public static string GetConnectionString()
        {
            const string databaseServer = "192.168.2.101,1433";
            const string databaseName = "productdev";
            const string databaseUser = "sa";
            const string databasePass = "zaQ@1234";

            return $"Server={databaseServer};" +
                   $"database={databaseName};" +
                   $"uid={databaseUser};" +
                   $"pwd={databasePass};" +
                   $"pooling=true;";
        }
    }
}
