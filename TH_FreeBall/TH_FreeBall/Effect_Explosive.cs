using System;
using System.Collections.Generic;
using System.Text;

namespace TH_FreeBall
{
    internal class Effect_Explosive
    {
        
        public double x, y, d;
        public int frame;
        public Effect_Explosive(double x = 1, double y = 1, double d = 0)
        {
            this.x = x;
            this.y = y;
            this.d = d;
            this.frame = 10;
        }
    }
}
