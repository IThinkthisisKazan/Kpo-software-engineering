using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4310.Utility;

namespace Kpo4162_nmv.Lib
{
    public static class AppGlobalSettings
    {
        private static string _logPath;
        public static string logPath
        {
            get => _logPath;
        }

        private static string _dataFileName;
        public static string dataFileName
        {
            get => _dataFileName;
        }
        public static void Initialize()
        {
            AppConfigUtility acu = new AppConfigUtility();
            _logPath = acu.AppSettings("logPath");
            _dataFileName = acu.AppSettings("dataFileName");
        }

    }
}


