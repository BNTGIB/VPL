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
        int sub_time = 0;

        //Space Ship
        Ship Ship1;
        Image ship1_image;
        Image ship1_HP_image;
        Font ship_Energy_font;
        Font ship_Score_font;


        //Fire
        List<Fire> fires = new List<Fire>();
        List<bool> enable_fire = new List<bool>();
        Image fire_image;

        //Effect_Explosive
        List<Explosive_effect> explosive_effects = new List<Explosive_effect>();
        Image[] explosive_images = new Image[9];

        //Enegy_Spawn
        List<Energy> energies = new List<Energy>();
        Image energy_image;
        int SpawnEnergy = 0;

        //System
        Random rand = new Random();
        int time_level = 0;
        bool IsOver = false;

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

            ship1_HP_image = Image.FromFile("Img\\Element\\Hp1.png");

            ship_Energy_font = new Font("Upheaval TT (BRK)", 13, FontStyle.Bold);
            ship_Score_font = new Font("Upheaval TT (BRK)", 20, FontStyle.Bold);


            energy_image = Image.FromFile("Img\\Element\\energy.png");

            for (int i = 0; i < 9; i++)
            {
                explosive_images[i] = Image.FromFile("Img\\Effect_Explosive\\" + (i + 1).ToString() + ".png");
            }
            timer1.Interval = 16;
            timer2.Interval = 500;

            timer1.Start(); ;
            timer2.Start();

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
                b.DrawImage(explosive_images[(8 - ef.frame) % 9], ef.x, ef.y, 100, 100);
            }
            foreach (Energy en in energies)
            {
                int frame = en.frame;
                b.DrawImage(energy_image, en.x + frame * 3, en.y + frame * 3, en.size[frame], en.size[frame]);
                b.DrawEllipse(Pens.Yellow, en.x - 3, en.y - 3, 36, 36);
            }

            b.FillRectangle(Brushes.Red, 60, 30, 225 * Ship1.HP / 100, 10);
            b.DrawImage(ship1_HP_image, 6, 20);
            b.DrawString("ENGERGY: " + Ship1.Energy.ToString(), ship_Energy_font, Brushes.White, 55, 50);
            b.DrawString("SCORE: " + Ship1.Score.ToString(), ship_Score_font, Brushes.Yellow, 10, this.ClientSize.Height - 40);

            if (IsOver)
            {
                b.FillRectangle(Brushes.White, this.ClientSize.Width / 2 - 205, this.ClientSize.Height / 2 - 20, 410, 82);
                b.DrawImage(Image.FromFile("Img\\GameOver\\gameover.png"), this.ClientSize.Width/2 - 200, this.ClientSize.Height/2-180, 400, 250);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Ship
            Ship1.move();

            //Fire
            if (Ship1.count_Down > 0)
                Ship1.count_Down--;

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
            time_level++;
            sub_time = ((40 - ((time_level / 60) / 3) + 40)) % 41 + 1;
            sub_time = sub_time < 15 ? 15 : sub_time;
            time_metero %= 120;
            if (time_metero % sub_time == 0)
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

                if (explosive_effects[i].frame > 0)
                    explosive_effects[i].frame--;
            }
            explosive_effects.RemoveRange(0, Explosive_eff_dead);


            //Conclision Metero
            for (int i = 0; i < meteros.Count; i++)
            {
                for (int j = 0; j < fires.Count; j++)
                {
                    if (meteros[i].conclision_fire(fires[j]))
                    {
                        enable_metero[i] = false;
                        enable_fire[j] = false;
                        int eff_x = meteros[i].x + meteros[i].d / 2 - 50,
                            eff_y = meteros[i].y + meteros[i].d / 2 - 50;
                        explosive_effects.Add(new Explosive_effect(eff_x, eff_y));
                        Ship1.Score += 7 + rand.Next(8);
                    }
                }

                if (meteros[i].conclision_Ship(Ship1))
                {
                    enable_metero[i] = false;
                    int eff_x = meteros[i].x + meteros[i].d / 2 - 50,
                            eff_y = meteros[i].y + meteros[i].d / 2 - 50;
                    explosive_effects.Add(new Explosive_effect(eff_x, eff_y));
                    Ship1.HP -= 10;
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


            //Energy_Spawn
            for (int i = 0; i < energies.Count; i++)
            {
                if (energies[i].conclision_Ship(Ship1) && energies[i].isAlive)
                {
                    Ship1.Energy += 3;
                    energies[i].isAlive = false;
                }
            }
            energies.RemoveAll(en => en.isAlive == false);

            //Is Over
            if (Ship1.HP <= 0 || Ship1.Score >= 500)
            {
                timer2.Stop();
                timer1.Stop();
                IsOver = true;
            }                
           
            this.Text = $"Meteros: {meteros.Count} | t={time_metero} | {Ship1.x_speed} | {Ship1.y_speed} | Sub_time= {sub_time} | Time Sec = {time_level / 60}";
            Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SpawnEnergy++;
            if (SpawnEnergy == 6)
            {
                energies.Add(new Energy());
                SpawnEnergy = 1;
            }

            foreach (Energy energy in energies)
            {
                energy.frame = energy.frame == 0 ? 1 : 0;
            }
            
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
                    if (Ship1.count_Down == 0 && Ship1.Energy > 0)
                    {
                        Ship1.count_Down = 7;
                        fires.Add(new Fire(Ship1.x + 14, Ship1.y));
                        enable_fire.Add(true);
                        Ship1.Energy--;
                    }

                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    Ship1.x_left = 0;
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
