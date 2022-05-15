using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class MessboxLATLongChoose : Form
    {
        public bool ShowMessageInfo = false;
        public double Latitude {  get { return _latitude; }   }
        double _latitude = 0.0f;
        public double Longitude { get { return _longitude; } }
        double _longitude = 0.0f;

        public MessboxLATLongChoose(String titlestr ,double latitude, double longitude)
        {            
            InitializeComponent();
            TopMost = false;
            BringToFront();
            TopMost = true;           

            this.ControlBox  = false;   // 设置不出现关闭按钮
            label_title.Text          = titlestr;
            text_Lat.Text   = latitude.ToString();
            text_long.Text = longitude.ToString();
            _latitude    = latitude;
            _longitude = longitude;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
          //  this.pictureBox4.Image = Properties.Resources.CloseWindowsPress;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
           // this.pictureBox4.Image = Properties.Resources.CloseWindows;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowMessageInfo = false;
            this.Close();
        }
        private Point offset = new Point();
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }

        private void myButton1_Click(object sender, EventArgs e)
        {//ok
            ShowMessageInfo = true;
            _latitude    = double.Parse( text_Lat.Text);
            _longitude = double.Parse(text_long.Text);
            this.Close();
        }

        private void BUT_read_Click(object sender, EventArgs e)
        {//close
            ShowMessageInfo = false;
            this.Close();
        }
    }
}
