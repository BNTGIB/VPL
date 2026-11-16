using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipGame
{
    internal class Ship
    {
        public int x, y;
        public int x_speed, y_speed, x_left, x_right, y_up, y_down;

        public int HP, Energy, count_Down, Score;

        public int FormWidth, FormHeight;
        public Ship(int FW = 800, int FH = 800, int x_spawn = 0)
        {
            this.x = FW/2 - x_spawn;
            this.y = FH - 100;
            this.FormWidth = FW;
            this.FormHeight = FH;
            x_speed = 0;
            y_speed = 0;
            x_left = x_right = 0;
            y_up = y_down = 0;
            HP = 100;
            Energy = 20;
            count_Down = 0;
            Score = 0;
        }

        public void move()
        {
            x_speed = x_right - x_left;
            y_speed = y_down - y_up;

            if ((x + x_speed) > 0 && (x + x_speed) < FormWidth - 32)
            {
                x += x_speed;
            }
            if ((y+y_speed) > 0 && (y + y_speed) < FormHeight - 32)
            {
                y+= y_speed;
            }
        }
    }
}
