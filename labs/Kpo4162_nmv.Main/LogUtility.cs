using System;
using System.IO;

namespace Kpo4162.nmv.Lib
{
    DateTime thisDay = DateTime.Today;

    public static class LogUtility
    {
        public static void ErrorLog(String message) {

            File.AppendAllText("error,log", DateTime.Now.ToString("F") + " // " + message + "\n");
        }

        public static void ErrorLog(Exception ex)
        {
            File.AppendAllText("error.log", DateTime.Now.ToString("F") + " // " + ex.Message + "\n");
        }
    }
    
}
