
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
            this.statusLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.diskActivityLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.networkSpeedLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.networkCardLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.toggleStatusLabel = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            this.toggleButton = new ReaLTaiizor.Controls.MaterialButton();
            this.diskDetectionCheckbox = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.shutdownAfterDropdown = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            this.speedTresholdDropdown = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            this.idleTresholdDropdown = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel7 = new ReaLTaiizor.Controls.MaterialLabel();
            this.materialLabel8 = new ReaLTaiizor.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Depth = 0;
            this.statusLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.statusLabel.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Caption;
            this.statusLabel.Location = new System.Drawing.Point(391, 127);
            this.statusLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1, 0);
            this.statusLabel.TabIndex = 20;
            // 
            // diskActivityLabel
            // 
            this.diskActivityLabel.AutoSize = true;
            this.diskActivityLabel.Depth = 0;
            this.diskActivityLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.diskActivityLabel.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Caption;
            this.diskActivityLabel.Location = new System.Drawing.Point(391, 97);
            this.diskActivityLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.diskActivityLabel.Name = "diskActivityLabel";
            this.diskActivityLabel.Size = new System.Drawing.Size(149, 14);
            this.diskActivityLabel.TabIndex = 19;
            this.diskActivityLabel.Text = "Steam Using Disk: Disabled";
            // 
            // networkSpeedLabel
            // 
            this.networkSpeedLabel.AutoSize = true;
            this.networkSpeedLabel.Depth = 0;
            this.networkSpeedLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.networkSpeedLabel.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Caption;
            this.networkSpeedLabel.Location = new System.Drawing.Point(391, 113);
            this.networkSpeedLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.networkSpeedLabel.Name = "networkSpeedLabel";
            this.networkSpeedLabel.Size = new System.Drawing.Size(56, 14);
            this.networkSpeedLabel.TabIndex = 18;
            this.networkSpeedLabel.Text = "0.00 MB/s";
            // 
            // networkCardLabel
            // 
            this.networkCardLabel.AutoSize = true;
            this.networkCardLabel.Depth = 0;
            this.networkCardLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.networkCardLabel.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Caption;
            this.networkCardLabel.Location = new System.Drawing.Point(391, 80);
            this.networkCardLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.networkCardLabel.Name = "networkCardLabel";
            this.networkCardLabel.Size = new System.Drawing.Size(193, 14);
            this.networkCardLabel.TabIndex = 17;
            this.networkCardLabel.Text = "Searching for active network card....";
            // 
            // toggleStatusLabel
            // 
            this.toggleStatusLabel.AutoSize = true;
            this.toggleStatusLabel.Depth = 0;
            this.toggleStatusLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.toggleStatusLabel.Location = new System.Drawing.Point(284, 122);
            this.toggleStatusLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.toggleStatusLabel.Name = "toggleStatusLabel";
            this.toggleStatusLabel.Size = new System.Drawing.Size(30, 19);
            this.toggleStatusLabel.TabIndex = 16;
            this.toggleStatusLabel.Text = "OFF";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(33, 122);
            this.materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(245, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Steam Auto Shutdown is currently:";
            // 
            // toggleButton
            // 
            this.toggleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toggleButton.Depth = 0;
            this.toggleButton.DrawShadows = true;
            this.toggleButton.HighEmphasis = true;
            this.toggleButton.Icon = null;
            this.toggleButton.Location = new System.Drawing.Point(31, 80);
            this.toggleButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.toggleButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(172, 36);
            this.toggleButton.TabIndex = 13;
            this.toggleButton.Text = "Toggle Auto Shutdown";
            this.toggleButton.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal;
            this.toggleButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.toggleButton.UseAccentColor = false;
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // diskDetectionCheckbox
            // 
            this.diskDetectionCheckbox.AutoSize = true;
            this.diskDetectionCheckbox.Depth = 0;
            this.diskDetectionCheckbox.Location = new System.Drawing.Point(207, 79);
            this.diskDetectionCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.diskDetectionCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.diskDetectionCheckbox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.diskDetectionCheckbox.Name = "diskDetectionCheckbox";
            this.diskDetectionCheckbox.Ripple = true;
            this.diskDetectionCheckbox.Size = new System.Drawing.Size(167, 37);
            this.diskDetectionCheckbox.TabIndex = 12;
            this.diskDetectionCheckbox.Text = "Use Disk Detection";
            this.diskDetectionCheckbox.UseVisualStyleBackColor = true;
            // 
            // shutdownAfterDropdown
            // 
            this.shutdownAfterDropdown.AutoResize = false;
            this.shutdownAfterDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.shutdownAfterDropdown.Depth = 0;
            this.shutdownAfterDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.shutdownAfterDropdown.DropDownHeight = 118;
            this.shutdownAfterDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shutdownAfterDropdown.DropDownWidth = 121;
            this.shutdownAfterDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.shutdownAfterDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.shutdownAfterDropdown.FormattingEnabled = true;
            this.shutdownAfterDropdown.IntegralHeight = false;
            this.shutdownAfterDropdown.ItemHeight = 29;
            this.shutdownAfterDropdown.Items.AddRange(new object[] {
            "10 seconds",
            "30 seconds",
            "1 minute",
            "5 minutes"});
            this.shutdownAfterDropdown.Location = new System.Drawing.Point(31, 171);
            this.shutdownAfterDropdown.MaxDropDownItems = 4;
            this.shutdownAfterDropdown.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.shutdownAfterDropdown.Name = "shutdownAfterDropdown";
            this.shutdownAfterDropdown.Size = new System.Drawing.Size(161, 35);
            this.shutdownAfterDropdown.StartIndex = 0;
            this.shutdownAfterDropdown.TabIndex = 21;
            this.shutdownAfterDropdown.UseAccent = false;
            this.shutdownAfterDropdown.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Body2;
            this.materialLabel1.Location = new System.Drawing.Point(33, 151);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(98, 17);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Shutdown after";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Body2;
            this.materialLabel3.Location = new System.Drawing.Point(223, 150);
            this.materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(101, 17);
            this.materialLabel3.TabIndex = 24;
            this.materialLabel3.Text = "Speed threshold";
            // 
            // speedTresholdDropdown
            // 
            this.speedTresholdDropdown.AutoResize = false;
            this.speedTresholdDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.speedTresholdDropdown.Depth = 0;
            this.speedTresholdDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.speedTresholdDropdown.DropDownHeight = 118;
            this.speedTresholdDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedTresholdDropdown.DropDownWidth = 121;
            this.speedTresholdDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.speedTresholdDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.speedTresholdDropdown.FormattingEnabled = true;
            this.speedTresholdDropdown.IntegralHeight = false;
            this.speedTresholdDropdown.ItemHeight = 29;
            this.speedTresholdDropdown.Items.AddRange(new object[] {
            "20 KB/s",
            "50 KB/s",
            "100 KB/s",
            "200 KB/s",
            "400 KB/s",
            "600 KB/s",
            "800 KB/s",
            "1 MB/s"});
            this.speedTresholdDropdown.Location = new System.Drawing.Point(226, 171);
            this.speedTresholdDropdown.MaxDropDownItems = 4;
            this.speedTresholdDropdown.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.speedTresholdDropdown.Name = "speedTresholdDropdown";
            this.speedTresholdDropdown.Size = new System.Drawing.Size(159, 35);
            this.speedTresholdDropdown.StartIndex = 3;
            this.speedTresholdDropdown.TabIndex = 23;
            this.speedTresholdDropdown.UseAccent = false;
            this.speedTresholdDropdown.UseTallSize = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Body2;
            this.materialLabel4.Location = new System.Drawing.Point(420, 150);
            this.materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(85, 17);
            this.materialLabel4.TabIndex = 26;
            this.materialLabel4.Text = "Idle threshold";
            // 
            // idleTresholdDropdown
            // 
            this.idleTresholdDropdown.AutoResize = false;
            this.idleTresholdDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.idleTresholdDropdown.Depth = 0;
            this.idleTresholdDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.idleTresholdDropdown.DropDownHeight = 118;
            this.idleTresholdDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idleTresholdDropdown.DropDownWidth = 121;
            this.idleTresholdDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.idleTresholdDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idleTresholdDropdown.FormattingEnabled = true;
            this.idleTresholdDropdown.IntegralHeight = false;
            this.idleTresholdDropdown.ItemHeight = 29;
            this.idleTresholdDropdown.Items.AddRange(new object[] {
            "3 seconds",
            "5 seconds",
            "10 seconds",
            "30 seconds"});
            this.idleTresholdDropdown.Location = new System.Drawing.Point(423, 171);
            this.idleTresholdDropdown.MaxDropDownItems = 4;
            this.idleTresholdDropdown.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.idleTresholdDropdown.Name = "idleTresholdDropdown";
            this.idleTresholdDropdown.Size = new System.Drawing.Size(161, 35);
            this.idleTresholdDropdown.StartIndex = 1;
            this.idleTresholdDropdown.TabIndex = 25;
            this.idleTresholdDropdown.UseAccent = false;
            this.idleTresholdDropdown.UseTallSize = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(539, 3);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(25, 36);
            this.materialButton1.TabIndex = 27;
            this.materialButton1.Text = "-";
            this.materialButton1.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal;
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(572, 3);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(29, 36);
            this.materialButton2.TabIndex = 28;
            this.materialButton2.Text = "x";
            this.materialButton2.TextState = ReaLTaiizor.Controls.MaterialButton.TextStateType.Normal;
            this.materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = ReaLTaiizor.Util.MaterialManager.FontType.H4;
            this.materialLabel5.Location = new System.Drawing.Point(72, 12);
            this.materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(338, 41);
            this.materialLabel5.TabIndex = 29;
            this.materialLabel5.Text = "Steam Auto Shutdown";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Blue;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Location = new System.Drawing.Point(-7, 63);
            this.materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(677, 3);
            this.materialDivider1.TabIndex = 31;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Steam Auto Shutdown";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Overline;
            this.materialLabel6.Location = new System.Drawing.Point(33, 218);
            this.materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(113, 13);
            this.materialLabel6.TabIndex = 32;
            this.materialLabel6.Text = "Created by Diogo Martino";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Overline;
            this.materialLabel7.Location = new System.Drawing.Point(481, 218);
            this.materialLabel7.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(103, 13);
            this.materialLabel7.TabIndex = 33;
            this.materialLabel7.Text = "Need help? Click HERE!";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = ReaLTaiizor.Util.MaterialManager.FontType.Overline;
            this.materialLabel8.Location = new System.Drawing.Point(416, 34);
            this.materialLabel8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(21, 13);
            this.materialLabel8.TabIndex = 34;
            this.materialLabel8.Text = "v5.0";
            this.materialLabel8.Click += new System.EventHandler(this.materialLabel8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Steam_Auto_Shutdown.Properties.Resources.steam_icon_steam_icon_11553449126dlqnjdi4pi;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 238);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.idleTresholdDropdown);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.speedTresholdDropdown);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.shutdownAfterDropdown);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.diskActivityLabel);
            this.Controls.Add(this.networkSpeedLabel);
            this.Controls.Add(this.networkCardLabel);
            this.Controls.Add(this.toggleStatusLabel);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.diskDetectionCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel statusLabel;
        private ReaLTaiizor.Controls.MaterialLabel diskActivityLabel;
        private ReaLTaiizor.Controls.MaterialLabel networkSpeedLabel;
        private ReaLTaiizor.Controls.MaterialLabel networkCardLabel;
        private ReaLTaiizor.Controls.MaterialLabel toggleStatusLabel;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialButton toggleButton;
        private ReaLTaiizor.Controls.MaterialCheckBox diskDetectionCheckbox;
        private ReaLTaiizor.Controls.MaterialComboBox shutdownAfterDropdown;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialComboBox speedTresholdDropdown;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialComboBox idleTresholdDropdown;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel7;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel8;
    }
}
