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
        public void FlushDNS1()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "ipconfig /flushdns\nipconfig / release\nipconfig / renew";
            process.StartInfo = startInfo;
            process.Start();

            //string strCmdText1 = "ipconfig /flushdns";
            //string strCmdText2 = "ipconfig / release";
            //string strCmdText3 = "ipconfig / renew";
            ////strCmdText1 = "ipconfig /flushdns" + "ipconfig / release" + "ipconfig / renew";
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText1);
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText2);
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText3);
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
            //process.WaitForExit();
        }
    }
}
