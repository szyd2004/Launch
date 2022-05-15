using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using MissionPlanner.Utilities;
using System.IO;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class Draw_AddOne : Form
    {
        public int CountAdd = 0;
        public List<Locationwp> cmdlist = new List<Locationwp>();
        public Draw_AddOne()
        {
            InitializeComponent();
            CountAdd = 0;
            if(GlobalVariable.IsEnglishfalg)
            {
                this.Text = "Airline merger";
                myButton1.Text = "Load";
                myButton2.Text = "Create";
            }
        }
       
        public bool CheckIsDrawWP(string file)
        {
            bool ReturnFlag = false;
            byte IDComand = 0;
            int CountCAM_TRIGG_DIST = 0;
            
            try
            {
                StreamReader sr = new StreamReader(file); //"defines.h"
                string header = sr.ReadLine();
                if (header == null || !header.Contains("QGC WPL"))
                {
                    if (GlobalVariable.IsEnglishfalg)
                        CustomMessageBox.Show("Invalid airline file");
                    else
                        CustomMessageBox.Show("无效的航线文件");
                    return false;
                }

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    if (line.StartsWith("#"))
                        continue;

                    string[] items = line.Split(new[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    if (items.Length <= 9)
                        continue;
                    try
                    {
                        IDComand = (byte)(int)Enum.Parse(typeof(MAVLink.MAV_CMD), items[3], false);             
                        if(206 == IDComand)
                        {
                            CountCAM_TRIGG_DIST++;
                        }

                    }
                    catch { CustomMessageBox.Show("Line invalid\n" + line); }
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Can't open file! " + ex);
            }
            if((CountCAM_TRIGG_DIST >1) && (0 == CountCAM_TRIGG_DIST%2))
            {
                ReturnFlag = true;
            }
            else
            {
                ReturnFlag = false;
            }
            return ReturnFlag;
        }

        public List<Locationwp> readQGC110wpfile(string file)
        {
            int wp_count = 0;
            bool error = false;
            List<Locationwp> cmds = new List<Locationwp>();

            try
            {
                StreamReader sr = new StreamReader(file); //"defines.h"
                string header = sr.ReadLine();
                if (header == null || !header.Contains("QGC WPL"))
                {
                    CustomMessageBox.Show("Invalid Waypoint file");
                    return new List<Locationwp>(); 
                }

                while (!error && !sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // waypoints

                    if (line.StartsWith("#"))
                        continue;

                    string[] items = line.Split(new[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (items.Length <= 9)
                        continue;

                    try
                    {
                        Locationwp temp = new Locationwp();
                        if (items[2] == "3")
                        { // abs MAV_FRAME_GLOBAL_RELATIVE_ALT=3
                            temp.options = 1;
                        }
                        else
                        {
                            temp.options = 0;
                        }
                        temp.id = (byte)(int)Enum.Parse(typeof(MAVLink.MAV_CMD), items[3], false);
                        temp.p1 = float.Parse(items[4], new CultureInfo("en-US"));

                        if (temp.id == 99)
                            temp.id = 0;

                        temp.alt = (float)(double.Parse(items[10], new CultureInfo("en-US")));
                        temp.lat = (double.Parse(items[8], new CultureInfo("en-US")));
                        temp.lng = (double.Parse(items[9], new CultureInfo("en-US")));

                        temp.p2 = (float)(double.Parse(items[5], new CultureInfo("en-US")));
                        temp.p3 = (float)(double.Parse(items[6], new CultureInfo("en-US")));
                        temp.p4 = (float)(double.Parse(items[7], new CultureInfo("en-US")));

                        cmds.Add(temp);

                        wp_count++;

                    }
                    catch
                    {
                        CustomMessageBox.Show("Line invalid\n" + line);
                        return new List<Locationwp>();
                    }
                }

                sr.Close();

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Can't open file! " + ex);
                return new List<Locationwp>();
            }
            return cmds;
        }
        private List<Locationwp> ClearHeadAndEnd(List<Locationwp> cmds)
        {
            int Count = cmds.Count;
            if (Count < 1)
                return new List<Locationwp>();
            int index = 0;
            while (Count > index)
            {
               if(cmds[index + 1].id == 206)
                {
                    break;
                }
               else
                {
                    cmds.RemoveAt(0);
                    Count = cmds.Count;
                    index = 0;
                }
            }
            Count = cmds.Count;
            index = Count - 1;
            while (Count > 0)
            {
                if (cmds[index].id == 206)
                {
                    break;
                }
                else
                {
                    cmds.RemoveAt(index);
                    Count = cmds.Count;
                    index = Count - 1;
                }
            }
            return cmds;
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            string filestr = "";
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "SMD_UAV Types|*.smdwp;*.txt";
                DialogResult result = fd.ShowDialog();
                filestr = fd.FileName;
                if (filestr.Length < 1)
                {
                    return;
                }
                if (CheckIsDrawWP(filestr))
                    listBox1.Items.Add(filestr);
                else
                {
                    if (GlobalVariable.IsEnglishfalg)
                        CustomMessageBox.Show("Invalid surveying and mapping route documents");
                    else
                        CustomMessageBox.Show("无效的测绘航线文件");
                }
                    
            }
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            List<Locationwp> cmds = new List<Locationwp>();
            CountAdd = listBox1.Items.Count;
            if (CountAdd < 2)
            {
                return;
            }

            try
            {
                for (int i = 0;i< CountAdd; i++)
                {
                    cmds = readQGC110wpfile(listBox1.Items[i].ToString());
                    cmds = ClearHeadAndEnd(cmds);
                    cmdlist.AddRange(cmds);
                }
                Locationwp temp = cmdlist[0];
                cmdlist.Insert(0, temp);
                MainV2.instance.FlightPlanner.WPtoScreen(cmdlist);
                this.Close();
            }
            catch(Exception ex)
            {

            }
        }

        private void BUT_saveWPFile_Click(object sender, EventArgs e)
        {
            string filestr = "";
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "SMD_UAV Types|*.smdwp;*.txt";
                DialogResult result = fd.ShowDialog();
                filestr = fd.FileName;
                if (filestr.Length < 1)
                {
                    return;
                }
                if (CheckIsDrawWP(filestr))
                    listBox1.Items.Add(filestr);
                else
                {
                    if (GlobalVariable.IsEnglishfalg)
                        CustomMessageBox.Show("Invalid surveying and mapping route documents");
                    else
                        CustomMessageBox.Show("无效的测绘航线文件");
                }

            }
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            List<Locationwp> cmds = new List<Locationwp>();
            CountAdd = listBox1.Items.Count;
            if (CountAdd < 2)
            {
                return;
            }

            try
            {
                for (int i = 0; i < CountAdd; i++)
                {
                    cmds = readQGC110wpfile(listBox1.Items[i].ToString());
                    cmds = ClearHeadAndEnd(cmds);
                    cmdlist.AddRange(cmds);
                }
                Locationwp temp = cmdlist[0];
                cmdlist.Insert(0, temp);
                MainV2.instance.FlightPlanner.WPtoScreen(cmdlist);
                this.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
