using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DesktopAppCRM
{
    class DataBaseConnectionOptions
    {
        static string serverName = "sql11.freemysqlhosting.net";
        static string databaseName = "sql11160470";
        static string userName = "sql11160470";
        static string password = "Uec8wTLlkp";
        [Obsolete]
        public static string ConnectionString => ("SERVER = " + serverName + "; DATABASE =" + databaseName + "; UID =" + userName + ";PWD=" + password + ";");
        public static string MySqlConnectionString => ("SERVER=www.deletecrm.com;DATABASE=ccy_delete;UID=ccy_delete;PWD=Ah!g9x87;");
    }
}
