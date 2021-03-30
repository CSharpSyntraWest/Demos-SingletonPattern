using System;
using System.Collections.Generic;
using System.Text;

namespace Oef_SingletonPattern
{
    using System;

    public class LogEvent
    {
        private string message;

        private DateTime eventDate;

        public LogEvent(string message)
        {
            this.message = message;
            this.eventDate = DateTime.Now;
        }

        public string Message
        {
            get { return this.message; }
        }

        public DateTime EventDate
        {
            get { return this.eventDate; }
        }
    }
}
