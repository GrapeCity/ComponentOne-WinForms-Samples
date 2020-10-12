using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using C1.C1Report;
using C1.C1Preview;

namespace SampleExternalExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sample external exe run....");
            MakeReport();
            Console.WriteLine("Sample external exe done.");
        }

        static void MakeReport()
        {
            // report definition must be in the current directory:
            string dir = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            // use C1PrintDocument to generate the report:
            C1PrintDocument doc = new C1PrintDocument();
            doc.ImportC1Report(Path.Combine(dir, @"CommonTasks.xml"), @"01: Alternating Background (Greenbar report)");
            doc.Generate();
            doc.Export(Path.Combine(dir, "OutputFromSampleExternalExe.PDF"), new OutputRange(new int[] { 1, 2 }), false);
        }
    }
}
