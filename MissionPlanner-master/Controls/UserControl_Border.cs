using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class UserControl_Border : UserControl
    {
        public UserControl_Border()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e.ClipRectangle, e.Graphics, 10);
            //base.OnPaint(e);
        }
        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    Draw(e.ClipRectangle, e.Graphics, 10);
        //    base.OnPaintBackground(e);
        //}
        private void Draw(Rectangle rectangle, Graphics g, int _radius)
        {
            Pen shadowPen = new Pen(Color.White);
            shadowPen.Width = 3;
            g.SmoothingMode = SmoothingMode.HighQuality; //高质量
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; //高像素偏移质量
            g.DrawPath(shadowPen, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width - 2, rectangle.Height - 1, _radius));
        }
        public static GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(x, y, radius, radius, 180, 90);
            gp.AddArc(width - radius, y, radius, radius, 270, 90);
            gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            gp.AddArc(x, height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            return gp;
        }
    }
}
