using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipGame
{
    internal class Energy
    {
        Random rand ;
        public int x, y, frame, time_alive;
        
        public int[] size;

        public bool isAlive;
        public Energy()
        {
            rand = new Random();
            this.x = 5 + rand.Next(700);
            this.y = 50 + rand.Next(600);
            this.frame = 0;
            this.time_alive = 0;
            this.size = new int[] { 30, 25 };
            this.isAlive = true;
        }

        public bool conclision_Ship(Ship ship)
        {
            return ((ship.x >= (x - 31) && ship.x < (x + 30)) && (ship.y >= (y - 31) && ship.y < (y + 30)));
        }
    }
}
