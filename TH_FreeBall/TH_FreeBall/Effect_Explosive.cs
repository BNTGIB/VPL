using System;
using System.Collections.Generic;
using System.Text;

namespace TH_FreeBall
{
    internal class Effect_Explosive
    {
        public double x, y, d, c;
        public int formWidth, formHeight;
        public double x_speed, y_speed;


        public Color color;

        public Effect_Explosive(int x = 1, int y = 1, int d = 50, int fW = 200, int fH = 200, int xs = 2, int ys = 2)
        {
            this.x = x;
            this.y = y;
            this.d = d;
            this.c = d / 2;
            this.formWidth = fW;
            this.formHeight = fH;
            this.x_speed = xs;
            this.y_speed = ys;
            this.color = Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256));
        }
    }
}
