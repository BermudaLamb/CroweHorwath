using CroweHorwath.Controllers;
using NLog;
using System;

namespace CroweHorwath
{
    class Program
    {
        static void Main(string[] args)
        {
            var howdyWorld = new HelloWorldAPIController();
            MLogger.Info(howdyWorld.GetHelloWorld("Crowe Horwath").Value);
            Console.ReadKey();
        }

        #region Logging
        private static Logger _mLogger;
        public static Logger MLogger
        {
            get
            {
                if (_mLogger == null) _mLogger = LogManager.GetCurrentClassLogger();
                return _mLogger;
            }
            set { _mLogger = value; }
        }
        #endregion

    }
}
