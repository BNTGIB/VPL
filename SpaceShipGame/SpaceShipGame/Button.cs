using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipGame
{
    internal class Button
    {
        public int x, y, frame_index;
        public List<Image> buttom_image;
        public bool IsClicked = false;
        public Button(int x, int y)
        {
            this.x = x;
            this.y = y;
            buttom_image = new List<Image>();
            frame_index = 0;
        }

        public bool checkMouse(int mX, int mY)
        {
            int w = this.buttom_image[frame_index].Width,
                h = this.buttom_image[frame_index].Height;

            return (mX >= x && mX <= x + w && mY >= y && mY <= y + h);
        }
    }
}
