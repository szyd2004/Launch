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
    public partial class MessboxInput : Form
    {
        public bool ShowMessageInfo = false;
        public int ALT { get { return _alt; } }
        int _alt = 0;

        public MessboxInput(String titlestr ,int alt)
        {            
            InitializeComponent();
      
            TopMost = false;
            BringToFront();
            TopMost = true;
           // MessageBox.Show("alt1——"+alt.ToString());
            this.ControlBox  = false;   // 设置不出现关闭按钮
            label_title.Text          = titlestr;
            if (alt < (int)numericUpDown1.Minimum)
                alt = (int)numericUpDown1.Minimum;
            if(alt > (int)numericUpDown1.Maximum)
                alt = (int)numericUpDown1.Maximum;
        //    MessageBox.Show(alt.ToString());
            numericUpDown1.Value   = alt;
            _alt = alt;
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
            _alt =(int)numericUpDown1.Value;
            this.Close();
        }

        private void BUT_read_Click(object sender, EventArgs e)
        {//close
            ShowMessageInfo = false;
            this.Close();
        }
    }
}
