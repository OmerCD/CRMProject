using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
abstract class DBConnection
{
    public static CRMKurs.ModelBuild dbCon;
    protected MySqlConnection _mySqlConnection;
    public DBConnection()
    {
        _mySqlConnection = new MySqlConnection(DesktopAppCRM.DataBaseConnectionOptions.MySqlConnectionString);
    }
}
