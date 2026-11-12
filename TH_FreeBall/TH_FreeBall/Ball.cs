using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TH_FreeBall
{

    internal class Ball
    {
        Random rand = new Random();
        public double x, y, d, c;
        public int formWidth, formHeight;
        public double x_speed, y_speed;

        
        public Color color;

        public Ball(int x = 1, int y = 1, int d = 50, int fW=200, int fH=200, int xs = 2, int ys = 2)
        { 
            this.x= x;
            this.y= y;
            this.d = d;
            this.c = d / 2;
            this.formWidth= fW;
            this.formHeight= fH;
            this.x_speed = xs;
            this.y_speed = ys;
            this.color = Color.FromArgb(255, rand.Next(256), rand.Next(256), rand.Next(256));
        }

        public void check()
        {
            if (x <= 0 || (x + d) >= formWidth)
            {
                if (x > 0)
                {
                    x_speed = x_speed > 0 ? -x_speed : x_speed;
                }
                else
                {
                    x_speed = x_speed < 0 ? -x_speed : x_speed;
                }
            }
            if (y <= 0 || (y + d) >= formHeight)
            {
                if (y > 0)
                {
                    y_speed = y_speed > 0 ? -y_speed : y_speed;
                }
                else
                {
                    y_speed = y_speed < 0 ? -y_speed : y_speed;
                }
            }
        }

        public bool checkCollision(Ball ball2)
        {
            double tx1 = x+c, ty1 = y+c;


            double tx2 = ball2.x + ball2.c, ty2 = ball2.y + ball2.c;

            if (Math.Sqrt(Math.Pow(tx1-tx2,2) + Math.Pow(ty1-ty2,2)) <= (c+ball2.c))
            {
                return true;
            }
            return false;

        }
        public void move()
        {
            x += x_speed;
            y += y_speed;
        }
    }
}
