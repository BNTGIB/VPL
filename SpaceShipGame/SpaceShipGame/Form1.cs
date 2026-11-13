using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SpaceShipGame
{
    public partial class Form1 : Form
    {
        //METERO
        List<Metero> meteros = new List<Metero>();
        List<bool> enable_metero = new List<bool>();
        int time_metero = 0;

        //Image[] metero_frame;
        //Bitmap bg;

        //Space Ship

        Ship Ship1;
        Image ship1_image;

        //Fire
        List<Fire> fires = new List<Fire>();
        List<bool> enable_fire = new List<bool>();

        Image fire_image;
        int fire_countDown = 0;

        //Effect_Explosive
        List<Explosive_effect> explosive_effects = new List<Explosive_effect>();
        Image[] explosive_images = new Image[9];

        Random rand = new Random();
        public double g = 0.3;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ship1 = new Ship(this.ClientSize.Width, this.ClientSize.Height);
            ship1_image = Image.FromFile("Img\\SpaceShip\\spaceships\\SpaceShips\\Ship_2.png");

            fire_image = Image.FromFile("Img\\SpaceShip\\firemeo.png");

            for (int i = 0; i < 9; i++)
            {
                explosive_images[i] = Image.FromFile("Img\\Effect_Explosive\\"+(i+1).ToString()+".png");
            }
            timer1.Interval = 20;
            timer1.Start(); ;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics b = e.Graphics;
            
            b.DrawImage(ship1_image, Ship1.x, Ship1.y);
            
            foreach (Fire fire in fires)
            {
                b.DrawImage(fire_image, fire.x, fire.y);
            }
            foreach (Metero metero in meteros)
            {
                b.DrawImage(Image.FromFile("Img\\metero\\metero.png"), metero.x, metero.y);
            }
            foreach (Explosive_effect ef in explosive_effects)
            {
                b.DrawImage(explosive_images[(8 - ef.frame)%9], ef.x, ef.y, 100, 100);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Ship
            Ship1.move();

            //Fire
            if(fire_countDown>0)
                fire_countDown--;

            for (int i = 0; i < fires.Count; i++)
            {
                fires[i].Move();
                if (fires[i].IsDead())
                {
                    enable_fire[i] = false;
                }
            }

            

            //Metero
            time_metero++;
            time_metero %= 120;
            if (time_metero % 20 == 0)
            {
                meteros.Add(new Metero(this.ClientSize.Width, this.ClientSize.Height));
                enable_metero.Add(true);
            }

            for (int i = 0; i < meteros.Count; i++)
            {
                meteros[i].move();
                if (meteros[i].IsDead())
                    enable_metero[i] = false;
            }

            //Explosive Effect
            int Explosive_eff_dead = 0;
            for (int i = 0; i < explosive_effects.Count; i++)
            {
                if (explosive_effects[i].IsDead())
                {
                    Explosive_eff_dead++;
                }

                if(explosive_effects[i].frame > 0)
                    explosive_effects[i].frame--;
            }
            explosive_effects.RemoveRange(0, Explosive_eff_dead);
            

            //Conclision Metero - Fire
            for (int i = 0; i < meteros.Count; i++)
            {
                for (int j = 0; j < fires.Count; j++)
                {
                    if (meteros[i].conclision_fire(fires[j]))
                    {
                        enable_metero[i] = false;
                        enable_fire[j] = false;
                        int eff_x = meteros[i].x + meteros[i].d/2 - 50, 
                            eff_y = meteros[i].y + meteros[i].d/2 - 50;
                        explosive_effects.Add(new Explosive_effect(eff_x, eff_y));
                    }
                }
            }

            //Update Metero/Fire List
            int fire_alive = 0;
            for (int i = 0; i < fires.Count; i++)
            {
                if (enable_fire[i])
                {
                    fires[fire_alive] = fires[i];
                    fire_alive++;
                }
            }
            fires.RemoveRange(fire_alive, fires.Count() - fire_alive);
            enable_fire = Enumerable.Repeat(true, fires.Count()).ToList();

            int metero_alive = 0;
            for (int i = 0; i < meteros.Count; i++)
            {
                if (enable_metero[i])
                {
                    meteros[metero_alive] = meteros[i];
                    metero_alive++;
                }
            }
            meteros.RemoveRange(metero_alive, meteros.Count() - metero_alive);
            enable_metero = Enumerable.Repeat(true, meteros.Count()).ToList();



            this.Text = $"Meteros: {meteros.Count} | t={time_metero} | {Ship1.x_speed} | {Ship1.y_speed}";
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    Ship1.x_left = 5;
                    break;
                case Keys.D:
                    Ship1.x_right = 5;
                    break;
                case Keys.W:
                    Ship1.y_up = 5;
                    break;
                case Keys.S:
                    Ship1.y_down = 5;
                    break;
                case Keys.Space:
                    if (fire_countDown == 0)
                    {
                        fire_countDown = 10;
                        fires.Add(new Fire(Ship1.x + 14, Ship1.y));
                        enable_fire.Add(true);
                    }
                    
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    Ship1.x_left = 0 ;
                    break;
                case Keys.D:
                    Ship1.x_right = 0;
                    break;
                case Keys.W:
                    Ship1.y_up = 0;
                    break;
                case Keys.S:
                    Ship1.y_down = 0;
                    break;
            }
        }
    }
}
