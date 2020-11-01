using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace esi
{
    public partial class MainForm : Form
    {
        #region messages
        readonly string message_standard = "Press Ok to Install";
        readonly string message_support = "Please consider helping me financially";
        #endregion

        public string folder = AppDomain.CurrentDomain.BaseDirectory + "installers\\";

        public MainForm()
        {
            InitializeComponent();
        }

        private void install_button_Click(object sender, EventArgs e)
        {
            
            if (check_discord.Checked == true)
            {
                MessageBox.Show(message_standard +" Discord");
                try
                {
                    Process.Start(folder + "DiscordSetup.exe");
                }
                catch { }
            }
            if (check_hwmonitor.Checked == true)
            {
                MessageBox.Show(message_standard + " Hardware Monitor");
                try
                {
                    Process.Start(folder + "hwmonitor.exe");
                }
                catch { }
                
            }
            if (check_java.Checked == true)
            {
                MessageBox.Show(message_standard + " Java");
                try
                {
                    Process.Start(folder + "java.exe");
                }
                catch{ }
            }
            if (check_zoom.Checked == true)
            {
                MessageBox.Show(message_standard + " Zoom");
                try
                {
                    Process.Start(folder + "ZoomInstaller.exe");
                }
                catch { }                
            }
            if (check_filezilla.Checked == true)
            {
                MessageBox.Show(message_standard + " Filezilla");
                try
                {
                    Process.Start(folder + "Filezilla-setup.exe");
                }
                catch { }
            }
            if (check_flux.Checked == true)
            {
                MessageBox.Show(message_standard + " f.lux");
                try
                {
                    Process.Start(folder + "f-lux-setup.exe");
                }
                catch { }
            }
            if (check_github.Checked == true)
            {
                MessageBox.Show(message_standard + " GitHub Desktop");
                try
                {
                    Process.Start(folder + "GitHubDesktopSetup.exe");
                }
                catch { }
            }
            if (check_powertoys.Checked == true)
            {
                MessageBox.Show(message_standard + " PowerToys");
                try
                {
                    Process.Start(folder + "PowerToysSetup-0.23.2-x64.exe");
                }
                catch { }
            }
            if (check_qbittorrent.Checked == true)
            {
                MessageBox.Show(message_standard + " qBittorent");
                try
                {
                    Process.Start(folder + "qbittorrent_4.3.0.1_x64_setup.exe");
                }
                catch { }
            }
            if (check_visualstudio.Checked == true)
            {
                MessageBox.Show(message_standard + " Visual Studio");
                try
                {
                    Process.Start(folder + "vs_community__452317010.1603328756.exe");
                }
                catch { }
            }
            if (check_opera.Checked == true)
            {
                MessageBox.Show(message_standard + " Opera");
                try
                {
                    Process.Start(folder + "OperaSetup.exe");
                }
                catch { }
            }
            if (check_operagx.Checked == true)
            {
                MessageBox.Show(message_standard + " OperaGX");
                try
                {
                    Process.Start(folder + "OperaGXSetup.exe");
                }
                catch { }
            }
            if (check_chrome.Checked == true)
            {
                MessageBox.Show(message_standard + " Google Chrome");
                try
                {
                    Process.Start(folder + "ChromeSetup.exe");
                }
                catch { }
            }
            if (check_firefox.Checked == true)
            {
                MessageBox.Show(message_standard + " Mozilla Firefox");
                try
                {
                    Process.Start(folder + "Firefox Installer.exe");
                }
                catch { }
            }
            if (check_raidrive.Checked == true)
            {
                MessageBox.Show(message_standard + " RaiDrive");
                try
                {
                    Process.Start(folder + "raidrive-2020-6-80.exe");
                }
                catch { }
            }
            if (check_rainmeter.Checked == true)
            {
                MessageBox.Show(message_standard + " Rainmeters");
                try
                {
                    Process.Start(folder + "Rainmeter-4.3.1.exe");
                }
                catch { }
            }
            if (check_raidrive.Checked == true)
            {
                MessageBox.Show(message_standard + " RaiDrive");
                try
                {
                    Process.Start(folder + "raidrive-2020-6-80.exe");
                }
                catch { }
            }
        }
        private void support_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(message_support, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Process.Start("https://www.paypal.me/toastaru");
            }
        }
    }
}