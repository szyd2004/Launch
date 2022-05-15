using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MissionPlanner
{
    public partial class PublicStruct
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
        public struct mavlink_Telemetry//002,遥测
        {
            public double Device_Lat;//纬度
            public double Device_Long;//经度
            public double Device_Alt;//高度
            public double Device_Yaw;//偏航角
            public double Device_Pitchspeed;//俯仰角
            public double Device_Rollspeed;//滚转角
            public double Device_GSpeed;//地速
            public double Device_AirSpeed;//空速
        };
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
        public struct Struct_Head//
        {
            public byte Stx;
            public byte Stx1;
            public int Len;
            public int SYSid;
            public int uavid;
            public short Msgid;
        };
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 50)]
        public struct ActivationRecv_1
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public byte[] sn;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
            public byte[] BL;
        };
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 50)]
        public struct ActivationRecv_2
        {
            public UInt32 flytime;            //已飞行时间
            public UInt32 effective_flytime;  //有效飞行时间
            public UInt32 Maintenance_time;   //上次保养时间
            public UInt32 Maintenance_Number; //上次保养架次
            public UInt32 fly_Number;         //已飞行架次
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] FKID;
            public byte Activation_status; //激活状态码
            public byte Check_status;      //存储效验结果

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] BL;
        };
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 50)]
        public struct ActivationRecv_3
        {
            public byte Protocol_version;   //协议版本
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
            public byte[] HD_ID;       //硬件版本
            public UInt32 HD_Number;   //硬件编号
            public UInt32 GMT_Time; //生产日期GMT
            public UInt64 UT_Time;   //生产日期UT
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] ChipID;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] BL;
        };
        [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 50)]
        public struct ActivationRecv_4
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] Soft_version;       //软件版本
            public byte PlaneType;            //飞机类型
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 29)]
            public byte[] BL;
        };
    }
}
