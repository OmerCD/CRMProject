using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppCRM
{
    abstract class DBConnection
    {
        protected MySqlConnection _mySqlConnection;
        public DBConnection()
        {
            _mySqlConnection = new MySqlConnection(DataBaseConnectionOptions.ConnectionString);
        }
    }
}
