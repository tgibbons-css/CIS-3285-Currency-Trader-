using System;

using CurrencyTrader.Contracts;
using System.IO;
using System.Windows.Forms;

namespace CurrencyTrader
{
    // **** NOTE **** This class will not work and generates a multitasking error which we will fix later
    public class LoggerGUI : ILogger
    {
        ListBox.ObjectCollection items;
        private ILogger baseLogger;

        public LoggerGUI(ListBox.ObjectCollection items, ILogger newBaseLogger)
        {
            this.items = items;
            baseLogger = newBaseLogger;
        }

        public void LogWarning(string message, params object[] args)
        {
            // Log the information the standard way
            baseLogger.LogWarning(message, args);

            // Try to update the list item in the form
            // **** NOTE **** This class will not work and generates a multitasking error which we will fix later
            string status = String.Format(string.Concat("WARN: ", message), args);
            items.Add(status);

        }

        public void LogInfo(string message, params object[] args)
        {
            // Log the information the standard way
            baseLogger.LogInfo(message, args);

            // Try to update the list item in the form
            // **** NOTE **** This class will not work and generates a multitasking error which we will fix later
            string status = String.Format(string.Concat("INFO: ", message), args);
            items.Add(status);

        }
    }
}
