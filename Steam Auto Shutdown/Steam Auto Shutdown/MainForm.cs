using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Auto_Shutdown
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

    public partial class MainForm : MetroForm
    {
        [DllImport(@"kernel32.dll", SetLastError = true)]
        static extern bool GetProcessIoCounters(IntPtr hProcess, out IO_COUNTERS counters);

        private static string networkCardName = string.Empty;
        private static bool steamUsingDisk = false;
        private static bool message = false;

        public MainForm()
        {
            InitializeComponent();

            Thread t = new Thread(() => GetUsedNetworkCard(networkLabel));
            Thread control = new Thread(() => Control(speedLabel, metroToggle1, statusLabel, steamStatusLabel, diskCheckbox));
            Thread diskM = new Thread(() => MonitorSteamDiskUsage());

            t.Start();
            control.Start();
            diskM.Start();
        }

        private static void Shutdown()
        {
            try
            {
                Process.Start("shutdown", "/s /t 15");

                DialogResult result = MessageBox.Show("Your computer is shutting down in 15 seconds! Do you want to CANCEL the shutdown? Press YES to ABORT THE SHUTDOWN.", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Process.Start("shutdown", "/a");
                }
                else
                {
                    Environment.Exit(-1);
                }
            }
            catch { }
        }

        private static void Control(MetroLabel speed, MetroToggle toggle, MetroLabel status, MetroLabel steam, MetroCheckBox disk)
        {
            int idleCounter = 0;
            int idleTreshold = 0;

            while (true)
            {
                try
                {
                    if (!string.IsNullOrEmpty(networkCardName))
                    {
                        double usage = GetNetworkUtilization(networkCardName);

                        if (toggle.Checked)
                        {
                            if (usage < 10000)
                            {
                                if(!disk.Checked)
                                {
                                    idleCounter++;
                                }
                                else if(disk.Checked && !steamUsingDisk)
                                {
                                    idleCounter++;
                                }
                            }
                            else
                            {
                                idleTreshold++;

                                if (idleTreshold > 6)
                                {
                                    idleCounter = 0;
                                }
                            }

                            if (idleCounter > 240)
                            {
                                idleCounter = 0;
                                Shutdown();
                            }

                            status.Invoke((MethodInvoker)delegate
                            {
                                status.Text = "Idle Detector: " + idleCounter + " / 240";
                            });
                        }
                        else
                        {
                            idleCounter = 0;
                            idleTreshold = 0;
                            status.Invoke((MethodInvoker)delegate
                            {
                                status.Text = "";
                            });
                        }

                        speed.Invoke((MethodInvoker)delegate
                        {
                            speed.Text = ((usage / 1024f) / 1024f).ToString("####0.00") + " MB/S";
                            
                            if(disk.Checked)
                            {
                                steam.Text = "Disk Activity: " + (steamUsingDisk ? "Yes" : "No");
                            }
                            else
                            {
                                steam.Text = "";
                            }
                        });
                    }
                }
                catch { }
                finally
                {
                    Thread.Sleep(500);
                }
            }
        }

        public static bool MonitorSteamDiskUsage()
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
                            steamUsingDisk = true;
                        }
                        else
                        {
                            steamUsingDisk = false;
                        }

                        lastValue = counters.WriteTransferCount;
                    }

                    Thread.Sleep(500);
                }
                catch { }
            }
        }

        private static double GetNetworkUtilization(string networkCard)
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

        private static void GetUsedNetworkCard(MetroLabel label)
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

                        label.Invoke((MethodInvoker)delegate
                        {
                            label.Text = name;
                        });

                        break;
                    }
                }
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            metroToggle1.Checked = !metroToggle1.Checked;
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && cursorNotInBar)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                this.Hide();

                if (message == false)
                {
                    notifyIcon1.BalloonTipText = "Hey! Steam Auto Shutdown is still running here, don't worry!";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipTitle = "Alert!";
                    notifyIcon1.ShowBalloonTip(500);
                    message = true;
                }
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.Visible = true;
        }
    }
}
