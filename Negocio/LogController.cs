using System;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Linq;
using System.Collections.Generic;
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
            string path = Path.Combine(Paths.Default.LogsRoute, "AppLog.txt");
            if (!File.Exists(path))
                using (StreamWriter logFile = File.CreateText(path))
                    logFile.WriteLine(logMessage);
            else
                using (StreamWriter logfile = File.AppendText(path))
                    logfile.WriteLine(logMessage);
        }
        
        public static bool IsIPv4(IPAddress ipa) => ipa.AddressFamily == AddressFamily.InterNetwork;

        public static IPAddress getIp() => NetworkInterface.GetAllNetworkInterfaces()
        .Select((ni) => ni.GetIPProperties())
        .Where((ip) => ip.GatewayAddresses.Where((ga) => IsIPv4(ga.Address)).Count() > 0)
        .FirstOrDefault()?.UnicastAddresses?
        .Where((ua) => IsIPv4(ua.Address))?.FirstOrDefault()?.Address;
    }
}
