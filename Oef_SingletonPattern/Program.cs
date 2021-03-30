using System;

namespace Oef_SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = Logger.Instance;
            log.SaveToLog("geregistreerd in log");
            log.SaveToLog("Nog iets in log geregistreerd");

            var log2 = Logger.Instance;
            log2.SaveToLog("Een derde registratie naar dezelfde log instantie (één enkele instantie door gebruik van Singleton class Logger)");

            log.PrintLog();
        }
    }
}
