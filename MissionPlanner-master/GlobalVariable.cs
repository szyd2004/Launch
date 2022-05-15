using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GMap.NET.MapProviders;
using MissionPlanner.Utilities;
using System.Drawing;

namespace MissionPlanner
{    
    public class GlobalVariable : PublicStruct
    {
        public static IDictionary<string,Color> G_ErrorList = new Dictionary<string, Color>();
        public static MAVLink.mavlink_sys_status_t G_sys_status = new MAVLink.mavlink_sys_status_t();
        public static MAVLink.mavlink_gps_raw_int_t G_gps_raw = new MAVLink.mavlink_gps_raw_int_t();
        public static MAVLink.mavlink_attitude_t G_attitude = new MAVLink.mavlink_attitude_t();
        public static MAVLink.mavlink_global_position_int_t G_global_position = new MAVLink.mavlink_global_position_int_t();
        public static MAVLink.mavlink_vfr_hud_t G_vfr_hud = new MAVLink.mavlink_vfr_hud_t();

        public static MAVLink.mavlink_heartbeat_t G_heartbeat = new MAVLink.mavlink_heartbeat_t();


        public static int speedV = 0;
        public static int G_SNReturn = 0;
        public static int G_SNReturn1 = 0;
        public static int ActivationType1 = 0;
        public static int ActivationType2 = 0;
        public static int ActivationType3 = 0;
        public static int ActivationType4 = 0;
        public static List<PointLatLngAlt> Drawpolygon = new List<PointLatLngAlt>();
        public static List<string> TableNameList = new List<string>();
        public static List<Byte[]> Listmavlink228 = new List<Byte[]>();
        public static List<Byte[]> Listmavlink235 = new List<Byte[]>();
        public static List<Byte> ByteSMDCGSCom = new List<Byte>();
        public static List<Byte> ByteSMDCGSCom2 = new List<Byte>();
        public static List<string> ByteSMDCGSComShow = new List<string>();
        public static bool SMDCGSComShowFlag = false;
        public static string SoftName = "";
        public static string SoftVersion = "";
        public static ushort glinkqualitygcsint = 0; //获取参数列表标记位
        public static float G_distTraveled = 0; //以飞行距离

        public static bool getParamListFlag = false; //获取参数列表标记位
        public static bool userParamListFlag = false;
        public static byte GlobalPlanType = 1;
        public static byte RememberMe = 0;
        public static bool JoystickEnablo = false;//相机云台是否接收；
        public static bool runCameraRunFlag = false;
        public static bool IsEnglishfalg = true;
        public static bool IsF11Press = false;

        public static bool WPRadCheckedFlag = true;
        public static bool DrawCheckFlag = false;
        public static bool DrawCheckUIFlag = false;

        public static double g_WPALLDist = 0.0;

        public static bool AircheckFlag = false;
        public static bool CalobrationFlag = false;
        public static bool MessageboxShowFlag = false;

        /// <summary>
        /// 新手模式变量
        /// </summary>
        public static bool NewmodeFlag = false;
        public static bool checkBox_LandChecked = false;//原地降落标志；
        public static double Land_Lng = 0.0;//降落经纬度；
        public static double Land_Lat = 0.0;//降落经纬度；
        public static int numericUpDown_LandYaw_value = 0;//降落点风向角；
        public static int WaypointAutoCount = 0;     //巡航点数；
        public static int Waypoint_alt_takeoff = 0;  //巡航点 起飞点高度；
        public static int Waypoint_alt_waypoint = 0; //巡航点 巡航点高度；
        public static int Waypoint_alt_land = 0;     //巡航点 降落点高度；

      //  public static int batteryIsOnline = 0;
        public static GMapProvider[] listMap = null;

        public static int GuidedAlt = 100;     //巡航点 降落点高度；

        public static int Time254Sleep = 20;
        public static int g_Errorcode = 0;

        public static bool G_RCreeorRunflag = false;

        public static bool G_aramdFlag = false;

        public static bool G_CheckselfFlag = false;
        public static bool G_CheckselfSucsessFlag = false;

        public static int smd_MagCalibCompass = 20;
        public static int smd_ISGEO = 0;

        public static bool smd_btnpress11 = false;
        public static bool smd_btnpress12 = false;

        public static bool smd_Campress = false;

        public static ushort YawQingzhuan;
    }
}
