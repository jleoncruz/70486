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
        static void Main(string[] args)
        {
            var process = Process.Start(@"C:\Windows\SysWOW64\calc.exe");
            process.WaitForExit();
        }
    }
}
