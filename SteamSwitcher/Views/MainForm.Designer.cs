namespace SteamSwitcher.Views
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
            this.steamDisplayComboBox = new System.Windows.Forms.ComboBox();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.steamDisplayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tvGroupBox = new System.Windows.Forms.GroupBox();
            this.tvHotKeyLabel = new System.Windows.Forms.Label();
            this.setTVDispalyButton = new System.Windows.Forms.Button();
            this.setTVAudioButton = new System.Windows.Forms.Button();
            this.activateTvPanelButton = new System.Windows.Forms.Button();
            this.steamAudioComboBox = new System.Windows.Forms.ComboBox();
            this.steamAudioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.monitorGroupBox = new System.Windows.Forms.GroupBox();
            this.monitorHotKeyLabel = new System.Windows.Forms.Label();
            this.setMonitorDispalyButton = new System.Windows.Forms.Button();
            this.setMonitorAudioButton = new System.Windows.Forms.Button();
            this.activateMonitorPanelButton = new System.Windows.Forms.Button();
            this.defaultAudioComboBox = new System.Windows.Forms.ComboBox();
            this.defaultAudioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.defaultDisplayComboBox = new System.Windows.Forms.ComboBox();
            this.defaultDisplayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.startUpCheckBox = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTrayContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTrayContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.autoBPModeCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.onlyAudioBPModeCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steamDisplayBindingSource)).BeginInit();
            this.tvGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.steamAudioBindingSource)).BeginInit();
            this.monitorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultAudioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDisplayBindingSource)).BeginInit();
            this.trayContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // steamDisplayComboBox
            // 
            this.steamDisplayComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.steamDisplayComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.settingsBindingSource, "SteamDisplay", true));
            this.steamDisplayComboBox.DataSource = this.steamDisplayBindingSource;
            this.steamDisplayComboBox.DisplayMember = "Title";
            this.steamDisplayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.steamDisplayComboBox.FormattingEnabled = true;
            this.steamDisplayComboBox.Location = new System.Drawing.Point(65, 19);
            this.steamDisplayComboBox.Name = "steamDisplayComboBox";
            this.steamDisplayComboBox.Size = new System.Drawing.Size(200, 21);
            this.steamDisplayComboBox.TabIndex = 0;
            this.steamDisplayComboBox.ValueMember = "Name";
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(Switcher.Dto.DeviceSettings);
            // 
            // steamDisplayBindingSource
            // 
            this.steamDisplayBindingSource.DataSource = typeof(Switcher.Dto.Device);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display:";
            // 
            // tvGroupBox
            // 
            this.tvGroupBox.Controls.Add(this.tvHotKeyLabel);
            this.tvGroupBox.Controls.Add(this.setTVDispalyButton);
            this.tvGroupBox.Controls.Add(this.setTVAudioButton);
            this.tvGroupBox.Controls.Add(this.activateTvPanelButton);
            this.tvGroupBox.Controls.Add(this.steamAudioComboBox);
            this.tvGroupBox.Controls.Add(this.label2);
            this.tvGroupBox.Controls.Add(this.steamDisplayComboBox);
            this.tvGroupBox.Controls.Add(this.label1);
            this.tvGroupBox.Location = new System.Drawing.Point(12, 29);
            this.tvGroupBox.Name = "tvGroupBox";
            this.tvGroupBox.Size = new System.Drawing.Size(313, 122);
            this.tvGroupBox.TabIndex = 2;
            this.tvGroupBox.TabStop = false;
            this.tvGroupBox.Text = "TV";
            // 
            // tvHotKeyLabel
            // 
            this.tvHotKeyLabel.AutoSize = true;
            this.tvHotKeyLabel.Location = new System.Drawing.Point(62, 85);
            this.tvHotKeyLabel.Name = "tvHotKeyLabel";
            this.tvHotKeyLabel.Size = new System.Drawing.Size(92, 13);
            this.tvHotKeyLabel.TabIndex = 12;
            this.tvHotKeyLabel.Text = "Hotkey: Ctrl+Alt+1";
            // 
            // setTVDispalyButton
            // 
            this.setTVDispalyButton.Image = ((System.Drawing.Image)(resources.GetObject("setTVDispalyButton.Image")));
            this.setTVDispalyButton.Location = new System.Drawing.Point(271, 18);
            this.setTVDispalyButton.Name = "setTVDispalyButton";
            this.setTVDispalyButton.Size = new System.Drawing.Size(33, 21);
            this.setTVDispalyButton.TabIndex = 10;
            this.setTVDispalyButton.UseVisualStyleBackColor = true;
            // 
            // setTVAudioButton
            // 
            this.setTVAudioButton.Image = ((System.Drawing.Image)(resources.GetObject("setTVAudioButton.Image")));
            this.setTVAudioButton.Location = new System.Drawing.Point(271, 54);
            this.setTVAudioButton.Name = "setTVAudioButton";
            this.setTVAudioButton.Size = new System.Drawing.Size(33, 21);
            this.setTVAudioButton.TabIndex = 9;
            this.setTVAudioButton.UseVisualStyleBackColor = true;
            // 
            // activateTvPanelButton
            // 
            this.activateTvPanelButton.Image = ((System.Drawing.Image)(resources.GetObject("activateTvPanelButton.Image")));
            this.activateTvPanelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activateTvPanelButton.Location = new System.Drawing.Point(212, 85);
            this.activateTvPanelButton.Name = "activateTvPanelButton";
            this.activateTvPanelButton.Size = new System.Drawing.Size(95, 26);
            this.activateTvPanelButton.TabIndex = 9;
            this.activateTvPanelButton.Text = "Activate Both";
            this.activateTvPanelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.activateTvPanelButton.UseVisualStyleBackColor = true;
            // 
            // steamAudioComboBox
            // 
            this.steamAudioComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.steamAudioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.settingsBindingSource, "SteamAudio", true));
            this.steamAudioComboBox.DataSource = this.steamAudioBindingSource;
            this.steamAudioComboBox.DisplayMember = "Title";
            this.steamAudioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.steamAudioComboBox.FormattingEnabled = true;
            this.steamAudioComboBox.Location = new System.Drawing.Point(65, 54);
            this.steamAudioComboBox.Name = "steamAudioComboBox";
            this.steamAudioComboBox.Size = new System.Drawing.Size(200, 21);
            this.steamAudioComboBox.TabIndex = 2;
            this.steamAudioComboBox.ValueMember = "Name";
            // 
            // steamAudioBindingSource
            // 
            this.steamAudioBindingSource.DataSource = typeof(Switcher.Dto.Device);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Audio:";
            // 
            // monitorGroupBox
            // 
            this.monitorGroupBox.Controls.Add(this.monitorHotKeyLabel);
            this.monitorGroupBox.Controls.Add(this.setMonitorDispalyButton);
            this.monitorGroupBox.Controls.Add(this.setMonitorAudioButton);
            this.monitorGroupBox.Controls.Add(this.activateMonitorPanelButton);
            this.monitorGroupBox.Controls.Add(this.defaultAudioComboBox);
            this.monitorGroupBox.Controls.Add(this.label3);
            this.monitorGroupBox.Controls.Add(this.defaultDisplayComboBox);
            this.monitorGroupBox.Controls.Add(this.label4);
            this.monitorGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.monitorGroupBox.Location = new System.Drawing.Point(331, 30);
            this.monitorGroupBox.Name = "monitorGroupBox";
            this.monitorGroupBox.Size = new System.Drawing.Size(308, 122);
            this.monitorGroupBox.TabIndex = 4;
            this.monitorGroupBox.TabStop = false;
            this.monitorGroupBox.Text = "Monitor";
            // 
            // monitorHotKeyLabel
            // 
            this.monitorHotKeyLabel.AutoSize = true;
            this.monitorHotKeyLabel.Location = new System.Drawing.Point(56, 84);
            this.monitorHotKeyLabel.Name = "monitorHotKeyLabel";
            this.monitorHotKeyLabel.Size = new System.Drawing.Size(92, 13);
            this.monitorHotKeyLabel.TabIndex = 13;
            this.monitorHotKeyLabel.Text = "Hotkey: Ctrl+Alt+2";
            // 
            // setMonitorDispalyButton
            // 
            this.setMonitorDispalyButton.Image = ((System.Drawing.Image)(resources.GetObject("setMonitorDispalyButton.Image")));
            this.setMonitorDispalyButton.Location = new System.Drawing.Point(265, 18);
            this.setMonitorDispalyButton.Name = "setMonitorDispalyButton";
            this.setMonitorDispalyButton.Size = new System.Drawing.Size(33, 22);
            this.setMonitorDispalyButton.TabIndex = 12;
            this.setMonitorDispalyButton.UseVisualStyleBackColor = true;
            // 
            // setMonitorAudioButton
            // 
            this.setMonitorAudioButton.Image = ((System.Drawing.Image)(resources.GetObject("setMonitorAudioButton.Image")));
            this.setMonitorAudioButton.Location = new System.Drawing.Point(265, 53);
            this.setMonitorAudioButton.Name = "setMonitorAudioButton";
            this.setMonitorAudioButton.Size = new System.Drawing.Size(33, 23);
            this.setMonitorAudioButton.TabIndex = 11;
            this.setMonitorAudioButton.UseVisualStyleBackColor = true;
            // 
            // activateMonitorPanelButton
            // 
            this.activateMonitorPanelButton.Image = ((System.Drawing.Image)(resources.GetObject("activateMonitorPanelButton.Image")));
            this.activateMonitorPanelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activateMonitorPanelButton.Location = new System.Drawing.Point(207, 84);
            this.activateMonitorPanelButton.Name = "activateMonitorPanelButton";
            this.activateMonitorPanelButton.Size = new System.Drawing.Size(95, 28);
            this.activateMonitorPanelButton.TabIndex = 8;
            this.activateMonitorPanelButton.Text = "Activate Both";
            this.activateMonitorPanelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.activateMonitorPanelButton.UseVisualStyleBackColor = true;
            // 
            // defaultAudioComboBox
            // 
            this.defaultAudioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.settingsBindingSource, "DefaultAudio", true));
            this.defaultAudioComboBox.DataSource = this.defaultAudioBindingSource;
            this.defaultAudioComboBox.DisplayMember = "Title";
            this.defaultAudioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultAudioComboBox.FormattingEnabled = true;
            this.defaultAudioComboBox.Location = new System.Drawing.Point(59, 54);
            this.defaultAudioComboBox.Name = "defaultAudioComboBox";
            this.defaultAudioComboBox.Size = new System.Drawing.Size(200, 21);
            this.defaultAudioComboBox.TabIndex = 2;
            this.defaultAudioComboBox.ValueMember = "Name";
            // 
            // defaultAudioBindingSource
            // 
            this.defaultAudioBindingSource.DataSource = typeof(Switcher.Dto.Device);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Audio:";
            // 
            // defaultDisplayComboBox
            // 
            this.defaultDisplayComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.settingsBindingSource, "DefaultDisplay", true));
            this.defaultDisplayComboBox.DataSource = this.defaultDisplayBindingSource;
            this.defaultDisplayComboBox.DisplayMember = "Title";
            this.defaultDisplayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultDisplayComboBox.FormattingEnabled = true;
            this.defaultDisplayComboBox.Location = new System.Drawing.Point(59, 19);
            this.defaultDisplayComboBox.Name = "defaultDisplayComboBox";
            this.defaultDisplayComboBox.Size = new System.Drawing.Size(200, 21);
            this.defaultDisplayComboBox.TabIndex = 0;
            this.defaultDisplayComboBox.ValueMember = "Name";
            // 
            // defaultDisplayBindingSource
            // 
            this.defaultDisplayBindingSource.DataSource = typeof(Switcher.Dto.Device);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Display:";
            // 
            // startUpCheckBox
            // 
            this.startUpCheckBox.AutoSize = true;
            this.startUpCheckBox.Location = new System.Drawing.Point(487, 30);
            this.startUpCheckBox.Name = "startUpCheckBox";
            this.startUpCheckBox.Size = new System.Drawing.Size(129, 17);
            this.startUpCheckBox.TabIndex = 6;
            this.startUpCheckBox.Text = "Startup with Windows";
            this.startUpCheckBox.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Minimazed To";
            this.notifyIcon.ContextMenuStrip = this.trayContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTrayContextMenu,
            this.exitTrayContextMenu});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // showTrayContextMenu
            // 
            this.showTrayContextMenu.Name = "showTrayContextMenu";
            this.showTrayContextMenu.Size = new System.Drawing.Size(103, 22);
            this.showTrayContextMenu.Text = "Show";
            // 
            // exitTrayContextMenu
            // 
            this.exitTrayContextMenu.Name = "exitTrayContextMenu";
            this.exitTrayContextMenu.Size = new System.Drawing.Size(103, 22);
            this.exitTrayContextMenu.Text = "Exit";
            // 
            // autoBPModeCheckBox
            // 
            this.autoBPModeCheckBox.AutoSize = true;
            this.autoBPModeCheckBox.Location = new System.Drawing.Point(37, 19);
            this.autoBPModeCheckBox.Name = "autoBPModeCheckBox";
            this.autoBPModeCheckBox.Size = new System.Drawing.Size(229, 17);
            this.autoBPModeCheckBox.TabIndex = 8;
            this.autoBPModeCheckBox.Text = "Wait for Big Picture mode and switch to TV";
            this.autoBPModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.onlyAudioBPModeCheckBox);
            this.groupBox1.Controls.Add(this.autoBPModeCheckBox);
            this.groupBox1.Controls.Add(this.startUpCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 72);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // onlyAudioBPModeCheckBox
            // 
            this.onlyAudioBPModeCheckBox.AutoSize = true;
            this.onlyAudioBPModeCheckBox.Location = new System.Drawing.Point(56, 43);
            this.onlyAudioBPModeCheckBox.Name = "onlyAudioBPModeCheckBox";
            this.onlyAudioBPModeCheckBox.Size = new System.Drawing.Size(221, 17);
            this.onlyAudioBPModeCheckBox.TabIndex = 9;
            this.onlyAudioBPModeCheckBox.Text = "Switch only TV Audio in Big Picture mode";
            this.onlyAudioBPModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(511, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Strongly recommended: Set main display for Big Picture from: Big Picture -> Setti" +
    "ng -> Display - > Resolution";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 238);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monitorGroupBox);
            this.Controls.Add(this.tvGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam TV Switcher :: Stanislav Glushak (st.glushak@gmail.com)";
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steamDisplayBindingSource)).EndInit();
            this.tvGroupBox.ResumeLayout(false);
            this.tvGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.steamAudioBindingSource)).EndInit();
            this.monitorGroupBox.ResumeLayout(false);
            this.monitorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultAudioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDisplayBindingSource)).EndInit();
            this.trayContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox steamDisplayComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox tvGroupBox;
        private System.Windows.Forms.ComboBox steamAudioComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox monitorGroupBox;
        private System.Windows.Forms.ComboBox defaultAudioComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox defaultDisplayComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource steamDisplayBindingSource;
        private System.Windows.Forms.BindingSource steamAudioBindingSource;
        private System.Windows.Forms.BindingSource defaultAudioBindingSource;
        private System.Windows.Forms.BindingSource defaultDisplayBindingSource;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.CheckBox startUpCheckBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.CheckBox autoBPModeCheckBox;
        private System.Windows.Forms.Button activateTvPanelButton;
        private System.Windows.Forms.Button activateMonitorPanelButton;
        private System.Windows.Forms.Button setTVDispalyButton;
        private System.Windows.Forms.Button setTVAudioButton;
        private System.Windows.Forms.Button setMonitorDispalyButton;
        private System.Windows.Forms.Button setMonitorAudioButton;
        private System.Windows.Forms.ToolStripMenuItem showTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitTrayContextMenu;
        private System.Windows.Forms.Label tvHotKeyLabel;
        private System.Windows.Forms.Label monitorHotKeyLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox onlyAudioBPModeCheckBox;
        private System.Windows.Forms.Label label5;
    }
}

