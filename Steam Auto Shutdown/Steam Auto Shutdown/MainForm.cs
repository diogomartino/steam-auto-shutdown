using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Auto_Shutdown
{
    public partial class MainForm : Form
    {
        struct IO_COUNTERS
        {
            public ulong ReadOperationCount;
            public ulong WriteOperationCount;
            public ulong OtherOperationCount;
            public ulong ReadTransferCount;
            public ulong WriteTransferCount;
            public ulong OtherTransferCount;
        }

        [DllImport(@"kernel32.dll", SetLastError = true)]
        static extern bool GetProcessIoCounters(IntPtr hProcess, out IO_COUNTERS counters);

        private string networkCardName = string.Empty;
        private bool isSteamUsingDisk = false;
        private bool monitoringStatus = false;
        private bool messageShown = false;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MainForm()
        {
            InitializeComponent();
            LoadApp();
        }

        private void LoadApp()
        {
            Thread cardThread = new Thread(() => LoadNetworkCardName());
            Thread diskThread = new Thread(() => MonitorSteamDiskUsage());
            Thread monitorThread = new Thread(() => MonitorAutoShutdown());

            cardThread.Start();
            diskThread.Start();
            monitorThread.Start();
        }

        private int GetShutdownSeconds()
        {
            int selectedIndex = 0;

            shutdownAfterDropdown.Invoke((MethodInvoker)delegate
            {
                selectedIndex = shutdownAfterDropdown.SelectedIndex;
            });

            switch (selectedIndex)
            {
                case 0: return 10;
                case 1: return 30;
                case 2: return 60;
                case 3: return 300;
                default: return 30;
            }
        }

        private int GetIdleTresholdSeconds()
        {
            int selectedIndex = 0;

            idleTresholdDropdown.Invoke((MethodInvoker)delegate
            {
                selectedIndex = idleTresholdDropdown.SelectedIndex;
            });

            switch (selectedIndex)
            {
                case 0: return 3;
                case 1: return 5;
                case 2: return 10;
                case 3: return 30;
                default: return 3;
            }
        }

        private int GetSpeedTresholdBytes()
        {
            int selectedIndex = 0;

            speedTresholdDropdown.Invoke((MethodInvoker)delegate
            {
                selectedIndex = speedTresholdDropdown.SelectedIndex;
            });

            switch (selectedIndex)
            {
                case 0: return 20 * 1000;
                case 1: return 50 * 1000;
                case 2: return 100 * 1000;
                case 3: return 200 * 1000;
                case 4: return 400 * 1000;
                case 5: return 600 * 1000;
                case 6: return 800 * 1000;
                case 7: return 1000 * 1000;
                default: return 200 * 1000;
            }
        }

        private void MonitorAutoShutdown()
        {
            int idleCounter = 0;
            int idleTresholdCounter = 0;

            while (true)
            {
                int shutdownAfterSeconds = GetShutdownSeconds();
                int speedTreshold = GetSpeedTresholdBytes();
                int idleTreshold = GetIdleTresholdSeconds();

                try
                {
                    if (!string.IsNullOrEmpty(networkCardName))
                    {
                        double bytesUsage = GetNetworkUtilization(networkCardName);

                        networkSpeedLabel.Invoke((MethodInvoker)delegate
                        {
                            networkSpeedLabel.Text = (((bytesUsage / 1024f) / 1024f).ToString("####0.00") + " MB/s").Replace(",", ".");

                            if (diskDetectionCheckbox.Checked)
                            {
                                diskActivityLabel.Text = "Steam Using Disk: " + (isSteamUsingDisk ? "Yes" : "No");
                            }
                            else
                            {
                                diskActivityLabel.Text = "Steam Using Disk: Disabled";
                            }
                        });

                        if (monitoringStatus)
                        {
                            if (bytesUsage < speedTreshold)
                            {
                                if (!diskDetectionCheckbox.Checked)
                                {
                                    idleCounter++;
                                }
                                else if (diskDetectionCheckbox.Checked && !isSteamUsingDisk)
                                {
                                    idleCounter++;
                                }

                                idleTresholdCounter = 0;
                            }
                            else
                            {
                                idleTresholdCounter++;

                                if (idleTresholdCounter > idleTreshold)
                                {
                                    idleCounter = 0;
                                }
                            }

                            if (idleCounter > shutdownAfterSeconds)
                            {
                                idleCounter = 0;
                                Shutdown();
                                ToggleStatus();
                            }

                            if(idleCounter == 0)
                            {
                                statusLabel.Invoke((MethodInvoker)delegate
                                {
                                    statusLabel.Text = "Downloading...";
                                });
                            }
                            else
                            {
                                statusLabel.Invoke((MethodInvoker)delegate
                                {
                                    statusLabel.Text = String.Format("Shutting down in {0} seconds", shutdownAfterSeconds - idleCounter);
                                });
                            }
                        }
                        else
                        {
                            idleCounter = 0;
                            idleTresholdCounter = 0;

                            statusLabel.Invoke((MethodInvoker)delegate
                            {
                                statusLabel.Text = "";
                            });
                        }
                    }
                }
                catch { }
                finally
                {
                    Thread.Sleep(1000);
                }
            }
        }

        private static void Shutdown()
        {
            try
            {
                Process.Start("shutdown", "/s /t 15");

                DialogResult result = MessageBox.Show("Your computer is shutting down in 15 seconds! Do you want to CANCEL the shutdown? Press YES to ABORT THE SHUTDOWN. Press NO to SHUTDOWN IMEDIATELY.", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Process.Start("shutdown", "/a");
                }
                else
                {
                    Process.Start("shutdown", "/s");
                }
            }
            catch { }
        }

        private void ToggleStatus()
        {
            monitoringStatus = !monitoringStatus;

            toggleStatusLabel.Invoke((MethodInvoker)delegate
            {
                toggleStatusLabel.Text = monitoringStatus ? "ON" : "OFF";
            });
        }

        private double GetNetworkUtilization(string networkCard)
        {
            PerformanceCounter dataReceivedCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", networkCard);

            float receiveSum = 0;

            for (int index = 0; index < 50; index++)
            {
                receiveSum += dataReceivedCounter.NextValue();
            }

            float dataReceived = receiveSum / 50;

            return dataReceived;
        }

        private void LoadNetworkCardName()
        {
            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");
            string[] instancename = category.GetInstanceNames();

            while (string.IsNullOrEmpty(networkCardName))
            {
                foreach (string name in instancename)
                {
                    double utilization = GetNetworkUtilization(name.TrimStart().TrimEnd());

                    if (utilization != 0)
                    {
                        networkCardName = name;

                        networkCardLabel.Invoke((MethodInvoker)delegate
                        {
                            networkCardLabel.Text = networkCardName;
                        });

                        break;
                    }
                }
            }
        }

        private void MonitorSteamDiskUsage()
        {
            ulong lastValue = 0;

            while (true)
            {
                try
                {
                    if (GetProcessIoCounters(Process.GetProcessesByName("steam").FirstOrDefault().Handle, out IO_COUNTERS counters))
                    {
                        if (lastValue != 0 && counters.WriteTransferCount != lastValue && counters.WriteTransferCount - lastValue > 100000)
                        {
                            isSteamUsingDisk = true;
                        }
                        else
                        {
                            isSteamUsingDisk = false;
                        }

                        lastValue = counters.WriteTransferCount;
                    }

                    networkCardLabel.Invoke((MethodInvoker)delegate
                    {
                        networkCardLabel.Text = isSteamUsingDisk ? "Yes" : "No";
                    });

                    Thread.Sleep(2000);
                }
                catch { }
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                this.Hide();

                if (messageShown == false)
                {
                    notifyIcon1.BalloonTipText = "Hey! Steam Auto Shutdown is still running here, don't worry!";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipTitle = "Alert!";
                    notifyIcon1.ShowBalloonTip(500);
                    messageShown = true;
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.Visible = true;
        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/bruxo00");
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            ToggleStatus();
        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/bruxo00/steam-auto-shutdown/wiki/Help");
        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/bruxo00/steam-auto-shutdown");
        }
    }
}
