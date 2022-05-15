namespace MissionPlanner.GCSViews
{
    partial class FlightData
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightData));
            this.MainH = new System.Windows.Forms.SplitContainer();
            this.SubMainLeft = new System.Windows.Forms.SplitContainer();
            this.hud1 = new MissionPlanner.Controls.HUD();
            this.contextMenuStripHud = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordHudToAVIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setMJPEGSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGStreamerSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hereLinkVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gStreamerStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAspectRatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianHudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swapWithMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceHud = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Messages = new System.Windows.Forms.Label();
            this.label_Logs = new System.Windows.Forms.Label();
            this.label_Actions = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.tableMap = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyToHereAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyToCoordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poiatcoordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointCameraHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PointCameraCoordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightPlannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEKFHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.takeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onOffCameraOverlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altitudeAngelSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.follwMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_hide = new System.Windows.Forms.Panel();
            this.progressBar1 = new BSE.Windows.Forms.ProgressBar();
            this.tabControlactions = new System.Windows.Forms.TabControl();
            this.contextMenuStripactionstab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabQuick = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelQuick = new System.Windows.Forms.TableLayoutPanel();
            this.quickView6 = new MissionPlanner.Controls.QuickView();
            this.contextMenuStripQuickView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setViewCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceQuickTab = new System.Windows.Forms.BindingSource(this.components);
            this.quickView5 = new MissionPlanner.Controls.QuickView();
            this.quickView4 = new MissionPlanner.Controls.QuickView();
            this.quickView3 = new MissionPlanner.Controls.QuickView();
            this.quickView2 = new MissionPlanner.Controls.QuickView();
            this.quickView1 = new MissionPlanner.Controls.QuickView();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.BUT_abortland = new MissionPlanner.Controls.MyButton();
            this.BUT_resumemis = new MissionPlanner.Controls.MyButton();
            this.CMB_mountmode = new System.Windows.Forms.ComboBox();
            this.BUT_mountmode = new MissionPlanner.Controls.MyButton();
            this.BUT_joystick = new MissionPlanner.Controls.MyButton();
            this.CMB_modes = new System.Windows.Forms.ComboBox();
            this.BUT_setmode = new MissionPlanner.Controls.MyButton();
            this.BUT_clear_track = new MissionPlanner.Controls.MyButton();
            this.CMB_action = new System.Windows.Forms.ComboBox();
            this.BUT_Homealt = new MissionPlanner.Controls.MyButton();
            this.BUT_RAWSensor = new MissionPlanner.Controls.MyButton();
            this.BUTrestartmission = new MissionPlanner.Controls.MyButton();
            this.BUTactiondo = new MissionPlanner.Controls.MyButton();
            this.tabActionsSimple = new System.Windows.Forms.TabPage();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.tabPagePreFlight = new System.Windows.Forms.TabPage();
            this.tabGauges = new System.Windows.Forms.TabPage();
            this.Gvspeed = new AGaugeApp.AGauge();
            this.bindingSourceGaugesTab = new System.Windows.Forms.BindingSource(this.components);
            this.Gheading = new MissionPlanner.Controls.HSI();
            this.Galt = new AGaugeApp.AGauge();
            this.Gspeed = new AGaugeApp.AGauge();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.tabServo = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelServos = new System.Windows.Forms.FlowLayoutPanel();
            this.tabTLogs = new System.Windows.Forms.TabPage();
            this.tablogbrowse = new System.Windows.Forms.TabPage();
            this.BUT_georefimage = new MissionPlanner.Controls.MyButton();
            this.BUT_loganalysis = new MissionPlanner.Controls.MyButton();
            this.but_dflogtokml = new MissionPlanner.Controls.MyButton();
            this.BUT_matlab = new MissionPlanner.Controls.MyButton();
            this.tabScripts = new System.Windows.Forms.TabPage();
            this.checkBoxRedirectOutput = new System.Windows.Forms.CheckBox();
            this.BUT_edit_selected = new MissionPlanner.Controls.MyButton();
            this.labelSelectedScript = new System.Windows.Forms.Label();
            this.BUT_run_script = new MissionPlanner.Controls.MyButton();
            this.BUT_abort_script = new MissionPlanner.Controls.MyButton();
            this.labelScriptStatus = new System.Windows.Forms.Label();
            this.BUT_select_script = new MissionPlanner.Controls.MyButton();
            this.tabPagemessages = new System.Windows.Forms.TabPage();
            this.tabPayload = new System.Windows.Forms.TabPage();
            this.BUT_PayloadFolder = new MissionPlanner.Controls.MyButton();
            this.groupBoxRoll = new System.Windows.Forms.GroupBox();
            this.TXT_gimbalRollPos = new System.Windows.Forms.TextBox();
            this.bindingSourcePayloadTab = new System.Windows.Forms.BindingSource(this.components);
            this.trackBarRoll = new System.Windows.Forms.TrackBar();
            this.groupBoxYaw = new System.Windows.Forms.GroupBox();
            this.TXT_gimbalYawPos = new System.Windows.Forms.TextBox();
            this.trackBarYaw = new System.Windows.Forms.TrackBar();
            this.BUT_resetGimbalPos = new MissionPlanner.Controls.MyButton();
            this.groupBoxPitch = new System.Windows.Forms.GroupBox();
            this.trackBarPitch = new System.Windows.Forms.TrackBar();
            this.TXT_gimbalPitchPos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_sats = new MissionPlanner.Controls.MyLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_hdop = new MissionPlanner.Controls.MyLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picture_flytrac = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_DistToHome1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_wpnonew = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_waypoint = new System.Windows.Forms.Label();
            this.label_Traveled = new System.Windows.Forms.Label();
            this.label_flytime = new System.Windows.Forms.Label();
            this.pictureBox_minus = new System.Windows.Forms.PictureBox();
            this.pictureBox_add = new System.Windows.Forms.PictureBox();
            this.but_disablejoystick = new MissionPlanner.Controls.MyButton();
            this.windDir1 = new MissionPlanner.Controls.WindDir();
            this.gMapControl1 = new MissionPlanner.Controls.myGMAP();
            this.TRK_zoom = new MissionPlanner.Controls.MyTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.Zoomlevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new MissionPlanner.Controls.MyLabel();
            this.CHK_autopan = new System.Windows.Forms.CheckBox();
            this.CB_tuning = new System.Windows.Forms.CheckBox();
            this.label_VerticalSpeed = new System.Windows.Forms.Label();
            this.label_Altitude = new System.Windows.Forms.Label();
            this.label_Throttle = new System.Windows.Forms.Label();
            this.label_Battery = new System.Windows.Forms.Label();
            this.ZedGraphTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openScriptDialog = new System.Windows.Forms.OpenFileDialog();
            this.scriptChecker = new System.Windows.Forms.Timer(this.components);
            this.Messagetabtimer = new System.Windows.Forms.Timer(this.components);
            this.bindingSourceStatusTab = new System.Windows.Forms.BindingSource(this.components);
            this.timer_check = new System.Windows.Forms.Timer(this.components);
            this.tabControl_Newactions = new MissionPlanner.My_tablepage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.myArcHalfProgressBar_battery = new MyArcBar.MyArcHalfProgressBar();
            this.myArcHalfProgressBar_VerticalSpeed = new MyArcBar.MyArcHalfProgressBar();
            this.myArcHalfProgressBar_Throttle = new MyArcBar.MyArcHalfProgressBar();
            this.myArcHalfProgressBar_Altitude = new MyArcBar.MyArcHalfProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_actions = new System.Windows.Forms.Panel();
            this.myButton4 = new MissionPlanner.Controls.MyButton();
            this.modifyandSetLoiterRad = new MissionPlanner.Controls.ModifyandSet();
            this.modifyandSetSpeed = new MissionPlanner.Controls.ModifyandSet();
            this.BUT_ARM = new MissionPlanner.Controls.MyButton();
            this.modifyandSetAlt = new MissionPlanner.Controls.ModifyandSet();
            this.CMB_setwp = new System.Windows.Forms.ComboBox();
            this.BUT_quickrtl = new MissionPlanner.Controls.MyButton();
            this.BUT_setwp = new MissionPlanner.Controls.MyButton();
            this.BUT_quickauto = new MissionPlanner.Controls.MyButton();
            this.BUT_quickmanual = new MissionPlanner.Controls.MyButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel_logs = new System.Windows.Forms.Panel();
            this.tableLayoutPaneltlogs = new System.Windows.Forms.TableLayoutPanel();
            this.panel_speed = new System.Windows.Forms.Panel();
            this.tracklog = new System.Windows.Forms.TrackBar();
            this.lbl_logpercent = new MissionPlanner.Controls.MyLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BUT_speed10 = new MissionPlanner.Controls.MyButton();
            this.lbl_playbackspeed = new MissionPlanner.Controls.MyLabel();
            this.BUT_speed5 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_4 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_10 = new MissionPlanner.Controls.MyButton();
            this.BUT_loadtelem = new MissionPlanner.Controls.MyButton();
            this.BUT_playlog = new MissionPlanner.Controls.MyButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.but_bintolog = new MissionPlanner.Controls.MyButton();
            this.BUT_DFMavlink = new MissionPlanner.Controls.MyButton();
            this.BUT_log2kml = new MissionPlanner.Controls.MyButton();
            this.BUT_logbrowse = new MissionPlanner.Controls.MyButton();
            this.LBL_logfn = new MissionPlanner.Controls.MyLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_messagebox = new System.Windows.Forms.TextBox();
            this.userHSI1 = new MissionPlanner.Controls.UserHSI();
            this.checkListControl1 = new MissionPlanner.Controls.PreFlight.CheckListControl();
            this.servoOptions1 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions2 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions3 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions4 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions5 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions6 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions7 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions8 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions9 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions10 = new MissionPlanner.Controls.ServoOptions();
            this.relayOptions1 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions2 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions3 = new MissionPlanner.Controls.RelayOptions();
            this.relayOptions4 = new MissionPlanner.Controls.RelayOptions();
            this.distanceBar1 = new MissionPlanner.Controls.DistanceBar();
            this.distanceBar2 = new MissionPlanner.Controls.DistanceBar();
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).BeginInit();
            this.MainH.Panel1.SuspendLayout();
            this.MainH.Panel2.SuspendLayout();
            this.MainH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).BeginInit();
            this.SubMainLeft.Panel1.SuspendLayout();
            this.SubMainLeft.Panel2.SuspendLayout();
            this.SubMainLeft.SuspendLayout();
            this.contextMenuStripHud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripMap.SuspendLayout();
            this.panel_hide.SuspendLayout();
            this.tabControlactions.SuspendLayout();
            this.contextMenuStripactionstab.SuspendLayout();
            this.tabQuick.SuspendLayout();
            this.tableLayoutPanelQuick.SuspendLayout();
            this.contextMenuStripQuickView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).BeginInit();
            this.tabActions.SuspendLayout();
            this.tabActionsSimple.SuspendLayout();
            this.tabPagePreFlight.SuspendLayout();
            this.tabGauges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).BeginInit();
            this.tabServo.SuspendLayout();
            this.flowLayoutPanelServos.SuspendLayout();
            this.tablogbrowse.SuspendLayout();
            this.tabScripts.SuspendLayout();
            this.tabPayload.SuspendLayout();
            this.groupBoxRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePayloadTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).BeginInit();
            this.groupBoxYaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYaw)).BeginInit();
            this.groupBoxPitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_flytrac)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).BeginInit();
            this.tabControl_Newactions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_actions.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel_logs.SuspendLayout();
            this.tableLayoutPaneltlogs.SuspendLayout();
            this.panel_speed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainH
            // 
            this.MainH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.MainH, "MainH");
            this.MainH.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainH.Name = "MainH";
            // 
            // MainH.Panel1
            // 
            this.MainH.Panel1.Controls.Add(this.SubMainLeft);
            // 
            // MainH.Panel2
            // 
            this.MainH.Panel2.Controls.Add(this.tableMap);
            // 
            // SubMainLeft
            // 
            this.SubMainLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.SubMainLeft, "SubMainLeft");
            this.SubMainLeft.Name = "SubMainLeft";
            // 
            // SubMainLeft.Panel1
            // 
            this.SubMainLeft.Panel1.Controls.Add(this.hud1);
            // 
            // SubMainLeft.Panel2
            // 
            this.SubMainLeft.Panel2.Controls.Add(this.tabControl_Newactions);
            this.SubMainLeft.Panel2.Controls.Add(this.panel3);
            // 
            // hud1
            // 
            this.hud1.airspeed = 0F;
            this.hud1.alt = 0F;
            this.hud1.altunit = null;
            this.hud1.AOA = 0F;
            this.hud1.BackColor = System.Drawing.Color.Black;
            this.hud1.batterylevel = 0F;
            this.hud1.batteryon = false;
            this.hud1.batteryremaining = 0F;
            this.hud1.bgimage = null;
            this.hud1.connected = false;
            this.hud1.ContextMenuStrip = this.contextMenuStripHud;
            this.hud1.critAOA = 25F;
            this.hud1.criticalvoltagealert = false;
            this.hud1.critSSA = 30F;
            this.hud1.current = 0F;
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("airspeed", this.bindingSourceHud, "airspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("alt", this.bindingSourceHud, "alt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batterylevel", this.bindingSourceHud, "battery_voltage", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batteryremaining", this.bindingSourceHud, "battery_remaining", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("connected", this.bindingSourceHud, "connected", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("current", this.bindingSourceHud, "current", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("datetime", this.bindingSourceHud, "datetime", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("disttowp", this.bindingSourceHud, "wp_dist", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("ekfstatus", this.bindingSourceHud, "ekfstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("failsafe", this.bindingSourceHud, "failsafe", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix", this.bindingSourceHud, "gpsstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix2", this.bindingSourceHud, "gpsstatus2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop", this.bindingSourceHud, "gpshdop", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop2", this.bindingSourceHud, "gpshdop2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundalt", this.bindingSourceHud, "HomeAlt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundcourse", this.bindingSourceHud, "groundcourse", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundspeed", this.bindingSourceHud, "groundspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("heading", this.bindingSourceHud, "yaw", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("linkqualitygcs", this.bindingSourceHud, "linkqualitygcs", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("message", this.bindingSourceHud, "messageHigh", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("mode", this.bindingSourceHud, "mode", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navpitch", this.bindingSourceHud, "nav_pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navroll", this.bindingSourceHud, "nav_roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("pitch", this.bindingSourceHud, "pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("roll", this.bindingSourceHud, "roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("status", this.bindingSourceHud, "armed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetalt", this.bindingSourceHud, "targetalt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetheading", this.bindingSourceHud, "nav_bearing", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetspeed", this.bindingSourceHud, "targetairspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("turnrate", this.bindingSourceHud, "turnrate", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("verticalspeed", this.bindingSourceHud, "verticalspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibex", this.bindingSourceHud, "vibex", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibey", this.bindingSourceHud, "vibey", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibez", this.bindingSourceHud, "vibez", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("wpno", this.bindingSourceHud, "wpno", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("xtrack_error", this.bindingSourceHud, "xtrack_error", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("AOA", this.bindingSourceHud, "AOA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("SSA", this.bindingSourceHud, "SSA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("critAOA", this.bindingSourceHud, "crit_AOA", true));
            this.hud1.datetime = new System.DateTime(((long)(0)));
            this.hud1.displayalt = false;
            this.hud1.displayAOASSA = false;
            this.hud1.displayconninfo = false;
            this.hud1.displayekf = false;
            this.hud1.displaygps = false;
            this.hud1.displayheading = false;
            this.hud1.displayspeed = false;
            this.hud1.displayvibe = false;
            this.hud1.displayxtrack = false;
            this.hud1.disttowp = 0F;
            this.hud1.distunit = null;
            resources.ApplyResources(this.hud1, "hud1");
            this.hud1.ekfstatus = 0F;
            this.hud1.failsafe = false;
            this.hud1.gpsfix = 0F;
            this.hud1.gpsfix2 = 0F;
            this.hud1.gpshdop = 0F;
            this.hud1.gpshdop2 = 0F;
            this.hud1.groundalt = 0F;
            this.hud1.groundColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(165)))), ((int)(((byte)(67)))));
            this.hud1.groundColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(132)))), ((int)(((byte)(63)))));
            this.hud1.groundcourse = 0F;
            this.hud1.groundspeed = 0F;
            this.hud1.heading = 0F;
            this.hud1.hudcolor = System.Drawing.Color.LightGray;
            this.hud1.linkqualitygcs = 0F;
            this.hud1.lowairspeed = false;
            this.hud1.lowgroundspeed = false;
            this.hud1.lowvoltagealert = false;
            this.hud1.message = "";
            this.hud1.mode = "Unknown";
            this.hud1.Name = "hud1";
            this.hud1.navpitch = 0F;
            this.hud1.navroll = 0F;
            this.hud1.pitch = 0F;
            this.hud1.roll = 0F;
            this.hud1.Russian = false;
            this.hud1.skyColor1 = System.Drawing.Color.Blue;
            this.hud1.skyColor2 = System.Drawing.Color.LightBlue;
            this.hud1.speedunit = null;
            this.hud1.SSA = 0F;
            this.hud1.status = false;
            this.hud1.streamjpg = null;
            this.hud1.targetalt = 0F;
            this.hud1.targetheading = 0F;
            this.hud1.targetspeed = 0F;
            this.hud1.turnrate = 0F;
            this.hud1.verticalspeed = 0F;
            this.hud1.vibex = 0F;
            this.hud1.vibey = 0F;
            this.hud1.vibez = 0F;
            this.hud1.VSync = false;
            this.hud1.wpno = 0;
            this.hud1.xtrack_error = 0F;
            this.hud1.ekfclick += new System.EventHandler(this.hud1_ekfclick);
            this.hud1.vibeclick += new System.EventHandler(this.hud1_vibeclick);
            this.hud1.Load += new System.EventHandler(this.hud1_Load);
            this.hud1.DoubleClick += new System.EventHandler(this.hud1_DoubleClick);
            this.hud1.Resize += new System.EventHandler(this.hud1_Resize);
            // 
            // contextMenuStripHud
            // 
            this.contextMenuStripHud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.setAspectRatioToolStripMenuItem,
            this.userItemsToolStripMenuItem,
            this.russianHudToolStripMenuItem,
            this.swapWithMapToolStripMenuItem,
            this.groundColorToolStripMenuItem});
            this.contextMenuStripHud.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStripHud, "contextMenuStripHud");
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordHudToAVIToolStripMenuItem,
            this.stopRecordToolStripMenuItem,
            this.setMJPEGSourceToolStripMenuItem,
            this.startCameraToolStripMenuItem,
            this.setGStreamerSourceToolStripMenuItem,
            this.hereLinkVideoToolStripMenuItem,
            this.gStreamerStopToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            resources.ApplyResources(this.videoToolStripMenuItem, "videoToolStripMenuItem");
            // 
            // recordHudToAVIToolStripMenuItem
            // 
            this.recordHudToAVIToolStripMenuItem.Name = "recordHudToAVIToolStripMenuItem";
            resources.ApplyResources(this.recordHudToAVIToolStripMenuItem, "recordHudToAVIToolStripMenuItem");
            this.recordHudToAVIToolStripMenuItem.Click += new System.EventHandler(this.recordHudToAVIToolStripMenuItem_Click);
            // 
            // stopRecordToolStripMenuItem
            // 
            this.stopRecordToolStripMenuItem.Name = "stopRecordToolStripMenuItem";
            resources.ApplyResources(this.stopRecordToolStripMenuItem, "stopRecordToolStripMenuItem");
            this.stopRecordToolStripMenuItem.Click += new System.EventHandler(this.stopRecordToolStripMenuItem_Click);
            // 
            // setMJPEGSourceToolStripMenuItem
            // 
            this.setMJPEGSourceToolStripMenuItem.Name = "setMJPEGSourceToolStripMenuItem";
            resources.ApplyResources(this.setMJPEGSourceToolStripMenuItem, "setMJPEGSourceToolStripMenuItem");
            this.setMJPEGSourceToolStripMenuItem.Click += new System.EventHandler(this.setMJPEGSourceToolStripMenuItem_Click);
            // 
            // startCameraToolStripMenuItem
            // 
            this.startCameraToolStripMenuItem.Name = "startCameraToolStripMenuItem";
            resources.ApplyResources(this.startCameraToolStripMenuItem, "startCameraToolStripMenuItem");
            this.startCameraToolStripMenuItem.Click += new System.EventHandler(this.startCameraToolStripMenuItem_Click);
            // 
            // setGStreamerSourceToolStripMenuItem
            // 
            this.setGStreamerSourceToolStripMenuItem.Name = "setGStreamerSourceToolStripMenuItem";
            resources.ApplyResources(this.setGStreamerSourceToolStripMenuItem, "setGStreamerSourceToolStripMenuItem");
            this.setGStreamerSourceToolStripMenuItem.Click += new System.EventHandler(this.setGStreamerSourceToolStripMenuItem_Click);
            // 
            // hereLinkVideoToolStripMenuItem
            // 
            this.hereLinkVideoToolStripMenuItem.Name = "hereLinkVideoToolStripMenuItem";
            resources.ApplyResources(this.hereLinkVideoToolStripMenuItem, "hereLinkVideoToolStripMenuItem");
            this.hereLinkVideoToolStripMenuItem.Click += new System.EventHandler(this.HereLinkVideoToolStripMenuItem_Click);
            // 
            // gStreamerStopToolStripMenuItem
            // 
            this.gStreamerStopToolStripMenuItem.Name = "gStreamerStopToolStripMenuItem";
            resources.ApplyResources(this.gStreamerStopToolStripMenuItem, "gStreamerStopToolStripMenuItem");
            this.gStreamerStopToolStripMenuItem.Click += new System.EventHandler(this.GStreamerStopToolStripMenuItem_Click);
            // 
            // setAspectRatioToolStripMenuItem
            // 
            this.setAspectRatioToolStripMenuItem.Name = "setAspectRatioToolStripMenuItem";
            resources.ApplyResources(this.setAspectRatioToolStripMenuItem, "setAspectRatioToolStripMenuItem");
            this.setAspectRatioToolStripMenuItem.Click += new System.EventHandler(this.setAspectRatioToolStripMenuItem_Click);
            // 
            // userItemsToolStripMenuItem
            // 
            this.userItemsToolStripMenuItem.Name = "userItemsToolStripMenuItem";
            resources.ApplyResources(this.userItemsToolStripMenuItem, "userItemsToolStripMenuItem");
            this.userItemsToolStripMenuItem.Click += new System.EventHandler(this.hud_UserItem);
            // 
            // russianHudToolStripMenuItem
            // 
            this.russianHudToolStripMenuItem.Name = "russianHudToolStripMenuItem";
            resources.ApplyResources(this.russianHudToolStripMenuItem, "russianHudToolStripMenuItem");
            this.russianHudToolStripMenuItem.Click += new System.EventHandler(this.russianHudToolStripMenuItem_Click);
            // 
            // swapWithMapToolStripMenuItem
            // 
            this.swapWithMapToolStripMenuItem.Name = "swapWithMapToolStripMenuItem";
            resources.ApplyResources(this.swapWithMapToolStripMenuItem, "swapWithMapToolStripMenuItem");
            this.swapWithMapToolStripMenuItem.Click += new System.EventHandler(this.swapWithMapToolStripMenuItem_Click);
            // 
            // groundColorToolStripMenuItem
            // 
            this.groundColorToolStripMenuItem.CheckOnClick = true;
            this.groundColorToolStripMenuItem.Name = "groundColorToolStripMenuItem";
            resources.ApplyResources(this.groundColorToolStripMenuItem, "groundColorToolStripMenuItem");
            this.groundColorToolStripMenuItem.Click += new System.EventHandler(this.groundColorToolStripMenuItem_Click);
            // 
            // bindingSourceHud
            // 
            this.bindingSourceHud.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::MissionPlanner.Properties.Resources.menubakwitre;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.label_Messages);
            this.panel3.Controls.Add(this.label_Logs);
            this.panel3.Controls.Add(this.label_Actions);
            this.panel3.Controls.Add(this.label_Status);
            this.panel3.Name = "panel3";
            // 
            // label_Messages
            // 
            this.label_Messages.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.label_Messages, "label_Messages");
            this.label_Messages.ForeColor = System.Drawing.Color.Black;
            this.label_Messages.Name = "label_Messages";
            this.label_Messages.Click += new System.EventHandler(this.label_Messages_Click);
            this.label_Messages.MouseEnter += new System.EventHandler(this.label_Status_MouseEnter);
            this.label_Messages.MouseLeave += new System.EventHandler(this.label_Status_MouseLeave);
            // 
            // label_Logs
            // 
            this.label_Logs.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.label_Logs, "label_Logs");
            this.label_Logs.ForeColor = System.Drawing.Color.Black;
            this.label_Logs.Name = "label_Logs";
            this.label_Logs.Click += new System.EventHandler(this.label_Logs_Click);
            this.label_Logs.MouseEnter += new System.EventHandler(this.label_Status_MouseEnter);
            this.label_Logs.MouseLeave += new System.EventHandler(this.label_Status_MouseLeave);
            // 
            // label_Actions
            // 
            this.label_Actions.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.label_Actions, "label_Actions");
            this.label_Actions.ForeColor = System.Drawing.Color.Black;
            this.label_Actions.Name = "label_Actions";
            this.label_Actions.Click += new System.EventHandler(this.label_Actions_Click);
            this.label_Actions.MouseEnter += new System.EventHandler(this.label_Status_MouseEnter);
            this.label_Actions.MouseLeave += new System.EventHandler(this.label_Status_MouseLeave);
            // 
            // label_Status
            // 
            this.label_Status.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.label_Status, "label_Status");
            this.label_Status.ForeColor = System.Drawing.Color.Black;
            this.label_Status.Name = "label_Status";
            this.label_Status.Click += new System.EventHandler(this.label_Status_Click);
            this.label_Status.MouseEnter += new System.EventHandler(this.label_Status_MouseEnter);
            this.label_Status.MouseLeave += new System.EventHandler(this.label_Status_MouseLeave);
            // 
            // tableMap
            // 
            resources.ApplyResources(this.tableMap, "tableMap");
            this.tableMap.Controls.Add(this.splitContainer1, 0, 0);
            this.tableMap.Controls.Add(this.panel1, 0, 1);
            this.tableMap.Name = "tableMap";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.zg1);
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.ContextMenuStrip = this.contextMenuStripMap;
            this.splitContainer1.Panel2.Controls.Add(this.userHSI1);
            this.splitContainer1.Panel2.Controls.Add(this.panel_hide);
            this.splitContainer1.Panel2.Controls.Add(this.picture_flytrac);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox_minus);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox_add);
            this.splitContainer1.Panel2.Controls.Add(this.distanceBar1);
            this.splitContainer1.Panel2.Controls.Add(this.but_disablejoystick);
            this.splitContainer1.Panel2.Controls.Add(this.windDir1);
            this.splitContainer1.Panel2.Controls.Add(this.gMapControl1);
            this.splitContainer1.Panel2.Controls.Add(this.TRK_zoom);
            // 
            // zg1
            // 
            resources.ApplyResources(this.zg1, "zg1");
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.DoubleClick += new System.EventHandler(this.zg1_DoubleClick);
            // 
            // contextMenuStripMap
            // 
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goHereToolStripMenuItem,
            this.flyToHereAltToolStripMenuItem,
            this.flyToCoordsToolStripMenuItem,
            this.deleteCameraToolStripMenuItem,
            this.addPoiToolStripMenuItem,
            this.pointCameraHereToolStripMenuItem,
            this.PointCameraCoordsToolStripMenuItem1,
            this.triggerCameraToolStripMenuItem,
            this.flightPlannerToolStripMenuItem,
            this.setHomeHereToolStripMenuItem,
            this.takeOffToolStripMenuItem,
            this.onOffCameraOverlapToolStripMenuItem,
            this.altitudeAngelSettingsToolStripMenuItem,
            this.follwMeToolStripMenuItem});
            this.contextMenuStripMap.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStripMap, "contextMenuStripMap");
            // 
            // goHereToolStripMenuItem
            // 
            this.goHereToolStripMenuItem.Name = "goHereToolStripMenuItem";
            resources.ApplyResources(this.goHereToolStripMenuItem, "goHereToolStripMenuItem");
            this.goHereToolStripMenuItem.Click += new System.EventHandler(this.goHereToolStripMenuItem_Click);
            // 
            // flyToHereAltToolStripMenuItem
            // 
            this.flyToHereAltToolStripMenuItem.Name = "flyToHereAltToolStripMenuItem";
            resources.ApplyResources(this.flyToHereAltToolStripMenuItem, "flyToHereAltToolStripMenuItem");
            this.flyToHereAltToolStripMenuItem.Click += new System.EventHandler(this.flyToHereAltToolStripMenuItem_Click);
            // 
            // flyToCoordsToolStripMenuItem
            // 
            this.flyToCoordsToolStripMenuItem.Name = "flyToCoordsToolStripMenuItem";
            resources.ApplyResources(this.flyToCoordsToolStripMenuItem, "flyToCoordsToolStripMenuItem");
            this.flyToCoordsToolStripMenuItem.Click += new System.EventHandler(this.flyToCoordsToolStripMenuItem_Click);
            // 
            // deleteCameraToolStripMenuItem
            // 
            this.deleteCameraToolStripMenuItem.Name = "deleteCameraToolStripMenuItem";
            resources.ApplyResources(this.deleteCameraToolStripMenuItem, "deleteCameraToolStripMenuItem");
            this.deleteCameraToolStripMenuItem.Click += new System.EventHandler(this.deleteCameraToolStripMenuItem_Click);
            // 
            // addPoiToolStripMenuItem
            // 
            this.addPoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.loadFileToolStripMenuItem,
            this.poiatcoordsToolStripMenuItem});
            this.addPoiToolStripMenuItem.Name = "addPoiToolStripMenuItem";
            resources.ApplyResources(this.addPoiToolStripMenuItem, "addPoiToolStripMenuItem");
            this.addPoiToolStripMenuItem.Click += new System.EventHandler(this.addPoiToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            resources.ApplyResources(this.saveFileToolStripMenuItem, "saveFileToolStripMenuItem");
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            resources.ApplyResources(this.loadFileToolStripMenuItem, "loadFileToolStripMenuItem");
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // poiatcoordsToolStripMenuItem
            // 
            this.poiatcoordsToolStripMenuItem.Name = "poiatcoordsToolStripMenuItem";
            resources.ApplyResources(this.poiatcoordsToolStripMenuItem, "poiatcoordsToolStripMenuItem");
            this.poiatcoordsToolStripMenuItem.Click += new System.EventHandler(this.poiatcoordsToolStripMenuItem_Click);
            // 
            // pointCameraHereToolStripMenuItem
            // 
            this.pointCameraHereToolStripMenuItem.Name = "pointCameraHereToolStripMenuItem";
            resources.ApplyResources(this.pointCameraHereToolStripMenuItem, "pointCameraHereToolStripMenuItem");
            this.pointCameraHereToolStripMenuItem.Click += new System.EventHandler(this.pointCameraHereToolStripMenuItem_Click);
            // 
            // PointCameraCoordsToolStripMenuItem1
            // 
            this.PointCameraCoordsToolStripMenuItem1.Name = "PointCameraCoordsToolStripMenuItem1";
            resources.ApplyResources(this.PointCameraCoordsToolStripMenuItem1, "PointCameraCoordsToolStripMenuItem1");
            this.PointCameraCoordsToolStripMenuItem1.Click += new System.EventHandler(this.PointCameraCoordsToolStripMenuItem1_Click);
            // 
            // triggerCameraToolStripMenuItem
            // 
            this.triggerCameraToolStripMenuItem.Name = "triggerCameraToolStripMenuItem";
            resources.ApplyResources(this.triggerCameraToolStripMenuItem, "triggerCameraToolStripMenuItem");
            this.triggerCameraToolStripMenuItem.Click += new System.EventHandler(this.triggerCameraToolStripMenuItem_Click);
            // 
            // flightPlannerToolStripMenuItem
            // 
            this.flightPlannerToolStripMenuItem.Name = "flightPlannerToolStripMenuItem";
            resources.ApplyResources(this.flightPlannerToolStripMenuItem, "flightPlannerToolStripMenuItem");
            this.flightPlannerToolStripMenuItem.Click += new System.EventHandler(this.flightPlannerToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem
            // 
            this.setHomeHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setEKFHomeHereToolStripMenuItem,
            this.setHomeHereToolStripMenuItem1});
            this.setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            resources.ApplyResources(this.setHomeHereToolStripMenuItem, "setHomeHereToolStripMenuItem");
            // 
            // setEKFHomeHereToolStripMenuItem
            // 
            this.setEKFHomeHereToolStripMenuItem.Name = "setEKFHomeHereToolStripMenuItem";
            resources.ApplyResources(this.setEKFHomeHereToolStripMenuItem, "setEKFHomeHereToolStripMenuItem");
            this.setEKFHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setEKFHomeHereToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem1
            // 
            this.setHomeHereToolStripMenuItem1.Name = "setHomeHereToolStripMenuItem1";
            resources.ApplyResources(this.setHomeHereToolStripMenuItem1, "setHomeHereToolStripMenuItem1");
            this.setHomeHereToolStripMenuItem1.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // takeOffToolStripMenuItem
            // 
            this.takeOffToolStripMenuItem.Name = "takeOffToolStripMenuItem";
            resources.ApplyResources(this.takeOffToolStripMenuItem, "takeOffToolStripMenuItem");
            this.takeOffToolStripMenuItem.Click += new System.EventHandler(this.takeOffToolStripMenuItem_Click);
            // 
            // onOffCameraOverlapToolStripMenuItem
            // 
            this.onOffCameraOverlapToolStripMenuItem.CheckOnClick = true;
            this.onOffCameraOverlapToolStripMenuItem.Name = "onOffCameraOverlapToolStripMenuItem";
            resources.ApplyResources(this.onOffCameraOverlapToolStripMenuItem, "onOffCameraOverlapToolStripMenuItem");
            this.onOffCameraOverlapToolStripMenuItem.Click += new System.EventHandler(this.onOffCameraOverlapToolStripMenuItem_Click);
            // 
            // altitudeAngelSettingsToolStripMenuItem
            // 
            this.altitudeAngelSettingsToolStripMenuItem.Name = "altitudeAngelSettingsToolStripMenuItem";
            resources.ApplyResources(this.altitudeAngelSettingsToolStripMenuItem, "altitudeAngelSettingsToolStripMenuItem");
            this.altitudeAngelSettingsToolStripMenuItem.Click += new System.EventHandler(this.altitudeAngelSettingsToolStripMenuItem_Click);
            // 
            // follwMeToolStripMenuItem
            // 
            this.follwMeToolStripMenuItem.Name = "follwMeToolStripMenuItem";
            resources.ApplyResources(this.follwMeToolStripMenuItem, "follwMeToolStripMenuItem");
            this.follwMeToolStripMenuItem.Click += new System.EventHandler(this.follwMeToolStripMenuItem_Click);
            // 
            // panel_hide
            // 
            this.panel_hide.Controls.Add(this.progressBar1);
            this.panel_hide.Controls.Add(this.tabControlactions);
            this.panel_hide.Controls.Add(this.label8);
            this.panel_hide.Controls.Add(this.lbl_sats);
            this.panel_hide.Controls.Add(this.label7);
            this.panel_hide.Controls.Add(this.label4);
            this.panel_hide.Controls.Add(this.label9);
            this.panel_hide.Controls.Add(this.label10);
            this.panel_hide.Controls.Add(this.label3);
            this.panel_hide.Controls.Add(this.lbl_hdop);
            this.panel_hide.Controls.Add(this.label5);
            this.panel_hide.Controls.Add(this.label6);
            resources.ApplyResources(this.panel_hide, "panel_hide");
            this.panel_hide.Name = "panel_hide";
            // 
            // progressBar1
            // 
            this.progressBar1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Value = 0;
            this.progressBar1.ValueColor = System.Drawing.Color.Green;
            // 
            // tabControlactions
            // 
            this.tabControlactions.ContextMenuStrip = this.contextMenuStripactionstab;
            this.tabControlactions.Controls.Add(this.tabQuick);
            this.tabControlactions.Controls.Add(this.tabActions);
            this.tabControlactions.Controls.Add(this.tabActionsSimple);
            this.tabControlactions.Controls.Add(this.tabPagePreFlight);
            this.tabControlactions.Controls.Add(this.tabGauges);
            this.tabControlactions.Controls.Add(this.tabStatus);
            this.tabControlactions.Controls.Add(this.tabServo);
            this.tabControlactions.Controls.Add(this.tabTLogs);
            this.tabControlactions.Controls.Add(this.tablogbrowse);
            this.tabControlactions.Controls.Add(this.tabScripts);
            this.tabControlactions.Controls.Add(this.tabPagemessages);
            this.tabControlactions.Controls.Add(this.tabPayload);
            resources.ApplyResources(this.tabControlactions, "tabControlactions");
            this.tabControlactions.Multiline = true;
            this.tabControlactions.Name = "tabControlactions";
            this.tabControlactions.SelectedIndex = 0;
            this.tabControlactions.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlactions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControlactions.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // contextMenuStripactionstab
            // 
            this.contextMenuStripactionstab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem});
            this.contextMenuStripactionstab.Name = "contextMenuStripactionstab";
            resources.ApplyResources(this.contextMenuStripactionstab, "contextMenuStripactionstab");
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            resources.ApplyResources(this.customizeToolStripMenuItem, "customizeToolStripMenuItem");
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // tabQuick
            // 
            resources.ApplyResources(this.tabQuick, "tabQuick");
            this.tabQuick.Controls.Add(this.tableLayoutPanelQuick);
            this.tabQuick.Name = "tabQuick";
            this.tabQuick.UseVisualStyleBackColor = true;
            this.tabQuick.Resize += new System.EventHandler(this.tabQuick_Resize);
            // 
            // tableLayoutPanelQuick
            // 
            resources.ApplyResources(this.tableLayoutPanelQuick, "tableLayoutPanelQuick");
            this.tableLayoutPanelQuick.Controls.Add(this.quickView6, 1, 2);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView5, 0, 2);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView4, 1, 1);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView3, 0, 1);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView2, 1, 0);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView1, 0, 0);
            this.tableLayoutPanelQuick.Name = "tableLayoutPanelQuick";
            // 
            // quickView6
            // 
            this.quickView6.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView6.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "DistToHome", true));
            this.quickView6.desc = "DistToMAV";
            resources.ApplyResources(this.quickView6, "quickView6");
            this.quickView6.Name = "quickView6";
            this.quickView6.number = 0D;
            this.quickView6.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.quickView6.numberformat = "0.00";
            this.quickView6.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // contextMenuStripQuickView
            // 
            this.contextMenuStripQuickView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setViewCountToolStripMenuItem});
            this.contextMenuStripQuickView.Name = "contextMenuStripQuickView";
            resources.ApplyResources(this.contextMenuStripQuickView, "contextMenuStripQuickView");
            // 
            // setViewCountToolStripMenuItem
            // 
            this.setViewCountToolStripMenuItem.Name = "setViewCountToolStripMenuItem";
            resources.ApplyResources(this.setViewCountToolStripMenuItem, "setViewCountToolStripMenuItem");
            this.setViewCountToolStripMenuItem.Click += new System.EventHandler(this.setViewCountToolStripMenuItem_Click);
            // 
            // bindingSourceQuickTab
            // 
            this.bindingSourceQuickTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // quickView5
            // 
            this.quickView5.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView5.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "verticalspeed", true));
            this.quickView5.desc = "verticalspeed";
            resources.ApplyResources(this.quickView5, "quickView5");
            this.quickView5.Name = "quickView5";
            this.quickView5.number = 0D;
            this.quickView5.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(86)))));
            this.quickView5.numberformat = "0.00";
            this.quickView5.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView4
            // 
            this.quickView4.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView4.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "yaw", true));
            this.quickView4.desc = "yaw";
            resources.ApplyResources(this.quickView4, "quickView4");
            this.quickView4.Name = "quickView4";
            this.quickView4.number = 0D;
            this.quickView4.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(83)))));
            this.quickView4.numberformat = "0.00";
            this.quickView4.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView3
            // 
            this.quickView3.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView3.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "wp_dist", true));
            this.quickView3.desc = "wp_dist";
            resources.ApplyResources(this.quickView3, "quickView3");
            this.quickView3.Name = "quickView3";
            this.quickView3.number = 0D;
            this.quickView3.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(91)))));
            this.quickView3.numberformat = "0.00";
            this.quickView3.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView2
            // 
            this.quickView2.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView2.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "groundspeed", true));
            this.quickView2.desc = "groundspeed";
            resources.ApplyResources(this.quickView2, "quickView2");
            this.quickView2.Name = "quickView2";
            this.quickView2.number = 0D;
            this.quickView2.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(132)))), ((int)(((byte)(46)))));
            this.quickView2.numberformat = "0.00";
            this.quickView2.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView1
            // 
            this.quickView1.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView1.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "alt", true));
            this.quickView1.desc = "alt";
            resources.ApplyResources(this.quickView1, "quickView1");
            this.quickView1.Name = "quickView1";
            this.quickView1.number = 0D;
            this.quickView1.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(151)))), ((int)(((byte)(248)))));
            this.quickView1.numberformat = "0.00";
            this.toolTip1.SetToolTip(this.quickView1, resources.GetString("quickView1.ToolTip"));
            this.quickView1.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // tabActions
            // 
            this.tabActions.Controls.Add(this.BUT_abortland);
            this.tabActions.Controls.Add(this.BUT_resumemis);
            this.tabActions.Controls.Add(this.CMB_mountmode);
            this.tabActions.Controls.Add(this.BUT_mountmode);
            this.tabActions.Controls.Add(this.BUT_joystick);
            this.tabActions.Controls.Add(this.CMB_modes);
            this.tabActions.Controls.Add(this.BUT_setmode);
            this.tabActions.Controls.Add(this.BUT_clear_track);
            this.tabActions.Controls.Add(this.CMB_action);
            this.tabActions.Controls.Add(this.BUT_Homealt);
            this.tabActions.Controls.Add(this.BUT_RAWSensor);
            this.tabActions.Controls.Add(this.BUTrestartmission);
            this.tabActions.Controls.Add(this.BUTactiondo);
            resources.ApplyResources(this.tabActions, "tabActions");
            this.tabActions.Name = "tabActions";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // BUT_abortland
            // 
            this.BUT_abortland.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_abortland.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_abortland.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_abortland, "BUT_abortland");
            this.BUT_abortland.Name = "BUT_abortland";
            this.toolTip1.SetToolTip(this.BUT_abortland, resources.GetString("BUT_abortland.ToolTip"));
            this.BUT_abortland.UseVisualStyleBackColor = true;
            this.BUT_abortland.Click += new System.EventHandler(this.BUT_abortland_Click);
            // 
            // BUT_resumemis
            // 
            this.BUT_resumemis.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_resumemis.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_resumemis.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_resumemis, "BUT_resumemis");
            this.BUT_resumemis.Name = "BUT_resumemis";
            this.BUT_resumemis.UseVisualStyleBackColor = true;
            this.BUT_resumemis.Click += new System.EventHandler(this.BUT_resumemis_Click);
            // 
            // CMB_mountmode
            // 
            this.CMB_mountmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_mountmode.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_mountmode, "CMB_mountmode");
            this.CMB_mountmode.Name = "CMB_mountmode";
            // 
            // BUT_mountmode
            // 
            this.BUT_mountmode.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_mountmode.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_mountmode.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_mountmode, "BUT_mountmode");
            this.BUT_mountmode.Name = "BUT_mountmode";
            this.toolTip1.SetToolTip(this.BUT_mountmode, resources.GetString("BUT_mountmode.ToolTip"));
            this.BUT_mountmode.UseVisualStyleBackColor = true;
            this.BUT_mountmode.Click += new System.EventHandler(this.BUT_mountmode_Click);
            // 
            // BUT_joystick
            // 
            this.BUT_joystick.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_joystick.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_joystick.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_joystick, "BUT_joystick");
            this.BUT_joystick.Name = "BUT_joystick";
            this.toolTip1.SetToolTip(this.BUT_joystick, resources.GetString("BUT_joystick.ToolTip"));
            this.BUT_joystick.UseVisualStyleBackColor = true;
            this.BUT_joystick.Click += new System.EventHandler(this.BUT_joystick_Click);
            // 
            // CMB_modes
            // 
            this.CMB_modes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_modes.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_modes, "CMB_modes");
            this.CMB_modes.Name = "CMB_modes";
            this.CMB_modes.Click += new System.EventHandler(this.CMB_modes_Click);
            // 
            // BUT_setmode
            // 
            this.BUT_setmode.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_setmode.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_setmode.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_setmode, "BUT_setmode");
            this.BUT_setmode.Name = "BUT_setmode";
            this.toolTip1.SetToolTip(this.BUT_setmode, resources.GetString("BUT_setmode.ToolTip"));
            this.BUT_setmode.UseVisualStyleBackColor = true;
            this.BUT_setmode.Click += new System.EventHandler(this.BUT_setmode_Click);
            // 
            // BUT_clear_track
            // 
            this.BUT_clear_track.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_clear_track.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_clear_track.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_clear_track, "BUT_clear_track");
            this.BUT_clear_track.Name = "BUT_clear_track";
            this.toolTip1.SetToolTip(this.BUT_clear_track, resources.GetString("BUT_clear_track.ToolTip"));
            this.BUT_clear_track.UseVisualStyleBackColor = true;
            this.BUT_clear_track.Click += new System.EventHandler(this.BUT_clear_track_Click);
            // 
            // CMB_action
            // 
            this.CMB_action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_action.DropDownWidth = 150;
            this.CMB_action.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_action, "CMB_action");
            this.CMB_action.Name = "CMB_action";
            // 
            // BUT_Homealt
            // 
            this.BUT_Homealt.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_Homealt.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_Homealt.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_Homealt, "BUT_Homealt");
            this.BUT_Homealt.Name = "BUT_Homealt";
            this.toolTip1.SetToolTip(this.BUT_Homealt, resources.GetString("BUT_Homealt.ToolTip"));
            this.BUT_Homealt.UseVisualStyleBackColor = true;
            this.BUT_Homealt.Click += new System.EventHandler(this.BUT_Homealt_Click);
            // 
            // BUT_RAWSensor
            // 
            this.BUT_RAWSensor.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_RAWSensor.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_RAWSensor.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_RAWSensor, "BUT_RAWSensor");
            this.BUT_RAWSensor.Name = "BUT_RAWSensor";
            this.toolTip1.SetToolTip(this.BUT_RAWSensor, resources.GetString("BUT_RAWSensor.ToolTip"));
            this.BUT_RAWSensor.UseVisualStyleBackColor = true;
            this.BUT_RAWSensor.Click += new System.EventHandler(this.BUT_RAWSensor_Click);
            // 
            // BUTrestartmission
            // 
            this.BUTrestartmission.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUTrestartmission.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUTrestartmission.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUTrestartmission, "BUTrestartmission");
            this.BUTrestartmission.Name = "BUTrestartmission";
            this.toolTip1.SetToolTip(this.BUTrestartmission, resources.GetString("BUTrestartmission.ToolTip"));
            this.BUTrestartmission.UseVisualStyleBackColor = true;
            this.BUTrestartmission.Click += new System.EventHandler(this.BUTrestartmission_Click);
            // 
            // BUTactiondo
            // 
            this.BUTactiondo.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUTactiondo.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUTactiondo.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUTactiondo, "BUTactiondo");
            this.BUTactiondo.Name = "BUTactiondo";
            this.toolTip1.SetToolTip(this.BUTactiondo, resources.GetString("BUTactiondo.ToolTip"));
            this.BUTactiondo.UseVisualStyleBackColor = true;
            this.BUTactiondo.Click += new System.EventHandler(this.BUTactiondo_Click);
            // 
            // tabActionsSimple
            // 
            this.tabActionsSimple.Controls.Add(this.myButton1);
            this.tabActionsSimple.Controls.Add(this.myButton2);
            this.tabActionsSimple.Controls.Add(this.myButton3);
            resources.ApplyResources(this.tabActionsSimple, "tabActionsSimple");
            this.tabActionsSimple.Name = "tabActionsSimple";
            this.tabActionsSimple.UseVisualStyleBackColor = true;
            // 
            // myButton1
            // 
            this.myButton1.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton1.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton1.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.Name = "myButton1";
            this.toolTip1.SetToolTip(this.myButton1, resources.GetString("myButton1.ToolTip"));
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.BUT_quickmanual_Click);
            // 
            // myButton2
            // 
            this.myButton2.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton2.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton2.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.Name = "myButton2";
            this.toolTip1.SetToolTip(this.myButton2, resources.GetString("myButton2.ToolTip"));
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // myButton3
            // 
            this.myButton3.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton3.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton3.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.myButton3, "myButton3");
            this.myButton3.Name = "myButton3";
            this.toolTip1.SetToolTip(this.myButton3, resources.GetString("myButton3.ToolTip"));
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // tabPagePreFlight
            // 
            this.tabPagePreFlight.Controls.Add(this.checkListControl1);
            resources.ApplyResources(this.tabPagePreFlight, "tabPagePreFlight");
            this.tabPagePreFlight.Name = "tabPagePreFlight";
            this.tabPagePreFlight.UseVisualStyleBackColor = true;
            // 
            // tabGauges
            // 
            this.tabGauges.Controls.Add(this.Gvspeed);
            this.tabGauges.Controls.Add(this.Gheading);
            this.tabGauges.Controls.Add(this.Galt);
            this.tabGauges.Controls.Add(this.Gspeed);
            resources.ApplyResources(this.tabGauges, "tabGauges");
            this.tabGauges.Name = "tabGauges";
            this.tabGauges.UseVisualStyleBackColor = true;
            this.tabGauges.Resize += new System.EventHandler(this.tabPage1_Resize);
            // 
            // Gvspeed
            // 
            this.Gvspeed.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Gvspeed, "Gvspeed");
            this.Gvspeed.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gvspeed.BaseArcRadius = 60;
            this.Gvspeed.BaseArcStart = 20;
            this.Gvspeed.BaseArcSweep = 320;
            this.Gvspeed.BaseArcWidth = 2;
            this.Gvspeed.Cap_Idx = ((byte)(0));
            this.Gvspeed.CapColor = System.Drawing.Color.White;
            this.Gvspeed.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gvspeed.CapPosition = new System.Drawing.Point(65, 85);
            this.Gvspeed.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(65, 85),
        new System.Drawing.Point(30, 55),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gvspeed.CapsText = new string[] {
        "VSI",
        "",
        "",
        "",
        ""};
            this.Gvspeed.CapText = "VSI";
            this.Gvspeed.Center = new System.Drawing.Point(75, 75);
            this.Gvspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "verticalspeed", true));
            this.Gvspeed.MaxValue = 10F;
            this.Gvspeed.MinValue = -10F;
            this.Gvspeed.Name = "Gvspeed";
            this.Gvspeed.Need_Idx = ((byte)(3));
            this.Gvspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gvspeed.NeedleColor2 = System.Drawing.Color.White;
            this.Gvspeed.NeedleEnabled = false;
            this.Gvspeed.NeedleRadius = 80;
            this.Gvspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gvspeed.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.Gvspeed.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.Gvspeed.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.Gvspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gvspeed.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.Gvspeed.NeedleType = 0;
            this.Gvspeed.NeedleWidth = 2;
            this.Gvspeed.Range_Idx = ((byte)(0));
            this.Gvspeed.RangeColor = System.Drawing.Color.LightGreen;
            this.Gvspeed.RangeEnabled = false;
            this.Gvspeed.RangeEndValue = 360F;
            this.Gvspeed.RangeInnerRadius = 1;
            this.Gvspeed.RangeOuterRadius = 60;
            this.Gvspeed.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gvspeed.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gvspeed.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.Gvspeed.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gvspeed.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.Gvspeed.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.Gvspeed.RangeStartValue = 0F;
            this.Gvspeed.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesInterInnerRadius = 52;
            this.Gvspeed.ScaleLinesInterOuterRadius = 60;
            this.Gvspeed.ScaleLinesInterWidth = 1;
            this.Gvspeed.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gvspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gvspeed.ScaleLinesMajorStepValue = 2F;
            this.Gvspeed.ScaleLinesMajorWidth = 2;
            this.Gvspeed.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gvspeed.ScaleLinesMinorNumOf = 9;
            this.Gvspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gvspeed.ScaleLinesMinorWidth = 1;
            this.Gvspeed.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleNumbersFormat = "";
            this.Gvspeed.ScaleNumbersRadius = 42;
            this.Gvspeed.ScaleNumbersRotation = 0;
            this.Gvspeed.ScaleNumbersStartScaleLine = 1;
            this.Gvspeed.ScaleNumbersStepScaleLines = 1;
            this.Gvspeed.Value = 0F;
            this.Gvspeed.Value0 = 0F;
            this.Gvspeed.Value1 = 0F;
            this.Gvspeed.Value2 = 0F;
            this.Gvspeed.Value3 = 0F;
            // 
            // bindingSourceGaugesTab
            // 
            this.bindingSourceGaugesTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // Gheading
            // 
            this.Gheading.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Gheading, "Gheading");
            this.Gheading.DataBindings.Add(new System.Windows.Forms.Binding("Heading", this.bindingSourceGaugesTab, "yaw", true));
            this.Gheading.DataBindings.Add(new System.Windows.Forms.Binding("NavHeading", this.bindingSourceGaugesTab, "nav_bearing", true));
            this.Gheading.Heading = 0;
            this.Gheading.Name = "Gheading";
            this.Gheading.NavHeading = 0;
            // 
            // Galt
            // 
            this.Galt.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Galt, "Galt");
            this.Galt.BaseArcColor = System.Drawing.Color.Transparent;
            this.Galt.BaseArcRadius = 60;
            this.Galt.BaseArcStart = 270;
            this.Galt.BaseArcSweep = 360;
            this.Galt.BaseArcWidth = 2;
            this.Galt.Cap_Idx = ((byte)(0));
            this.Galt.CapColor = System.Drawing.Color.White;
            this.Galt.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Galt.CapPosition = new System.Drawing.Point(68, 85);
            this.Galt.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(68, 85),
        new System.Drawing.Point(30, 55),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Galt.CapsText = new string[] {
        "Alt",
        "",
        "",
        "",
        ""};
            this.Galt.CapText = "Alt";
            this.Galt.Center = new System.Drawing.Point(75, 75);
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "altd100", true));
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSourceGaugesTab, "altd1000", true));
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value2", this.bindingSourceGaugesTab, "targetaltd100", true));
            this.Galt.MaxValue = 9.99F;
            this.Galt.MinValue = 0F;
            this.Galt.Name = "Galt";
            this.Galt.Need_Idx = ((byte)(3));
            this.Galt.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Galt.NeedleColor2 = System.Drawing.Color.White;
            this.Galt.NeedleEnabled = false;
            this.Galt.NeedleRadius = 80;
            this.Galt.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Galt.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.Galt.NeedlesEnabled = new bool[] {
        true,
        true,
        true,
        false};
            this.Galt.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.Galt.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Galt.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.Galt.NeedleType = 0;
            this.Galt.NeedleWidth = 2;
            this.Galt.Range_Idx = ((byte)(0));
            this.Galt.RangeColor = System.Drawing.Color.LightGreen;
            this.Galt.RangeEnabled = false;
            this.Galt.RangeEndValue = 360F;
            this.Galt.RangeInnerRadius = 1;
            this.Galt.RangeOuterRadius = 60;
            this.Galt.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Galt.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Galt.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.Galt.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Galt.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.Galt.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.Galt.RangeStartValue = 0F;
            this.Galt.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesInterInnerRadius = 52;
            this.Galt.ScaleLinesInterOuterRadius = 60;
            this.Galt.ScaleLinesInterWidth = 1;
            this.Galt.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesMajorInnerRadius = 50;
            this.Galt.ScaleLinesMajorOuterRadius = 60;
            this.Galt.ScaleLinesMajorStepValue = 1F;
            this.Galt.ScaleLinesMajorWidth = 2;
            this.Galt.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesMinorInnerRadius = 55;
            this.Galt.ScaleLinesMinorNumOf = 9;
            this.Galt.ScaleLinesMinorOuterRadius = 60;
            this.Galt.ScaleLinesMinorWidth = 1;
            this.Galt.ScaleNumbersColor = System.Drawing.Color.White;
            this.Galt.ScaleNumbersFormat = "";
            this.Galt.ScaleNumbersRadius = 42;
            this.Galt.ScaleNumbersRotation = 0;
            this.Galt.ScaleNumbersStartScaleLine = 1;
            this.Galt.ScaleNumbersStepScaleLines = 1;
            this.Galt.Value = 0F;
            this.Galt.Value0 = 0F;
            this.Galt.Value1 = 0F;
            this.Galt.Value2 = 0F;
            this.Galt.Value3 = 0F;
            // 
            // Gspeed
            // 
            this.Gspeed.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Gspeed, "Gspeed");
            this.Gspeed.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gspeed.BaseArcRadius = 70;
            this.Gspeed.BaseArcStart = 135;
            this.Gspeed.BaseArcSweep = 270;
            this.Gspeed.BaseArcWidth = 2;
            this.Gspeed.Cap_Idx = ((byte)(0));
            this.Gspeed.CapColor = System.Drawing.Color.White;
            this.Gspeed.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gspeed.CapPosition = new System.Drawing.Point(58, 85);
            this.Gspeed.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gspeed.CapsText = new string[] {
        "Speed",
        "",
        "",
        "",
        ""};
            this.Gspeed.CapText = "Speed";
            this.Gspeed.Center = new System.Drawing.Point(75, 75);
            this.Gspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "airspeed", true));
            this.Gspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSourceGaugesTab, "groundspeed", true));
            this.Gspeed.MaxValue = 60F;
            this.Gspeed.MinValue = 0F;
            this.Gspeed.Name = "Gspeed";
            this.Gspeed.Need_Idx = ((byte)(3));
            this.Gspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gspeed.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gspeed.NeedleEnabled = false;
            this.Gspeed.NeedleRadius = 70;
            this.Gspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gspeed.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gspeed.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gspeed.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gspeed.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gspeed.NeedleType = 0;
            this.Gspeed.NeedleWidth = 2;
            this.Gspeed.Range_Idx = ((byte)(2));
            this.Gspeed.RangeColor = System.Drawing.Color.Orange;
            this.Gspeed.RangeEnabled = false;
            this.Gspeed.RangeEndValue = 50F;
            this.Gspeed.RangeInnerRadius = 1;
            this.Gspeed.RangeOuterRadius = 70;
            this.Gspeed.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gspeed.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gspeed.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gspeed.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gspeed.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gspeed.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gspeed.RangeStartValue = 35F;
            this.Gspeed.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesInterInnerRadius = 52;
            this.Gspeed.ScaleLinesInterOuterRadius = 60;
            this.Gspeed.ScaleLinesInterWidth = 1;
            this.Gspeed.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gspeed.ScaleLinesMajorStepValue = 10F;
            this.Gspeed.ScaleLinesMajorWidth = 2;
            this.Gspeed.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gspeed.ScaleLinesMinorNumOf = 9;
            this.Gspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gspeed.ScaleLinesMinorWidth = 1;
            this.Gspeed.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gspeed.ScaleNumbersFormat = null;
            this.Gspeed.ScaleNumbersRadius = 42;
            this.Gspeed.ScaleNumbersRotation = 0;
            this.Gspeed.ScaleNumbersStartScaleLine = 1;
            this.Gspeed.ScaleNumbersStepScaleLines = 1;
            this.toolTip1.SetToolTip(this.Gspeed, resources.GetString("Gspeed.ToolTip"));
            this.Gspeed.Value = 0F;
            this.Gspeed.Value0 = 0F;
            this.Gspeed.Value1 = 0F;
            this.Gspeed.Value2 = 0F;
            this.Gspeed.Value3 = 0F;
            this.Gspeed.DoubleClick += new System.EventHandler(this.Gspeed_DoubleClick);
            // 
            // tabStatus
            // 
            resources.ApplyResources(this.tabStatus, "tabStatus");
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.tabStatus_Paint);
            // 
            // tabServo
            // 
            this.tabServo.Controls.Add(this.flowLayoutPanelServos);
            resources.ApplyResources(this.tabServo, "tabServo");
            this.tabServo.Name = "tabServo";
            this.tabServo.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelServos
            // 
            resources.ApplyResources(this.flowLayoutPanelServos, "flowLayoutPanelServos");
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions1);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions2);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions3);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions4);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions5);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions6);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions7);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions8);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions9);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions10);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions1);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions2);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions3);
            this.flowLayoutPanelServos.Controls.Add(this.relayOptions4);
            this.flowLayoutPanelServos.Name = "flowLayoutPanelServos";
            // 
            // tabTLogs
            // 
            resources.ApplyResources(this.tabTLogs, "tabTLogs");
            this.tabTLogs.Name = "tabTLogs";
            this.tabTLogs.UseVisualStyleBackColor = true;
            // 
            // tablogbrowse
            // 
            this.tablogbrowse.Controls.Add(this.BUT_georefimage);
            this.tablogbrowse.Controls.Add(this.BUT_loganalysis);
            this.tablogbrowse.Controls.Add(this.but_dflogtokml);
            this.tablogbrowse.Controls.Add(this.BUT_matlab);
            resources.ApplyResources(this.tablogbrowse, "tablogbrowse");
            this.tablogbrowse.Name = "tablogbrowse";
            this.tablogbrowse.UseVisualStyleBackColor = true;
            // 
            // BUT_georefimage
            // 
            resources.ApplyResources(this.BUT_georefimage, "BUT_georefimage");
            this.BUT_georefimage.Name = "BUT_georefimage";
            this.BUT_georefimage.Click += new System.EventHandler(this.BUT_georefimage_Click);
            // 
            // BUT_loganalysis
            // 
            this.BUT_loganalysis.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_loganalysis.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_loganalysis.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_loganalysis, "BUT_loganalysis");
            this.BUT_loganalysis.Name = "BUT_loganalysis";
            this.BUT_loganalysis.UseVisualStyleBackColor = true;
            this.BUT_loganalysis.Click += new System.EventHandler(this.BUT_loganalysis_Click);
            // 
            // but_dflogtokml
            // 
            this.but_dflogtokml.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_dflogtokml.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_dflogtokml.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.but_dflogtokml, "but_dflogtokml");
            this.but_dflogtokml.Name = "but_dflogtokml";
            this.but_dflogtokml.UseVisualStyleBackColor = true;
            this.but_dflogtokml.Click += new System.EventHandler(this.but_dflogtokml_Click);
            // 
            // BUT_matlab
            // 
            this.BUT_matlab.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_matlab.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_matlab.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_matlab, "BUT_matlab");
            this.BUT_matlab.Name = "BUT_matlab";
            this.BUT_matlab.UseVisualStyleBackColor = true;
            this.BUT_matlab.Click += new System.EventHandler(this.BUT_matlab_Click);
            // 
            // tabScripts
            // 
            this.tabScripts.Controls.Add(this.checkBoxRedirectOutput);
            this.tabScripts.Controls.Add(this.BUT_edit_selected);
            this.tabScripts.Controls.Add(this.labelSelectedScript);
            this.tabScripts.Controls.Add(this.BUT_run_script);
            this.tabScripts.Controls.Add(this.BUT_abort_script);
            this.tabScripts.Controls.Add(this.labelScriptStatus);
            this.tabScripts.Controls.Add(this.BUT_select_script);
            resources.ApplyResources(this.tabScripts, "tabScripts");
            this.tabScripts.Name = "tabScripts";
            this.tabScripts.UseVisualStyleBackColor = true;
            // 
            // checkBoxRedirectOutput
            // 
            resources.ApplyResources(this.checkBoxRedirectOutput, "checkBoxRedirectOutput");
            this.checkBoxRedirectOutput.Checked = true;
            this.checkBoxRedirectOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRedirectOutput.Name = "checkBoxRedirectOutput";
            this.checkBoxRedirectOutput.UseVisualStyleBackColor = true;
            // 
            // BUT_edit_selected
            // 
            this.BUT_edit_selected.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_edit_selected.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_edit_selected.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_edit_selected, "BUT_edit_selected");
            this.BUT_edit_selected.Name = "BUT_edit_selected";
            this.BUT_edit_selected.UseVisualStyleBackColor = true;
            this.BUT_edit_selected.Click += new System.EventHandler(this.BUT_edit_selected_Click);
            // 
            // labelSelectedScript
            // 
            resources.ApplyResources(this.labelSelectedScript, "labelSelectedScript");
            this.labelSelectedScript.Name = "labelSelectedScript";
            // 
            // BUT_run_script
            // 
            this.BUT_run_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_run_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_run_script.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_run_script, "BUT_run_script");
            this.BUT_run_script.Name = "BUT_run_script";
            this.BUT_run_script.UseVisualStyleBackColor = true;
            this.BUT_run_script.Click += new System.EventHandler(this.BUT_run_script_Click);
            // 
            // BUT_abort_script
            // 
            this.BUT_abort_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_abort_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_abort_script.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_abort_script, "BUT_abort_script");
            this.BUT_abort_script.Name = "BUT_abort_script";
            this.BUT_abort_script.UseVisualStyleBackColor = true;
            this.BUT_abort_script.Click += new System.EventHandler(this.BUT_abort_script_Click);
            // 
            // labelScriptStatus
            // 
            resources.ApplyResources(this.labelScriptStatus, "labelScriptStatus");
            this.labelScriptStatus.Name = "labelScriptStatus";
            // 
            // BUT_select_script
            // 
            this.BUT_select_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_select_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_select_script.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_select_script, "BUT_select_script");
            this.BUT_select_script.Name = "BUT_select_script";
            this.BUT_select_script.UseVisualStyleBackColor = true;
            this.BUT_select_script.Click += new System.EventHandler(this.BUT_select_script_Click);
            // 
            // tabPagemessages
            // 
            resources.ApplyResources(this.tabPagemessages, "tabPagemessages");
            this.tabPagemessages.Name = "tabPagemessages";
            this.tabPagemessages.UseVisualStyleBackColor = true;
            // 
            // tabPayload
            // 
            this.tabPayload.Controls.Add(this.BUT_PayloadFolder);
            this.tabPayload.Controls.Add(this.groupBoxRoll);
            this.tabPayload.Controls.Add(this.groupBoxYaw);
            this.tabPayload.Controls.Add(this.BUT_resetGimbalPos);
            this.tabPayload.Controls.Add(this.groupBoxPitch);
            resources.ApplyResources(this.tabPayload, "tabPayload");
            this.tabPayload.Name = "tabPayload";
            this.tabPayload.UseVisualStyleBackColor = true;
            // 
            // BUT_PayloadFolder
            // 
            resources.ApplyResources(this.BUT_PayloadFolder, "BUT_PayloadFolder");
            this.BUT_PayloadFolder.Name = "BUT_PayloadFolder";
            this.BUT_PayloadFolder.UseVisualStyleBackColor = true;
            // 
            // groupBoxRoll
            // 
            this.groupBoxRoll.Controls.Add(this.TXT_gimbalRollPos);
            this.groupBoxRoll.Controls.Add(this.trackBarRoll);
            resources.ApplyResources(this.groupBoxRoll, "groupBoxRoll");
            this.groupBoxRoll.Name = "groupBoxRoll";
            this.groupBoxRoll.TabStop = false;
            // 
            // TXT_gimbalRollPos
            // 
            this.TXT_gimbalRollPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointb", true));
            resources.ApplyResources(this.TXT_gimbalRollPos, "TXT_gimbalRollPos");
            this.TXT_gimbalRollPos.Name = "TXT_gimbalRollPos";
            // 
            // bindingSourcePayloadTab
            // 
            this.bindingSourcePayloadTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // trackBarRoll
            // 
            resources.ApplyResources(this.trackBarRoll, "trackBarRoll");
            this.trackBarRoll.LargeChange = 10;
            this.trackBarRoll.Maximum = 45;
            this.trackBarRoll.Minimum = -45;
            this.trackBarRoll.Name = "trackBarRoll";
            this.trackBarRoll.TickFrequency = 10;
            this.trackBarRoll.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // groupBoxYaw
            // 
            this.groupBoxYaw.Controls.Add(this.TXT_gimbalYawPos);
            this.groupBoxYaw.Controls.Add(this.trackBarYaw);
            resources.ApplyResources(this.groupBoxYaw, "groupBoxYaw");
            this.groupBoxYaw.Name = "groupBoxYaw";
            this.groupBoxYaw.TabStop = false;
            // 
            // TXT_gimbalYawPos
            // 
            this.TXT_gimbalYawPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointc", true));
            resources.ApplyResources(this.TXT_gimbalYawPos, "TXT_gimbalYawPos");
            this.TXT_gimbalYawPos.Name = "TXT_gimbalYawPos";
            // 
            // trackBarYaw
            // 
            resources.ApplyResources(this.trackBarYaw, "trackBarYaw");
            this.trackBarYaw.LargeChange = 10;
            this.trackBarYaw.Maximum = 45;
            this.trackBarYaw.Minimum = -45;
            this.trackBarYaw.Name = "trackBarYaw";
            this.trackBarYaw.TickFrequency = 10;
            this.trackBarYaw.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // BUT_resetGimbalPos
            // 
            resources.ApplyResources(this.BUT_resetGimbalPos, "BUT_resetGimbalPos");
            this.BUT_resetGimbalPos.Name = "BUT_resetGimbalPos";
            this.BUT_resetGimbalPos.UseVisualStyleBackColor = true;
            this.BUT_resetGimbalPos.Click += new System.EventHandler(this.BUT_resetGimbalPos_Click);
            // 
            // groupBoxPitch
            // 
            this.groupBoxPitch.Controls.Add(this.trackBarPitch);
            this.groupBoxPitch.Controls.Add(this.TXT_gimbalPitchPos);
            resources.ApplyResources(this.groupBoxPitch, "groupBoxPitch");
            this.groupBoxPitch.Name = "groupBoxPitch";
            this.groupBoxPitch.TabStop = false;
            // 
            // trackBarPitch
            // 
            resources.ApplyResources(this.trackBarPitch, "trackBarPitch");
            this.trackBarPitch.LargeChange = 10;
            this.trackBarPitch.Maximum = 45;
            this.trackBarPitch.Minimum = -45;
            this.trackBarPitch.Name = "trackBarPitch";
            this.trackBarPitch.SmallChange = 5;
            this.trackBarPitch.TickFrequency = 10;
            this.trackBarPitch.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // TXT_gimbalPitchPos
            // 
            this.TXT_gimbalPitchPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointa", true));
            resources.ApplyResources(this.TXT_gimbalPitchPos, "TXT_gimbalPitchPos");
            this.TXT_gimbalPitchPos.Name = "TXT_gimbalPitchPos";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // lbl_sats
            // 
            resources.ApplyResources(this.lbl_sats, "lbl_sats");
            this.lbl_sats.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "satcount", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "Sats: 0"));
            this.lbl_sats.Name = "lbl_sats";
            this.lbl_sats.resize = true;
            this.toolTip1.SetToolTip(this.lbl_sats, resources.GetString("lbl_sats.ToolTip"));
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            this.label4.Tag = "custom";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Name = "label3";
            this.label3.Tag = "custom";
            // 
            // lbl_hdop
            // 
            resources.ApplyResources(this.lbl_hdop, "lbl_hdop");
            this.lbl_hdop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_hdop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "gpshdop", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "hdop: 0.0"));
            this.lbl_hdop.Name = "lbl_hdop";
            this.lbl_hdop.resize = true;
            this.toolTip1.SetToolTip(this.lbl_hdop, resources.GetString("lbl_hdop.ToolTip"));
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Name = "label5";
            this.label5.Tag = "custom";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            this.label6.Tag = "custom";
            // 
            // picture_flytrac
            // 
            this.picture_flytrac.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.picture_flytrac, "picture_flytrac");
            this.picture_flytrac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_flytrac.Image = global::MissionPlanner.Properties.Resources.原始状态;
            this.picture_flytrac.Name = "picture_flytrac";
            this.picture_flytrac.TabStop = false;
            this.picture_flytrac.Click += new System.EventHandler(this.picture_flytrac_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.BackgroundImage = global::MissionPlanner.Properties.Resources.Map_0;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.label_DistToHome1);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label_wpnonew);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label_waypoint);
            this.panel5.Controls.Add(this.label_Traveled);
            this.panel5.Controls.Add(this.label_flytime);
            this.panel5.Name = "panel5";
            // 
            // label_DistToHome1
            // 
            resources.ApplyResources(this.label_DistToHome1, "label_DistToHome1");
            this.label_DistToHome1.BackColor = System.Drawing.Color.Transparent;
            this.label_DistToHome1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "DistToHome", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "0.00"));
            this.label_DistToHome1.ForeColor = System.Drawing.Color.Black;
            this.label_DistToHome1.Name = "label_DistToHome1";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Name = "label14";
            // 
            // label_wpnonew
            // 
            this.label_wpnonew.BackColor = System.Drawing.Color.Transparent;
            this.label_wpnonew.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "wpno", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "0"));
            resources.ApplyResources(this.label_wpnonew, "label_wpnonew");
            this.label_wpnonew.ForeColor = System.Drawing.Color.Black;
            this.label_wpnonew.Name = "label_wpnonew";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Name = "label11";
            // 
            // label_waypoint
            // 
            resources.ApplyResources(this.label_waypoint, "label_waypoint");
            this.label_waypoint.BackColor = System.Drawing.Color.Transparent;
            this.label_waypoint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "wp_dist", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "0.00"));
            this.label_waypoint.ForeColor = System.Drawing.Color.Black;
            this.label_waypoint.Name = "label_waypoint";
            // 
            // label_Traveled
            // 
            resources.ApplyResources(this.label_Traveled, "label_Traveled");
            this.label_Traveled.BackColor = System.Drawing.Color.Transparent;
            this.label_Traveled.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "distTraveled", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "0.00"));
            this.label_Traveled.ForeColor = System.Drawing.Color.Black;
            this.label_Traveled.Name = "label_Traveled";
            this.label_Traveled.TextChanged += new System.EventHandler(this.label_homedist_TextChanged);
            // 
            // label_flytime
            // 
            resources.ApplyResources(this.label_flytime, "label_flytime");
            this.label_flytime.BackColor = System.Drawing.Color.Transparent;
            this.label_flytime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "timeInAir", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "0.0"));
            this.label_flytime.ForeColor = System.Drawing.Color.Black;
            this.label_flytime.Name = "label_flytime";
            // 
            // pictureBox_minus
            // 
            this.pictureBox_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minus.Image = global::MissionPlanner.Properties.Resources.minusNomo;
            resources.ApplyResources(this.pictureBox_minus, "pictureBox_minus");
            this.pictureBox_minus.Name = "pictureBox_minus";
            this.pictureBox_minus.TabStop = false;
            this.pictureBox_minus.Click += new System.EventHandler(this.pictureBox_minus_Click);
            this.pictureBox_minus.MouseEnter += new System.EventHandler(this.pictureBox_minus_MouseEnter);
            this.pictureBox_minus.MouseLeave += new System.EventHandler(this.pictureBox_minus_MouseLeave);
            // 
            // pictureBox_add
            // 
            this.pictureBox_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_add.Image = global::MissionPlanner.Properties.Resources.addMouseNomo;
            resources.ApplyResources(this.pictureBox_add, "pictureBox_add");
            this.pictureBox_add.Name = "pictureBox_add";
            this.pictureBox_add.TabStop = false;
            this.pictureBox_add.Click += new System.EventHandler(this.pictureBox_add_Click);
            this.pictureBox_add.MouseEnter += new System.EventHandler(this.pictureBox_add_MouseEnter);
            this.pictureBox_add.MouseLeave += new System.EventHandler(this.pictureBox_add_MouseLeave);
            // 
            // but_disablejoystick
            // 
            this.but_disablejoystick.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_disablejoystick.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_disablejoystick.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.but_disablejoystick, "but_disablejoystick");
            this.but_disablejoystick.Name = "but_disablejoystick";
            this.but_disablejoystick.UseVisualStyleBackColor = true;
            this.but_disablejoystick.Click += new System.EventHandler(this.but_disablejoystick_Click);
            // 
            // windDir1
            // 
            this.windDir1.BackColor = System.Drawing.Color.Transparent;
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Direction", this.bindingSource1, "wind_dir", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Speed", this.bindingSource1, "wind_vel", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.Direction = 33480D;
            resources.ApplyResources(this.windDir1, "windDir1");
            this.windDir1.Name = "windDir1";
            this.windDir1.Speed = 0D;
            this.windDir1.UseWaitCursor = true;
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.Color.Transparent;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.ContextMenuStrip = this.contextMenuStripMap;
            resources.ApplyResources(this.gMapControl1, "gMapControl1");
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Gray;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.HoldInvalidation = false;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 24;
            this.gMapControl1.MinZoom = 0;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Zoom = 3D;
            this.gMapControl1.OnPositionChanged += new GMap.NET.PositionChanged(this.gMapControl1_OnPositionChanged);
            this.gMapControl1.SizeChanged += new System.EventHandler(this.gMapControl1_SizeChanged);
            this.gMapControl1.Click += new System.EventHandler(this.gMapControl1_Click);
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDown);
            this.gMapControl1.MouseLeave += new System.EventHandler(this.gMapControl1_MouseLeave);
            this.gMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseMove);
            // 
            // TRK_zoom
            // 
            resources.ApplyResources(this.TRK_zoom, "TRK_zoom");
            this.TRK_zoom.LargeChange = 1F;
            this.TRK_zoom.Maximum = 24F;
            this.TRK_zoom.Minimum = 1F;
            this.TRK_zoom.Name = "TRK_zoom";
            this.TRK_zoom.SmallChange = 1F;
            this.TRK_zoom.TickFrequency = 1F;
            this.TRK_zoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TRK_zoom.Value = 1F;
            this.TRK_zoom.Scroll += new System.EventHandler(this.TRK_zoom_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.distanceBar2);
            this.panel1.Controls.Add(this.coords1);
            this.panel1.Controls.Add(this.Zoomlevel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CHK_autopan);
            this.panel1.Controls.Add(this.CB_tuning);
            this.panel1.Controls.Add(this.label_VerticalSpeed);
            this.panel1.Controls.Add(this.label_Altitude);
            this.panel1.Controls.Add(this.label_Throttle);
            this.panel1.Controls.Add(this.label_Battery);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltSource = "";
            this.coords1.AltUnit = "m";
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Alt", this.bindingSource1, "alt", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lat", this.bindingSource1, "lat", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lng", this.bindingSource1, "lng", true));
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.Name = "coords1";
            this.coords1.Vertical = false;
            // 
            // Zoomlevel
            // 
            resources.ApplyResources(this.Zoomlevel, "Zoomlevel");
            this.Zoomlevel.DecimalPlaces = 1;
            this.Zoomlevel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Zoomlevel.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Zoomlevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Zoomlevel.Name = "Zoomlevel";
            this.toolTip1.SetToolTip(this.Zoomlevel, resources.GetString("Zoomlevel.ToolTip"));
            this.Zoomlevel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Zoomlevel.ValueChanged += new System.EventHandler(this.Zoomlevel_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.resize = false;
            // 
            // CHK_autopan
            // 
            resources.ApplyResources(this.CHK_autopan, "CHK_autopan");
            this.CHK_autopan.Checked = true;
            this.CHK_autopan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_autopan.Name = "CHK_autopan";
            this.toolTip1.SetToolTip(this.CHK_autopan, resources.GetString("CHK_autopan.ToolTip"));
            this.CHK_autopan.UseVisualStyleBackColor = true;
            this.CHK_autopan.CheckedChanged += new System.EventHandler(this.CHK_autopan_CheckedChanged);
            // 
            // CB_tuning
            // 
            resources.ApplyResources(this.CB_tuning, "CB_tuning");
            this.CB_tuning.Name = "CB_tuning";
            this.toolTip1.SetToolTip(this.CB_tuning, resources.GetString("CB_tuning.ToolTip"));
            this.CB_tuning.UseVisualStyleBackColor = true;
            this.CB_tuning.CheckedChanged += new System.EventHandler(this.CB_tuning_CheckedChanged);
            // 
            // label_VerticalSpeed
            // 
            resources.ApplyResources(this.label_VerticalSpeed, "label_VerticalSpeed");
            this.label_VerticalSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "verticalspeed", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "0.00"));
            this.label_VerticalSpeed.Name = "label_VerticalSpeed";
            this.label_VerticalSpeed.TextChanged += new System.EventHandler(this.label_VerticalSpeed_TextChanged);
            // 
            // label_Altitude
            // 
            resources.ApplyResources(this.label_Altitude, "label_Altitude");
            this.label_Altitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "alt", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "0.00"));
            this.label_Altitude.Name = "label_Altitude";
            this.label_Altitude.TextChanged += new System.EventHandler(this.label_Altitude_TextChanged);
            // 
            // label_Throttle
            // 
            resources.ApplyResources(this.label_Throttle, "label_Throttle");
            this.label_Throttle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ch3percent11", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "0.00 %"));
            this.label_Throttle.Name = "label_Throttle";
            this.label_Throttle.TextChanged += new System.EventHandler(this.label_Throttle_TextChanged);
            // 
            // label_Battery
            // 
            resources.ApplyResources(this.label_Battery, "label_Battery");
            this.label_Battery.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "battery_remaining", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "0.00 %"));
            this.label_Battery.Name = "label_Battery";
            this.label_Battery.TextChanged += new System.EventHandler(this.label_Battery_TextChanged);
            // 
            // ZedGraphTimer
            // 
            this.ZedGraphTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(150)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            // 
            // openScriptDialog
            // 
            resources.ApplyResources(this.openScriptDialog, "openScriptDialog");
            // 
            // scriptChecker
            // 
            this.scriptChecker.Tick += new System.EventHandler(this.scriptChecker_Tick);
            // 
            // Messagetabtimer
            // 
            this.Messagetabtimer.Interval = 200;
            this.Messagetabtimer.Tick += new System.EventHandler(this.Messagetabtimer_Tick);
            // 
            // bindingSourceStatusTab
            // 
            this.bindingSourceStatusTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // timer_check
            // 
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // tabControl_Newactions
            // 
            this.tabControl_Newactions.Controls.Add(this.tabPage1);
            this.tabControl_Newactions.Controls.Add(this.tabPage2);
            this.tabControl_Newactions.Controls.Add(this.tabPage3);
            this.tabControl_Newactions.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.tabControl_Newactions, "tabControl_Newactions");
            this.tabControl_Newactions.Multiline = true;
            this.tabControl_Newactions.Name = "tabControl_Newactions";
            this.tabControl_Newactions.SelectedIndex = 0;
            this.tabControl_Newactions.SizeChanged += new System.EventHandler(this.tabControl_Newactions_SizeChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.SizeChanged += new System.EventHandler(this.tabPage1_SizeChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.myArcHalfProgressBar_battery, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.myArcHalfProgressBar_VerticalSpeed, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.myArcHalfProgressBar_Throttle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.myArcHalfProgressBar_Altitude, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // myArcHalfProgressBar_battery
            // 
            this.myArcHalfProgressBar_battery.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myArcHalfProgressBar_battery.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            resources.ApplyResources(this.myArcHalfProgressBar_battery, "myArcHalfProgressBar_battery");
            this.myArcHalfProgressBar_battery.FontUnit = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myArcHalfProgressBar_battery.ForeColor = System.Drawing.Color.White;
            this.myArcHalfProgressBar_battery.HeightTitle = 20;
            this.myArcHalfProgressBar_battery.MaxminTextHeight = 20;
            this.myArcHalfProgressBar_battery.MaxValue = 100;
            this.myArcHalfProgressBar_battery.MinValue = 0;
            this.myArcHalfProgressBar_battery.Name = "myArcHalfProgressBar_battery";
            this.myArcHalfProgressBar_battery.PBotton = 25;
            this.myArcHalfProgressBar_battery.PFont = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myArcHalfProgressBar_battery.PFontColor = System.Drawing.Color.White;
            this.myArcHalfProgressBar_battery.Pleft = 5;
            this.myArcHalfProgressBar_battery.PProgresBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.myArcHalfProgressBar_battery.PProgresFrontColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(131)))), ((int)(((byte)(70)))));
            this.myArcHalfProgressBar_battery.PRight = 5;
            this.myArcHalfProgressBar_battery.PText = "0";
            this.myArcHalfProgressBar_battery.PTitleFont = new System.Drawing.Font("微软雅黑", 12F);
            this.myArcHalfProgressBar_battery.PTop = 25;
            this.myArcHalfProgressBar_battery.Pwidth = 16;
            this.myArcHalfProgressBar_battery.Startarg = 180;
            this.myArcHalfProgressBar_battery.TitleText = "Battery";
            this.myArcHalfProgressBar_battery.UnitText = "%";
            this.myArcHalfProgressBar_battery.Value = 0D;
            // 
            // myArcHalfProgressBar_VerticalSpeed
            // 
            this.myArcHalfProgressBar_VerticalSpeed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.myArcHalfProgressBar_VerticalSpeed, "myArcHalfProgressBar_VerticalSpeed");
            this.myArcHalfProgressBar_VerticalSpeed.FontUnit = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myArcHalfProgressBar_VerticalSpeed.ForeColor = System.Drawing.Color.White;
            this.myArcHalfProgressBar_VerticalSpeed.HeightTitle = 20;
            this.myArcHalfProgressBar_VerticalSpeed.MaxminTextHeight = 20;
            this.myArcHalfProgressBar_VerticalSpeed.MaxValue = 10;
            this.myArcHalfProgressBar_VerticalSpeed.MinValue = -10;
            this.myArcHalfProgressBar_VerticalSpeed.Name = "myArcHalfProgressBar_VerticalSpeed";
            this.myArcHalfProgressBar_VerticalSpeed.PBotton = 25;
            this.myArcHalfProgressBar_VerticalSpeed.PFont = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myArcHalfProgressBar_VerticalSpeed.PFontColor = System.Drawing.Color.White;
            this.myArcHalfProgressBar_VerticalSpeed.Pleft = 5;
            this.myArcHalfProgressBar_VerticalSpeed.PProgresBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.myArcHalfProgressBar_VerticalSpeed.PProgresFrontColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(64)))));
            this.myArcHalfProgressBar_VerticalSpeed.PRight = 5;
            this.myArcHalfProgressBar_VerticalSpeed.PText = "0";
            this.myArcHalfProgressBar_VerticalSpeed.PTitleFont = new System.Drawing.Font("微软雅黑", 12F);
            this.myArcHalfProgressBar_VerticalSpeed.PTop = 25;
            this.myArcHalfProgressBar_VerticalSpeed.Pwidth = 16;
            this.myArcHalfProgressBar_VerticalSpeed.Startarg = 270;
            this.myArcHalfProgressBar_VerticalSpeed.TitleText = "VerSpeed";
            this.myArcHalfProgressBar_VerticalSpeed.UnitText = "m/s";
            this.myArcHalfProgressBar_VerticalSpeed.Value = 0D;
            // 
            // myArcHalfProgressBar_Throttle
            // 
            this.myArcHalfProgressBar_Throttle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.myArcHalfProgressBar_Throttle, "myArcHalfProgressBar_Throttle");
            this.myArcHalfProgressBar_Throttle.FontUnit = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myArcHalfProgressBar_Throttle.ForeColor = System.Drawing.Color.White;
            this.myArcHalfProgressBar_Throttle.HeightTitle = 20;
            this.myArcHalfProgressBar_Throttle.MaxminTextHeight = 20;
            this.myArcHalfProgressBar_Throttle.MaxValue = 100;
            this.myArcHalfProgressBar_Throttle.MinValue = 0;
            this.myArcHalfProgressBar_Throttle.Name = "myArcHalfProgressBar_Throttle";
            this.myArcHalfProgressBar_Throttle.PBotton = 25;
            this.myArcHalfProgressBar_Throttle.PFont = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myArcHalfProgressBar_Throttle.PFontColor = System.Drawing.Color.White;
            this.myArcHalfProgressBar_Throttle.Pleft = 5;
            this.myArcHalfProgressBar_Throttle.PProgresBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.myArcHalfProgressBar_Throttle.PProgresFrontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(79)))));
            this.myArcHalfProgressBar_Throttle.PRight = 5;
            this.myArcHalfProgressBar_Throttle.PText = "0";
            this.myArcHalfProgressBar_Throttle.PTitleFont = new System.Drawing.Font("微软雅黑", 12F);
            this.myArcHalfProgressBar_Throttle.PTop = 25;
            this.myArcHalfProgressBar_Throttle.Pwidth = 16;
            this.myArcHalfProgressBar_Throttle.Startarg = 180;
            this.myArcHalfProgressBar_Throttle.TitleText = "Throttle";
            this.myArcHalfProgressBar_Throttle.UnitText = "%";
            this.myArcHalfProgressBar_Throttle.Value = 0D;
            // 
            // myArcHalfProgressBar_Altitude
            // 
            this.myArcHalfProgressBar_Altitude.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.myArcHalfProgressBar_Altitude, "myArcHalfProgressBar_Altitude");
            this.myArcHalfProgressBar_Altitude.FontUnit = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myArcHalfProgressBar_Altitude.ForeColor = System.Drawing.Color.White;
            this.myArcHalfProgressBar_Altitude.HeightTitle = 20;
            this.myArcHalfProgressBar_Altitude.MaxminTextHeight = 20;
            this.myArcHalfProgressBar_Altitude.MaxValue = 100;
            this.myArcHalfProgressBar_Altitude.MinValue = 0;
            this.myArcHalfProgressBar_Altitude.Name = "myArcHalfProgressBar_Altitude";
            this.myArcHalfProgressBar_Altitude.PBotton = 25;
            this.myArcHalfProgressBar_Altitude.PFont = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myArcHalfProgressBar_Altitude.PFontColor = System.Drawing.Color.White;
            this.myArcHalfProgressBar_Altitude.Pleft = 5;
            this.myArcHalfProgressBar_Altitude.PProgresBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(124)))), ((int)(((byte)(127)))));
            this.myArcHalfProgressBar_Altitude.PProgresFrontColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(219)))), ((int)(((byte)(70)))));
            this.myArcHalfProgressBar_Altitude.PRight = 5;
            this.myArcHalfProgressBar_Altitude.PText = "0";
            this.myArcHalfProgressBar_Altitude.PTitleFont = new System.Drawing.Font("微软雅黑", 12F);
            this.myArcHalfProgressBar_Altitude.PTop = 25;
            this.myArcHalfProgressBar_Altitude.Pwidth = 16;
            this.myArcHalfProgressBar_Altitude.Startarg = 180;
            this.myArcHalfProgressBar_Altitude.TitleText = "Altitude";
            this.myArcHalfProgressBar_Altitude.UnitText = "M";
            this.myArcHalfProgressBar_Altitude.Value = 0D;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.panel_actions);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_actions
            // 
            this.panel_actions.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            resources.ApplyResources(this.panel_actions, "panel_actions");
            this.panel_actions.Controls.Add(this.myButton4);
            this.panel_actions.Controls.Add(this.modifyandSetLoiterRad);
            this.panel_actions.Controls.Add(this.modifyandSetSpeed);
            this.panel_actions.Controls.Add(this.BUT_ARM);
            this.panel_actions.Controls.Add(this.modifyandSetAlt);
            this.panel_actions.Controls.Add(this.CMB_setwp);
            this.panel_actions.Controls.Add(this.BUT_quickrtl);
            this.panel_actions.Controls.Add(this.BUT_setwp);
            this.panel_actions.Controls.Add(this.BUT_quickauto);
            this.panel_actions.Controls.Add(this.BUT_quickmanual);
            this.panel_actions.Name = "panel_actions";
            // 
            // myButton4
            // 
            this.myButton4.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton4.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton4.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.myButton4, "myButton4");
            this.myButton4.Name = "myButton4";
            this.toolTip1.SetToolTip(this.myButton4, resources.GetString("myButton4.ToolTip"));
            this.myButton4.UseVisualStyleBackColor = true;
            this.myButton4.Click += new System.EventHandler(this.myButton4_Click);
            // 
            // modifyandSetLoiterRad
            // 
            resources.ApplyResources(this.modifyandSetLoiterRad, "modifyandSetLoiterRad");
            this.modifyandSetLoiterRad.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            this.modifyandSetLoiterRad.ButtonText = "Set Loiter Rad";
            this.modifyandSetLoiterRad.DecimalPlaces = 0;
            this.modifyandSetLoiterRad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.modifyandSetLoiterRad.Name = "modifyandSetLoiterRad";
            this.modifyandSetLoiterRad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Click += new System.EventHandler(this.modifyandSetLoiterRad_Click);
            // 
            // modifyandSetSpeed
            // 
            resources.ApplyResources(this.modifyandSetSpeed, "modifyandSetSpeed");
            this.modifyandSetSpeed.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            this.modifyandSetSpeed.ButtonText = "Change Speed";
            this.modifyandSetSpeed.DecimalPlaces = 1;
            this.modifyandSetSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.modifyandSetSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.modifyandSetSpeed.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.modifyandSetSpeed.Name = "modifyandSetSpeed";
            this.modifyandSetSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetSpeed.Click += new System.EventHandler(this.modifyandSetSpeed_Click);
            this.modifyandSetSpeed.ParentChanged += new System.EventHandler(this.modifyandSetSpeed_ParentChanged);
            // 
            // BUT_ARM
            // 
            this.BUT_ARM.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_ARM.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_ARM.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_ARM, "BUT_ARM");
            this.BUT_ARM.Name = "BUT_ARM";
            this.toolTip1.SetToolTip(this.BUT_ARM, resources.GetString("BUT_ARM.ToolTip"));
            this.BUT_ARM.UseVisualStyleBackColor = true;
            this.BUT_ARM.Click += new System.EventHandler(this.BUT_ARM_Click);
            // 
            // modifyandSetAlt
            // 
            resources.ApplyResources(this.modifyandSetAlt, "modifyandSetAlt");
            this.modifyandSetAlt.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            this.modifyandSetAlt.ButtonText = "Change Alt";
            this.modifyandSetAlt.DecimalPlaces = 1;
            this.modifyandSetAlt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.modifyandSetAlt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.modifyandSetAlt.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.modifyandSetAlt.Name = "modifyandSetAlt";
            this.modifyandSetAlt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetAlt.Click += new System.EventHandler(this.modifyandSetAlt_Click);
            // 
            // CMB_setwp
            // 
            this.CMB_setwp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CMB_setwp, "CMB_setwp");
            this.CMB_setwp.FormattingEnabled = true;
            this.CMB_setwp.Items.AddRange(new object[] {
            resources.GetString("CMB_setwp.Items")});
            this.CMB_setwp.Name = "CMB_setwp";
            this.CMB_setwp.Click += new System.EventHandler(this.CMB_setwp_Click);
            // 
            // BUT_quickrtl
            // 
            this.BUT_quickrtl.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickrtl.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickrtl.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_quickrtl, "BUT_quickrtl");
            this.BUT_quickrtl.Name = "BUT_quickrtl";
            this.toolTip1.SetToolTip(this.BUT_quickrtl, resources.GetString("BUT_quickrtl.ToolTip"));
            this.BUT_quickrtl.UseVisualStyleBackColor = true;
            this.BUT_quickrtl.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // BUT_setwp
            // 
            this.BUT_setwp.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_setwp.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_setwp.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_setwp, "BUT_setwp");
            this.BUT_setwp.Name = "BUT_setwp";
            this.toolTip1.SetToolTip(this.BUT_setwp, resources.GetString("BUT_setwp.ToolTip"));
            this.BUT_setwp.UseVisualStyleBackColor = true;
            this.BUT_setwp.Click += new System.EventHandler(this.BUT_setwp_Click);
            // 
            // BUT_quickauto
            // 
            this.BUT_quickauto.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickauto.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickauto.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_quickauto, "BUT_quickauto");
            this.BUT_quickauto.Name = "BUT_quickauto";
            this.toolTip1.SetToolTip(this.BUT_quickauto, resources.GetString("BUT_quickauto.ToolTip"));
            this.BUT_quickauto.UseVisualStyleBackColor = true;
            this.BUT_quickauto.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // BUT_quickmanual
            // 
            this.BUT_quickmanual.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickmanual.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickmanual.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_quickmanual, "BUT_quickmanual");
            this.BUT_quickmanual.Name = "BUT_quickmanual";
            this.toolTip1.SetToolTip(this.BUT_quickmanual, resources.GetString("BUT_quickmanual.ToolTip"));
            this.BUT_quickmanual.UseVisualStyleBackColor = true;
            this.BUT_quickmanual.Click += new System.EventHandler(this.BUT_quickmanual_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.panel_logs);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel_logs
            // 
            this.panel_logs.Controls.Add(this.tableLayoutPaneltlogs);
            this.panel_logs.Controls.Add(this.panel4);
            resources.ApplyResources(this.panel_logs, "panel_logs");
            this.panel_logs.Name = "panel_logs";
            // 
            // tableLayoutPaneltlogs
            // 
            this.tableLayoutPaneltlogs.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            resources.ApplyResources(this.tableLayoutPaneltlogs, "tableLayoutPaneltlogs");
            this.tableLayoutPaneltlogs.Controls.Add(this.panel_speed, 1, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_loadtelem, 0, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_playlog, 0, 1);
            this.tableLayoutPaneltlogs.Name = "tableLayoutPaneltlogs";
            // 
            // panel_speed
            // 
            this.panel_speed.Controls.Add(this.tracklog);
            this.panel_speed.Controls.Add(this.lbl_logpercent);
            resources.ApplyResources(this.panel_speed, "panel_speed");
            this.panel_speed.Name = "panel_speed";
            // 
            // tracklog
            // 
            this.tracklog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.tracklog, "tracklog");
            this.tracklog.Maximum = 100;
            this.tracklog.Name = "tracklog";
            this.tracklog.TickFrequency = 5;
            this.tracklog.Scroll += new System.EventHandler(this.tracklog_Scroll);
            // 
            // lbl_logpercent
            // 
            this.lbl_logpercent.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            resources.ApplyResources(this.lbl_logpercent, "lbl_logpercent");
            this.lbl_logpercent.Name = "lbl_logpercent";
            this.lbl_logpercent.resize = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.BUT_speed10);
            this.panel2.Controls.Add(this.lbl_playbackspeed);
            this.panel2.Controls.Add(this.BUT_speed5);
            this.panel2.Controls.Add(this.BUT_speed2);
            this.panel2.Controls.Add(this.BUT_speed1);
            this.panel2.Controls.Add(this.BUT_speed1_2);
            this.panel2.Controls.Add(this.BUT_speed1_4);
            this.panel2.Controls.Add(this.BUT_speed1_10);
            this.panel2.Name = "panel2";
            // 
            // BUT_speed10
            // 
            this.BUT_speed10.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed10.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed10.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed10, "BUT_speed10");
            this.BUT_speed10.Name = "BUT_speed10";
            this.BUT_speed10.Tag = "10";
            this.BUT_speed10.UseVisualStyleBackColor = true;
            this.BUT_speed10.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // lbl_playbackspeed
            // 
            resources.ApplyResources(this.lbl_playbackspeed, "lbl_playbackspeed");
            this.lbl_playbackspeed.Name = "lbl_playbackspeed";
            this.lbl_playbackspeed.resize = false;
            // 
            // BUT_speed5
            // 
            this.BUT_speed5.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed5.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed5.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed5, "BUT_speed5");
            this.BUT_speed5.Name = "BUT_speed5";
            this.BUT_speed5.Tag = "5";
            this.BUT_speed5.UseVisualStyleBackColor = true;
            this.BUT_speed5.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed2
            // 
            this.BUT_speed2.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed2.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed2.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed2, "BUT_speed2");
            this.BUT_speed2.Name = "BUT_speed2";
            this.BUT_speed2.Tag = "2";
            this.BUT_speed2.UseVisualStyleBackColor = true;
            this.BUT_speed2.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1
            // 
            this.BUT_speed1.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1, "BUT_speed1");
            this.BUT_speed1.Name = "BUT_speed1";
            this.BUT_speed1.Tag = "1";
            this.BUT_speed1.UseVisualStyleBackColor = true;
            this.BUT_speed1.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_2
            // 
            this.BUT_speed1_2.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_2.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_2.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1_2, "BUT_speed1_2");
            this.BUT_speed1_2.Name = "BUT_speed1_2";
            this.BUT_speed1_2.Tag = "0.5";
            this.BUT_speed1_2.UseVisualStyleBackColor = true;
            this.BUT_speed1_2.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_4
            // 
            this.BUT_speed1_4.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_4.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_4.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1_4, "BUT_speed1_4");
            this.BUT_speed1_4.Name = "BUT_speed1_4";
            this.BUT_speed1_4.Tag = "0.25";
            this.BUT_speed1_4.UseVisualStyleBackColor = true;
            this.BUT_speed1_4.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_10
            // 
            this.BUT_speed1_10.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_10.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_10.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1_10, "BUT_speed1_10");
            this.BUT_speed1_10.Name = "BUT_speed1_10";
            this.BUT_speed1_10.Tag = "0.1";
            this.BUT_speed1_10.UseVisualStyleBackColor = true;
            this.BUT_speed1_10.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_loadtelem
            // 
            this.BUT_loadtelem.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_loadtelem, "BUT_loadtelem");
            this.BUT_loadtelem.Name = "BUT_loadtelem";
            this.BUT_loadtelem.UseVisualStyleBackColor = true;
            this.BUT_loadtelem.Click += new System.EventHandler(this.BUT_loadtelem_Click);
            // 
            // BUT_playlog
            // 
            this.BUT_playlog.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_playlog, "BUT_playlog");
            this.BUT_playlog.Name = "BUT_playlog";
            this.BUT_playlog.UseVisualStyleBackColor = true;
            this.BUT_playlog.Click += new System.EventHandler(this.BUT_playlog_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::MissionPlanner.Properties.Resources.bakUI;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.but_bintolog);
            this.panel4.Controls.Add(this.BUT_DFMavlink);
            this.panel4.Controls.Add(this.BUT_log2kml);
            this.panel4.Controls.Add(this.BUT_logbrowse);
            this.panel4.Controls.Add(this.LBL_logfn);
            this.panel4.Name = "panel4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // but_bintolog
            // 
            this.but_bintolog.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_bintolog.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_bintolog.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.but_bintolog, "but_bintolog");
            this.but_bintolog.Name = "but_bintolog";
            this.but_bintolog.UseVisualStyleBackColor = true;
            this.but_bintolog.Click += new System.EventHandler(this.but_bintolog_Click);
            // 
            // BUT_DFMavlink
            // 
            this.BUT_DFMavlink.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_DFMavlink.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_DFMavlink.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_DFMavlink, "BUT_DFMavlink");
            this.BUT_DFMavlink.Name = "BUT_DFMavlink";
            this.BUT_DFMavlink.UseVisualStyleBackColor = true;
            this.BUT_DFMavlink.Click += new System.EventHandler(this.BUT_DFMavlink_Click);
            // 
            // BUT_log2kml
            // 
            this.BUT_log2kml.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_log2kml.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_log2kml.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_log2kml, "BUT_log2kml");
            this.BUT_log2kml.Name = "BUT_log2kml";
            this.BUT_log2kml.UseVisualStyleBackColor = true;
            this.BUT_log2kml.Click += new System.EventHandler(this.BUT_log2kml_Click);
            // 
            // BUT_logbrowse
            // 
            this.BUT_logbrowse.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_logbrowse.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_logbrowse.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_logbrowse, "BUT_logbrowse");
            this.BUT_logbrowse.Name = "BUT_logbrowse";
            this.BUT_logbrowse.UseVisualStyleBackColor = true;
            this.BUT_logbrowse.Click += new System.EventHandler(this.BUT_logbrowse_Click);
            // 
            // LBL_logfn
            // 
            resources.ApplyResources(this.LBL_logfn, "LBL_logfn");
            this.LBL_logfn.Name = "LBL_logfn";
            this.LBL_logfn.resize = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_messagebox);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_messagebox
            // 
            resources.ApplyResources(this.txt_messagebox, "txt_messagebox");
            this.txt_messagebox.Name = "txt_messagebox";
            // 
            // userHSI1
            // 
            this.userHSI1.BackColor = System.Drawing.Color.Transparent;
            this.userHSI1.BackgroundImage = global::MissionPlanner.Properties.Resources.hsiBACK;
            resources.ApplyResources(this.userHSI1, "userHSI1");
            this.userHSI1.DataBindings.Add(new System.Windows.Forms.Binding("heading", this.bindingSourceHud, "yaw", true));
            this.userHSI1.Heading = 0;
            this.userHSI1.Name = "userHSI1";
            this.userHSI1.SetImg = null;
            // 
            // checkListControl1
            // 
            resources.ApplyResources(this.checkListControl1, "checkListControl1");
            this.checkListControl1.Name = "checkListControl1";
            // 
            // servoOptions1
            // 
            resources.ApplyResources(this.servoOptions1, "servoOptions1");
            this.servoOptions1.Name = "servoOptions1";
            this.servoOptions1.thisservo = 5;
            // 
            // servoOptions2
            // 
            resources.ApplyResources(this.servoOptions2, "servoOptions2");
            this.servoOptions2.Name = "servoOptions2";
            this.servoOptions2.thisservo = 6;
            // 
            // servoOptions3
            // 
            resources.ApplyResources(this.servoOptions3, "servoOptions3");
            this.servoOptions3.Name = "servoOptions3";
            this.servoOptions3.thisservo = 7;
            // 
            // servoOptions4
            // 
            resources.ApplyResources(this.servoOptions4, "servoOptions4");
            this.servoOptions4.Name = "servoOptions4";
            this.servoOptions4.thisservo = 8;
            // 
            // servoOptions5
            // 
            resources.ApplyResources(this.servoOptions5, "servoOptions5");
            this.servoOptions5.Name = "servoOptions5";
            this.servoOptions5.thisservo = 9;
            // 
            // servoOptions6
            // 
            resources.ApplyResources(this.servoOptions6, "servoOptions6");
            this.servoOptions6.Name = "servoOptions6";
            this.servoOptions6.thisservo = 10;
            // 
            // servoOptions7
            // 
            resources.ApplyResources(this.servoOptions7, "servoOptions7");
            this.servoOptions7.Name = "servoOptions7";
            this.servoOptions7.thisservo = 11;
            // 
            // servoOptions8
            // 
            resources.ApplyResources(this.servoOptions8, "servoOptions8");
            this.servoOptions8.Name = "servoOptions8";
            this.servoOptions8.thisservo = 12;
            // 
            // servoOptions9
            // 
            resources.ApplyResources(this.servoOptions9, "servoOptions9");
            this.servoOptions9.Name = "servoOptions9";
            this.servoOptions9.thisservo = 13;
            // 
            // servoOptions10
            // 
            resources.ApplyResources(this.servoOptions10, "servoOptions10");
            this.servoOptions10.Name = "servoOptions10";
            this.servoOptions10.thisservo = 14;
            // 
            // relayOptions1
            // 
            resources.ApplyResources(this.relayOptions1, "relayOptions1");
            this.relayOptions1.Name = "relayOptions1";
            this.relayOptions1.thisrelay = 0;
            // 
            // relayOptions2
            // 
            resources.ApplyResources(this.relayOptions2, "relayOptions2");
            this.relayOptions2.Name = "relayOptions2";
            this.relayOptions2.thisrelay = 1;
            // 
            // relayOptions3
            // 
            resources.ApplyResources(this.relayOptions3, "relayOptions3");
            this.relayOptions3.Name = "relayOptions3";
            this.relayOptions3.thisrelay = 2;
            // 
            // relayOptions4
            // 
            resources.ApplyResources(this.relayOptions4, "relayOptions4");
            this.relayOptions4.Name = "relayOptions4";
            this.relayOptions4.thisrelay = 3;
            // 
            // distanceBar1
            // 
            resources.ApplyResources(this.distanceBar1, "distanceBar1");
            this.distanceBar1.BackColor = System.Drawing.Color.Black;
            this.distanceBar1.Name = "distanceBar1";
            this.distanceBar1.totaldist = 100F;
            this.distanceBar1.traveleddist = 0F;
            this.distanceBar1.valuebarcolor = System.Drawing.Color.Empty;
            // 
            // distanceBar2
            // 
            this.distanceBar2.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.distanceBar2, "distanceBar2");
            this.distanceBar2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.distanceBar2.Name = "distanceBar2";
            this.distanceBar2.totaldist = 100F;
            this.distanceBar2.traveleddist = 0F;
            this.distanceBar2.valuebarcolor = System.Drawing.Color.Green;
            // 
            // FlightData
            // 
            this.Controls.Add(this.MainH);
            resources.ApplyResources(this, "$this");
            this.Name = "FlightData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightData_FormClosing);
            this.Load += new System.EventHandler(this.FlightData_Load);
            this.Resize += new System.EventHandler(this.FlightData_Resize);
            this.ParentChanged += new System.EventHandler(this.FlightData_ParentChanged);
            this.MainH.Panel1.ResumeLayout(false);
            this.MainH.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).EndInit();
            this.MainH.ResumeLayout(false);
            this.SubMainLeft.Panel1.ResumeLayout(false);
            this.SubMainLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).EndInit();
            this.SubMainLeft.ResumeLayout(false);
            this.contextMenuStripHud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableMap.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripMap.ResumeLayout(false);
            this.panel_hide.ResumeLayout(false);
            this.panel_hide.PerformLayout();
            this.tabControlactions.ResumeLayout(false);
            this.contextMenuStripactionstab.ResumeLayout(false);
            this.tabQuick.ResumeLayout(false);
            this.tableLayoutPanelQuick.ResumeLayout(false);
            this.contextMenuStripQuickView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).EndInit();
            this.tabActions.ResumeLayout(false);
            this.tabActionsSimple.ResumeLayout(false);
            this.tabPagePreFlight.ResumeLayout(false);
            this.tabGauges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).EndInit();
            this.tabServo.ResumeLayout(false);
            this.flowLayoutPanelServos.ResumeLayout(false);
            this.tablogbrowse.ResumeLayout(false);
            this.tabScripts.ResumeLayout(false);
            this.tabScripts.PerformLayout();
            this.tabPayload.ResumeLayout(false);
            this.groupBoxRoll.ResumeLayout(false);
            this.groupBoxRoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePayloadTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).EndInit();
            this.groupBoxYaw.ResumeLayout(false);
            this.groupBoxYaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYaw)).EndInit();
            this.groupBoxPitch.ResumeLayout(false);
            this.groupBoxPitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_flytrac)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).EndInit();
            this.tabControl_Newactions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel_actions.ResumeLayout(false);
            this.panel_actions.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel_logs.ResumeLayout(false);
            this.tableLayoutPaneltlogs.ResumeLayout(false);
            this.panel_speed.ResumeLayout(false);
            this.panel_speed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

  

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer ZedGraphTimer;
        private System.Windows.Forms.SplitContainer MainH;
        private System.Windows.Forms.SplitContainer SubMainLeft;
        private System.Windows.Forms.ToolStripMenuItem goHereToolStripMenuItem;
        private Controls.HUD hud1;
        private Controls.MyButton BUT_clear_track;
        private System.Windows.Forms.CheckBox CB_tuning;
        private Controls.MyButton BUT_RAWSensor;
        private Controls.MyButton BUTactiondo;
        private Controls.MyButton BUTrestartmission;
        private System.Windows.Forms.ComboBox CMB_action;
        private Controls.MyButton BUT_Homealt;
        private System.Windows.Forms.TrackBar tracklog;
        private Controls.MyButton BUT_playlog;
        private Controls.MyButton BUT_loadtelem;
        private AGaugeApp.AGauge Galt;
        private AGaugeApp.AGauge Gspeed;
        private AGaugeApp.AGauge Gvspeed;
        private System.Windows.Forms.TableLayoutPanel tableMap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Zoomlevel;
        private Controls.MyLabel label1;
        private System.Windows.Forms.CheckBox CHK_autopan;
        public Controls.myGMAP gMapControl1;
        private ZedGraph.ZedGraphControl zg1;
        public System.Windows.Forms.TabControl tabControlactions;
        public System.Windows.Forms.TabPage tabGauges;
        public System.Windows.Forms.TabPage tabStatus;
        public System.Windows.Forms.TabPage tabActions;
        public System.Windows.Forms.TabPage tabTLogs;
        private System.Windows.Forms.ComboBox CMB_modes;
        private Controls.MyButton BUT_setmode;
        private System.Windows.Forms.ComboBox CMB_setwp;
        private Controls.MyButton BUT_setwp;
        private Controls.MyButton BUT_quickmanual;
        private Controls.MyButton BUT_quickrtl;
        private Controls.MyButton BUT_quickauto;
        private Controls.MyButton BUT_log2kml;
        private Controls.MyButton BUT_joystick;
        private System.Windows.Forms.ToolTip toolTip1;
        private Controls.MyLabel lbl_logpercent;
        private System.Windows.Forms.ToolStripMenuItem pointCameraHereToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.MyLabel lbl_hdop;
        private Controls.MyLabel lbl_sats;
        private Controls.HSI Gheading;
        private Controls.MyLabel lbl_playbackspeed;
        private System.Windows.Forms.ToolStripMenuItem setAspectRatioToolStripMenuItem;
        public System.Windows.Forms.TabPage tabQuick;
        private Controls.QuickView quickView3;
        private Controls.QuickView quickView2;
        private Controls.QuickView quickView1;
        private Controls.QuickView quickView4;
        private System.Windows.Forms.ToolStripMenuItem flyToHereAltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightPlannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userItemsToolStripMenuItem;
        //private Crom.Controls.Docking.DockContainer dockContainer1;
        private Controls.MyButton BUT_ARM;
        private Controls.ModifyandSet modifyandSetAlt;
        private Controls.ModifyandSet modifyandSetSpeed;
        private System.Windows.Forms.ToolStripMenuItem triggerCameraToolStripMenuItem;
        private Controls.MyTrackBar TRK_zoom;
        private Controls.MyLabel LBL_logfn;
        public System.Windows.Forms.TabPage tabServo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelServos;
        private Controls.ServoOptions servoOptions1;
        private Controls.ServoOptions servoOptions2;
        private Controls.ServoOptions servoOptions3;
        private Controls.ServoOptions servoOptions4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPaneltlogs;
        private Controls.ServoOptions servoOptions5;
        private Controls.ServoOptions servoOptions6;
        private Controls.ServoOptions servoOptions7;
        private Controls.ServoOptions servoOptions8;
        private Controls.ServoOptions servoOptions9;
        private Controls.ServoOptions servoOptions10;
        private System.Windows.Forms.BindingSource bindingSourceHud;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuick;
        private System.Windows.Forms.Panel panel2;
        private Controls.MyButton BUT_speed10;
        private Controls.MyButton BUT_speed5;
        private Controls.MyButton BUT_speed2;
        private Controls.MyButton BUT_speed1;
        private Controls.MyButton BUT_speed1_2;
        private Controls.MyButton BUT_speed1_4;
        private Controls.MyButton BUT_speed1_10;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabPage tablogbrowse;
        private Controls.MyButton BUT_logbrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TabPage tabScripts;
        private Controls.MyButton BUT_edit_selected;
        private System.Windows.Forms.Label labelSelectedScript;
        private Controls.MyButton BUT_run_script;
        private Controls.MyButton BUT_abort_script;
        private System.Windows.Forms.Label labelScriptStatus;
        private Controls.MyButton BUT_select_script;
        private System.Windows.Forms.OpenFileDialog openScriptDialog;
        private System.Windows.Forms.Timer scriptChecker;
        private System.Windows.Forms.CheckBox checkBoxRedirectOutput;
        private System.Windows.Forms.ToolStripMenuItem russianHudToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripHud;
        private System.Windows.Forms.BindingSource bindingSourceQuickTab;
        private System.Windows.Forms.BindingSource bindingSourceStatusTab;
        private System.Windows.Forms.BindingSource bindingSourceGaugesTab;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem;
        private MissionPlanner.Controls.Coords coords1;
        private Controls.MyButton BUT_matlab;
        private System.Windows.Forms.ComboBox CMB_mountmode;
        private Controls.MyButton BUT_mountmode;
        public Controls.WindDir windDir1;
        private Controls.MyButton but_bintolog;
        private Controls.MyButton but_dflogtokml;
        private Controls.MyButton BUT_DFMavlink;
        public System.Windows.Forms.TabPage tabPagemessages;
        private System.Windows.Forms.TextBox txt_messagebox;
        private System.Windows.Forms.Timer Messagetabtimer;
        public System.Windows.Forms.TabPage tabActionsSimple;
        private Controls.MyButton myButton1;
        private Controls.MyButton myButton2;
        private Controls.MyButton myButton3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripactionstab;
        private Controls.MyButton BUT_loganalysis;
        private System.Windows.Forms.ToolStripMenuItem addPoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private Controls.DistanceBar distanceBar1;
        private System.Windows.Forms.ToolStripMenuItem takeOffToolStripMenuItem;
        private Controls.MyButton BUT_resumemis;
        public System.Windows.Forms.TabPage tabPagePreFlight;
        private Controls.PreFlight.CheckListControl checkListControl1;
        private System.Windows.Forms.ToolStripMenuItem swapWithMapToolStripMenuItem;
        private Controls.MyButton BUT_abortland;
        private Controls.MyButton but_disablejoystick;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordHudToAVIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setMJPEGSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PointCameraCoordsToolStripMenuItem1;
        private Controls.ModifyandSet modifyandSetLoiterRad;
        private System.Windows.Forms.ToolStripMenuItem onOffCameraOverlapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altitudeAngelSettingsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripQuickView;
        private System.Windows.Forms.ToolStripMenuItem setViewCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGStreamerSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEKFHomeHereToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPayload;
        private System.Windows.Forms.BindingSource bindingSourcePayloadTab;
        private System.Windows.Forms.TrackBar trackBarYaw;
        private System.Windows.Forms.TrackBar trackBarRoll;
        private System.Windows.Forms.TrackBar trackBarPitch;
        private Controls.MyButton BUT_resetGimbalPos;
        private System.Windows.Forms.TextBox TXT_gimbalPitchPos;
        private System.Windows.Forms.TextBox TXT_gimbalYawPos;
        private System.Windows.Forms.TextBox TXT_gimbalRollPos;
        private System.Windows.Forms.GroupBox groupBoxRoll;
        private System.Windows.Forms.GroupBox groupBoxYaw;
        private System.Windows.Forms.GroupBox groupBoxPitch;
        private Controls.MyButton BUT_PayloadFolder;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem groundColorToolStripMenuItem;
        private Controls.RelayOptions relayOptions1;
        private Controls.RelayOptions relayOptions2;
        private Controls.RelayOptions relayOptions3;
        private Controls.RelayOptions relayOptions4;
        private System.Windows.Forms.ToolStripMenuItem hereLinkVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gStreamerStopToolStripMenuItem;
        private Controls.MyButton BUT_georefimage;
        private Controls.QuickView quickView6;
        private Controls.QuickView quickView5;
        private System.Windows.Forms.ToolStripMenuItem poiatcoordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flyToCoordsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox_minus;
        private System.Windows.Forms.PictureBox pictureBox_add;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label_VerticalSpeed;
        private System.Windows.Forms.Label label_Battery;
        private System.Windows.Forms.Label label_Altitude;
        private System.Windows.Forms.Label label_Throttle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private My_tablepage tabControl_Newactions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Logs;
        private System.Windows.Forms.Label label_Actions;
        private System.Windows.Forms.Label label_Status;
        private Controls.MyButton myButton4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_speed;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_waypoint;
        private System.Windows.Forms.Label label_Traveled;
        private System.Windows.Forms.Label label_flytime;
        private MyArcBar.MyArcHalfProgressBar myArcHalfProgressBar_Altitude;
        public MyArcBar.MyArcHalfProgressBar myArcHalfProgressBar_Throttle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private BSE.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel_actions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MyArcBar.MyArcHalfProgressBar myArcHalfProgressBar_battery;
        private MyArcBar.MyArcHalfProgressBar myArcHalfProgressBar_VerticalSpeed;
        private System.Windows.Forms.Panel panel_logs;
        private System.Windows.Forms.PictureBox picture_flytrac;
        private System.Windows.Forms.Label label_Messages;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel_hide;
        private Controls.DistanceBar distanceBar2;
        private System.Windows.Forms.Label label_wpnonew;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_DistToHome1;
        private System.Windows.Forms.ToolStripMenuItem deleteCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem follwMeToolStripMenuItem;
        private System.Windows.Forms.Timer timer_check;
        private Controls.UserHSI userHSI1;
    }
}