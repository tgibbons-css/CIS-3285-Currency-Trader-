using System;

using CurrencyTrader.Contracts;
using System.IO;

namespace CurrencyTrader
{
    public class LoggerConsole : ILogger
    {
        public void LogWarning(string message, params object[] args)
        {
            Console.WriteLine(string.Concat("WARN: ", message), args);
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine(string.Concat("WARN: ", message), args);
            }
        }

        public void LogInfo(string message, params object[] args)
        {
            Console.WriteLine(string.Concat("INFO: ", message), args);
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine(string.Concat("INFO: ", message), args);
            }
        }
    }
}
