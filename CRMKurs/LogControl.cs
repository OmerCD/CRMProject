using System.Linq;
using CRMKurs.EntityClasses;
using DesktopAppCRM;

namespace CRMKurs
{
    class LogControl
    {
        private Log[] _logs;
        public LogControl()
        {
            _logs = DBConnection.DbCon.Log.Where(x => x.OwnerId == DataBaseConnectionOptions.OwnerUserId).ToArray();
        }
        /// <summary>
        /// Verilen adette log sayısını son eklenenler arasından verir. 
        /// </summary>
        /// <param name="amount">Döndürülecek log sayısı</param>
        /// <returns>Girilen adette Log sayısı</returns>
        public Log[] GetLast(int amount)
        {
            if (_logs == null) return null;
            var tempLogs = new Log[amount];
            var startIndex = _logs.Length - amount;
            var endIndex = _logs.Length;
            var counter = 0;
            for (var i = startIndex; i < endIndex; i++)
            {
                tempLogs[counter++] = _logs[i];
            }
            return tempLogs;
        }
        public Log this[int index] => _logs[index];
    }
}
