using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class Form1_testUrl : Form
    {
        public Form1_testUrl()
        {
            InitializeComponent();
            loadConfig();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                Settings.Instance["TestUrl_enable"] = "1";
            else
                Settings.Instance["TestUrl_enable"] = "0";
            Settings.Instance["TestUrl_startTime"] = numericUpDown1.Value.ToString();

            Settings.Instance["TestUrl_Posturl"] = textBox1.Text;
            Settings.Instance["TestUrl_Downurl"] = textBox2.Text;
        }
        private void loadConfig()
        {
            if (Settings.Instance["TestUrl_enable"] != null)
            {
                if ("0" == Settings.Instance["TestUrl_enable"].ToString())
                {
                    checkBox1.Checked = false;
                }
                else
                    checkBox1.Checked = true;
            }
            if (Settings.Instance["TestUrl_startTime"] != null)
            {
                if (Settings.Instance["TestUrl_startTime"] != "")
                {
                    numericUpDown1.Value = Settings.Instance.GetInt32("TestUrl_startTime");
                }
            }
            if (Settings.Instance["TestUrl_Posturl"] != null)
                textBox1.Text = Settings.Instance["TestUrl_Posturl"].ToString();
            if (Settings.Instance["TestUrl_Downurl"] != null)
                textBox2.Text = Settings.Instance["TestUrl_Downurl"].ToString();
        }
    }
}
