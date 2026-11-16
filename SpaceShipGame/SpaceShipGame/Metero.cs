using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipGame
{
    internal class Metero
    {
        Random rand = new Random();
        public int x, y;
        public int formWidth, formHeight, frame;
        public int y_speed, d = 64;

        public Metero(int fW = 200, int fH = 200)
        {
            this.formWidth = fW;
            this.formHeight = fH;
            this.frame = 0;

            this.x = rand.Next(fW - d);
            this.y = -100;
            this.y_speed =  3 + rand.Next(3);
        }

        public void move()
        {
            y += y_speed;
            frame++;
            frame = frame % 36;
        }

        public bool IsDead()
        {
            if (y > formHeight + 10)
            {
                return true;
            }
            return false;
        }

        public bool conclision_fire(Fire fire)
        {
            return ((fire.x >= (x - 5) && fire.x < (x + d)) && (fire.y > y && fire.y < (y + d - 10)));
        }

        public bool conclision_Ship(Ship ship)
        {
            return ((ship.x >= (x - 31) && ship.x < (x + d)) && (ship.y >= (y-31) && ship.y < (y + d - 5)));
        }
    }

}
