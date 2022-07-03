using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Auto_Shutdown
{
    class Util
    {
        public static void LogToFile(string message, bool showMessage = true)
        {
            try
            {
                File.AppendAllText("logs.txt", String.Format("{0}\n", message));

                if(showMessage)
                {
                    MessageBox.Show(String.Format("An error occurred: \"{0}\"", message), "Error");
                }
            }
            catch { }
        }
    }
}
