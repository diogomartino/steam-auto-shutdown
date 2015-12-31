using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Steam_Auto_Shutdown
{
    public partial class Form1 : Form
    {
        private static bool message = false;
        private static int selectedOption = 0;
        private static string networkCard = null;
        private static int noDownloadCounter = 0;

        public Form1()
        {
            InitializeComponent();
            GetUsedNetworkCard();

            toolStripStatusLabel1.Text = "Network card: " + networkCard;
        }

        private void futureButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void futureButton1_Click(object sender, EventArgs e)
        {
            if(selectedOption == 0)
            {
                toolStripStatusLabel1.Text = "Updating system status...";
                futureButton1.Text = "Disable auto shutdown";

                timer1.Start();

                selectedOption = 1;
            }
            else
            {
                futureButton1.Text = "Shutdown when downloads are finished";
                toolStripStatusLabel1.Text = "Waiting...";

                timer1.Stop();

                selectedOption = 0;
                noDownloadCounter = 0;
            }

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if(this.WindowState == FormWindowState.Minimized && cursorNotInBar)
            {
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                this.Hide();

                if(message == false)
                {
                    notifyIcon1.BalloonTipText = "Hey! Steam Auto Shutdown is still running here, don't worry!";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipTitle = "Alert!";
                    notifyIcon1.ShowBalloonTip(500);

                    message = true;
                }
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.Visible = true;
        }

        private void futureButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double result = GetNetworkUtilization(networkCard);

            if(result <= 10000)
            {
                noDownloadCounter++;
                toolStripStatusLabel1.Text = "Not downloading... (" + result.ToString() + " bytes p/sec) for " + noDownloadCounter + " seconds";
            }
            else
            {
                toolStripStatusLabel1.Text = "Current download: " + result.ToString() + " bytes p/sec";
            }

            if(noDownloadCounter > 60)
            {
                timer1.Stop();
                Shutdown();
            }
        }

        public void Shutdown()
        {
            Process.Start("shutdown", "/s /t 15");

            DialogResult result = MessageBox.Show("Your computer is shutting down! Do you want to CANCEL the shutdown?", "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Process.Start("shutdown", "/a");
            }

            Application.Exit();
        }

        public double GetNetworkUtilization(string networkCard) // By RagnaRock @ stackoverflow
        {
            const int numberOfIterations = 10;

            PerformanceCounter bandwidthCounter = new PerformanceCounter("Network Interface", "Current Bandwidth", networkCard);
            float bandwidth = bandwidthCounter.NextValue();

            PerformanceCounter dataSentCounter = new PerformanceCounter("Network Interface", "Bytes Sent/sec", networkCard);
            PerformanceCounter dataReceivedCounter = new PerformanceCounter("Network Interface", "Bytes Received/sec", networkCard);

            float sendSum = 0;
            float receiveSum = 0;

            for (int index = 0; index < numberOfIterations; index++)
            {
                sendSum += dataSentCounter.NextValue();
                receiveSum += dataReceivedCounter.NextValue();
            }

            float dataSent = sendSum;
            float dataReceived = receiveSum;

            return dataReceived;
        }

        public void GetUsedNetworkCard() 
        {
            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");
            String[] instancename = category.GetInstanceNames();

            foreach (string name in instancename)
            {
                YOLO:

                int i = 0;
                double s = GetNetworkUtilization(name);

                if(s == 0 && i < 3) // try 3 times
                {
                    Thread.Sleep(1000);

                    i++;
                    goto YOLO;
                }
                else if(s > 0)
                {
                    networkCard = name;
                    break;
                }
            }
        }
    }
}
