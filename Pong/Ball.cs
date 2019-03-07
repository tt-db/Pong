using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Ball
    {
        int xSpeed;
        int ySpeed;
        int xLoc;
        int yLoc;
        int width;
        int height;
        public Ball(int xS,int yS,int xL,int yL,int w,int h)
        {
            XSpeed = xS;
            YSpeed = yS;
            XLoc = xL;
            YLoc = yL;
            width = w;
            height = h;
        }

        public int XSpeed { get => xSpeed; set => xSpeed = value; }
        public int YSpeed { get => ySpeed; set => ySpeed = value; }
        public int XLoc { get => xLoc; set => xLoc = value; }
        public int YLoc { get => yLoc; set => yLoc = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
    }
}
