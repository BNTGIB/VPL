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
        int time_metero = 0;
        int sub_time = 0;

        //Space Ship-----------------
        Font ship_Energy_font;
        Font ship_Score_font;
        //Ship 1
        Ship Ship1;
        Image ship1_image;
        Image ship1_HP_image;

        //Ship2
        Ship Ship2;
        Image ship2_image;
        Image ship2_HP_image;


        //Fire
        List<Fire> fires = new List<Fire>();
        Image fire1_image;
        Image fire2_image;


        //Effect_Explosive
        List<Explosive_effect> explosive_effects = new List<Explosive_effect>();
        Image[] explosive_images = new Image[9];

        //Enegy_Spawn
        List<Energy> energies = new List<Energy>();
        Image energy_image;
        int SpawnEnergy = 0;

        //System
        int mouseX, mouseY;
        Random rand = new Random();
        bool IsNotRunning = true;
        bool IsBegin = true;
        bool IsOver = false;
        bool Ship1Win = false;
        int time_level = 0;
        Button PlayButton;
        Button RestarButton;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ship 1
            Ship1 = new Ship(this.ClientSize.Width, this.ClientSize.Height, 132);
            ship1_image = Image.FromFile("Img\\SpaceShip\\spaceships\\SpaceShips\\Ship_1.png");
            ship1_HP_image = Image.FromFile("Img\\Element\\Hp1.png");
            //Ship 2
            Ship2 = new Ship(this.ClientSize.Width, this.ClientSize.Height, -100);
            ship2_image = Image.FromFile("Img\\SpaceShip\\spaceships\\SpaceShips\\Ship_2.png");
            ship2_HP_image = Image.FromFile("Img\\Element\\Hp2.png");

            ship_Energy_font = new Font("Upheaval TT (BRK)", 13, FontStyle.Bold);
            ship_Score_font = new Font("Upheaval TT (BRK)", 20, FontStyle.Bold);

            //Fire
            fire1_image = Image.FromFile("Img\\SpaceShip\\firemeo1.png");
            fire2_image = Image.FromFile("Img\\SpaceShip\\firemeo2.png");
            //Energy
            energy_image = Image.FromFile("Img\\Element\\energy.png");
            //Effect
            for (int i = 0; i < 9; i++)
            {
                explosive_images[i] = Image.FromFile("Img\\Effect_Explosive\\" + (i + 1).ToString() + ".png");
            }

            //System
            PlayButton = new Button(this.ClientSize.Width / 2 - 118, this.ClientSize.Height / 2 - 35);
            PlayButton.buttom_image.Add(Image.FromFile("Img\\System\\playbt1.png"));
            PlayButton.buttom_image.Add(Image.FromFile("Img\\System\\playbt2.png"));
            PlayButton.buttom_image.Add(Image.FromFile("Img\\System\\playbt3.png"));

            RestarButton = new Button(this.ClientSize.Width / 2 - 35, this.ClientSize.Height / 2 + 200);
            RestarButton.buttom_image.Add(Image.FromFile("Img\\System\\restartbt.png"));
            RestarButton.buttom_image.Add(Image.FromFile("Img\\System\\restartbt2.png"));

            timer1.Interval = 16;
            timer2.Interval = 500;

            timer1.Start();
            timer2.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics b = e.Graphics;

            b.DrawImage(ship1_image, Ship1.x, Ship1.y);
            b.DrawImage(ship2_image, Ship2.x, Ship2.y);

            if (IsNotRunning && IsBegin)
            {
                b.DrawImage(PlayButton.buttom_image[PlayButton.frame_index], PlayButton.x, PlayButton.y);
                b.DrawString("Player 1", ship_Energy_font, Brushes.DeepSkyBlue, 225, 615);
                b.DrawString("Player 2", ship_Energy_font, Brushes.OrangeRed, 450, 615);
                return;
            }

            foreach (Fire fire in fires)
            {
                b.DrawImage(fire.FromShip == 1 ? fire1_image : fire2_image, fire.x, fire.y);
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

            //Ship 1 element
            b.FillRectangle(Brushes.Red, 60, 30, 225 * Ship1.HP / 100, 10);
            b.DrawImage(ship1_HP_image, 6, 20);
            b.DrawString("ENGERGY: " + Ship1.Energy.ToString(), ship_Energy_font, Brushes.White, 55, 50);
            b.DrawString("SCORE: " + Ship1.Score.ToString(), ship_Score_font, Brushes.Yellow, 10, this.ClientSize.Height - 40);
            //Ship 2 element
            b.FillRectangle(Brushes.Red, 505 + 225 - (225 * Ship2.HP / 100), 30, 225 * Ship2.HP / 100, 10);
            b.DrawImage(ship2_HP_image, 500, 20);
            b.DrawString("ENGERGY: " + Ship2.Energy.ToString(), ship_Energy_font, Brushes.White, 585, 50);
            b.DrawString("SCORE: " + Ship2.Score.ToString(), ship_Score_font, Brushes.Yellow, 600, this.ClientSize.Height - 40);

            if (IsOver)
            {
                b.FillRectangle(Brushes.White, this.ClientSize.Width / 2 - 205, this.ClientSize.Height / 2 - 20, 410, 82);
                b.DrawImage(Image.FromFile("Img\\GameOver\\gameover.png"), this.ClientSize.Width / 2 - 200, this.ClientSize.Height / 2 - 180, 400, 250);
                b.DrawString("PLAYER " + (Ship1Win ? "1" : "2") + " WIN !!", ship_Score_font, Ship1Win ? Brushes.DeepSkyBlue : Brushes.OrangeRed, this.ClientSize.Width / 2 - 135, this.ClientSize.Height / 2 + 80);

                b.DrawImage(RestarButton.buttom_image[RestarButton.frame_index], RestarButton.x, RestarButton.y, RestarButton.GetSize().Width, RestarButton.GetSize().Height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsNotRunning)
            {
                Invalidate();
                this.Text = $"Meteros: {meteros.Count} | t={time_metero} | {Ship1.x_speed} | {Ship1.y_speed} | Sub_time= {sub_time} | Time Sec = {time_level / 60} - Mouse: {mouseX} |  {mouseY} ";
                return;
            }
            //Ship
            Ship1.move();
            Ship2.move();

            //Fire
            if (Ship1.count_Down > 0)
                Ship1.count_Down--;

            if (Ship2.count_Down > 0)
                Ship2.count_Down--;

            foreach (Fire fire in fires)
            {
                fire.Move();
                if (fire.IsDead())
                {
                    fire.IsAlive = false;
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
            }

            foreach (Metero metero in meteros)
            {
                metero.move();
                if (metero.IsDead())
                    metero.IsAlive = false;
            }

            //Explosive Effect
            foreach (Explosive_effect explosive in explosive_effects)
            {
                if (explosive.IsDead())
                {
                    explosive.IsAlive = false;
                }

                if (explosive.frame > 0)
                    explosive.frame--;
            }


            //Conclision Metero
            foreach (Metero metero in meteros)
            {
                foreach (Fire fire in fires)
                {
                    if (metero.conclision_fire(fire))
                    {
                        metero.IsAlive = false;
                        fire.IsAlive = false;
                        int eff_x = metero.x + metero.d / 2 - 50,
                            eff_y = metero.y + metero.d / 2 - 50;
                        explosive_effects.Add(new Explosive_effect(eff_x, eff_y));

                        if (fire.FromShip == 1)
                            Ship1.Score += 7 + rand.Next(8);
                        else
                            Ship2.Score += 7 + rand.Next(8);
                    }
                }

                if (metero.conclision_Ship(Ship1))
                {
                    metero.IsAlive = false;
                    int eff_x = metero.x + metero.d / 2 - 50,
                            eff_y = metero.y + metero.d / 2 - 50;
                    explosive_effects.Add(new Explosive_effect(eff_x, eff_y));
                    Ship1.HP -= 10;
                }

                if (metero.conclision_Ship(Ship2))
                {
                    metero.IsAlive = false;
                    int eff_x = metero.x + metero.d / 2 - 50,
                            eff_y = metero.y + metero.d / 2 - 50;
                    explosive_effects.Add(new Explosive_effect(eff_x, eff_y));
                    Ship2.HP -= 10;
                }
            }


            //Energy_Spawn
            for (int i = 0; i < energies.Count; i++)
            {
                if (energies[i].conclision_Ship(Ship1) && energies[i].isAlive)
                {
                    Ship1.Energy += 3;
                    energies[i].isAlive = false;
                }
                if (energies[i].conclision_Ship(Ship2) && energies[i].isAlive)
                {
                    Ship2.Energy += 3;
                    energies[i].isAlive = false;
                }

            }

            //Update

            fires.RemoveAll(f => f.IsAlive == false);
            meteros.RemoveAll(m => m.IsAlive == false);
            energies.RemoveAll(en => en.isAlive == false);
            explosive_effects.RemoveAll(ef => ef.IsAlive == false);


            //Is Over
            if (Ship1.HP <= 0 || Ship1.Score >= 500 || Ship2.HP <= 0 || Ship2.Score >= 500)
            {
                IsOver = true;
                IsNotRunning = true;
                if (Ship1.Score >= 500 || Ship2.HP <= 0)
                {
                    Ship1Win = true;
                }

            }

            this.Text = $"Meteros: {meteros.Count} | t={time_metero} | {Ship1.x_speed} | {Ship1.y_speed} | Sub_time= {sub_time} | Time Sec = {time_level / 60} - Mouse: {mouseX} |  {mouseY} ";
            Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (IsNotRunning)
            {
                return;
            }

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
            if (IsNotRunning)
            {
                return;
            }

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
                        fires.Add(new Fire(Ship1.x + 14, Ship1.y, 1));
                        Ship1.Energy--;
                    }
                    break;

                case Keys.Left:
                    Ship2.x_left = 5;
                    break;
                case Keys.Right:
                    Ship2.x_right = 5;
                    break;
                case Keys.Up:
                    Ship2.y_up = 5;
                    break;
                case Keys.Down:
                    Ship2.y_down = 5;
                    break;
                case Keys.Enter:
                    if (Ship2.count_Down == 0 && Ship2.Energy > 0)
                    {
                        Ship2.count_Down = 7;
                        fires.Add(new Fire(Ship2.x + 14, Ship2.y, 2));
                        Ship2.Energy--;
                    }

                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsNotRunning)
            {
                return;
            }
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

                case Keys.Left:
                    Ship2.x_left = 0;
                    break;
                case Keys.Right:
                    Ship2.x_right = 0;
                    break;
                case Keys.Up:
                    Ship2.y_up = 0;
                    break;
                case Keys.Down:
                    Ship2.y_down = 0;
                    break;
            }
        }
            
        private void ReStartGame()
        {
            Ship1 = new Ship(this.ClientSize.Width, this.ClientSize.Height, 132);
            Ship2 = new Ship(this.ClientSize.Width, this.ClientSize.Height, -100);
            meteros.Clear();
            fires.Clear();
            explosive_effects.Clear();
            time_metero = 0;
            sub_time = 0;
            time_level = 0;
            SpawnEnergy = 0;
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            if (IsNotRunning && IsBegin)
            {
                if (PlayButton.checkMouse(e.X, e.Y))
                {
                    PlayButton.frame_index = PlayButton.IsClicked ? 2 : 1;
                }
                else
                {
                    PlayButton.frame_index = 0;
                    PlayButton.IsClicked = false;
                }
            }
            if (IsOver)
            {
                if (RestarButton.checkMouse(e.X, e.Y))
                {
                    RestarButton.frame_index = 1;
                }
                else
                {
                    RestarButton.frame_index = 0;
                    RestarButton.IsClicked = false;
                }
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsNotRunning && IsBegin)
            {
                if (PlayButton.checkMouse(e.X, e.Y))
                {
                    PlayButton.IsClicked = true;
                    PlayButton.frame_index = 2;
                }
            }
            else if (IsOver)
            {
                if (RestarButton.checkMouse(e.X, e.Y))
                {
                    RestarButton.IsClicked = true;
                }
            }

        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsNotRunning && IsBegin)
            {
                PlayButton.IsClicked = false;
                if (PlayButton.checkMouse(e.X, e.Y))
                {
                    IsNotRunning = false;
                    IsBegin = false;
                }
            }
            else if (IsOver)
            {
                if (RestarButton.checkMouse(e.X, e.Y))
                {
                    IsNotRunning = true;
                    IsOver = false;
                    IsBegin = true;
                    ReStartGame();
                    RestarButton.frame_index = 0;

                }
            }
            
        }
    }
}
