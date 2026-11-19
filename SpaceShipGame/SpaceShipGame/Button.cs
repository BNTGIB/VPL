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

        public Size GetSize(double mul = 1)
        {
            Size result = new Size();
            result.Width = (int)(buttom_image[frame_index].Size.Width * mul);
            result.Height = (int)(buttom_image[frame_index].Size.Height * mul);
            return result;
        }
        public Point GetCenterPoint(int difx = 0, int dify = 0)
        {
            Point result = new Point();
            result.X = difx - GetSize().Width / 2;
            result.Y = dify - GetSize().Height / 2;
            return result;
        }
        
    }
}
