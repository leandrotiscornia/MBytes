using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Negocio
{
    public static class LogController
    {
        public static void writeInLog(string action, string result, string userName)
        {
            string logMessage;
            logMessage = Session.userId + " | " + userName + " | " + action + " | " + result + " | " + DateTime.Now.ToString() + " | " + getIp();

            using (StreamWriter logFile = new StreamWriter(Path.Combine(Paths.Default.LogsRoute, "AppLog.txt")))
                    logFile.WriteLine(logMessage);
        }

        private static string getIp()
        {
            string hostName = Dns.GetHostName(); 
            string myIP = Dns.GetHostEntry(hostName).AddressList[0].ToString();
            return myIP;
        }
    }
}
