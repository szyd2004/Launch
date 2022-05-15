using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MissionPlanner.Controls
{
    public partial class UserHSI : UserControl
    {
        public UserHSI()
        {
            InitializeComponent();
        }
        public int Heading
        {
            get { return _angle; }
            set { _angle = value; if (!this.DesignMode) this.Invalidate(); }
        }
        public XmlDocument SetImg
        {
            get { return _img; }
            set
            {
                _img = value;
                if (!this.DesignMode) this.Invalidate();
            }
        }
        XmlDocument _img ;
        int _angle = 0;

        private void UserHSI_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
           
            var doc1 = SvgDocument.Open(_img);
            int wid = this.Width;
            int hei = this.Height;
            int imgsize = (hei > wid) ? wid : hei;
            var img1 = new Bitmap(imgsize / 3, imgsize / 3);
            doc1.Draw(img1);

            var test = e.Graphics.Save();
            e.Graphics.TranslateTransform(this.Width / 2.0f, this.Height / 2.0f);
            e.Graphics.RotateTransform(_angle);
            e.Graphics.DrawImage(img1, -img1.Width / 2.0f, -img1.Height / 2.0f, img1.Width, img1.Height);
            e.Graphics.ResetTransform();

            e.Graphics.Restore(test);

            Font _titlefont = new Font("微软雅黑", 12, FontStyle.Regular);
            string sizestr = _angle.ToString();
            SizeF sizeF = e.Graphics.MeasureString(sizestr, _titlefont);
            e.Graphics.DrawString(sizestr, _titlefont, new SolidBrush(Color.White), (this.Width - sizeF.Width) / 2, (this.Height - sizeF.Height) / 2);
        }
    }
}
