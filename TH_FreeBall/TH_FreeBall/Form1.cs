using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TH_FreeBall
{
    public partial class Form1 : Form
    {
        List<Ball> balls = new List<Ball>();
        List<bool> enable = new List<bool>();
        List<Effect_Explosive> eff_ex = new List<Effect_Explosive>();

        Image effect_explosive_image;


        Random rand = new Random();
        public double g = 0.3;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        int x = 30, y = 30;
        int x_speed = 2, y_speed = 2;
        int w = 60, h = 60;

        public int left() { return x; }
        public int right() { return x + w; }
        public int top() { return y; }
        public int bottom() { return y + h; }

        public void check()
        {
            if (left() <= 0 || right() >= this.ClientSize.Width)
            {
                x_speed = -x_speed;
            }
            if (top() <= 0 || bottom() >= this.ClientSize.Height)
            {
                y_speed = -y_speed;
            }
            if (y_speed >= 0)
                y_speed = 2;
            else
                y_speed = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 16;
            timer1.Start();
            effect_explosive_image = Image.FromFile("explosive_effect.png");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics b = e.Graphics;

            for (int i = 0; i < balls.Count; i++)
            {
                if (enable[i])
                {
                    SolidBrush brush = new SolidBrush(balls[i].color);
                    b.FillEllipse(brush, (int)balls[i].x, (int)balls[i].y, (int)balls[i].d, (int)balls[i].d);
                }
            }
            foreach (Effect_Explosive ef in eff_ex)
            {
                if (ef.frame > 0)
                {
                    b.DrawImage(effect_explosive_image, (int)ef.x, (int)ef.y, (int)ef.d, (int)ef.d);

                    ef.frame--;
                    ef.d += 20;
                    ef.x-=10;
                    ef.y-=10;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {          
            List<Ball> new_balls = new List<Ball>();
            for (int i = 0; i < balls.Count(); i++)
            {
                for (int j = i+1 ; j < balls.Count() && balls.Count() > 1; j++)
                {
                    if (j == i || !enable[i] || !enable[j])
                        continue;

                    if (balls[i].checkCollision(balls[j]))
                    {
                        enable[i] = false;
                        enable[j] = false;

                        eff_ex.Add(new Effect_Explosive((balls[i].x + balls[j].x) / 2, 
                                                        (balls[i].y + balls[j].y) / 2));
                    }


                }
                if (enable[i])
                {
                    new_balls.Add(balls[i]);
                }
            }

            for (int i = 0; i < balls.Count(); i++)
            {
                balls[i].formHeight = this.ClientSize.Height;
                balls[i].formWidth = this.ClientSize.Width;
                balls[i].check();
                balls[i].y_speed += g;
                balls[i].move();

                if (balls[i].x + balls[i].d > balls[i].formWidth)
                {
                    balls[i].x = balls[i].formWidth - balls[i].d;
                }

                if (balls[i].y + balls[i].d > balls[i].formHeight)
                {
                    balls[i].y = balls[i].formHeight -balls[i].d;
                }
            }
            int alive = 0;
            for (int i = 0; i < eff_ex.Count(); i++)
            {
                if (eff_ex[i].frame > 0)
                {
                    eff_ex[alive] = eff_ex[i];
                    alive++;
                }
            }
            eff_ex.RemoveRange(alive, eff_ex.Count() - alive);

            balls = new_balls;
            enable = Enumerable.Repeat(true, balls.Count()).ToList();
            Invalidate();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int duongkinh = rand.Next(30,80);
            int speed = rand.Next(1, 5);
            Ball ball = new Ball((e.X - duongkinh/2), e.Y - duongkinh/2, 60, this.ClientSize.Width, this.ClientSize.Height, speed*rand.Next(-1,1), speed);
            balls.Add(ball);
            enable.Add(true);
        }
    }
}
