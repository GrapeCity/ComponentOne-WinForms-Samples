using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zip64Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ** event handlers

        void _btnOneBigFile_Click(object sender, EventArgs e)
        {
            // prepare
            long fileSize = (long)uint.MaxValue * 2 + 1000;
            var fnIn = Path.Combine(Application.StartupPath, "bigIn.txt");
            var fnOut = Path.Combine(Application.StartupPath, "bigOut.txt");
            var fnZip = Path.Combine(Application.StartupPath, "test.zip");

            // create big file
            CreateTextFile(fnIn, fileSize, false);

            // zip big file
            ZipBigFile(fnIn, fnZip);

            // unzip big file
            UnzipBigFile(fnZip, fnOut);

            // compare in and out files
            CompareFiles(fnIn, fnOut);

            // all done
            ShowStatus("All done, all good!");
        }
        void _btnManyFiles_Click_Click(object sender, EventArgs e)
        {
            // prepare
            long fileSize = 10 * 1024;
            int entryCount = ushort.MaxValue + 10;
            var fnIn = Path.Combine(Application.StartupPath, "smallIn.txt");
            var fnZip = Path.Combine(Application.StartupPath, "manyFiles.zip");

            // crate a small file
            CreateTextFile(fnIn, fileSize, false);

            // add many copies to zip
            var zip = new C1.Zip.C1ZipFile(fnZip, true);
            for (int i = 0; i < entryCount; i++)
            {
                ShowStatus("Zipping entry {0:n0} of {1:n0}...", i + 1, entryCount);
                zip.Entries.Add(fnIn, string.Format("entry{0}", i + 1));
            }

            // check the copies
            var sr = new StreamReader(fnIn);
            var content = sr.ReadToEnd();

            for (int i = 0; i < entryCount; i++)
            {
                var ze = zip.Entries[0];
                if (!ze.CheckCRC32())
                {
                    ShowStatus("Checking entry {0}...", i + 1);
                    throw new Exception("entry failed crc32, file is corrupted");
                }

                using (var srz = new StreamReader(ze.OpenReader()))
                {
                    var zcontent = srz.ReadToEnd();
                    if (!string.Equals(content, zcontent))
                    {
                        throw new Exception("entry contents are different!");
                    }
                }
            }

            // all done
            ShowStatus("All done, all good!");
        }

        // ** implementation

        void CreateTextFile(string fnIn, long fileSize, bool forceNew)
        {
            if (forceNew && File.Exists(fnIn))
            {
                File.Delete(fnIn);
            }
            if (!File.Exists(fnIn))
            {
                long lastPos = 0;
                long pos = 0;

                var rnd = new Random(0);
                ShowStatus("Creating text file...");
                using (var sw = new StreamWriter(fnIn))
                {
                    while (pos < fileSize)
                    {
                        for (int i = 0; i < 1000; i++)
                        {
                            sw.Write(rnd.NextDouble().ToString());
                        }
                        pos = sw.BaseStream.Position;
                        if (pos > lastPos + 500000)
                        {
                            lastPos = pos;
                            double pct = pos / (double)fileSize;
                            ShowStatus("Creating text file... {0:p0}", pct);
                        }
                    }
                }
            }
        }
        void ZipBigFile(string fnIn, string fnZip)
        {
            ShowStatus("Zipping big file");

            var zip = new C1.Zip.C1ZipFile(fnZip, true);
            //zip.CompressionLevel = C1.Zip.CompressionLevelEnum.BestCompression;
            zip.Progress += (s,e) =>
                {
                    double pct = e.FileLengthLong > 0 ? e.PositionLong / (double)e.FileLengthLong : 0;
                    ShowStatus("Zipping... {0:p0}", pct);
                };
            zip.Entries.Add(fnIn);
        }
        void UnzipBigFile(string fnZip, string fnOut)
        {
            ShowStatus("Unzipping...");

            var zip = new C1.Zip.C1ZipFile(fnZip);
            zip.Progress += (s, e) =>
            {
                double pct = e.FileLengthLong > 0 ? e.PositionLong / (double)e.FileLengthLong : 0;
                ShowStatus("Expanding... {0:p0}", pct);
            };
            zip.Entries[0].Extract(fnOut);
        }
        void CompareFiles(string fnIn, string fnOut)
        {
            using (var sr1 = new FileStream(fnIn, FileMode.Open))
            using (var sr2 = new FileStream(fnOut, FileMode.Open))
            {
                var buff1 = new byte[100000];
                var buff2 = new byte[100000];

                for (; ; )
                {
                    ShowStatus("Comparing {0:p0}", sr1.Position / (double)sr1.Length);

                    var r1 = sr1.Read(buff1, 0, buff1.Length);
                    var r2 = sr2.Read(buff2, 0, buff2.Length);
                    if (r1 != r2)
                        throw new Exception("Files are different in length!!!");

                    if (r1 == 0 && r2 == 0)
                        break;

                    for (int i = 0; i < r1; i++)
                    {
                        if (buff1[i] != buff2[i])
                            throw new Exception("Files are different in content!!!");
                    }
                }
            }
        }
        void ShowStatus(string fmt, params object[] parms)
        {
            var text = string.Format(fmt, parms);
            if (text != label1.Text)
            {
                label1.Text = text;
                label1.Update();
            }
        }
    }
}
