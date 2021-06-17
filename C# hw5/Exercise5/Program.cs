using System;
namespace consoleApplication
{
    public class Myclass
    {
        public delegate void LogHandler(string message);
        public void Process(LogHandler logHandler)
        {
            if (logHandler != null)
            {
                logHandler("begin");
            }
            if (logHandler != null)
            {
                logHandler("End");
            }
        }
        public class MyLogger
        {
            public void Logger(string s)
            {
                Console.WriteLine(s);
            }
        }
        public class TestApplication
        {
            static void Logger(string s)
            {
                Console.WriteLine(s);
            }
            static void Main(string[] args)
            {
                MyLogger f1 = new MyLogger();
                Myclass myclass = new Myclass();
                Myclass.LogHandler myLogger = null;
                myLogger += new Myclass.LogHandler(Logger);
                myLogger += new Myclass.LogHandler(f1.Logger);
                Myclass.Process(myLogger);
                return;

            }
        }
    }
}