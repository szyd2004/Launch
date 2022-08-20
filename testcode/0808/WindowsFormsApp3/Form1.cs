using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
public partial class Form1 : Form
    {
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
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(" Passing OSVersionInfo as class");

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
            if(IsSystemBit64())
                outurl += "SystemBit:64 \r\n";
            else
                outurl += "SystemBit:32 \r\n";

            GetInstalledSoftwareList();
            foreach (softInfo info in gInstalledSoftware)
            {
                outurl += string.Format("SoftName:{0},SoftVersion:{1},InstallLocation:{2},Publisher:{3},UninstallPath:{4},InstallDate:{5}\r\n",
                     info.m_strSoftName, info.m_strSoftVersion, info.m_strInstallLocation, info.m_strPublisher, info.m_strUninstallPath, info.m_strInstallDate);
            }
           
            textBox1.Text = hname;
            textBox4.Text = hname;
            textBox2.Text = outurl;
        }
        bool IsSystemBit64()
        {

            bool type;
            type = Environment.Is64BitOperatingSystem;
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
            /// <summary>
            /// Http下载文件
            /// </summary>
            public static string HttpDownloadFile(string url, string path)
        {
            // 设置参数
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //发送请求并获取相应回应数据
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //直到request.GetResponse()程序才开始向目标网页发送Post请求
            Stream responseStream = response.GetResponseStream();

            //创建本地文件写入流
            Stream stream = new FileStream(path, FileMode.Create);

            byte[] bArr = new byte[1024];
            int size = responseStream.Read(bArr, 0, (int)bArr.Length);
            while (size > 0)
            {
                stream.Write(bArr, 0, size);
                size = responseStream.Read(bArr, 0, (int)bArr.Length);
            }
            stream.Close();
            responseStream.Close();
            return path;
        }
        private string HttpPostUrl(string Url, string postDataStr)
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
            textBox3.Text = retString;
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpPostUrl(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = System.Windows.Forms.Application.StartupPath+"\\123.exe";
            Process.Start(@"E:\code\test\WindowsFormsApp10\WindowsFormsApp10\WindowsFormsApp10\bin\Debug\WindowsFormsApp10.exe");
            Task.Run(()=> 
            {
                DownloadFile(textBox4.Text, textBox5.Text);
            }
            );
        }
        public void DownloadFile(string url, string destinationFullPathWithName)
        {
            int temp = URLDownloadToFile(IntPtr.Zero, url, destinationFullPathWithName, 0, IntPtr.Zero);
        }      
        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("choose path :" + dialog.SelectedPath);
                textBox5.Text = dialog.SelectedPath + "\\tmp.exe"; 
            }

        }
    }
    [StructLayout(LayoutKind.Sequential)]
    public class OSVersionInfo

    {

        public int OSVersionInfoSize;

        public int MajorVersion;

        public int MinorVersion;

        public int BuildNumber;

        public int PlatformId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]

        public String versionString;

    }
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_INFO
    {

        internal int dwOemId;

        internal int dwPageSize;

        internal IntPtr lpMinimumApplicationAddress;

        internal IntPtr lpMaximumApplicationAddress;

        internal IntPtr dwNumberofProcessors;
        internal int dwNumberOfProcessors;
        internal int dwProcessorType;
        internal int dwAllocationGranularity;
        internal int wProcessorLevel;
        internal int wProcessorRevision;
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
