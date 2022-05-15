using System;
using System.IO;

namespace MissionPlanner
{
    partial class MainV2
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
            Console.WriteLine("mainv2_Dispose");
            if (PluginThreadrunner != null)
                PluginThreadrunner.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainV2));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.CTX_mainmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autoHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readonlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFlightData = new System.Windows.Forms.ToolStripButton();
            this.MenuFlightPlanner = new System.Windows.Forms.ToolStripButton();
            this.MenuInitConfig = new System.Windows.Forms.ToolStripButton();
            this.MenuConfigTune = new System.Windows.Forms.ToolStripButton();
            this.MenuSimulation = new System.Windows.Forms.ToolStripButton();
            this.MenuConnect = new System.Windows.Forms.ToolStripButton();
            this.MenuHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripConnectionControl = new MissionPlanner.Controls.ToolStripConnectionControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.piclmg_connet = new MissionPlanner.Controls.ImageLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_satellite = new System.Windows.Forms.Panel();
            this.Label_satellite = new System.Windows.Forms.Label();
            this.panel_arm = new System.Windows.Forms.Panel();
            this.ARME_text = new System.Windows.Forms.Label();
            this.imageLabel_xinhao = new MissionPlanner.Controls.ImageLabel();
            this.label_Warning = new System.Windows.Forms.Label();
            this.image_help = new MissionPlanner.Controls.ImageLabel();
            this.image_setup = new MissionPlanner.Controls.ImageLabel();
            this.image_plan = new MissionPlanner.Controls.ImageLabel();
            this.image_flying = new MissionPlanner.Controls.ImageLabel();
            this.status1 = new MissionPlanner.Controls.Status();
            this.panel_NewConnet = new System.Windows.Forms.Panel();
            this.myButton_connet = new MissionPlanner.Controls.MyButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lable111 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_waringlog = new System.Windows.Forms.Panel();
            this.textBox_wranlog = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picture_top = new System.Windows.Forms.PictureBox();
            this.menu = new MissionPlanner.Controls.MyButton();
            this.MainMenu.SuspendLayout();
            this.CTX_mainmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_satellite.SuspendLayout();
            this.panel_arm.SuspendLayout();
            this.panel_NewConnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel_waringlog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_top)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.ContextMenuStrip = this.CTX_mainmenu;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(45, 39);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFlightData,
            this.MenuFlightPlanner,
            this.MenuInitConfig,
            this.MenuConfigTune,
            this.MenuSimulation,
            this.MenuConnect,
            this.MenuHelp,
            this.toolStripConnectionControl});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.ShowItemToolTips = true;
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            this.MainMenu.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // CTX_mainmenu
            // 
            this.CTX_mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoHideToolStripMenuItem,
            this.fullScreenToolStripMenuItem,
            this.readonlyToolStripMenuItem,
            this.connectionOptionsToolStripMenuItem,
            this.connectionListToolStripMenuItem});
            this.CTX_mainmenu.Name = "CTX_mainmenu";
            resources.ApplyResources(this.CTX_mainmenu, "CTX_mainmenu");
            // 
            // autoHideToolStripMenuItem
            // 
            this.autoHideToolStripMenuItem.CheckOnClick = true;
            this.autoHideToolStripMenuItem.Name = "autoHideToolStripMenuItem";
            resources.ApplyResources(this.autoHideToolStripMenuItem, "autoHideToolStripMenuItem");
            this.autoHideToolStripMenuItem.Click += new System.EventHandler(this.autoHideToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.CheckOnClick = true;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            resources.ApplyResources(this.fullScreenToolStripMenuItem, "fullScreenToolStripMenuItem");
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // readonlyToolStripMenuItem
            // 
            this.readonlyToolStripMenuItem.CheckOnClick = true;
            this.readonlyToolStripMenuItem.Name = "readonlyToolStripMenuItem";
            resources.ApplyResources(this.readonlyToolStripMenuItem, "readonlyToolStripMenuItem");
            this.readonlyToolStripMenuItem.Click += new System.EventHandler(this.readonlyToolStripMenuItem_Click);
            // 
            // connectionOptionsToolStripMenuItem
            // 
            this.connectionOptionsToolStripMenuItem.Name = "connectionOptionsToolStripMenuItem";
            resources.ApplyResources(this.connectionOptionsToolStripMenuItem, "connectionOptionsToolStripMenuItem");
            this.connectionOptionsToolStripMenuItem.Click += new System.EventHandler(this.connectionOptionsToolStripMenuItem_Click);
            // 
            // connectionListToolStripMenuItem
            // 
            this.connectionListToolStripMenuItem.Name = "connectionListToolStripMenuItem";
            resources.ApplyResources(this.connectionListToolStripMenuItem, "connectionListToolStripMenuItem");
            this.connectionListToolStripMenuItem.Click += new System.EventHandler(this.connectionListToolStripMenuItem_Click);
            // 
            // MenuFlightData
            // 
            this.MenuFlightData.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuFlightData, "MenuFlightData");
            this.MenuFlightData.Margin = new System.Windows.Forms.Padding(0);
            this.MenuFlightData.Name = "MenuFlightData";
            this.MenuFlightData.Click += new System.EventHandler(this.MenuFlightData_Click);
            // 
            // MenuFlightPlanner
            // 
            this.MenuFlightPlanner.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuFlightPlanner, "MenuFlightPlanner");
            this.MenuFlightPlanner.Margin = new System.Windows.Forms.Padding(0);
            this.MenuFlightPlanner.Name = "MenuFlightPlanner";
            this.MenuFlightPlanner.Click += new System.EventHandler(this.MenuFlightPlanner_Click);
            // 
            // MenuInitConfig
            // 
            this.MenuInitConfig.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuInitConfig, "MenuInitConfig");
            this.MenuInitConfig.Margin = new System.Windows.Forms.Padding(0);
            this.MenuInitConfig.Name = "MenuInitConfig";
            this.MenuInitConfig.Click += new System.EventHandler(this.MenuSetup_Click);
            // 
            // MenuConfigTune
            // 
            this.MenuConfigTune.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuConfigTune, "MenuConfigTune");
            this.MenuConfigTune.Margin = new System.Windows.Forms.Padding(0);
            this.MenuConfigTune.Name = "MenuConfigTune";
            this.MenuConfigTune.Click += new System.EventHandler(this.MenuTuning_Click);
            // 
            // MenuSimulation
            // 
            this.MenuSimulation.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuSimulation, "MenuSimulation");
            this.MenuSimulation.Margin = new System.Windows.Forms.Padding(0);
            this.MenuSimulation.Name = "MenuSimulation";
            this.MenuSimulation.Click += new System.EventHandler(this.MenuSimulation_Click);
            // 
            // MenuConnect
            // 
            this.MenuConnect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuConnect.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.MenuConnect, "MenuConnect");
            this.MenuConnect.Margin = new System.Windows.Forms.Padding(0);
            this.MenuConnect.Name = "MenuConnect";
            this.MenuConnect.Click += new System.EventHandler(this.MenuConnect_Click);
            // 
            // MenuHelp
            // 
            resources.ApplyResources(this.MenuHelp, "MenuHelp");
            this.MenuHelp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuHelp.Margin = new System.Windows.Forms.Padding(0);
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Click += new System.EventHandler(this.MenuHelp_Click);
            // 
            // toolStripConnectionControl
            // 
            this.toolStripConnectionControl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripConnectionControl, "toolStripConnectionControl");
            this.toolStripConnectionControl.ForeColor = System.Drawing.Color.Black;
            this.toolStripConnectionControl.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripConnectionControl.Name = "toolStripConnectionControl";
            this.toolStripConnectionControl.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.piclmg_connet);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel_satellite);
            this.panel1.Controls.Add(this.panel_arm);
            this.panel1.Controls.Add(this.imageLabel_xinhao);
            this.panel1.Controls.Add(this.label_Warning);
            this.panel1.Controls.Add(this.image_help);
            this.panel1.Controls.Add(this.image_setup);
            this.panel1.Controls.Add(this.image_plan);
            this.panel1.Controls.Add(this.image_flying);
            this.panel1.Controls.Add(this.status1);
            this.panel1.Controls.Add(this.MainMenu);
            this.panel1.Name = "panel1";
            this.panel1.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // piclmg_connet
            // 
            this.piclmg_connet.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.piclmg_connet, "piclmg_connet");
            this.piclmg_connet.ForeColor = System.Drawing.Color.White;
            this.piclmg_connet.Image = global::MissionPlanner.Properties.Resources.dark_disconnect_icon;
            this.piclmg_connet.Name = "piclmg_connet";
            this.piclmg_connet.Click += new System.EventHandler(this.piclmg_connet_Click);
            this.piclmg_connet.MouseEnter += new System.EventHandler(this.piclmg_connet_MouseEnter);
            this.piclmg_connet.MouseLeave += new System.EventHandler(this.piclmg_connet_MouseLeave);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel_satellite
            // 
            this.panel_satellite.BackgroundImage = global::MissionPlanner.Properties.Resources.Statlite;
            resources.ApplyResources(this.panel_satellite, "panel_satellite");
            this.panel_satellite.Controls.Add(this.Label_satellite);
            this.panel_satellite.Name = "panel_satellite";
            // 
            // Label_satellite
            // 
            this.Label_satellite.BackColor = System.Drawing.Color.Transparent;
            this.Label_satellite.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Label_satellite, "Label_satellite");
            this.Label_satellite.ForeColor = System.Drawing.Color.White;
            this.Label_satellite.Name = "Label_satellite";
            // 
            // panel_arm
            // 
            this.panel_arm.BackgroundImage = global::MissionPlanner.Properties.Resources.backlmag;
            resources.ApplyResources(this.panel_arm, "panel_arm");
            this.panel_arm.Controls.Add(this.ARME_text);
            this.panel_arm.Name = "panel_arm";
            // 
            // ARME_text
            // 
            this.ARME_text.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ARME_text, "ARME_text");
            this.ARME_text.ForeColor = System.Drawing.Color.Red;
            this.ARME_text.Name = "ARME_text";
            this.ARME_text.UseCompatibleTextRendering = true;
            // 
            // imageLabel_xinhao
            // 
            resources.ApplyResources(this.imageLabel_xinhao, "imageLabel_xinhao");
            this.imageLabel_xinhao.ForeColor = System.Drawing.Color.White;
            this.imageLabel_xinhao.Image = global::MissionPlanner.Properties.Resources.信号;
            this.imageLabel_xinhao.Name = "imageLabel_xinhao";
            // 
            // label_Warning
            // 
            resources.ApplyResources(this.label_Warning, "label_Warning");
            this.label_Warning.ForeColor = System.Drawing.Color.White;
            this.label_Warning.Name = "label_Warning";
            // 
            // image_help
            // 
            this.image_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(130)))), ((int)(((byte)(59)))));
            resources.ApplyResources(this.image_help, "image_help");
            this.image_help.ForeColor = System.Drawing.Color.White;
            this.image_help.Image = global::MissionPlanner.Properties.Resources.Help;
            this.image_help.Name = "image_help";
            // 
            // image_setup
            // 
            this.image_setup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(130)))), ((int)(((byte)(59)))));
            resources.ApplyResources(this.image_setup, "image_setup");
            this.image_setup.ForeColor = System.Drawing.Color.White;
            this.image_setup.Image = global::MissionPlanner.Properties.Resources.Setup;
            this.image_setup.Name = "image_setup";
            // 
            // image_plan
            // 
            this.image_plan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(130)))), ((int)(((byte)(59)))));
            resources.ApplyResources(this.image_plan, "image_plan");
            this.image_plan.ForeColor = System.Drawing.Color.White;
            this.image_plan.Image = global::MissionPlanner.Properties.Resources.Planning;
            this.image_plan.Name = "image_plan";
            // 
            // image_flying
            // 
            this.image_flying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(130)))), ((int)(((byte)(59)))));
            resources.ApplyResources(this.image_flying, "image_flying");
            this.image_flying.ForeColor = System.Drawing.Color.White;
            this.image_flying.Image = global::MissionPlanner.Properties.Resources.Flying;
            this.image_flying.Name = "image_flying";
            // 
            // status1
            // 
            resources.ApplyResources(this.status1, "status1");
            this.status1.Name = "status1";
            this.status1.Percent = 0D;
            // 
            // panel_NewConnet
            // 
            this.panel_NewConnet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_NewConnet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_NewConnet.Controls.Add(this.myButton_connet);
            this.panel_NewConnet.Controls.Add(this.label2);
            this.panel_NewConnet.Controls.Add(this.label1);
            this.panel_NewConnet.Controls.Add(this.lable111);
            this.panel_NewConnet.Controls.Add(this.pictureBox7);
            this.panel_NewConnet.Controls.Add(this.comboBox1);
            this.panel_NewConnet.Controls.Add(this.comboBox2);
            resources.ApplyResources(this.panel_NewConnet, "panel_NewConnet");
            this.panel_NewConnet.Name = "panel_NewConnet";
            // 
            // myButton_connet
            // 
            resources.ApplyResources(this.myButton_connet, "myButton_connet");
            this.myButton_connet.Name = "myButton_connet";
            this.myButton_connet.UseVisualStyleBackColor = true;
            this.myButton_connet.Click += new System.EventHandler(this.myButton_connet_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // lable111
            // 
            resources.ApplyResources(this.lable111, "lable111");
            this.lable111.BackColor = System.Drawing.Color.Transparent;
            this.lable111.ForeColor = System.Drawing.Color.White;
            this.lable111.Name = "lable111";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::MissionPlanner.Properties.Resources.close_474;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2"),
            resources.GetString("comboBox2.Items3"),
            resources.GetString("comboBox2.Items4"),
            resources.GetString("comboBox2.Items5"),
            resources.GetString("comboBox2.Items6"),
            resources.GetString("comboBox2.Items7"),
            resources.GetString("comboBox2.Items8"),
            resources.GetString("comboBox2.Items9"),
            resources.GetString("comboBox2.Items10"),
            resources.GetString("comboBox2.Items11")});
            this.comboBox2.Name = "comboBox2";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_waringlog
            // 
            this.panel_waringlog.Controls.Add(this.textBox_wranlog);
            this.panel_waringlog.Controls.Add(this.pictureBox3);
            this.panel_waringlog.Controls.Add(this.picture_top);
            resources.ApplyResources(this.panel_waringlog, "panel_waringlog");
            this.panel_waringlog.Name = "panel_waringlog";
            // 
            // textBox_wranlog
            // 
            this.textBox_wranlog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.textBox_wranlog, "textBox_wranlog");
            this.textBox_wranlog.Name = "textBox_wranlog";
            this.textBox_wranlog.ReadOnly = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MissionPlanner.Properties.Resources.close_474;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picture_top
            // 
            this.picture_top.BackgroundImage = global::MissionPlanner.Properties.Resources.menubakwitre;
            resources.ApplyResources(this.picture_top, "picture_top");
            this.picture_top.Name = "picture_top";
            this.picture_top.TabStop = false;
            this.picture_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_top_MouseDown);
            this.picture_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_top_MouseMove);
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            // 
            // MainV2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel_waringlog);
            this.Controls.Add(this.panel_NewConnet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Red;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainV2";
            this.ShowIcon = false;
            this.SizeChanged += new System.EventHandler(this.MainV2_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainV2_KeyDown);
            this.Resize += new System.EventHandler(this.MainV2_Resize);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.CTX_mainmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_satellite.ResumeLayout(false);
            this.panel_arm.ResumeLayout(false);
            this.panel_NewConnet.ResumeLayout(false);
            this.panel_NewConnet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel_waringlog.ResumeLayout(false);
            this.panel_waringlog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_top)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ToolStripButton MenuFlightData;
        public System.Windows.Forms.ToolStripButton MenuFlightPlanner;
        public System.Windows.Forms.ToolStripButton MenuInitConfig;
        public System.Windows.Forms.ToolStripButton MenuSimulation;
        public System.Windows.Forms.ToolStripButton MenuConfigTune;
        public System.Windows.Forms.ToolStripButton MenuConnect;
        private Controls.ToolStripConnectionControl toolStripConnectionControl;
        private Controls.MyButton menu;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip CTX_mainmenu;
        private System.Windows.Forms.ToolStripMenuItem autoHideToolStripMenuItem;
        public System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readonlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionListToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton MenuHelp;
        public Controls.Status status1;
        private Controls.ImageLabel image_flying;
        private Controls.ImageLabel image_help;
        private Controls.ImageLabel image_setup;
        private Controls.ImageLabel image_plan;
        private System.Windows.Forms.Panel panel_NewConnet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable111;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Controls.MyButton myButton_connet;
        private Controls.ImageLabel piclmg_connet;
        private System.Windows.Forms.Label label_Warning;
        private System.Windows.Forms.Label ARME_text;
        private Controls.ImageLabel imageLabel_xinhao;
        private System.Windows.Forms.Panel panel_arm;
        private System.Windows.Forms.Panel panel_satellite;
        private System.Windows.Forms.Label Label_satellite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_waringlog;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picture_top;
        private System.Windows.Forms.TextBox textBox_wranlog;
    }
}