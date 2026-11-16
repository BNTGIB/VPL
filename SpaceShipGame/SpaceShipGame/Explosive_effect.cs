using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipGame
{
    internal class Explosive_effect
    {
        public int x, y, frame;
        public bool IsAlive;
        public Explosive_effect(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.frame = 8;
            this.IsAlive = true;
        }

        public bool IsDead()
        {
            return frame <= 0;
        }
    }
}
