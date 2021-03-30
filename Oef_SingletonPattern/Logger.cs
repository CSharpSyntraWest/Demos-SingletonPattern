using System;
using System.Collections.Generic;

namespace Oef_SingletonPattern
{
    public sealed class Logger
    {
        private static readonly Logger logger = new Logger(); //Deze versie is WEL ( Multi-)thread safe
        //private static Logger logger = null; //deze is niet thread-safe!!
        public static Logger Instance
        {
            get
            {
                //if(logger ==null)  //niet thread-safe!
                //{
                //    logger = new Logger();
                //}
                return logger;
            }
        }

        private List<LogEvent> Events;

        private Logger()
        {
            this.Events = new List<LogEvent>();
        }

        public void SaveToLog(string message)
        {
            this.Events.Add(new LogEvent(message));
        }

        public void PrintLog()
        {
            foreach (var ev in this.Events)
            {
                Console.WriteLine("Time: {0}, Event: {1}", ev.EventDate.ToShortTimeString(), ev.Message);
            }
        }
    }
}
