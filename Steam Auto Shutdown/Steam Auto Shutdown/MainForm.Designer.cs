namespace Steam_Auto_Shutdown
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.networkLabel = new MetroFramework.Controls.MetroLabel();
            this.speedLabel = new MetroFramework.Controls.MetroLabel();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.steamStatusLabel = new MetroFramework.Controls.MetroLabel();
            this.diskCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 100);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(235, 54);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Toggle Auto Shutdown";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 160);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(235, 54);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Minimize To Tray";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(23, 220);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(235, 54);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "Exit";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.Click += new System.EventHandler(this.MetroButton3_Click);
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Enabled = false;
            this.metroToggle1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle1.Location = new System.Drawing.Point(23, 68);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToggle1.TabIndex = 4;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToggle1.UseVisualStyleBackColor = true;
            // 
            // networkLabel
            // 
            this.networkLabel.AutoSize = true;
            this.networkLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.networkLabel.Location = new System.Drawing.Point(23, 289);
            this.networkLabel.Name = "networkLabel";
            this.networkLabel.Size = new System.Drawing.Size(107, 15);
            this.networkLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.networkLabel.TabIndex = 5;
            this.networkLabel.Text = "Detecting network...";
            this.networkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.networkLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.speedLabel.Location = new System.Drawing.Point(23, 313);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(42, 15);
            this.speedLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.speedLabel.TabIndex = 6;
            this.speedLabel.Text = "0 MB/s";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speedLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.statusLabel.Location = new System.Drawing.Point(23, 362);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(56, 15);
            this.statusLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Loading...";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // steamStatusLabel
            // 
            this.steamStatusLabel.AutoSize = true;
            this.steamStatusLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.steamStatusLabel.Location = new System.Drawing.Point(23, 337);
            this.steamStatusLabel.Name = "steamStatusLabel";
            this.steamStatusLabel.Size = new System.Drawing.Size(56, 15);
            this.steamStatusLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.steamStatusLabel.TabIndex = 8;
            this.steamStatusLabel.Text = "Loading...";
            this.steamStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.steamStatusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // diskCheckbox
            // 
            this.diskCheckbox.AutoSize = true;
            this.diskCheckbox.Checked = true;
            this.diskCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.diskCheckbox.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.diskCheckbox.Location = new System.Drawing.Point(109, 69);
            this.diskCheckbox.Name = "diskCheckbox";
            this.diskCheckbox.Size = new System.Drawing.Size(151, 15);
            this.diskCheckbox.Style = MetroFramework.MetroColorStyle.Orange;
            this.diskCheckbox.TabIndex = 9;
            this.diskCheckbox.Text = "Use Disk Detection (BETA)";
            this.diskCheckbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.diskCheckbox.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(31, 392);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(221, 15);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Created by bruxo github.com/bruxo00";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 417);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.diskCheckbox);
            this.Controls.Add(this.steamStatusLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.networkLabel);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Steam Auto Shutdown";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroLabel networkLabel;
        private MetroFramework.Controls.MetroLabel speedLabel;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private MetroFramework.Controls.MetroLabel steamStatusLabel;
        private MetroFramework.Controls.MetroCheckBox diskCheckbox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

