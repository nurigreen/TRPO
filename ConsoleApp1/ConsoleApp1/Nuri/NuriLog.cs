using System.Collections.Generic;


namespace Simberdeev
{
    class EgorLog : LogAbstract, LogInterface
    {
        private static EgorLog i = null;

        public static EgorLog I()
        {
            if (i == null)
            {
                i = new EgorLog();
            }
            return i;
        }
        private EgorLog() { }

        List<string> logs = new List<string>();

        public LogInterface log(string str)
        {
            logs.Add(str);
            return this;
        }

        public LogInterface write()
        {
            writeConsole(logs.ToArray());
            return this;
        }
    }
}
