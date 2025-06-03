using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baccofy.Config
{
    public class PostgresConnection
    {
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=1234;Database=baccofy2");
        }
    }
}
