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
    public partial class MessboxShowInfo : Form
    {
        private Image Close_ok = null;
        private Image Close_okPress = null;
        private Image Close_cancel = null;
        private Image Close_cancelpress = null;
        public bool ShowMessageInfo = false;
        private bool IsEnglishfalg = true;
        public MessboxShowInfo(String titlestr ,String messagestr, int level = 1,int buttonshow = 1,bool BarVisible = false)
        {            
            InitializeComponent();
            TopMost = false;
            BringToFront();
            TopMost = true;
            //if (!IsEnglishfalg)
            //{
            //    this.Close_ok = global::MissionPlanner.Properties.Resources.clsoebtn;
            //    this.Close_okPress = global::MissionPlanner.Properties.Resources.closepress;
            //    this.Close_cancel = global::MissionPlanner.Properties.Resources.取消;
            //    this.Close_cancelpress = global::MissionPlanner.Properties.Resources.取消press;
            //}
            //else
            {
                this.Close_ok = global::MissionPlanner.Properties.Resources.OK_2;
                this.Close_okPress = global::MissionPlanner.Properties.Resources.OK_1;
                this.Close_cancel = global::MissionPlanner.Properties.Resources.Cancel_2;
                this.Close_cancelpress = global::MissionPlanner.Properties.Resources.Cancel_1;
            }
            this.pictureBox2.Image = this.Close_ok;
            this.pictureBox1.Image = this.Close_cancel;

            switch(level)
            {
                case 0:
                    pictureBox_wring.Visible = false;
                    break;
                case 1://叹号
                    pictureBox_wring.Image = Properties.Resources.Messbox_1;
                    break;
                case 2://问号
                    pictureBox_wring.Image = Properties.Resources.Messbox_2;
                    break;
                case 3://错误
                    pictureBox_wring.Image = Properties.Resources.Messbox_3;
                    break;
                case 4://加载等待
                    pictureBox_wring.Image = Properties.Resources.Messbox_4;
                    break;
                case 5://成功
                    pictureBox_wring.Image = Properties.Resources.Messbox_5;
                    break;
                default:
                    pictureBox_wring.Image = Properties.Resources.Messbox_1;
                    break;
            }

            /* switch (buttonshow)
              {
                  case 0:
                      pictureBox2.Visible = false;
                      pictureBox3.Visible = false;
                      pictureBox1.Visible = false;
                      break;
                  case 1:
                      pictureBox2.Visible = true;
                      pictureBox3.Visible = true;
                      pictureBox1.Visible = true;
                      break;
                  case 2://确定
                      pictureBox2.Visible = true;
                      pictureBox3.Visible = false;
                      pictureBox1.Visible = false;
                      break;
                  case 3://取消
                      pictureBox2.Visible = false;
                      pictureBox3.Visible = false;
                      pictureBox1.Visible = true;
                      break;
                  default:
                      pictureBox2.Visible = true;
                      pictureBox3.Visible = true;
                      pictureBox1.Visible = true;
                      break;
              }*/
            pictureBox2.Visible = true;
        //    pictureBox3.Visible = true;
            pictureBox1.Visible = true;

            progressBar1.Visible = BarVisible;
            this.ControlBox  = false;   // 设置不出现关闭按钮
            this.Text        = titlestr;
            this.label1.Text = messagestr;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.OK_1;
            //    this.pictureBox3.Image = global::MissionPlanner.Properties.Resources.midleft;

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.OK_2;
            //this.pictureBox3.Image = global::MissionPlanner.Properties.Resources.midd;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.Cancel_1;
        //    this.pictureBox3.Image = global::MissionPlanner.Properties.Resources.midright;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Properties.Resources.Cancel_2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowMessageInfo = true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowMessageInfo = false;
            this.Close();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
         //   this.pictureBox4.Image = global::MissionPlanner.Properties.Resources.CloseWindowsPress;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
          //  this.pictureBox4.Image = global::MissionPlanner.Properties.Resources.CloseWindows;
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

        

    }
}
