using System;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace TH_FreeBall
{
    public partial class Form1 : Form
    {
        List<Ball> balls = new List<Ball>();
        List<bool> enable = new List<bool>();


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
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics b = e.Graphics;
            //foreach (Ball ball in balls)
            //{
            //    SolidBrush brush = new SolidBrush(ball.color);
            //    b.FillEllipse(brush, (int)ball.x, (int)ball.y, (int)ball.d, (int)ball.d);
            //}
            for (int i = 0; i < balls.Count; i++)
            {
                if (enable[i])
                {
                    SolidBrush brush = new SolidBrush(balls[i].color);
                    b.FillEllipse(brush, (int)balls[i].x, (int)balls[i].y, (int)balls[i].d, (int)balls[i].d);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {          

            for (int i = 0; i < balls.Count(); i++)
            {
                for (int j = 0; j < balls.Count() && balls.Count() > 1; j++)
                {
                    if (j == i || !enable[i] || !enable[j])
                        continue;

                    if (balls[i].checkCollision(balls[j]))
                    {
                        enable[i] = false;
                        enable[j] = false;
                    }
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
