using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyProgressBar
{
    public partial class MyArcProgressBar : UserControl
    {
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string PText { get { return _Text; } set { _Text = value; } }
        [Description("最大值")]
        [Category("Behavior")]
        public int MaxValue { get { return _MaxValue; } set { _MaxValue = value; } }

        [Description("最小值")]
        [Category("Behavior")]
        public int MinValue { get { return _MinValue; } set { _MinValue = value; } }

        [Description("进度条值")]
        [Category("Behavior")]
        public double Value { get { return _Value; } set { _Value = value; this.Invalidate(); } }
       
        [Description("进度条宽度")]
        [Category("Behavior")]
        public int Pwidth { get { return _Pwidth; } set { _Pwidth = value; this.Invalidate(); } }

        [Description("左边界")]
        [Category("Behavior")]
        public int Pleft { get { return _Pleft; } set { _Pleft = value; this.Invalidate(); } }
        [Description("右边界")]
        [Category("Behavior")]
        public int PRight { get { return _PRight; } set { _PRight = value; this.Invalidate(); } }
        [Description("上边界")]
        [Category("Behavior")]
        public int PTop { get { return _PTop; } set { _PTop = value; this.Invalidate(); } }
        [Description("下边界")]
        [Category("Behavior")]
        public int PBotton { get { return _PBotton; } set { _PBotton = value; this.Invalidate(); } }

        [Description("进度条背景色")]
        [Category("Behavior")]
        public Color PProgresBackColor { get { return _ProgresBackColor; } set { _ProgresBackColor = value; this.Invalidate(); } }

        [Description("进度条前景色")]
        [Category("Behavior")]
        public Color PProgresFrontColor { get { return _PProgresFrontColor; } set { _PProgresFrontColor = value; this.Invalidate(); } }

        [Description("字体颜色")]
        [Category("Behavior")]
        public Color PFontColor { get { return _ForeColor; } set { _ForeColor = value; this.Invalidate(); } }
        
        [Description("标题内容")]
        [Category("Behavior")]
        public string TitleText { get { return _TitleText; } set { _TitleText = value; this.Invalidate(); } }
        [Description("单位")]
        [Category("Behavior")]
        public string UnitText { get { return _unitText; } set { _unitText = value; this.Invalidate(); } }
        [Description("标题高度")]
        [Category("Behavior")]
        public int HeightTitle { get { return _heightTitle; } set { _heightTitle = value; this.Invalidate(); } }
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public Font PTitleFont { get { return _TitleFont; } set { _TitleFont = value; this.Invalidate(); } }
        [Description("底部字高度")]
        [Category("Behavior")]
        public int MaxminTextHeight { get { return _MaxminTextHeight; } set { _MaxminTextHeight = value; this.Invalidate(); } }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public Font PFont { get { return _Font; } set { _Font = value; this.Invalidate(); } }
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public Font FontUnit { get { return _FontUnit; } set { _FontUnit = value; this.Invalidate(); } }
        

        private double _Value = 0.0f;
        private string _Text = "0";
        private int _MaxValue = 100;
        private int _MinValue = 0;
        private int _Pwidth = 0;

        private int _heightTitle = 20;
        private int _MaxminTextHeight = 20;
        private string _TitleText = "test";
        private string _unitText = "";

        private int _Pleft = 0;
        private int _PRight = 0;
        private int _PTop = 0;
        private int _PBotton = 0;
        private Color _ProgresBackColor = Color.White;
        private Color _PProgresFrontColor = Color.Red;

        private Color _ForeColor = Color.FromArgb(64, 64, 64);
        private Font _Font = new Font("Microsoft Sans Serif", 72, FontStyle.Bold);
        private Font _TitleFont = new Font("Microsoft Sans Serif", 30, FontStyle.Bold);
        private Font _FontUnit = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);

        public MyArcProgressBar()
        {
            InitializeComponent();            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.TextRenderingHint = TextRenderingHint.AntiAlias;
                g.SmoothingMode = SmoothingMode.HighQuality;

                //g.CompositingMode = CompositingMode.SourceCopy;

                int DrawWidth = this.Width - _Pleft - _PRight;
                int DrawHeight = this.Height * 2 - _PTop - _PBotton - _heightTitle  - _MaxminTextHeight;

                if (_Value >= (_MaxValue - _MinValue))
                    _Value = _MaxValue - _MinValue;
                float persent = (float)(_Value / (_MaxValue - _MinValue)) * 180.0f;

                GraphicsPath path = new GraphicsPath();

                path.AddArc(_Pleft, _PTop, DrawWidth, DrawHeight, 180, 180);
                path.AddArc(_Pleft + _Pwidth, _PTop + _Pwidth,
                    DrawWidth - 2 * _Pwidth, DrawHeight - 2 * _Pwidth, 0, -180);
                g.FillPath(new SolidBrush(_ProgresBackColor), path);
                path = new GraphicsPath();

                path.AddArc(_Pleft, _PTop, DrawWidth, DrawHeight, 180,
                    persent);
                path.AddArc(_Pleft + _Pwidth, _PTop + _Pwidth,
                    DrawWidth - 2 * _Pwidth, DrawHeight - 2 * _Pwidth, 180 + persent, -persent);

               
                g.FillPath(new SolidBrush(_PProgresFrontColor), path);

                var stringFormat =
                       new StringFormat(RightToLeft == RightToLeft.Yes ? StringFormatFlags.DirectionRightToLeft : 0)
                       {
                           Alignment = StringAlignment.Center,
                           LineAlignment = StringAlignment.Near
                       };
                var textSize = g.MeasureString(_Text, _Font);
                var textPoint = new PointF(
                    Pleft + (DrawWidth - textSize.Width)/ 2 ,
                    this.Height/ 2 - 5);
                if (_Text == string.Empty)
                {
                    return;
                }
                g.DrawString(
                        _Text,
                        _Font,
                        new SolidBrush(_ForeColor),
                        new RectangleF(textPoint, textSize),
                        stringFormat);
                textSize = g.MeasureString(_unitText, _FontUnit);
                g.DrawString(
                        _unitText,
                        _FontUnit,
                        new SolidBrush(_ForeColor), this.Width/2,
                        this.Height - textSize.Height-5, stringFormat);

                g.DrawString(
                        _TitleText,
                        _TitleFont,
                        new SolidBrush(_ForeColor),(this.Width)/2,
                        1,     stringFormat);
                string textV = _MinValue.ToString();
                textSize = g.MeasureString(textV, _FontUnit);
                g.DrawString(
                        textV,
                        _FontUnit,
                        new SolidBrush(_ForeColor), _Pleft + 10,
                        this.Height - textSize.Height + 5, stringFormat);
                textV = _MaxValue.ToString();
                textSize = g.MeasureString(textV, _FontUnit);
                g.DrawString(
                        textV,
                        _FontUnit,
                        new SolidBrush(_ForeColor), this.Width - textSize.Width/2,
                        this.Height - textSize.Height + 5 , stringFormat);                
            }
            catch
            {
                // ignored
            }



        }
    }
}
