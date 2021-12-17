using System.Collections.Generic;


namespace Simberdeev
{
    class NuriLog : LogAbstract, LogInterface
    {
        private static NuriLog i = null;

        public static NuriLog I()
        {
            if (i == null)
            {
                i = new NuriLog();
            }
            return i;
        }
        private NuriLog() { }

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
