using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopAppCRM;
using MySql.Data.MySqlClient;

namespace CRMKurs
{
    class DBConnection
    {
        public static MySqlConnection QueryConnection;
        public static ModelBuild DbCon;
        public DBConnection()
        {
            QueryConnection= new MySqlConnection(DataBaseConnectionOptions.MySqlConnectionString);
            DbCon = new ModelBuild();
        }
        [Obsolete]
        public static string ExecuteCommand(string commandText, params dynamic[] parameters)
        {
            QueryConnection.Open();
            string returnValue;
            using (MySqlCommand cmd = new MySqlCommand(commandText,QueryConnection))
            {
                returnValue = (string) cmd.ExecuteScalar();
            }
            return returnValue;
        }

        public static string SaveChanges()
        {
            try
            {
                DbCon.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                return e.Message;
            }
            return "";
        }
    }
}
