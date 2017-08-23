using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRID.CommonUtils
{
    class HandleWindowsProcesses
    {
        public static void KillProcesses(string processName)
        {
            //var processes = Process.GetProcessesByName("chromeDriver.exe");
            var processes = Process.GetProcessesByName(processName);
            foreach (var process in processes)
            {
                try
                {
                    process.Close();
                }
                catch
                {
                }
                try
                {
                    process.Kill();
                }
                catch
                {
                }
            }
        }
    }
}
