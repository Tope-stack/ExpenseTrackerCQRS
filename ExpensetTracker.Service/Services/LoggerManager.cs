using ExpenseTracker.Service.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Service.Services
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public LoggerManager()
        {

        }
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            logger.Debug(message);
        }

        public void LogInformation(string message)
        {
            logger.Debug(message);
        }

        public void LogWarning(string message)
        {
            logger.Debug(message);
        }
    }
}
