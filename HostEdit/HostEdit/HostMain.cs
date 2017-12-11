using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace HostEdit
{
    public partial class HostMain : Form
    {
        private string hostPath;
        private string localOriginPath;
        private string localZhiRuoPath;
        public HostMain()
        {
            InitializeComponent();
            hostPath = Environment.SystemDirectory + "\\drivers\\etc\\hosts";
            var originDirectory = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\origin");
            var zhiRuoDirectory = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\zhiruo");
            localOriginPath = originDirectory.FullName + "\\hosts";
            localZhiRuoPath = zhiRuoDirectory.FullName + "\\hosts";
            if (!File.Exists(localOriginPath))
            {
                File.Copy(hostPath, localOriginPath);
            }
            if (!File.Exists(localZhiRuoPath))
            {
                File.Copy(hostPath, localZhiRuoPath);
                File.AppendAllLines(localZhiRuoPath, new string[] { "40.125.172.125 heroii.dodox.com.cn" });
            }
        }

        private void btnZhiruo_Click(object sender, EventArgs e)
        {
            HostAndTest(localZhiRuoPath);
        }

        private void btnDodox_Click(object sender, EventArgs e)
        {
            File.AppendAllLines(hostPath, new string[] { "40.125.172.125 heroii.dodox.com.cn" });
            HostAndTest(localOriginPath);          
        }

        private void HostAndTest(string path)
        {

            File.Copy(path, hostPath, true);
            CloseALLieProcess();
            ProcessStartInfo pInfo = new ProcessStartInfo("iexplore", "heroii.dodox.com.cn");
            Process.Start(pInfo);
        }


        private void CloseALLieProcess()
        {
            Process[] myProcesses = Process.GetProcesses();

            foreach (Process myProcess in myProcesses)
            {
                if (myProcess.ProcessName.ToUpper() == "IEXPLORE")
                {

                    if (!myProcess.CloseMainWindow())
                    {
                        myProcess.Kill();
                    }
                }
            }
        }
    }
}
