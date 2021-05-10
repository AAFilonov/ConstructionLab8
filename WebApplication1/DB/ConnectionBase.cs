using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1.DB
{
    public class ConnectionBase
    {
        protected readonly string ConnectionString ;
        protected readonly SqlConnection Connection;

        protected ConnectionBase(string connectionString)
        {
            ConnectionString = connectionString;
            Connection = new SqlConnection(ConnectionString);
        }
    }
}