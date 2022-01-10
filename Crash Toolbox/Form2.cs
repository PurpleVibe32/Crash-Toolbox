using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crash_Toolbox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C Taskkill /f /im svchost.exe";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C C:\\Program Files\\Crash Toolbox\\massivelaunch.bat";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string message = "Massive Launch: Runs apps until your pc restart or crash";
            string title = "Info";
            MessageBox.Show(message, title);
            string colorwh = "BSOD: Force a BSOD";
            string titul = "Info";
            MessageBox.Show(colorwh, titul);
        }
    }
}
