﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class DistanceBar : UserControl
    {
        private Brush _brushbar = new SolidBrush(Color.FromArgb(50, Color.White));
        public Color valuebarcolor
        {
            get { return _brushcolor; }
            set
            {
                _brushcolor = value;
                _brushbar = new SolidBrush(Color.FromArgb(50, _brushcolor));
                this.Invalidate();
            }
        }
        private Color _brushcolor;
        private readonly Bitmap icon = global::MissionPlanner.Properties.Resources.marker_05;

        private float _traveleddist = 0;

        public float totaldist { get; set; }
        public float traveleddist
        {
            get { return _traveleddist; }
            set
            {
                _traveleddist = value;
                this.Invalidate();
            }
        }

        private object locker = new object();
        private List<float> wpdist = new List<float>();

        Bitmap buffer = new Bitmap(640, 480);

        public void AddWPDist(float dist)
        {
            lock (locker)
            {
                wpdist.Add(dist);
                totaldist = wpdist.Sum();
            }
        }

        public void ClearWPDist()
        {
            lock (locker)
            {
                wpdist.Clear();
                wpdist.Add(0);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                //parms.ExStyle |= 0x20;
                return parms;
            }
        }

        public DistanceBar()
        {
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //SetStyle(ControlStyles.Opaque, true);

            this.DoubleBuffered = false;

            InitializeComponent();

            totaldist = 100;


            //this.BackColor = Color.Transparent;

            ClearWPDist();
        }

        public void DoPaintRemote(PaintEventArgs e)
        {
            var matrix = new System.Drawing.Drawing2D.Matrix();
            matrix.Translate(this.Left, this.Top);
            e.Graphics.Transform = matrix;
            OnPaint(e);
            e.Graphics.ResetTransform();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

            if (this.Parent != null)
            {
                //Parent.Invalidate(this.Bounds, true);
            }

            try
            {
                using (Graphics etemp = Graphics.FromImage(buffer))
                {
                    if (totaldist <= 0)
                        totaldist = 100;

                    // bar

                    RectangleF bar = new RectangleF(4, 4, this.Width - 8, this.Height - 8);

                    etemp.Clear(Color.Transparent);

                    etemp.FillRectangle(_brushbar, bar);

                    // draw bar traveled

                    RectangleF bartrav = new RectangleF(bar.X, bar.Y, bar.Width * (traveleddist / totaldist), bar.Height);

                    etemp.FillRectangle(_brushbar, bartrav);
                    etemp.FillRectangle(_brushbar, bartrav);
                    etemp.FillRectangle(_brushbar, bartrav);
                    etemp.FillRectangle(_brushbar, bartrav);
                    etemp.FillRectangle(_brushbar, bartrav);

                    // draw wp dist

                    //lock (locker)
                    //{
                    //    float iconwidth = this.Height / 4.0f;
                    //    float trav = 0;
                    //    foreach (var disttrav in wpdist)
                    //    {
                    //        trav += disttrav;

                    //        if (trav > totaldist)
                    //            trav = totaldist;

                    //        etemp.FillPie(Brushes.Yellow, (bar.X + bar.Width * (trav / totaldist)) - iconwidth / 2, bar.Top,
                    //            bar.Height / 2, bar.Height, 0, 360);
                    //        //e.Graphics.DrawImage(icon, (bar.X + bar.Width * (trav / totaldist)) - iconwidth / 2, 1, iconwidth, bar.Height);
                    //    }
                    //}

                    // draw dist traveled

                    string dist = (traveleddist / totaldist).ToString("0.00%");

                    etemp.DrawString(dist, this.Font, new SolidBrush(this.ForeColor), bar.Width/2,
                        bartrav.Bottom - FontHeight);

                    e.Graphics.DrawImageUnscaled(buffer, 0, 0);
                }
            }
            catch (Exception)
            {
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.Width == 0 || this.Height == 0)
                return;

            buffer = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            // base.OnParentBackColorChanged(e);
        }
    }
}