using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForWorkerRoleSample
{
    class Program
    {
        static int Main(string[] args)
        {
            Trace.TraceInformation("ConsoleAppForWorkerRoleSample Main has been started", "Information");
            var process = Process.Start(@"C:\Windows\SysWOW64\calc.exe");
            //var process = Process.Start("calc.exe");
            process.WaitForExit();
            Trace.TraceInformation("ConsoleAppForWorkerRoleSample Main has been ended", "Information");
            return 1;
        }
    }
}
