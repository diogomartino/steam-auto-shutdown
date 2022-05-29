using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Auto_Shutdown
{
    class Util
    {
        public static void LogToFile(string message)
        {
            try
            {
                File.AppendAllText("logs.txt", String.Format("{0}\n", message));
            }
            catch { }
        }
    }
}
