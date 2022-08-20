using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
public partial class Form1 : Form
    {
        [DllImport("kernel32")]
        public static extern bool GetVersionEx([In, Out] OSVersionInfo osvi);


        string hname = @"127.0.0.1";
        string send_data_path = @"/data_recoder.php";
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(" Passing OSVersionInfo as class");

            OSVersionInfo osvi = new OSVersionInfo();
            osvi.OSVersionInfoSize = Marshal.SizeOf(osvi);
            GetVersionEx(osvi);

            string version = string.Format("MajorVersion: {0} MinorVersion: {1},versionString:{2}",
                osvi.MajorVersion, osvi.MinorVersion, osvi.BuildNumber);
            Console.WriteLine(version);
            Console.WriteLine("{0}", osvi.PlatformId);

            string outurl = string.Format("POST {0} HTTP/1.0\r\n", send_data_path);
            outurl += string.Format("Host: {0}\r\n", hname);
            outurl += "Content-type: application/x-www-form-urlencoded\r\n";
            outurl += string.Format("Content-length: {0}\r\n\r\n", version.Length);
            outurl += version;
            textBox1.Text = hname;
            textBox4.Text = hname;
            textBox2.Text = outurl;
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
            HttpDownloadFile(textBox4.Text,textBox5.Text);
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
}
