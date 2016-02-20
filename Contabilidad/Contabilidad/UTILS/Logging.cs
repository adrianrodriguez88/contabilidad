using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Diagnostics;
using System.Security.Permissions;

namespace Contabilidad.UTILS
{
    class Logging
    {
        public static void writeToLogFile(string logMessage)
        {
            string strLogMessage = string.Empty;
            string strLogFile = ConfigurationManager.AppSettings["LogDirectory"].ToString();
            strLogFile += "Piramide.log";

            StreamWriter swLog;

            strLogMessage = string.Format("{0}: {1}", DateTime.Now, logMessage);

            if (!File.Exists(strLogFile))
            {
                swLog = new StreamWriter(strLogFile);
            }
            else
            {
                swLog = File.AppendText(strLogFile);
            }

            swLog.WriteLine(strLogMessage);
            swLog.WriteLine();

            swLog.Close();

        }
    }
}
