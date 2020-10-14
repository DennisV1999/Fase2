using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace _IPC2_F1E1_201800593.Classes
{
    public class Coin
    {
        private Coin up;
        private Coin down;
        private Coin right;
        private Coin left;
        private Color color;
        private int posx;
        private int posy;

        public Coin()
        {
            color = Color.Transparent;
            posx = -1;
            posy = -1;
        }

        public Coin(int i, int j)
        {
            color = Color.Transparent;
            posx = j;
            posy = i;
        }

        public Coin Up
        {
            get { return up; }
            set { up = value; }
        }

        public Coin Down
        {
            get { return down; }
            set { down = value; }
        }

        public Coin Right
        {
            get { return right; }
            set { right = value; }
        }

        public Coin Left
        {
            get { return left; }
            set { left = value; }
        }

        public Color Colores
        {
            get { return color; }
            set { color = value; }
        }

        public int Posy
        {
            get { return posy; }
            set { posy = value; }
        }

        public int Posx
        {
            get { return posx; }
            set { posx = value; }
        }
    }
}