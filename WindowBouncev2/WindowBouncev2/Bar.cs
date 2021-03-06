﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace WindowBouncev2
{
    public class Bar : UserControl
    {
        int weakcount = 0;
        public Color BarColor { get; set; }
        public Bar()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            BarColor = Color.Maroon;
        }
        public Bar(Color c)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            BarColor = c;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.FillRectangle(new SolidBrush(this.BarColor), new Rectangle(0, 0, this.Width, this.Height));
            //g.DrawString(this.WeakCount.ToString(), new Font("Arial", 10f, FontStyle.Bold), new SolidBrush(Color.Black), this.Width / 5, this.Height / 5);
        }
        public bool CollisionDetected(Control c)
        {
            int b1_x = this.Location.X;
            int b1_y = this.Location.Y;
            int b1_w = this.Width;
            int b1_h = this.Height;
            Rectangle b1_rec = new Rectangle(b1_x, b1_y, b1_w, b1_h);

            int b2_x = c.Location.X;
            int b2_y = c.Location.Y;
            int b2_w = c.Width;
            int b2_h = c.Height;
            Rectangle b2_rec = new Rectangle(b2_x, b2_y, b2_w, b2_h);

            if (b1_rec.IntersectsWith(b2_rec))
            {
                return true;
            }
            return false;
        }
    }
}
