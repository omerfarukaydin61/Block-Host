using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_Locker
{
    internal class repository
    {
        const string filePath = @"C:\Windows\System32\drivers\etc\hosts";

        List<string> linesList = File.ReadAllLines(filePath).ToList();
        public void BlockYoutube()
        {
            string add = "\n127.0.0.1 youtube.com" +
                        "\n127.0.0.1 www.youtube.com" +
                        "\n127.0.0.1 m.youtube.com" +
                        "\n127.0.0.1 yt3.ggpht.com";
            File.AppendAllText(filePath, add);
            FlushDNS();
        }
        public void AllowYoutube()
        {
            for (int i = 0; i < linesList.Count; i++)
            {
                var xxx = linesList[i];
                if (linesList[i] == "127.0.0.1 youtube.com" ||
                    linesList[i] == "127.0.0.1 www.youtube.com" ||
                    linesList[i] == "127.0.0.1 m.youtube.com" ||
                    linesList[i] == "127.0.0.1 yt3.ggpht.com")
                {
                    linesList.RemoveAt(i);
                    return;
                }
            }
            File.WriteAllLines(filePath, linesList.ToArray());
            FlushDNS();
        }
        public static void FlushDNS()
        {
            Process process = new Process();
            process.StartInfo.FileName = " cmd.exe ";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("ipconfig /flushdns" + "ipconfig / release" + "ipconfig / renew");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
        }
    }
}
