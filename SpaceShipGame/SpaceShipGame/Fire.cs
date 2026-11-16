using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace SpaceShipGame
{
    internal class Fire
    {
        public int x, y;

        public int speed;

        public bool IsAlive;

        public Fire(int x, int y)
        {
            this.x = x;
            this.y = y;
            speed = 10;
            IsAlive = true;
        }

        public void Move()
        {
              y -= speed;
        }

        public bool IsDead()
        {
            return y < -50;
        }
    }
}
