using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{

    class Paddle
    {
        int yLocation;
        int xLocation;
        int speed;
        int width;
        int height;
        String playerID;
        public Paddle(String pID,int s,int x,int w, int h)
        {
            PlayerID = pID;
            Speed = s;
            yLocation=186;
            xLocation = x;
            width = w;
            height = h;
        }

        public int YLocation { get => yLocation; set => yLocation = value; }
        public int XLocation { get => xLocation; set => xLocation = value; }
        public int Speed { get => speed; set => speed = value; }
        public string PlayerID { get => playerID; set => playerID = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
    }
}
