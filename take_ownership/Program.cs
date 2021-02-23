using System;
using System.Security.Principal;

namespace take_ownership
{
    class Program
    {
        static void Main(string[] args)
        {

            //ownership
            String FileName = @"C:\Windows\SystemApps\Microsoft.Windows.PinningConfirmationDialog_cw5n1h2txyewy";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            startInfo.FileName = "cmd.exe";

            startInfo.Arguments = @" /k takeown /f " + FileName;

            process.StartInfo = startInfo;
            process.Start();


            System.Threading.Thread.Sleep(100);

            System.Diagnostics.Process f_r = new System.Diagnostics.Process();
            f_r.StartInfo.FileName = "cmd.exe";
            f_r.StartInfo.RedirectStandardInput = true;
            f_r.StartInfo.RedirectStandardOutput = true;
            f_r.StartInfo.CreateNoWindow = true;
            f_r.StartInfo.UseShellExecute = false;
            f_r.Start();

            f_r.StandardInput.WriteLine("cd/ & cd windows & cd system32 & cacls \"" + FileName + "\" /e /p Everyone:f");
            f_r.StandardInput.Flush();
            f_r.StandardInput.Close();
        }
    }
}
