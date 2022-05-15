﻿using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews
{
    partial class FlightPlanner
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

            if (currentMarker != null) currentMarker.Dispose();
            if (drawnpolygon != null) drawnpolygon.Dispose();
            if (kmlpolygonsoverlay != null) kmlpolygonsoverlay.Dispose();
            if (wppolygon != null) wppolygon.Dispose();
            if (top != null) top.Dispose();
            if (geofencepolygon != null) geofencepolygon.Dispose();
            if (geofenceoverlay != null) geofenceoverlay.Dispose();
            if (drawnpolygonsoverlay != null) drawnpolygonsoverlay.Dispose();
            if (center != null) center.Dispose(); 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightPlanner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CHK_verifyheight = new System.Windows.Forms.CheckBox();
            this.TXT_WPRad = new System.Windows.Forms.TextBox();
            this.TXT_DefaultAlt = new System.Windows.Forms.TextBox();
            this.LBL_WPRad = new System.Windows.Forms.Label();
            this.LBL_defalutalt = new System.Windows.Forms.Label();
            this.TXT_loiterrad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.but_writewpfast = new MissionPlanner.Controls.MyButton();
            this.BUT_Add = new MissionPlanner.Controls.MyButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_wpfile = new System.Windows.Forms.Label();
            this.BUT_write = new MissionPlanner.Controls.MyButton();
            this.BUT_read = new MissionPlanner.Controls.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TXT_homealt = new System.Windows.Forms.TextBox();
            this.TXT_homelng = new System.Windows.Forms.TextBox();
            this.TXT_homelat = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.lbl_status = new System.Windows.Forms.Label();
            this.panelWaypoints = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_grid = new System.Windows.Forms.CheckBox();
            this.lnk_kml = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmb_missiontype = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.but_mincommands = new MissionPlanner.Controls.MyButton();
            this.label11 = new System.Windows.Forms.Label();
            this.CMB_altmode = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new MissionPlanner.Controls.MyTrackBar();
            this.CHK_splinedefault = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_altwarn = new System.Windows.Forms.TextBox();
            this.Commands = new MissionPlanner.Controls.MyDataGridView();
            this.Command = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frame = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.coordZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordEasting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordNorthing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MGRS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelAction = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Commands1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_more = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Homealtitude = new System.Windows.Forms.Label();
            this.number_bufferdist = new System.Windows.Forms.NumericUpDown();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.label7 = new System.Windows.Forms.Label();
            this.myButton4 = new MissionPlanner.Controls.MyButton();
            this.BUT_loadwpfile = new MissionPlanner.Controls.MyButton();
            this.lbl_Homelatitude = new System.Windows.Forms.Label();
            this.BUT_saveWPFile = new MissionPlanner.Controls.MyButton();
            this.lbl_homedist = new System.Windows.Forms.Label();
            this.lbl_Homelongitude = new System.Windows.Forms.Label();
            this.lbl_Altitude = new System.Windows.Forms.Label();
            this.lbl_prevdist = new System.Windows.Forms.Label();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panel_mapset = new System.Windows.Forms.Panel();
            this.pictureBox_homeset = new System.Windows.Forms.PictureBox();
            this.pictureBox_planset = new System.Windows.Forms.PictureBox();
            this.pictureBox_minus = new System.Windows.Forms.PictureBox();
            this.pictureBox_add = new System.Windows.Forms.PictureBox();
            this.checkBox_Reverse_RTL = new System.Windows.Forms.CheckBox();
            this.checkBox_WPRad = new System.Windows.Forms.CheckBox();
            this.panel_zhongche = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel_draw = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pic_AddOne = new System.Windows.Forms.PictureBox();
            this.pic_stand = new System.Windows.Forms.PictureBox();
            this.pic_sort = new System.Windows.Forms.PictureBox();
            this.pic_drawLoad = new System.Windows.Forms.PictureBox();
            this.pic_drawasave = new System.Windows.Forms.PictureBox();
            this.pic_drawadelete = new System.Windows.Forms.PictureBox();
            this.pic_drawadd = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pic_draw = new System.Windows.Forms.PictureBox();
            this.panel_info = new System.Windows.Forms.Panel();
            this.myButton_savedist = new MissionPlanner.Controls.MyButton();
            this.myButton7 = new MissionPlanner.Controls.MyButton();
            this.textBox_dist = new System.Windows.Forms.TextBox();
            this.label_setdist = new System.Windows.Forms.Label();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox_lat = new System.Windows.Forms.TextBox();
            this.label_infoMassion = new System.Windows.Forms.Label();
            this.textBox_p2 = new System.Windows.Forms.TextBox();
            this.label_lat = new System.Windows.Forms.Label();
            this.label_p4 = new System.Windows.Forms.Label();
            this.textBox_p3 = new System.Windows.Forms.TextBox();
            this.label_p1 = new System.Windows.Forms.Label();
            this.textBox_p4 = new System.Windows.Forms.TextBox();
            this.label_p3 = new System.Windows.Forms.Label();
            this.textBox_lon = new System.Windows.Forms.TextBox();
            this.label_lon = new System.Windows.Forms.Label();
            this.label_p2 = new System.Windows.Forms.Label();
            this.textBox_p1 = new System.Windows.Forms.TextBox();
            this.MainMap = new MissionPlanner.Controls.myGMAP();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.relativeRouteEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftedAndRotatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wholeBodyMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertWpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSplineWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterForeverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitertimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitercirclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpstartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpwPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolygonPointToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPolygonToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPolygonToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSHPToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.geoFenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoFenceuploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoFencedownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setReturnLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRallyPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createWpCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSplineCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCircleSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surveyGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchWPPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMLOverlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevationGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseWPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLoadSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndAppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSHPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poiaddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poideleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poieditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackerHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterUTMCoordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchDockingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteLandingSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolygonPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenceInclusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenceExclusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBASE = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripPoly = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawAPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripZoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zoomToVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelWaypoints.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).BeginInit();
            this.panelAction.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Commands1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_bufferdist)).BeginInit();
            this.panelMap.SuspendLayout();
            this.panel_mapset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_homeset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_planset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add)).BeginInit();
            this.panel_zhongche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel_draw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AddOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_stand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drawLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drawasave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drawadelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drawadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_draw)).BeginInit();
            this.panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelBASE.SuspendLayout();
            this.contextMenuStripPoly.SuspendLayout();
            this.contextMenuStripZoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // CHK_verifyheight
            // 
            resources.ApplyResources(this.CHK_verifyheight, "CHK_verifyheight");
            this.CHK_verifyheight.Name = "CHK_verifyheight";
            this.CHK_verifyheight.UseVisualStyleBackColor = true;
            // 
            // TXT_WPRad
            // 
            resources.ApplyResources(this.TXT_WPRad, "TXT_WPRad");
            this.TXT_WPRad.Name = "TXT_WPRad";
            this.TXT_WPRad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_WPRad_KeyPress);
            this.TXT_WPRad.Leave += new System.EventHandler(this.TXT_WPRad_Leave);
            // 
            // TXT_DefaultAlt
            // 
            resources.ApplyResources(this.TXT_DefaultAlt, "TXT_DefaultAlt");
            this.TXT_DefaultAlt.Name = "TXT_DefaultAlt";
            this.TXT_DefaultAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_DefaultAlt_KeyPress);
            this.TXT_DefaultAlt.Leave += new System.EventHandler(this.TXT_DefaultAlt_Leave);
            // 
            // LBL_WPRad
            // 
            resources.ApplyResources(this.LBL_WPRad, "LBL_WPRad");
            this.LBL_WPRad.Name = "LBL_WPRad";
            // 
            // LBL_defalutalt
            // 
            resources.ApplyResources(this.LBL_defalutalt, "LBL_defalutalt");
            this.LBL_defalutalt.Name = "LBL_defalutalt";
            // 
            // TXT_loiterrad
            // 
            resources.ApplyResources(this.TXT_loiterrad, "TXT_loiterrad");
            this.TXT_loiterrad.Name = "TXT_loiterrad";
            this.TXT_loiterrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_loiterrad_KeyPress);
            this.TXT_loiterrad.Leave += new System.EventHandler(this.TXT_loiterrad_Leave);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.but_writewpfast);
            this.panel5.Controls.Add(this.BUT_Add);
            this.panel5.Controls.Add(this.panel2);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // but_writewpfast
            // 
            resources.ApplyResources(this.but_writewpfast, "but_writewpfast");
            this.but_writewpfast.Name = "but_writewpfast";
            this.but_writewpfast.UseVisualStyleBackColor = true;
            this.but_writewpfast.Click += new System.EventHandler(this.but_writewpfast_Click);
            // 
            // BUT_Add
            // 
            resources.ApplyResources(this.BUT_Add, "BUT_Add");
            this.BUT_Add.Name = "BUT_Add";
            this.toolTip1.SetToolTip(this.BUT_Add, resources.GetString("BUT_Add.ToolTip"));
            this.BUT_Add.UseVisualStyleBackColor = true;
            this.BUT_Add.Click += new System.EventHandler(this.BUT_Add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_wpfile);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbl_wpfile
            // 
            resources.ApplyResources(this.lbl_wpfile, "lbl_wpfile");
            this.lbl_wpfile.Name = "lbl_wpfile";
            // 
            // BUT_write
            // 
            this.BUT_write.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BUT_write, "BUT_write");
            this.BUT_write.Name = "BUT_write";
            this.BUT_write.UseVisualStyleBackColor = true;
            this.BUT_write.Click += new System.EventHandler(this.BUT_write_Click);
            // 
            // BUT_read
            // 
            this.BUT_read.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BUT_read, "BUT_read");
            this.BUT_read.Name = "BUT_read";
            this.BUT_read.UseVisualStyleBackColor = true;
            this.BUT_read.Click += new System.EventHandler(this.BUT_read_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.TabStop = true;
            this.label4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label4_LinkClicked);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.Name = "Label1";
            // 
            // TXT_homealt
            // 
            resources.ApplyResources(this.TXT_homealt, "TXT_homealt");
            this.TXT_homealt.Name = "TXT_homealt";
            this.TXT_homealt.TextChanged += new System.EventHandler(this.TXT_homealt_TextChanged);
            // 
            // TXT_homelng
            // 
            resources.ApplyResources(this.TXT_homelng, "TXT_homelng");
            this.TXT_homelng.Name = "TXT_homelng";
            this.TXT_homelng.TextChanged += new System.EventHandler(this.TXT_homelng_TextChanged);
            // 
            // TXT_homelat
            // 
            resources.ApplyResources(this.TXT_homelat, "TXT_homelat");
            this.TXT_homelat.Name = "TXT_homelat";
            this.TXT_homelat.TextChanged += new System.EventHandler(this.TXT_homelat_TextChanged);
            this.TXT_homelat.Enter += new System.EventHandler(this.TXT_homelat_Enter);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltSource = "";
            this.coords1.AltUnit = "m";
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.Name = "coords1";
            this.coords1.Vertical = true;
            this.coords1.SystemChanged += new System.EventHandler(this.coords1_SystemChanged);
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            // 
            // panelWaypoints
            // 
            this.panelWaypoints.Controls.Add(this.panel3);
            this.panelWaypoints.Controls.Add(this.flowLayoutPanel1);
            this.panelWaypoints.Controls.Add(this.coords1);
            this.panelWaypoints.Controls.Add(this.cmb_missiontype);
            this.panelWaypoints.Controls.Add(this.panel1);
            this.panelWaypoints.Controls.Add(this.panel4);
            this.panelWaypoints.Controls.Add(this.but_mincommands);
            this.panelWaypoints.Controls.Add(this.label11);
            this.panelWaypoints.Controls.Add(this.CMB_altmode);
            this.panelWaypoints.Controls.Add(this.trackBar1);
            this.panelWaypoints.Controls.Add(this.panel5);
            this.panelWaypoints.Controls.Add(this.CHK_splinedefault);
            this.panelWaypoints.Controls.Add(this.label17);
            this.panelWaypoints.Controls.Add(this.TXT_altwarn);
            this.panelWaypoints.Controls.Add(this.LBL_WPRad);
            this.panelWaypoints.Controls.Add(this.label5);
            this.panelWaypoints.Controls.Add(this.TXT_loiterrad);
            this.panelWaypoints.Controls.Add(this.Commands);
            this.panelWaypoints.Controls.Add(this.CHK_verifyheight);
            this.panelWaypoints.Controls.Add(this.TXT_WPRad);
            resources.ApplyResources(this.panelWaypoints, "panelWaypoints");
            this.panelWaypoints.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelWaypoints.Name = "panelWaypoints";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chk_grid);
            this.panel3.Controls.Add(this.lbl_status);
            this.panel3.Controls.Add(this.lnk_kml);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // chk_grid
            // 
            resources.ApplyResources(this.chk_grid, "chk_grid");
            this.chk_grid.Name = "chk_grid";
            this.chk_grid.UseVisualStyleBackColor = true;
            this.chk_grid.CheckedChanged += new System.EventHandler(this.chk_grid_CheckedChanged);
            // 
            // lnk_kml
            // 
            resources.ApplyResources(this.lnk_kml, "lnk_kml");
            this.lnk_kml.Name = "lnk_kml";
            this.lnk_kml.TabStop = true;
            this.lnk_kml.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_kml_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // cmb_missiontype
            // 
            resources.ApplyResources(this.cmb_missiontype, "cmb_missiontype");
            this.cmb_missiontype.FormattingEnabled = true;
            this.cmb_missiontype.Items.AddRange(new object[] {
            resources.GetString("cmb_missiontype.Items"),
            resources.GetString("cmb_missiontype.Items1"),
            resources.GetString("cmb_missiontype.Items2")});
            this.cmb_missiontype.Name = "cmb_missiontype";
            this.cmb_missiontype.SelectedIndexChanged += new System.EventHandler(this.Cmb_missiontype_SelectedIndexChanged);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // but_mincommands
            // 
            resources.ApplyResources(this.but_mincommands, "but_mincommands");
            this.but_mincommands.Name = "but_mincommands";
            this.but_mincommands.UseVisualStyleBackColor = true;
            this.but_mincommands.Click += new System.EventHandler(this.but_mincommands_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // CMB_altmode
            // 
            this.CMB_altmode.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_altmode, "CMB_altmode");
            this.CMB_altmode.Name = "CMB_altmode";
            this.CMB_altmode.SelectedIndexChanged += new System.EventHandler(this.CMB_altmode_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.LargeChange = 0.005F;
            this.trackBar1.Maximum = 24F;
            this.trackBar1.Minimum = 1F;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.SmallChange = 0.001F;
            this.trackBar1.TickFrequency = 1F;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 2F;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // CHK_splinedefault
            // 
            resources.ApplyResources(this.CHK_splinedefault, "CHK_splinedefault");
            this.CHK_splinedefault.Name = "CHK_splinedefault";
            this.CHK_splinedefault.UseVisualStyleBackColor = true;
            this.CHK_splinedefault.CheckedChanged += new System.EventHandler(this.CHK_splinedefault_CheckedChanged);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // TXT_altwarn
            // 
            resources.ApplyResources(this.TXT_altwarn, "TXT_altwarn");
            this.TXT_altwarn.Name = "TXT_altwarn";
            // 
            // Commands
            // 
            this.Commands.AllowUserToAddRows = false;
            resources.ApplyResources(this.Commands, "Commands");
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Commands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.Param1,
            this.Param2,
            this.Param3,
            this.Param4,
            this.Lat,
            this.Lon,
            this.Alt,
            this.Frame,
            this.coordZone,
            this.coordEasting,
            this.coordNorthing,
            this.MGRS,
            this.Delete,
            this.Up,
            this.Down,
            this.Grad,
            this.Angle,
            this.Dist,
            this.AZ,
            this.TagData});
            this.Commands.Name = "Commands";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Commands.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Commands.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Commands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellContentClick);
            this.Commands.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellEndEdit);
            this.Commands.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Commands_DataError);
            this.Commands.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.Commands_DefaultValuesNeeded);
            this.Commands.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Commands_EditingControlShowing);
            this.Commands.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_RowEnter);
            this.Commands.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Commands_RowsAdded);
            this.Commands.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Commands_RowsRemoved);
            this.Commands.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Commands_RowValidating);
            // 
            // Command
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Command.DefaultCellStyle = dataGridViewCellStyle4;
            this.Command.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            resources.ApplyResources(this.Command, "Command");
            this.Command.Name = "Command";
            // 
            // Param1
            // 
            resources.ApplyResources(this.Param1, "Param1");
            this.Param1.Name = "Param1";
            this.Param1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param2
            // 
            resources.ApplyResources(this.Param2, "Param2");
            this.Param2.Name = "Param2";
            this.Param2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param3
            // 
            resources.ApplyResources(this.Param3, "Param3");
            this.Param3.Name = "Param3";
            this.Param3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param4
            // 
            resources.ApplyResources(this.Param4, "Param4");
            this.Param4.Name = "Param4";
            this.Param4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lat
            // 
            resources.ApplyResources(this.Lat, "Lat");
            this.Lat.Name = "Lat";
            this.Lat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lon
            // 
            resources.ApplyResources(this.Lon, "Lon");
            this.Lon.Name = "Lon";
            this.Lon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Alt
            // 
            resources.ApplyResources(this.Alt, "Alt");
            this.Alt.Name = "Alt";
            this.Alt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Frame
            // 
            resources.ApplyResources(this.Frame, "Frame");
            this.Frame.Name = "Frame";
            // 
            // coordZone
            // 
            resources.ApplyResources(this.coordZone, "coordZone");
            this.coordZone.Name = "coordZone";
            // 
            // coordEasting
            // 
            resources.ApplyResources(this.coordEasting, "coordEasting");
            this.coordEasting.Name = "coordEasting";
            // 
            // coordNorthing
            // 
            resources.ApplyResources(this.coordNorthing, "coordNorthing");
            this.coordNorthing.Name = "coordNorthing";
            // 
            // MGRS
            // 
            resources.ApplyResources(this.MGRS, "MGRS");
            this.MGRS.Name = "MGRS";
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            // 
            // Up
            // 
            this.Up.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.Up, "Up");
            this.Up.Image = ((System.Drawing.Image)(resources.GetObject("Up.Image")));
            this.Up.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Up.Name = "Up";
            // 
            // Down
            // 
            this.Down.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.Down, "Down");
            this.Down.Image = ((System.Drawing.Image)(resources.GetObject("Down.Image")));
            this.Down.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Down.Name = "Down";
            // 
            // Grad
            // 
            resources.ApplyResources(this.Grad, "Grad");
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Angle
            // 
            resources.ApplyResources(this.Angle, "Angle");
            this.Angle.Name = "Angle";
            this.Angle.ReadOnly = true;
            this.Angle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dist
            // 
            resources.ApplyResources(this.Dist, "Dist");
            this.Dist.Name = "Dist";
            this.Dist.ReadOnly = true;
            this.Dist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AZ
            // 
            resources.ApplyResources(this.AZ, "AZ");
            this.AZ.Name = "AZ";
            this.AZ.ReadOnly = true;
            this.AZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TagData
            // 
            resources.ApplyResources(this.TagData, "TagData");
            this.TagData.Name = "TagData";
            this.TagData.ReadOnly = true;
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.panel7);
            this.panelAction.Controls.Add(this.panel6);
            this.panelAction.Controls.Add(this.lbl_prevdist);
            resources.ApplyResources(this.panelAction, "panelAction");
            this.panelAction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAction.Name = "panelAction";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Commands1);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // Commands1
            // 
            this.Commands1.AllowUserToAddRows = false;
            this.Commands1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Commands1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            resources.ApplyResources(this.Commands1, "Commands1");
            this.Commands1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.Column_more,
            this.dataGridViewImageColumn3});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Commands1.DefaultCellStyle = dataGridViewCellStyle13;
            this.Commands1.Name = "Commands1";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = "0";
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Commands1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.Commands1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.Commands1.ShowCellToolTips = false;
            this.Commands1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands1_CellContentClick);
            this.Commands1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands1_CellEndEdit);
            this.Commands1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands1_CellMouseLeave);
            this.Commands1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Commands1_DataError);
            this.Commands1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.Commands1_RowPrePaint);
            this.Commands1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.Commands1_RowStateChanged);
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            this.dataGridViewComboBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewComboBoxColumn1.FillWeight = 200F;
            this.dataGridViewComboBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.dataGridViewComboBoxColumn1, "dataGridViewComboBoxColumn1");
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_more
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.NullValue = null;
            this.Column_more.DefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.Column_more, "Column_more");
            this.Column_more.Image = global::MissionPlanner.Properties.Resources.more72;
            this.Column_more.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column_more.Name = "Column_more";
            this.Column_more.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            resources.ApplyResources(this.dataGridViewImageColumn3, "dataGridViewImageColumn3");
            this.dataGridViewImageColumn3.Image = global::MissionPlanner.Properties.Resources.Delete_Index;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel9
            // 
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // panel8
            // 
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.lbl_Homealtitude);
            this.panel6.Controls.Add(this.number_bufferdist);
            this.panel6.Controls.Add(this.myButton1);
            this.panel6.Controls.Add(this.lbl_distance);
            this.panel6.Controls.Add(this.myButton2);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.myButton4);
            this.panel6.Controls.Add(this.TXT_DefaultAlt);
            this.panel6.Controls.Add(this.LBL_defalutalt);
            this.panel6.Controls.Add(this.BUT_loadwpfile);
            this.panel6.Controls.Add(this.lbl_Homelatitude);
            this.panel6.Controls.Add(this.BUT_saveWPFile);
            this.panel6.Controls.Add(this.BUT_write);
            this.panel6.Controls.Add(this.lbl_homedist);
            this.panel6.Controls.Add(this.BUT_read);
            this.panel6.Controls.Add(this.lbl_Homelongitude);
            this.panel6.Controls.Add(this.TXT_homelat);
            this.panel6.Controls.Add(this.TXT_homelng);
            this.panel6.Controls.Add(this.TXT_homealt);
            this.panel6.Controls.Add(this.lbl_Altitude);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel10.Controls.Add(this.label8);
            this.panel10.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            this.panel10.Click += new System.EventHandler(this.panel10_Click);
            this.panel10.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            this.panel10.MouseLeave += new System.EventHandler(this.panel10_MouseLeave);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.panel10_Click);
            this.label8.Paint += new System.Windows.Forms.PaintEventHandler(this.label8_Paint);
            this.label8.MouseEnter += new System.EventHandler(this.panel10_MouseEnter);
            // 
            // lbl_Homealtitude
            // 
            resources.ApplyResources(this.lbl_Homealtitude, "lbl_Homealtitude");
            this.lbl_Homealtitude.Name = "lbl_Homealtitude";
            // 
            // number_bufferdist
            // 
            resources.ApplyResources(this.number_bufferdist, "number_bufferdist");
            this.number_bufferdist.Maximum = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.number_bufferdist.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.number_bufferdist.Name = "number_bufferdist";
            this.number_bufferdist.Value = new decimal(new int[] {
            140,
            0,
            0,
            0});
            // 
            // myButton1
            // 
            this.myButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.Name = "myButton1";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // lbl_distance
            // 
            resources.ApplyResources(this.lbl_distance, "lbl_distance");
            this.lbl_distance.Name = "lbl_distance";
            // 
            // myButton2
            // 
            this.myButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.Name = "myButton2";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // myButton4
            // 
            this.myButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.myButton4, "myButton4");
            this.myButton4.Name = "myButton4";
            this.myButton4.UseVisualStyleBackColor = true;
            this.myButton4.Click += new System.EventHandler(this.myButton4_Click);
            // 
            // BUT_loadwpfile
            // 
            this.BUT_loadwpfile.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BUT_loadwpfile, "BUT_loadwpfile");
            this.BUT_loadwpfile.Name = "BUT_loadwpfile";
            this.BUT_loadwpfile.UseVisualStyleBackColor = true;
            this.BUT_loadwpfile.Click += new System.EventHandler(this.BUT_loadwpfile_Click);
            // 
            // lbl_Homelatitude
            // 
            resources.ApplyResources(this.lbl_Homelatitude, "lbl_Homelatitude");
            this.lbl_Homelatitude.Name = "lbl_Homelatitude";
            // 
            // BUT_saveWPFile
            // 
            this.BUT_saveWPFile.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BUT_saveWPFile, "BUT_saveWPFile");
            this.BUT_saveWPFile.Name = "BUT_saveWPFile";
            this.BUT_saveWPFile.UseVisualStyleBackColor = true;
            this.BUT_saveWPFile.Click += new System.EventHandler(this.BUT_saveWPFile_Click);
            // 
            // lbl_homedist
            // 
            resources.ApplyResources(this.lbl_homedist, "lbl_homedist");
            this.lbl_homedist.Name = "lbl_homedist";
            // 
            // lbl_Homelongitude
            // 
            resources.ApplyResources(this.lbl_Homelongitude, "lbl_Homelongitude");
            this.lbl_Homelongitude.Name = "lbl_Homelongitude";
            // 
            // lbl_Altitude
            // 
            resources.ApplyResources(this.lbl_Altitude, "lbl_Altitude");
            this.lbl_Altitude.Name = "lbl_Altitude";
            // 
            // lbl_prevdist
            // 
            resources.ApplyResources(this.lbl_prevdist, "lbl_prevdist");
            this.lbl_prevdist.Name = "lbl_prevdist";
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxMapType, "comboBoxMapType");
            this.comboBoxMapType.FormattingEnabled = true;
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.toolTip1.SetToolTip(this.comboBoxMapType, resources.GetString("comboBoxMapType.ToolTip"));
            // 
            // splitter2
            // 
            resources.ApplyResources(this.splitter2, "splitter2");
            this.splitter2.Name = "splitter2";
            this.splitter2.TabStop = false;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.panel_mapset);
            this.panelMap.Controls.Add(this.pictureBox_minus);
            this.panelMap.Controls.Add(this.pictureBox_add);
            this.panelMap.Controls.Add(this.checkBox_Reverse_RTL);
            this.panelMap.Controls.Add(this.checkBox_WPRad);
            this.panelMap.Controls.Add(this.panel_zhongche);
            this.panelMap.Controls.Add(this.comboBoxMapType);
            this.panelMap.Controls.Add(this.panel_draw);
            this.panelMap.Controls.Add(this.panel_info);
            this.panelMap.Controls.Add(this.MainMap);
            resources.ApplyResources(this.panelMap, "panelMap");
            this.panelMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMap.Name = "panelMap";
            this.panelMap.Resize += new System.EventHandler(this.panelMap_Resize);
            // 
            // panel_mapset
            // 
            this.panel_mapset.BackgroundImage = global::MissionPlanner.Properties.Resources.MissionplannHomeback;
            resources.ApplyResources(this.panel_mapset, "panel_mapset");
            this.panel_mapset.Controls.Add(this.pictureBox_homeset);
            this.panel_mapset.Controls.Add(this.pictureBox_planset);
            this.panel_mapset.Name = "panel_mapset";
            // 
            // pictureBox_homeset
            // 
            this.pictureBox_homeset.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_homeset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_homeset.Image = global::MissionPlanner.Properties.Resources.MissionplannHomeNOMO;
            resources.ApplyResources(this.pictureBox_homeset, "pictureBox_homeset");
            this.pictureBox_homeset.Name = "pictureBox_homeset";
            this.pictureBox_homeset.TabStop = false;
            this.pictureBox_homeset.Click += new System.EventHandler(this.pictureBox_homeset_Click);
            this.pictureBox_homeset.MouseEnter += new System.EventHandler(this.pictureBox_homeset_MouseEnter);
            this.pictureBox_homeset.MouseLeave += new System.EventHandler(this.pictureBox_homeset_MouseLeave);
            // 
            // pictureBox_planset
            // 
            this.pictureBox_planset.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_planset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_planset.Image = global::MissionPlanner.Properties.Resources.MissionplannHomeflayNomo;
            resources.ApplyResources(this.pictureBox_planset, "pictureBox_planset");
            this.pictureBox_planset.Name = "pictureBox_planset";
            this.pictureBox_planset.TabStop = false;
            this.pictureBox_planset.Click += new System.EventHandler(this.pictureBox_planset_Click);
            this.pictureBox_planset.MouseEnter += new System.EventHandler(this.pictureBox_planset_MouseEnter);
            this.pictureBox_planset.MouseLeave += new System.EventHandler(this.pictureBox_planset_MouseLeave);
            // 
            // pictureBox_minus
            // 
            this.pictureBox_minus.BackColor = System.Drawing.Color.Transparent;
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
            this.pictureBox_add.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_add.Image = global::MissionPlanner.Properties.Resources.addMouseNomo;
            resources.ApplyResources(this.pictureBox_add, "pictureBox_add");
            this.pictureBox_add.Name = "pictureBox_add";
            this.pictureBox_add.TabStop = false;
            this.pictureBox_add.Click += new System.EventHandler(this.pictureBox_add_Click);
            this.pictureBox_add.MouseEnter += new System.EventHandler(this.pictureBox_add_MouseEnter);
            this.pictureBox_add.MouseLeave += new System.EventHandler(this.pictureBox_add_MouseLeave);
            // 
            // checkBox_Reverse_RTL
            // 
            resources.ApplyResources(this.checkBox_Reverse_RTL, "checkBox_Reverse_RTL");
            this.checkBox_Reverse_RTL.ForeColor = System.Drawing.Color.Red;
            this.checkBox_Reverse_RTL.Name = "checkBox_Reverse_RTL";
            this.checkBox_Reverse_RTL.UseVisualStyleBackColor = true;
            // 
            // checkBox_WPRad
            // 
            resources.ApplyResources(this.checkBox_WPRad, "checkBox_WPRad");
            this.checkBox_WPRad.ForeColor = System.Drawing.Color.Red;
            this.checkBox_WPRad.Name = "checkBox_WPRad";
            this.checkBox_WPRad.UseVisualStyleBackColor = true;
            this.checkBox_WPRad.CheckedChanged += new System.EventHandler(this.checkBox_WPRad_CheckedChanged);
            // 
            // panel_zhongche
            // 
            this.panel_zhongche.Controls.Add(this.pictureBox7);
            this.panel_zhongche.Controls.Add(this.pic_AddOne);
            this.panel_zhongche.Controls.Add(this.pictureBox8);
            this.panel_zhongche.Controls.Add(this.pic_stand);
            this.panel_zhongche.Controls.Add(this.treeView1);
            resources.ApplyResources(this.panel_zhongche, "panel_zhongche");
            this.panel_zhongche.Name = "panel_zhongche";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MissionPlanner.Properties.Resources.close_474;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MissionPlanner.Properties.Resources.menubak;
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // treeView1
            // 
            resources.ApplyResources(this.treeView1, "treeView1");
            this.treeView1.Name = "treeView1";
            // 
            // panel_draw
            // 
            this.panel_draw.BackColor = System.Drawing.Color.Black;
            this.panel_draw.Controls.Add(this.pictureBox9);
            this.panel_draw.Controls.Add(this.pic_sort);
            this.panel_draw.Controls.Add(this.pic_drawLoad);
            this.panel_draw.Controls.Add(this.pic_drawasave);
            this.panel_draw.Controls.Add(this.pic_drawadelete);
            this.panel_draw.Controls.Add(this.pic_drawadd);
            this.panel_draw.Controls.Add(this.pictureBox6);
            this.panel_draw.Controls.Add(this.pic_draw);
            this.panel_draw.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel_draw, "panel_draw");
            this.panel_draw.Name = "panel_draw";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::MissionPlanner.Properties.Resources.listwp;
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox9, resources.GetString("pictureBox9.ToolTip"));
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            this.pictureBox9.MouseEnter += new System.EventHandler(this.pictureBox9_MouseEnter);
            this.pictureBox9.MouseLeave += new System.EventHandler(this.pictureBox9_MouseLeave);
            // 
            // pic_AddOne
            // 
            this.pic_AddOne.BackColor = System.Drawing.Color.Transparent;
            this.pic_AddOne.Image = global::MissionPlanner.Properties.Resources.Polygon_AddOne;
            resources.ApplyResources(this.pic_AddOne, "pic_AddOne");
            this.pic_AddOne.Name = "pic_AddOne";
            this.pic_AddOne.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_AddOne, resources.GetString("pic_AddOne.ToolTip"));
            this.pic_AddOne.Click += new System.EventHandler(this.pic_AddOne_Click);
            this.pic_AddOne.MouseEnter += new System.EventHandler(this.pic_AddOne_MouseEnter);
            this.pic_AddOne.MouseLeave += new System.EventHandler(this.pic_AddOne_MouseLeave);
            // 
            // pic_stand
            // 
            this.pic_stand.BackColor = System.Drawing.Color.Transparent;
            this.pic_stand.Image = global::MissionPlanner.Properties.Resources.Polygon_Stand;
            resources.ApplyResources(this.pic_stand, "pic_stand");
            this.pic_stand.Name = "pic_stand";
            this.pic_stand.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_stand, resources.GetString("pic_stand.ToolTip"));
            this.pic_stand.Click += new System.EventHandler(this.pic_stand_Click);
            this.pic_stand.MouseEnter += new System.EventHandler(this.pic_stand_MouseEnter);
            this.pic_stand.MouseLeave += new System.EventHandler(this.pic_stand_MouseLeave);
            // 
            // pic_sort
            // 
            this.pic_sort.BackColor = System.Drawing.Color.Transparent;
            this.pic_sort.Image = global::MissionPlanner.Properties.Resources.Polygon_sort;
            resources.ApplyResources(this.pic_sort, "pic_sort");
            this.pic_sort.Name = "pic_sort";
            this.pic_sort.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_sort, resources.GetString("pic_sort.ToolTip"));
            this.pic_sort.Click += new System.EventHandler(this.pic_sort_Click);
            this.pic_sort.MouseEnter += new System.EventHandler(this.pic_sort_MouseEnter);
            this.pic_sort.MouseLeave += new System.EventHandler(this.pic_sort_MouseLeave);
            // 
            // pic_drawLoad
            // 
            this.pic_drawLoad.BackColor = System.Drawing.Color.Transparent;
            this.pic_drawLoad.Image = global::MissionPlanner.Properties.Resources.Polygon;
            resources.ApplyResources(this.pic_drawLoad, "pic_drawLoad");
            this.pic_drawLoad.Name = "pic_drawLoad";
            this.pic_drawLoad.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_drawLoad, resources.GetString("pic_drawLoad.ToolTip"));
            this.pic_drawLoad.Click += new System.EventHandler(this.pic_drawLoad_Click);
            this.pic_drawLoad.MouseEnter += new System.EventHandler(this.pic_drawLoad_MouseEnter);
            this.pic_drawLoad.MouseLeave += new System.EventHandler(this.pic_drawLoad_MouseLeave);
            // 
            // pic_drawasave
            // 
            this.pic_drawasave.BackColor = System.Drawing.Color.Transparent;
            this.pic_drawasave.Image = global::MissionPlanner.Properties.Resources.Polygonsave;
            resources.ApplyResources(this.pic_drawasave, "pic_drawasave");
            this.pic_drawasave.Name = "pic_drawasave";
            this.pic_drawasave.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_drawasave, resources.GetString("pic_drawasave.ToolTip"));
            this.pic_drawasave.Click += new System.EventHandler(this.pic_drawasave_Click);
            this.pic_drawasave.MouseEnter += new System.EventHandler(this.pic_drawasave_MouseEnter);
            this.pic_drawasave.MouseLeave += new System.EventHandler(this.pic_drawasave_MouseLeave);
            // 
            // pic_drawadelete
            // 
            this.pic_drawadelete.BackColor = System.Drawing.Color.Transparent;
            this.pic_drawadelete.Image = global::MissionPlanner.Properties.Resources.PolygonDel;
            resources.ApplyResources(this.pic_drawadelete, "pic_drawadelete");
            this.pic_drawadelete.Name = "pic_drawadelete";
            this.pic_drawadelete.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_drawadelete, resources.GetString("pic_drawadelete.ToolTip"));
            this.pic_drawadelete.Click += new System.EventHandler(this.pic_drawadelete_Click);
            this.pic_drawadelete.MouseEnter += new System.EventHandler(this.pic_drawadelete_MouseEnter);
            this.pic_drawadelete.MouseLeave += new System.EventHandler(this.pic_drawadelete_MouseLeave);
            // 
            // pic_drawadd
            // 
            this.pic_drawadd.BackColor = System.Drawing.Color.Transparent;
            this.pic_drawadd.Image = global::MissionPlanner.Properties.Resources.Polygonadd;
            resources.ApplyResources(this.pic_drawadd, "pic_drawadd");
            this.pic_drawadd.Name = "pic_drawadd";
            this.pic_drawadd.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_drawadd, resources.GetString("pic_drawadd.ToolTip"));
            this.pic_drawadd.Click += new System.EventHandler(this.pic_drawadd_Click);
            this.pic_drawadd.MouseEnter += new System.EventHandler(this.pic_drawadd_MouseEnter);
            this.pic_drawadd.MouseLeave += new System.EventHandler(this.pic_drawadd_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MissionPlanner.Properties.Resources.close_474;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, resources.GetString("pictureBox6.ToolTip"));
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pic_draw
            // 
            this.pic_draw.BackColor = System.Drawing.Color.Transparent;
            this.pic_draw.Image = global::MissionPlanner.Properties.Resources.PolygondrawWP;
            resources.ApplyResources(this.pic_draw, "pic_draw");
            this.pic_draw.Name = "pic_draw";
            this.pic_draw.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_draw, resources.GetString("pic_draw.ToolTip"));
            this.pic_draw.Click += new System.EventHandler(this.pic_draw_Click);
            this.pic_draw.MouseEnter += new System.EventHandler(this.pic_draw_MouseEnter);
            this.pic_draw.MouseLeave += new System.EventHandler(this.pic_draw_MouseLeave);
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_info.Controls.Add(this.myButton_savedist);
            this.panel_info.Controls.Add(this.myButton7);
            this.panel_info.Controls.Add(this.textBox_dist);
            this.panel_info.Controls.Add(this.label_setdist);
            this.panel_info.Controls.Add(this.label_head);
            this.panel_info.Controls.Add(this.pictureBox5);
            this.panel_info.Controls.Add(this.textBox_lat);
            this.panel_info.Controls.Add(this.label_infoMassion);
            this.panel_info.Controls.Add(this.textBox_p2);
            this.panel_info.Controls.Add(this.label_lat);
            this.panel_info.Controls.Add(this.label_p4);
            this.panel_info.Controls.Add(this.textBox_p3);
            this.panel_info.Controls.Add(this.label_p1);
            this.panel_info.Controls.Add(this.textBox_p4);
            this.panel_info.Controls.Add(this.label_p3);
            this.panel_info.Controls.Add(this.textBox_lon);
            this.panel_info.Controls.Add(this.label_lon);
            this.panel_info.Controls.Add(this.label_p2);
            this.panel_info.Controls.Add(this.textBox_p1);
            resources.ApplyResources(this.panel_info, "panel_info");
            this.panel_info.Name = "panel_info";
            // 
            // myButton_savedist
            // 
            resources.ApplyResources(this.myButton_savedist, "myButton_savedist");
            this.myButton_savedist.Name = "myButton_savedist";
            this.myButton_savedist.UseVisualStyleBackColor = true;
            this.myButton_savedist.Click += new System.EventHandler(this.myButton_savedist_Click);
            // 
            // myButton7
            // 
            resources.ApplyResources(this.myButton7, "myButton7");
            this.myButton7.Name = "myButton7";
            this.myButton7.UseVisualStyleBackColor = true;
            this.myButton7.Click += new System.EventHandler(this.myButton7_Click);
            // 
            // textBox_dist
            // 
            resources.ApplyResources(this.textBox_dist, "textBox_dist");
            this.textBox_dist.ForeColor = System.Drawing.Color.Red;
            this.textBox_dist.Name = "textBox_dist";
            // 
            // label_setdist
            // 
            resources.ApplyResources(this.label_setdist, "label_setdist");
            this.label_setdist.BackColor = System.Drawing.Color.Transparent;
            this.label_setdist.ForeColor = System.Drawing.Color.White;
            this.label_setdist.Name = "label_setdist";
            // 
            // label_head
            // 
            resources.ApplyResources(this.label_head, "label_head");
            this.label_head.BackColor = System.Drawing.Color.Transparent;
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Name = "label_head";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MissionPlanner.Properties.Resources.close_474;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // textBox_lat
            // 
            resources.ApplyResources(this.textBox_lat, "textBox_lat");
            this.textBox_lat.Name = "textBox_lat";
            // 
            // label_infoMassion
            // 
            resources.ApplyResources(this.label_infoMassion, "label_infoMassion");
            this.label_infoMassion.BackColor = System.Drawing.Color.Transparent;
            this.label_infoMassion.ForeColor = System.Drawing.Color.Lime;
            this.label_infoMassion.Name = "label_infoMassion";
            // 
            // textBox_p2
            // 
            resources.ApplyResources(this.textBox_p2, "textBox_p2");
            this.textBox_p2.Name = "textBox_p2";
            // 
            // label_lat
            // 
            resources.ApplyResources(this.label_lat, "label_lat");
            this.label_lat.BackColor = System.Drawing.Color.Transparent;
            this.label_lat.ForeColor = System.Drawing.Color.White;
            this.label_lat.Name = "label_lat";
            // 
            // label_p4
            // 
            resources.ApplyResources(this.label_p4, "label_p4");
            this.label_p4.BackColor = System.Drawing.Color.Transparent;
            this.label_p4.ForeColor = System.Drawing.Color.White;
            this.label_p4.Name = "label_p4";
            // 
            // textBox_p3
            // 
            resources.ApplyResources(this.textBox_p3, "textBox_p3");
            this.textBox_p3.Name = "textBox_p3";
            // 
            // label_p1
            // 
            resources.ApplyResources(this.label_p1, "label_p1");
            this.label_p1.BackColor = System.Drawing.Color.Transparent;
            this.label_p1.ForeColor = System.Drawing.Color.White;
            this.label_p1.Name = "label_p1";
            // 
            // textBox_p4
            // 
            resources.ApplyResources(this.textBox_p4, "textBox_p4");
            this.textBox_p4.Name = "textBox_p4";
            // 
            // label_p3
            // 
            resources.ApplyResources(this.label_p3, "label_p3");
            this.label_p3.BackColor = System.Drawing.Color.Transparent;
            this.label_p3.ForeColor = System.Drawing.Color.White;
            this.label_p3.Name = "label_p3";
            // 
            // textBox_lon
            // 
            resources.ApplyResources(this.textBox_lon, "textBox_lon");
            this.textBox_lon.Name = "textBox_lon";
            // 
            // label_lon
            // 
            resources.ApplyResources(this.label_lon, "label_lon");
            this.label_lon.BackColor = System.Drawing.Color.Transparent;
            this.label_lon.ForeColor = System.Drawing.Color.White;
            this.label_lon.Name = "label_lon";
            // 
            // label_p2
            // 
            resources.ApplyResources(this.label_p2, "label_p2");
            this.label_p2.BackColor = System.Drawing.Color.Transparent;
            this.label_p2.ForeColor = System.Drawing.Color.White;
            this.label_p2.Name = "label_p2";
            // 
            // textBox_p1
            // 
            resources.ApplyResources(this.textBox_p1, "textBox_p1");
            this.textBox_p1.Name = "textBox_p1";
            // 
            // MainMap
            // 
            this.MainMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.ContextMenuStrip = this.contextMenuStrip1;
            this.MainMap.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.MainMap, "MainMap");
            this.MainMap.EmptyTileColor = System.Drawing.Color.Gray;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.HoldInvalidation = false;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 19;
            this.MainMap.MinZoom = 0;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = false;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Zoom = 0D;
            this.MainMap.SizeChanged += new System.EventHandler(this.MainMap_SizeChanged);
            this.MainMap.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMap_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relativeRouteEditorToolStripMenuItem,
            this.shiftedAndRotatedToolStripMenuItem,
            this.wholeBodyMoveToolStripMenuItem,
            this.deleteWPToolStripMenuItem,
            this.insertWpToolStripMenuItem,
            this.insertSplineWPToolStripMenuItem,
            this.loiterToolStripMenuItem,
            this.jumpToolStripMenuItem,
            this.rTLToolStripMenuItem,
            this.landToolStripMenuItem,
            this.takeoffToolStripMenuItem,
            this.setROIToolStripMenuItem,
            this.clearMissionToolStripMenuItem,
            this.toolStripSeparator1,
            this.polygonToolStripMenuItem,
            this.geoFenceToolStripMenuItem,
            this.rallyPointsToolStripMenuItem,
            this.autoWPToolStripMenuItem,
            this.mapToolToolStripMenuItem,
            this.fileLoadSaveToolStripMenuItem,
            this.pOIToolStripMenuItem,
            this.trackerHomeToolStripMenuItem,
            this.modifyAltToolStripMenuItem,
            this.enterUTMCoordToolStripMenuItem,
            this.switchDockingToolStripMenuItem,
            this.setHomeHereToolStripMenuItem,
            this.remoteLandingSiteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // relativeRouteEditorToolStripMenuItem
            // 
            this.relativeRouteEditorToolStripMenuItem.Name = "relativeRouteEditorToolStripMenuItem";
            resources.ApplyResources(this.relativeRouteEditorToolStripMenuItem, "relativeRouteEditorToolStripMenuItem");
            // 
            // shiftedAndRotatedToolStripMenuItem
            // 
            this.shiftedAndRotatedToolStripMenuItem.Name = "shiftedAndRotatedToolStripMenuItem";
            resources.ApplyResources(this.shiftedAndRotatedToolStripMenuItem, "shiftedAndRotatedToolStripMenuItem");
            // 
            // wholeBodyMoveToolStripMenuItem
            // 
            this.wholeBodyMoveToolStripMenuItem.Name = "wholeBodyMoveToolStripMenuItem";
            resources.ApplyResources(this.wholeBodyMoveToolStripMenuItem, "wholeBodyMoveToolStripMenuItem");
            // 
            // deleteWPToolStripMenuItem
            // 
            this.deleteWPToolStripMenuItem.Name = "deleteWPToolStripMenuItem";
            resources.ApplyResources(this.deleteWPToolStripMenuItem, "deleteWPToolStripMenuItem");
            this.deleteWPToolStripMenuItem.Click += new System.EventHandler(this.deleteWPToolStripMenuItem_Click);
            // 
            // insertWpToolStripMenuItem
            // 
            this.insertWpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentPositionToolStripMenuItem});
            this.insertWpToolStripMenuItem.Name = "insertWpToolStripMenuItem";
            resources.ApplyResources(this.insertWpToolStripMenuItem, "insertWpToolStripMenuItem");
            this.insertWpToolStripMenuItem.Click += new System.EventHandler(this.insertWpToolStripMenuItem_Click);
            // 
            // currentPositionToolStripMenuItem
            // 
            this.currentPositionToolStripMenuItem.Name = "currentPositionToolStripMenuItem";
            resources.ApplyResources(this.currentPositionToolStripMenuItem, "currentPositionToolStripMenuItem");
            this.currentPositionToolStripMenuItem.Click += new System.EventHandler(this.currentPositionToolStripMenuItem_Click);
            // 
            // insertSplineWPToolStripMenuItem
            // 
            this.insertSplineWPToolStripMenuItem.Name = "insertSplineWPToolStripMenuItem";
            resources.ApplyResources(this.insertSplineWPToolStripMenuItem, "insertSplineWPToolStripMenuItem");
            this.insertSplineWPToolStripMenuItem.Click += new System.EventHandler(this.insertSplineWPToolStripMenuItem_Click);
            // 
            // loiterToolStripMenuItem
            // 
            this.loiterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loiterForeverToolStripMenuItem,
            this.loitertimeToolStripMenuItem,
            this.loitercirclesToolStripMenuItem});
            this.loiterToolStripMenuItem.Name = "loiterToolStripMenuItem";
            resources.ApplyResources(this.loiterToolStripMenuItem, "loiterToolStripMenuItem");
            // 
            // loiterForeverToolStripMenuItem
            // 
            this.loiterForeverToolStripMenuItem.Name = "loiterForeverToolStripMenuItem";
            resources.ApplyResources(this.loiterForeverToolStripMenuItem, "loiterForeverToolStripMenuItem");
            this.loiterForeverToolStripMenuItem.Click += new System.EventHandler(this.loiterForeverToolStripMenuItem_Click);
            // 
            // loitertimeToolStripMenuItem
            // 
            this.loitertimeToolStripMenuItem.Name = "loitertimeToolStripMenuItem";
            resources.ApplyResources(this.loitertimeToolStripMenuItem, "loitertimeToolStripMenuItem");
            this.loitertimeToolStripMenuItem.Click += new System.EventHandler(this.loitertimeToolStripMenuItem_Click);
            // 
            // loitercirclesToolStripMenuItem
            // 
            this.loitercirclesToolStripMenuItem.Name = "loitercirclesToolStripMenuItem";
            resources.ApplyResources(this.loitercirclesToolStripMenuItem, "loitercirclesToolStripMenuItem");
            this.loitercirclesToolStripMenuItem.Click += new System.EventHandler(this.loitercirclesToolStripMenuItem_Click);
            // 
            // jumpToolStripMenuItem
            // 
            this.jumpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumpstartToolStripMenuItem,
            this.jumpwPToolStripMenuItem});
            this.jumpToolStripMenuItem.Name = "jumpToolStripMenuItem";
            resources.ApplyResources(this.jumpToolStripMenuItem, "jumpToolStripMenuItem");
            // 
            // jumpstartToolStripMenuItem
            // 
            this.jumpstartToolStripMenuItem.Name = "jumpstartToolStripMenuItem";
            resources.ApplyResources(this.jumpstartToolStripMenuItem, "jumpstartToolStripMenuItem");
            this.jumpstartToolStripMenuItem.Click += new System.EventHandler(this.jumpstartToolStripMenuItem_Click);
            // 
            // jumpwPToolStripMenuItem
            // 
            this.jumpwPToolStripMenuItem.Name = "jumpwPToolStripMenuItem";
            resources.ApplyResources(this.jumpwPToolStripMenuItem, "jumpwPToolStripMenuItem");
            this.jumpwPToolStripMenuItem.Click += new System.EventHandler(this.jumpwPToolStripMenuItem_Click);
            // 
            // rTLToolStripMenuItem
            // 
            this.rTLToolStripMenuItem.Name = "rTLToolStripMenuItem";
            resources.ApplyResources(this.rTLToolStripMenuItem, "rTLToolStripMenuItem");
            this.rTLToolStripMenuItem.Click += new System.EventHandler(this.rTLToolStripMenuItem_Click);
            // 
            // landToolStripMenuItem
            // 
            this.landToolStripMenuItem.Name = "landToolStripMenuItem";
            resources.ApplyResources(this.landToolStripMenuItem, "landToolStripMenuItem");
            this.landToolStripMenuItem.Click += new System.EventHandler(this.landToolStripMenuItem_Click);
            // 
            // takeoffToolStripMenuItem
            // 
            this.takeoffToolStripMenuItem.Name = "takeoffToolStripMenuItem";
            resources.ApplyResources(this.takeoffToolStripMenuItem, "takeoffToolStripMenuItem");
            this.takeoffToolStripMenuItem.Click += new System.EventHandler(this.takeoffToolStripMenuItem_Click);
            // 
            // setROIToolStripMenuItem
            // 
            this.setROIToolStripMenuItem.Name = "setROIToolStripMenuItem";
            resources.ApplyResources(this.setROIToolStripMenuItem, "setROIToolStripMenuItem");
            this.setROIToolStripMenuItem.Click += new System.EventHandler(this.setROIToolStripMenuItem_Click);
            // 
            // clearMissionToolStripMenuItem
            // 
            this.clearMissionToolStripMenuItem.Name = "clearMissionToolStripMenuItem";
            resources.ApplyResources(this.clearMissionToolStripMenuItem, "clearMissionToolStripMenuItem");
            this.clearMissionToolStripMenuItem.Click += new System.EventHandler(this.clearMissionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPolygonPointToolStripMenuItem2,
            this.clearPolygonToolStripMenuItem2,
            this.savePolygonToolStripMenuItem2,
            this.loadPolygonToolStripMenuItem2,
            this.fromSHPToolStripMenuItem2,
            this.areaToolStripMenuItem2});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            resources.ApplyResources(this.polygonToolStripMenuItem, "polygonToolStripMenuItem");
            // 
            // addPolygonPointToolStripMenuItem2
            // 
            this.addPolygonPointToolStripMenuItem2.Name = "addPolygonPointToolStripMenuItem2";
            resources.ApplyResources(this.addPolygonPointToolStripMenuItem2, "addPolygonPointToolStripMenuItem2");
            this.addPolygonPointToolStripMenuItem2.Click += new System.EventHandler(this.addPolygonPointToolStripMenuItem_Click);
            // 
            // clearPolygonToolStripMenuItem2
            // 
            this.clearPolygonToolStripMenuItem2.Name = "clearPolygonToolStripMenuItem2";
            resources.ApplyResources(this.clearPolygonToolStripMenuItem2, "clearPolygonToolStripMenuItem2");
            this.clearPolygonToolStripMenuItem2.Click += new System.EventHandler(this.clearPolygonToolStripMenuItem_Click);
            // 
            // savePolygonToolStripMenuItem2
            // 
            this.savePolygonToolStripMenuItem2.Name = "savePolygonToolStripMenuItem2";
            resources.ApplyResources(this.savePolygonToolStripMenuItem2, "savePolygonToolStripMenuItem2");
            this.savePolygonToolStripMenuItem2.Click += new System.EventHandler(this.savePolygonToolStripMenuItem_Click);
            // 
            // loadPolygonToolStripMenuItem2
            // 
            this.loadPolygonToolStripMenuItem2.Name = "loadPolygonToolStripMenuItem2";
            resources.ApplyResources(this.loadPolygonToolStripMenuItem2, "loadPolygonToolStripMenuItem2");
            this.loadPolygonToolStripMenuItem2.Click += new System.EventHandler(this.loadPolygonToolStripMenuItem_Click);
            // 
            // fromSHPToolStripMenuItem2
            // 
            this.fromSHPToolStripMenuItem2.Name = "fromSHPToolStripMenuItem2";
            resources.ApplyResources(this.fromSHPToolStripMenuItem2, "fromSHPToolStripMenuItem2");
            this.fromSHPToolStripMenuItem2.Click += new System.EventHandler(this.fromSHPToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem2
            // 
            this.areaToolStripMenuItem2.Name = "areaToolStripMenuItem2";
            resources.ApplyResources(this.areaToolStripMenuItem2, "areaToolStripMenuItem2");
            this.areaToolStripMenuItem2.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // geoFenceToolStripMenuItem
            // 
            this.geoFenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeoFenceuploadToolStripMenuItem,
            this.GeoFencedownloadToolStripMenuItem,
            this.setReturnLocationToolStripMenuItem,
            this.loadFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.geoFenceToolStripMenuItem.Name = "geoFenceToolStripMenuItem";
            resources.ApplyResources(this.geoFenceToolStripMenuItem, "geoFenceToolStripMenuItem");
            // 
            // GeoFenceuploadToolStripMenuItem
            // 
            this.GeoFenceuploadToolStripMenuItem.Name = "GeoFenceuploadToolStripMenuItem";
            resources.ApplyResources(this.GeoFenceuploadToolStripMenuItem, "GeoFenceuploadToolStripMenuItem");
            this.GeoFenceuploadToolStripMenuItem.Click += new System.EventHandler(this.GeoFenceuploadToolStripMenuItem_Click);
            // 
            // GeoFencedownloadToolStripMenuItem
            // 
            this.GeoFencedownloadToolStripMenuItem.Name = "GeoFencedownloadToolStripMenuItem";
            resources.ApplyResources(this.GeoFencedownloadToolStripMenuItem, "GeoFencedownloadToolStripMenuItem");
            this.GeoFencedownloadToolStripMenuItem.Click += new System.EventHandler(this.GeoFencedownloadToolStripMenuItem_Click);
            // 
            // setReturnLocationToolStripMenuItem
            // 
            this.setReturnLocationToolStripMenuItem.Name = "setReturnLocationToolStripMenuItem";
            resources.ApplyResources(this.setReturnLocationToolStripMenuItem, "setReturnLocationToolStripMenuItem");
            this.setReturnLocationToolStripMenuItem.Click += new System.EventHandler(this.setReturnLocationToolStripMenuItem_Click);
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem, "loadFromFileToolStripMenuItem");
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            resources.ApplyResources(this.saveToFileToolStripMenuItem, "saveToFileToolStripMenuItem");
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // rallyPointsToolStripMenuItem
            // 
            this.rallyPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRallyPointToolStripMenuItem,
            this.getRallyPointsToolStripMenuItem,
            this.saveRallyPointsToolStripMenuItem,
            this.clearRallyPointsToolStripMenuItem,
            this.saveToFileToolStripMenuItem1,
            this.loadFromFileToolStripMenuItem1});
            this.rallyPointsToolStripMenuItem.Name = "rallyPointsToolStripMenuItem";
            resources.ApplyResources(this.rallyPointsToolStripMenuItem, "rallyPointsToolStripMenuItem");
            // 
            // setRallyPointToolStripMenuItem
            // 
            this.setRallyPointToolStripMenuItem.Name = "setRallyPointToolStripMenuItem";
            resources.ApplyResources(this.setRallyPointToolStripMenuItem, "setRallyPointToolStripMenuItem");
            this.setRallyPointToolStripMenuItem.Click += new System.EventHandler(this.setRallyPointToolStripMenuItem_Click);
            // 
            // getRallyPointsToolStripMenuItem
            // 
            this.getRallyPointsToolStripMenuItem.Name = "getRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.getRallyPointsToolStripMenuItem, "getRallyPointsToolStripMenuItem");
            this.getRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.getRallyPointsToolStripMenuItem_Click);
            // 
            // saveRallyPointsToolStripMenuItem
            // 
            this.saveRallyPointsToolStripMenuItem.Name = "saveRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.saveRallyPointsToolStripMenuItem, "saveRallyPointsToolStripMenuItem");
            this.saveRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.saveRallyPointsToolStripMenuItem_Click);
            // 
            // clearRallyPointsToolStripMenuItem
            // 
            this.clearRallyPointsToolStripMenuItem.Name = "clearRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.clearRallyPointsToolStripMenuItem, "clearRallyPointsToolStripMenuItem");
            this.clearRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.clearRallyPointsToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem1
            // 
            this.saveToFileToolStripMenuItem1.Name = "saveToFileToolStripMenuItem1";
            resources.ApplyResources(this.saveToFileToolStripMenuItem1, "saveToFileToolStripMenuItem1");
            this.saveToFileToolStripMenuItem1.Click += new System.EventHandler(this.saveToFileToolStripMenuItem1_Click);
            // 
            // loadFromFileToolStripMenuItem1
            // 
            this.loadFromFileToolStripMenuItem1.Name = "loadFromFileToolStripMenuItem1";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem1, "loadFromFileToolStripMenuItem1");
            this.loadFromFileToolStripMenuItem1.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem1_Click);
            // 
            // autoWPToolStripMenuItem
            // 
            this.autoWPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createWpCircleToolStripMenuItem,
            this.createSplineCircleToolStripMenuItem,
            this.areaToolStripMenuItem1,
            this.textToolStripMenuItem,
            this.createCircleSurveyToolStripMenuItem,
            this.surveyGridToolStripMenuItem});
            this.autoWPToolStripMenuItem.Name = "autoWPToolStripMenuItem";
            resources.ApplyResources(this.autoWPToolStripMenuItem, "autoWPToolStripMenuItem");
            // 
            // createWpCircleToolStripMenuItem
            // 
            this.createWpCircleToolStripMenuItem.Name = "createWpCircleToolStripMenuItem";
            resources.ApplyResources(this.createWpCircleToolStripMenuItem, "createWpCircleToolStripMenuItem");
            this.createWpCircleToolStripMenuItem.Click += new System.EventHandler(this.createWpCircleToolStripMenuItem_Click);
            // 
            // createSplineCircleToolStripMenuItem
            // 
            this.createSplineCircleToolStripMenuItem.Name = "createSplineCircleToolStripMenuItem";
            resources.ApplyResources(this.createSplineCircleToolStripMenuItem, "createSplineCircleToolStripMenuItem");
            this.createSplineCircleToolStripMenuItem.Click += new System.EventHandler(this.createSplineCircleToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem1
            // 
            this.areaToolStripMenuItem1.Name = "areaToolStripMenuItem1";
            resources.ApplyResources(this.areaToolStripMenuItem1, "areaToolStripMenuItem1");
            this.areaToolStripMenuItem1.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            resources.ApplyResources(this.textToolStripMenuItem, "textToolStripMenuItem");
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // createCircleSurveyToolStripMenuItem
            // 
            this.createCircleSurveyToolStripMenuItem.Name = "createCircleSurveyToolStripMenuItem";
            resources.ApplyResources(this.createCircleSurveyToolStripMenuItem, "createCircleSurveyToolStripMenuItem");
            this.createCircleSurveyToolStripMenuItem.Click += new System.EventHandler(this.createCircleSurveyToolStripMenuItem_Click);
            // 
            // surveyGridToolStripMenuItem
            // 
            this.surveyGridToolStripMenuItem.Name = "surveyGridToolStripMenuItem";
            resources.ApplyResources(this.surveyGridToolStripMenuItem, "surveyGridToolStripMenuItem");
            this.surveyGridToolStripMenuItem.Click += new System.EventHandler(this.surveyGridToolStripMenuItem_Click);
            // 
            // mapToolToolStripMenuItem
            // 
            this.mapToolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMeasure,
            this.rotateMapToolStripMenuItem,
            this.zoomToToolStripMenuItem,
            this.prefetchToolStripMenuItem,
            this.prefetchWPPathToolStripMenuItem,
            this.kMLOverlayToolStripMenuItem,
            this.elevationGraphToolStripMenuItem,
            this.reverseWPsToolStripMenuItem});
            this.mapToolToolStripMenuItem.Name = "mapToolToolStripMenuItem";
            resources.ApplyResources(this.mapToolToolStripMenuItem, "mapToolToolStripMenuItem");
            // 
            // ContextMeasure
            // 
            this.ContextMeasure.Name = "ContextMeasure";
            resources.ApplyResources(this.ContextMeasure, "ContextMeasure");
            this.ContextMeasure.Click += new System.EventHandler(this.ContextMeasure_Click);
            // 
            // rotateMapToolStripMenuItem
            // 
            this.rotateMapToolStripMenuItem.Name = "rotateMapToolStripMenuItem";
            resources.ApplyResources(this.rotateMapToolStripMenuItem, "rotateMapToolStripMenuItem");
            this.rotateMapToolStripMenuItem.Click += new System.EventHandler(this.rotateMapToolStripMenuItem_Click);
            // 
            // zoomToToolStripMenuItem
            // 
            this.zoomToToolStripMenuItem.Name = "zoomToToolStripMenuItem";
            resources.ApplyResources(this.zoomToToolStripMenuItem, "zoomToToolStripMenuItem");
            this.zoomToToolStripMenuItem.Click += new System.EventHandler(this.zoomToToolStripMenuItem_Click);
            // 
            // prefetchToolStripMenuItem
            // 
            this.prefetchToolStripMenuItem.Name = "prefetchToolStripMenuItem";
            resources.ApplyResources(this.prefetchToolStripMenuItem, "prefetchToolStripMenuItem");
            this.prefetchToolStripMenuItem.Click += new System.EventHandler(this.prefetchToolStripMenuItem_Click);
            // 
            // prefetchWPPathToolStripMenuItem
            // 
            this.prefetchWPPathToolStripMenuItem.Name = "prefetchWPPathToolStripMenuItem";
            resources.ApplyResources(this.prefetchWPPathToolStripMenuItem, "prefetchWPPathToolStripMenuItem");
            this.prefetchWPPathToolStripMenuItem.Click += new System.EventHandler(this.prefetchWPPathToolStripMenuItem_Click);
            // 
            // kMLOverlayToolStripMenuItem
            // 
            this.kMLOverlayToolStripMenuItem.Name = "kMLOverlayToolStripMenuItem";
            resources.ApplyResources(this.kMLOverlayToolStripMenuItem, "kMLOverlayToolStripMenuItem");
            this.kMLOverlayToolStripMenuItem.Click += new System.EventHandler(this.kMLOverlayToolStripMenuItem_Click);
            // 
            // elevationGraphToolStripMenuItem
            // 
            this.elevationGraphToolStripMenuItem.Name = "elevationGraphToolStripMenuItem";
            resources.ApplyResources(this.elevationGraphToolStripMenuItem, "elevationGraphToolStripMenuItem");
            this.elevationGraphToolStripMenuItem.Click += new System.EventHandler(this.elevationGraphToolStripMenuItem_Click);
            // 
            // reverseWPsToolStripMenuItem
            // 
            this.reverseWPsToolStripMenuItem.Name = "reverseWPsToolStripMenuItem";
            resources.ApplyResources(this.reverseWPsToolStripMenuItem, "reverseWPsToolStripMenuItem");
            this.reverseWPsToolStripMenuItem.Click += new System.EventHandler(this.reverseWPsToolStripMenuItem_Click);
            // 
            // fileLoadSaveToolStripMenuItem
            // 
            this.fileLoadSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWPFileToolStripMenuItem,
            this.loadAndAppendToolStripMenuItem,
            this.saveWPFileToolStripMenuItem,
            this.loadKMLFileToolStripMenuItem,
            this.loadSHPFileToolStripMenuItem});
            this.fileLoadSaveToolStripMenuItem.Name = "fileLoadSaveToolStripMenuItem";
            resources.ApplyResources(this.fileLoadSaveToolStripMenuItem, "fileLoadSaveToolStripMenuItem");
            // 
            // loadWPFileToolStripMenuItem
            // 
            this.loadWPFileToolStripMenuItem.Name = "loadWPFileToolStripMenuItem";
            resources.ApplyResources(this.loadWPFileToolStripMenuItem, "loadWPFileToolStripMenuItem");
            this.loadWPFileToolStripMenuItem.Click += new System.EventHandler(this.loadWPFileToolStripMenuItem_Click);
            // 
            // loadAndAppendToolStripMenuItem
            // 
            this.loadAndAppendToolStripMenuItem.Name = "loadAndAppendToolStripMenuItem";
            resources.ApplyResources(this.loadAndAppendToolStripMenuItem, "loadAndAppendToolStripMenuItem");
            this.loadAndAppendToolStripMenuItem.Click += new System.EventHandler(this.loadAndAppendToolStripMenuItem_Click);
            // 
            // saveWPFileToolStripMenuItem
            // 
            this.saveWPFileToolStripMenuItem.Name = "saveWPFileToolStripMenuItem";
            resources.ApplyResources(this.saveWPFileToolStripMenuItem, "saveWPFileToolStripMenuItem");
            this.saveWPFileToolStripMenuItem.Click += new System.EventHandler(this.saveWPFileToolStripMenuItem_Click);
            // 
            // loadKMLFileToolStripMenuItem
            // 
            this.loadKMLFileToolStripMenuItem.Name = "loadKMLFileToolStripMenuItem";
            resources.ApplyResources(this.loadKMLFileToolStripMenuItem, "loadKMLFileToolStripMenuItem");
            this.loadKMLFileToolStripMenuItem.Click += new System.EventHandler(this.loadKMLFileToolStripMenuItem_Click);
            // 
            // loadSHPFileToolStripMenuItem
            // 
            this.loadSHPFileToolStripMenuItem.Name = "loadSHPFileToolStripMenuItem";
            resources.ApplyResources(this.loadSHPFileToolStripMenuItem, "loadSHPFileToolStripMenuItem");
            this.loadSHPFileToolStripMenuItem.Click += new System.EventHandler(this.loadSHPFileToolStripMenuItem_Click);
            // 
            // pOIToolStripMenuItem
            // 
            this.pOIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poiaddToolStripMenuItem,
            this.poideleteToolStripMenuItem,
            this.poieditToolStripMenuItem});
            this.pOIToolStripMenuItem.Name = "pOIToolStripMenuItem";
            resources.ApplyResources(this.pOIToolStripMenuItem, "pOIToolStripMenuItem");
            // 
            // poiaddToolStripMenuItem
            // 
            this.poiaddToolStripMenuItem.Name = "poiaddToolStripMenuItem";
            resources.ApplyResources(this.poiaddToolStripMenuItem, "poiaddToolStripMenuItem");
            this.poiaddToolStripMenuItem.Click += new System.EventHandler(this.poiaddToolStripMenuItem_Click);
            // 
            // poideleteToolStripMenuItem
            // 
            this.poideleteToolStripMenuItem.Name = "poideleteToolStripMenuItem";
            resources.ApplyResources(this.poideleteToolStripMenuItem, "poideleteToolStripMenuItem");
            this.poideleteToolStripMenuItem.Click += new System.EventHandler(this.poideleteToolStripMenuItem_Click);
            // 
            // poieditToolStripMenuItem
            // 
            this.poieditToolStripMenuItem.Name = "poieditToolStripMenuItem";
            resources.ApplyResources(this.poieditToolStripMenuItem, "poieditToolStripMenuItem");
            this.poieditToolStripMenuItem.Click += new System.EventHandler(this.poieditToolStripMenuItem_Click);
            // 
            // trackerHomeToolStripMenuItem
            // 
            this.trackerHomeToolStripMenuItem.Name = "trackerHomeToolStripMenuItem";
            resources.ApplyResources(this.trackerHomeToolStripMenuItem, "trackerHomeToolStripMenuItem");
            this.trackerHomeToolStripMenuItem.Click += new System.EventHandler(this.trackerHomeToolStripMenuItem_Click);
            // 
            // modifyAltToolStripMenuItem
            // 
            this.modifyAltToolStripMenuItem.Name = "modifyAltToolStripMenuItem";
            resources.ApplyResources(this.modifyAltToolStripMenuItem, "modifyAltToolStripMenuItem");
            this.modifyAltToolStripMenuItem.Click += new System.EventHandler(this.modifyAltToolStripMenuItem_Click);
            // 
            // enterUTMCoordToolStripMenuItem
            // 
            this.enterUTMCoordToolStripMenuItem.Name = "enterUTMCoordToolStripMenuItem";
            resources.ApplyResources(this.enterUTMCoordToolStripMenuItem, "enterUTMCoordToolStripMenuItem");
            this.enterUTMCoordToolStripMenuItem.Click += new System.EventHandler(this.enterUTMCoordToolStripMenuItem_Click);
            // 
            // switchDockingToolStripMenuItem
            // 
            this.switchDockingToolStripMenuItem.Name = "switchDockingToolStripMenuItem";
            resources.ApplyResources(this.switchDockingToolStripMenuItem, "switchDockingToolStripMenuItem");
            this.switchDockingToolStripMenuItem.Click += new System.EventHandler(this.switchDockingToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem
            // 
            this.setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            resources.ApplyResources(this.setHomeHereToolStripMenuItem, "setHomeHereToolStripMenuItem");
            this.setHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // remoteLandingSiteToolStripMenuItem
            // 
            this.remoteLandingSiteToolStripMenuItem.Name = "remoteLandingSiteToolStripMenuItem";
            resources.ApplyResources(this.remoteLandingSiteToolStripMenuItem, "remoteLandingSiteToolStripMenuItem");
            this.remoteLandingSiteToolStripMenuItem.Click += new System.EventHandler(this.remoteLandingSiteToolStripMenuItem_Click);
            // 
            // addPolygonPointToolStripMenuItem
            // 
            this.addPolygonPointToolStripMenuItem.Name = "addPolygonPointToolStripMenuItem";
            resources.ApplyResources(this.addPolygonPointToolStripMenuItem, "addPolygonPointToolStripMenuItem");
            this.addPolygonPointToolStripMenuItem.Click += new System.EventHandler(this.addPolygonPointToolStripMenuItem_Click);
            // 
            // clearPolygonToolStripMenuItem
            // 
            this.clearPolygonToolStripMenuItem.Name = "clearPolygonToolStripMenuItem";
            resources.ApplyResources(this.clearPolygonToolStripMenuItem, "clearPolygonToolStripMenuItem");
            this.clearPolygonToolStripMenuItem.Click += new System.EventHandler(this.clearPolygonToolStripMenuItem_Click);
            // 
            // savePolygonToolStripMenuItem
            // 
            this.savePolygonToolStripMenuItem.Name = "savePolygonToolStripMenuItem";
            resources.ApplyResources(this.savePolygonToolStripMenuItem, "savePolygonToolStripMenuItem");
            this.savePolygonToolStripMenuItem.Click += new System.EventHandler(this.savePolygonToolStripMenuItem_Click);
            // 
            // loadPolygonToolStripMenuItem
            // 
            this.loadPolygonToolStripMenuItem.Name = "loadPolygonToolStripMenuItem";
            resources.ApplyResources(this.loadPolygonToolStripMenuItem, "loadPolygonToolStripMenuItem");
            this.loadPolygonToolStripMenuItem.Click += new System.EventHandler(this.loadPolygonToolStripMenuItem_Click);
            // 
            // fromSHPToolStripMenuItem
            // 
            this.fromSHPToolStripMenuItem.Name = "fromSHPToolStripMenuItem";
            resources.ApplyResources(this.fromSHPToolStripMenuItem, "fromSHPToolStripMenuItem");
            this.fromSHPToolStripMenuItem.Click += new System.EventHandler(this.fromSHPToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            resources.ApplyResources(this.areaToolStripMenuItem, "areaToolStripMenuItem");
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // fenceInclusionToolStripMenuItem
            // 
            this.fenceInclusionToolStripMenuItem.Name = "fenceInclusionToolStripMenuItem";
            resources.ApplyResources(this.fenceInclusionToolStripMenuItem, "fenceInclusionToolStripMenuItem");
            this.fenceInclusionToolStripMenuItem.Click += new System.EventHandler(this.FenceInclusionToolStripMenuItem_Click);
            // 
            // fenceExclusionToolStripMenuItem
            // 
            this.fenceExclusionToolStripMenuItem.Name = "fenceExclusionToolStripMenuItem";
            resources.ApplyResources(this.fenceExclusionToolStripMenuItem, "fenceExclusionToolStripMenuItem");
            this.fenceExclusionToolStripMenuItem.Click += new System.EventHandler(this.FenceExclusionToolStripMenuItem_Click);
            // 
            // panelBASE
            // 
            this.panelBASE.Controls.Add(this.splitter2);
            this.panelBASE.Controls.Add(this.splitter1);
            this.panelBASE.Controls.Add(this.panelMap);
            this.panelBASE.Controls.Add(this.panelWaypoints);
            this.panelBASE.Controls.Add(this.panelAction);
            this.panelBASE.Controls.Add(this.label6);
            resources.ApplyResources(this.panelBASE, "panelBASE");
            this.panelBASE.Name = "panelBASE";
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStripPoly
            // 
            this.contextMenuStripPoly.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPolygonPointToolStripMenuItem,
            this.clearPolygonToolStripMenuItem,
            this.savePolygonToolStripMenuItem,
            this.loadPolygonToolStripMenuItem,
            this.fromSHPToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.fenceInclusionToolStripMenuItem,
            this.fenceExclusionToolStripMenuItem});
            this.contextMenuStripPoly.Name = "contextMenuStripPoly";
            this.contextMenuStripPoly.ShowImageMargin = false;
            resources.ApplyResources(this.contextMenuStripPoly, "contextMenuStripPoly");
            this.contextMenuStripPoly.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripPoly_Opening);
            // 
            // drawAPolygonToolStripMenuItem
            // 
            this.drawAPolygonToolStripMenuItem.Name = "drawAPolygonToolStripMenuItem";
            resources.ApplyResources(this.drawAPolygonToolStripMenuItem, "drawAPolygonToolStripMenuItem");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            resources.ApplyResources(this.testToolStripMenuItem, "testToolStripMenuItem");
            // 
            // contextMenuStripZoom
            // 
            this.contextMenuStripZoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToVehicleToolStripMenuItem,
            this.zoomToMissionToolStripMenuItem,
            this.zoomToHomeToolStripMenuItem});
            this.contextMenuStripZoom.Name = "contextMenuStripZoom";
            resources.ApplyResources(this.contextMenuStripZoom, "contextMenuStripZoom");
            // 
            // zoomToVehicleToolStripMenuItem
            // 
            this.zoomToVehicleToolStripMenuItem.Name = "zoomToVehicleToolStripMenuItem";
            resources.ApplyResources(this.zoomToVehicleToolStripMenuItem, "zoomToVehicleToolStripMenuItem");
            this.zoomToVehicleToolStripMenuItem.Click += new System.EventHandler(this.zoomToVehicleToolStripMenuItem_Click);
            // 
            // zoomToMissionToolStripMenuItem
            // 
            this.zoomToMissionToolStripMenuItem.Name = "zoomToMissionToolStripMenuItem";
            resources.ApplyResources(this.zoomToMissionToolStripMenuItem, "zoomToMissionToolStripMenuItem");
            this.zoomToMissionToolStripMenuItem.Click += new System.EventHandler(this.zoomToMissionToolStripMenuItem_Click);
            // 
            // zoomToHomeToolStripMenuItem
            // 
            this.zoomToHomeToolStripMenuItem.Name = "zoomToHomeToolStripMenuItem";
            resources.ApplyResources(this.zoomToHomeToolStripMenuItem, "zoomToHomeToolStripMenuItem");
            this.zoomToHomeToolStripMenuItem.Click += new System.EventHandler(this.zoomToHomeToolStripMenuItem_Click);
            // 
            // FlightPlanner
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelBASE);
            resources.ApplyResources(this, "$this");
            this.Name = "FlightPlanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightPlanner_FormClosing);
            this.Load += new System.EventHandler(this.FlightPlanner_Load);
            this.Resize += new System.EventHandler(this.Planner_Resize);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelWaypoints.ResumeLayout(false);
            this.panelWaypoints.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).EndInit();
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Commands1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_bufferdist)).EndInit();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            this.panel_mapset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_homeset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_planset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add)).EndInit();
            this.panel_zhongche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel_draw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AddOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_stand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drawLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drawasave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drawadelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drawadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_draw)).EndInit();
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelBASE.ResumeLayout(false);
            this.contextMenuStripPoly.ResumeLayout(false);
            this.contextMenuStripZoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        public Panel panelWaypoints;
        public Panel panelAction;
        public Controls.myGMAP MainMap;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.CheckBox CHK_verifyheight;
        public System.Windows.Forms.TextBox TXT_WPRad;
        public System.Windows.Forms.TextBox TXT_DefaultAlt;
        public System.Windows.Forms.TextBox TXT_loiterrad;
        public System.Windows.Forms.CheckBox CHK_splinedefault;
        public System.Windows.Forms.ComboBox CMB_altmode;
        public MyButton BUT_read;
        public MyButton BUT_write;
        public Panel panel5;
        public Panel panel1;
        public LinkLabel label4;
        public Label label3;
        public Label label2;
        public Label Label1;
        public TextBox TXT_homealt;
        public TextBox TXT_homelng;
        public TextBox TXT_homelat;
        public DataGridViewImageColumn dataGridViewImageColumn1;
        public DataGridViewImageColumn dataGridViewImageColumn2;
        public Label label6;
        public Label lbl_status;
        public MyDataGridView Commands;
        public MyButton BUT_Add;
        public Label LBL_WPRad;
        public Label LBL_defalutalt;
        public Label label5;
        public Panel panelMap;
        public MyTrackBar trackBar1;
        public Label label11;
        public Label lbl_distance;
        public Label lbl_prevdist;
        public Splitter splitter1;
        public Panel panelBASE;
        public Label lbl_homedist;
        public ToolTip toolTip1;
        public ToolStripMenuItem clearMissionToolStripMenuItem;
        public ToolStripMenuItem addPolygonPointToolStripMenuItem;
        public ToolStripMenuItem clearPolygonToolStripMenuItem;
        public ToolStripMenuItem loiterToolStripMenuItem;
        public ToolStripMenuItem loiterForeverToolStripMenuItem;
        public ToolStripMenuItem loitertimeToolStripMenuItem;
        public ToolStripMenuItem loitercirclesToolStripMenuItem;
        public ToolStripMenuItem jumpToolStripMenuItem;
        public ToolStripMenuItem jumpstartToolStripMenuItem;
        public ToolStripMenuItem jumpwPToolStripMenuItem;
        public ToolStripSeparator toolStripSeparator1;
        public ToolStripMenuItem deleteWPToolStripMenuItem;
        public Timer timer1;
        public ToolStripMenuItem setROIToolStripMenuItem;
        public ToolStripMenuItem mapToolToolStripMenuItem;
        public ToolStripMenuItem ContextMeasure;
        public ToolStripMenuItem rotateMapToolStripMenuItem;
        public ToolStripMenuItem zoomToToolStripMenuItem;
        public ToolStripMenuItem prefetchToolStripMenuItem;
        public ToolStripMenuItem kMLOverlayToolStripMenuItem;
        public ToolStripMenuItem elevationGraphToolStripMenuItem;
        public ToolStripMenuItem rTLToolStripMenuItem;
        public ToolStripMenuItem landToolStripMenuItem;
        public ToolStripMenuItem takeoffToolStripMenuItem;
        public ComboBox comboBoxMapType;
        public ToolStripMenuItem fileLoadSaveToolStripMenuItem;
        public ToolStripMenuItem loadWPFileToolStripMenuItem;
        public ToolStripMenuItem saveWPFileToolStripMenuItem;
        public ToolStripMenuItem trackerHomeToolStripMenuItem;
        public ToolStripMenuItem reverseWPsToolStripMenuItem;
        public ToolStripMenuItem loadAndAppendToolStripMenuItem;
        public ToolStripMenuItem savePolygonToolStripMenuItem;
        public ToolStripMenuItem loadPolygonToolStripMenuItem;
        public CheckBox chk_grid;
        public ToolStripMenuItem insertWpToolStripMenuItem;
        public ToolStripMenuItem loadKMLFileToolStripMenuItem;
        public LinkLabel lnk_kml;
        public ToolStripMenuItem modifyAltToolStripMenuItem;
        public ToolStripMenuItem prefetchWPPathToolStripMenuItem;
        public Label label17;
        public TextBox TXT_altwarn;
        public ToolStripMenuItem pOIToolStripMenuItem;
        public ToolStripMenuItem poiaddToolStripMenuItem;
        public ToolStripMenuItem poideleteToolStripMenuItem;
        public ToolStripMenuItem poieditToolStripMenuItem;
        public ToolStripMenuItem enterUTMCoordToolStripMenuItem;
        public ToolStripMenuItem loadSHPFileToolStripMenuItem;
        public Coords coords1;
        public MyButton BUT_loadwpfile;
        public MyButton BUT_saveWPFile;
        public Panel panel2;
        public Panel panel4;
        public Panel panel3;
        public FlowLayoutPanel flowLayoutPanel1;
        public ToolStripMenuItem switchDockingToolStripMenuItem;
        public Splitter splitter2;
        public ToolStripMenuItem insertSplineWPToolStripMenuItem;
        public ToolStripMenuItem fromSHPToolStripMenuItem;
        public Label lbl_wpfile;
        public ToolStripMenuItem areaToolStripMenuItem;
        public ToolStripMenuItem setHomeHereToolStripMenuItem;
        public ToolStripMenuItem currentPositionToolStripMenuItem;
        public MyButton but_writewpfast;
        public ComboBox cmb_missiontype;
        public ContextMenuStrip contextMenuStripPoly;
        public ToolStripMenuItem drawAPolygonToolStripMenuItem;
        public ToolStripMenuItem fenceInclusionToolStripMenuItem;
        public ToolStripMenuItem fenceExclusionToolStripMenuItem;
        public ToolStripMenuItem autoWPToolStripMenuItem;
        public ToolStripMenuItem createWpCircleToolStripMenuItem;
        public ToolStripMenuItem createSplineCircleToolStripMenuItem;
        public ToolStripMenuItem areaToolStripMenuItem1;
        public ToolStripMenuItem textToolStripMenuItem;
        public ToolStripMenuItem createCircleSurveyToolStripMenuItem;
        public ToolStripMenuItem surveyGridToolStripMenuItem;
        public ToolStripMenuItem geoFenceToolStripMenuItem;
        public ToolStripMenuItem GeoFenceuploadToolStripMenuItem;
        public ToolStripMenuItem GeoFencedownloadToolStripMenuItem;
        public ToolStripMenuItem setReturnLocationToolStripMenuItem;
        public ToolStripMenuItem loadFromFileToolStripMenuItem;
        public ToolStripMenuItem saveToFileToolStripMenuItem;
        public ToolStripMenuItem clearToolStripMenuItem;
        public ToolStripMenuItem rallyPointsToolStripMenuItem;
        public ToolStripMenuItem setRallyPointToolStripMenuItem;
        public ToolStripMenuItem getRallyPointsToolStripMenuItem;
        public ToolStripMenuItem saveRallyPointsToolStripMenuItem;
        public ToolStripMenuItem clearRallyPointsToolStripMenuItem;
        public ToolStripMenuItem saveToFileToolStripMenuItem1;
        public ToolStripMenuItem loadFromFileToolStripMenuItem1;
        public MyButton but_mincommands;
        private ToolStripMenuItem polygonToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem testToolStripMenuItem;
        public ToolStripMenuItem addPolygonPointToolStripMenuItem2;
        public ToolStripMenuItem clearPolygonToolStripMenuItem2;
        public ToolStripMenuItem savePolygonToolStripMenuItem2;
        public ToolStripMenuItem loadPolygonToolStripMenuItem2;
        public ToolStripMenuItem fromSHPToolStripMenuItem2;
        public ToolStripMenuItem areaToolStripMenuItem2;
        private ContextMenuStrip contextMenuStripZoom;
        private ToolStripMenuItem zoomToVehicleToolStripMenuItem;
        private ToolStripMenuItem zoomToMissionToolStripMenuItem;
        private ToolStripMenuItem zoomToHomeToolStripMenuItem;
        private DataGridViewComboBoxColumn Command;
        private DataGridViewTextBoxColumn Param1;
        private DataGridViewTextBoxColumn Param2;
        private DataGridViewTextBoxColumn Param3;
        private DataGridViewTextBoxColumn Param4;
        private DataGridViewTextBoxColumn Lat;
        private DataGridViewTextBoxColumn Lon;
        private DataGridViewTextBoxColumn Alt;
        private DataGridViewComboBoxColumn Frame;
        private DataGridViewTextBoxColumn coordZone;
        private DataGridViewTextBoxColumn coordEasting;
        private DataGridViewTextBoxColumn coordNorthing;
        private DataGridViewTextBoxColumn MGRS;
        private DataGridViewButtonColumn Delete;
        private DataGridViewImageColumn Up;
        private DataGridViewImageColumn Down;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Angle;
        private DataGridViewTextBoxColumn Dist;
        private DataGridViewTextBoxColumn AZ;
        private DataGridViewTextBoxColumn TagData;
        private ToolStripMenuItem relativeRouteEditorToolStripMenuItem;
        private ToolStripMenuItem shiftedAndRotatedToolStripMenuItem;
        private ToolStripMenuItem wholeBodyMoveToolStripMenuItem;
        public MyButton myButton1;
        public MyButton myButton2;
        public MyButton myButton4;
        private Label lbl_Homelatitude;
        private Label lbl_Homelongitude;
        private Label lbl_Homealtitude;
        private Label lbl_Altitude;
        private Panel panel_info;
        private TextBox textBox_dist;
        private Label label_setdist;
        private Label label_head;
        private PictureBox pictureBox5;
        private TextBox textBox_lat;
        private Label label_infoMassion;
        private TextBox textBox_p2;
        private Label label_lat;
        private Label label_p4;
        private TextBox textBox_p3;
        private Label label_p1;
        private TextBox textBox_p4;
        private Label label_p3;
        private TextBox textBox_lon;
        private Label label_lon;
        private Label label_p2;
        private TextBox textBox_p1;
        private DataGridView Commands1;
        public MyButton myButton_savedist;
        public MyButton myButton7;
        private Panel panel_draw;
        private PictureBox pictureBox9;
        private PictureBox pic_AddOne;
        private PictureBox pic_stand;
        private PictureBox pic_sort;
        private PictureBox pic_drawLoad;
        private PictureBox pic_drawasave;
        private PictureBox pic_drawadelete;
        private PictureBox pic_drawadd;
        private PictureBox pictureBox6;
        private PictureBox pic_draw;
        private Panel panel_zhongche;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private TreeView treeView1;
        private CheckBox checkBox_Reverse_RTL;
        private CheckBox checkBox_WPRad;
        private PictureBox pictureBox_minus;
        private PictureBox pictureBox_add;
        private Panel panel_mapset;
        private PictureBox pictureBox_planset;
        private PictureBox pictureBox_homeset;
        public Label label7;
        private NumericUpDown number_bufferdist;
        private Panel panel6;
        private Panel panel7;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewImageColumn Column_more;
        private DataGridViewImageColumn dataGridViewImageColumn3;
        private Panel panel9;
        private Panel panel8;
        private Panel panel10;
        public Label label8;
        private ToolStripMenuItem remoteLandingSiteToolStripMenuItem;
    }
}