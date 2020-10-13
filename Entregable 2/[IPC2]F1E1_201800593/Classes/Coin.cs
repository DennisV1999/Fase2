using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace _IPC2_F1E1_201800593.Classes
{
    public class Coin
    {
        private int up;
        private int down;
        private int right;
        private int left;
        private Color color;
        
        public Coin()
        {
            up = 0;
            down = 0;
            right = 0;
            left = 0;
            color = Color.Transparent;
        }

        public int Up
        {
            get { return up; }
            set { up = value; }
        }

        public int Down
        {
            get { return down; }
            set { down = value; }
        }

        public int Right
        {
            get { return right; }
            set { right = value; }
        }

        public int Left
        {
            get { return left; }
            set { left = value; }
        }

        public Color Colores
        {
            get { return color; }
            set { color = value; }
        }
    }
}