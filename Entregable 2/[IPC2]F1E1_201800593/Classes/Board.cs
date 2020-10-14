using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _IPC2_F1E1_201800593.Classes;
using System.Drawing;
using System.Web.UI.WebControls.WebParts;

namespace _IPC2_F1E1_201800593.Classes
{
    public class Board
    {
        private Coin[,] fichas = new Coin[8, 8];

        public Board()
        {
            limpiarTablero();
        }
        public void limpiarTablero()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    fichas[i, j] = new Coin(i,j);
                }
            }
            fichas[3, 3].Colores = Color.White;
            fichas[3, 4].Colores = Color.Black;
            fichas[4, 3].Colores = Color.Black;
            fichas[4, 4].Colores = Color.White;
            checkAround();
        }

        public void setColor(int i, int j, string color)
        {
            if (color == "blanco")
            {
                fichas[i, j].Colores = Color.White;
                //for (int m = 0; m < 8; m++)
                //{
                //}
            }
            else if (color == "negro")
            {
                fichas[i, j].Colores = Color.Black;
                //for (int m = 0; m < 8; m++)
                //{
                //}
            }
            checkWhichFlanked(i, j);
        }

        public void checkWhichFlanked(int i, int j)
        {
            if (fichas[i, j].Colores == Color.White)
            {
                if (i != 0)
                {
                    if (fichas[i, j].Up.Colores == Color.Black)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Up.Colores == Color.Black)
                        {
                            aux = aux.Up;
                        }
                        if (aux.Up.Colores == Color.White)
                        {
                            for (int o = i - 1; o > aux.Up.Posy; o--)
                            {
                                fichas[o, j].Colores = Color.White;
                            }
                        }
                    }
                }
                if (i != 0 && j != 7) {
                    if (fichas[i, j].Up.Right.Colores == Color.Black)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Up.Right.Colores == Color.Black)
                        {
                            aux = aux.Up.Right;
                        }
                        if (aux.Up.Right.Colores == Color.White)
                        {
                            while (i > aux.Up.Right.Posy && j < aux.Up.Right.Posx)
                            {
                                fichas[i, j].Colores = Color.White;
                                i--;
                                j++;
                            }
                        }
                    }
                }
                if (i != 0 && j != 0) {
                    if (fichas[i, j].Up.Left.Colores == Color.Black)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Up.Left.Colores == Color.Black)
                        {
                            aux = aux.Up.Left;
                        }
                        if (aux.Up.Left.Colores == Color.White)
                        {
                            while (i > aux.Up.Left.Posy && j > aux.Up.Left.Posx)
                            {
                                fichas[i, j].Colores = Color.White;
                                i--;
                                j--;
                            }
                        }
                    }
                }
                if (j != 7) {
                    if (fichas[i, j].Right.Colores == Color.Black)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Right.Colores == Color.Black)
                        {
                            aux = aux.Right;
                        }
                        if (aux.Right.Colores == Color.White)
                        {
                            for (int o = j + 1; o < aux.Right.Posx; o++)
                            {
                                fichas[i, o].Colores = Color.White;
                            }
                        }
                    }
                }
                if (i != 7 && j != 7) {
                    if (fichas[i, j].Down.Right.Colores == Color.Black)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Down.Right.Colores == Color.Black)
                        {
                            aux = aux.Down.Right;
                        }
                        if (aux.Down.Right.Colores == Color.White)
                        {
                            while (i < aux.Down.Right.Posy && j < aux.Down.Right.Posx)
                            {
                                fichas[i, j].Colores = Color.White;
                                i++;
                                j++;
                            }
                        }
                    }
                }
                if (i != 7) {
                    if (fichas[i, j].Down.Colores == Color.Black)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Down.Colores == Color.Black)
                        {
                            aux = aux.Down;
                        }
                        if (aux.Down.Colores == Color.White)
                        {
                            for (int o = i + 1; o < aux.Down.Posy; o++)
                            {
                                fichas[o, j].Colores = Color.White;
                            }
                        }
                    }
                }
                if (i != 7 && j != 0) {
                    if (fichas[i, j].Down.Left.Colores == Color.Black)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Down.Left.Colores == Color.Black)
                        {
                            aux = aux.Down.Left;
                        }
                        if (aux.Down.Left.Colores == Color.White)
                        {
                            while (i < aux.Down.Left.Posy && j > aux.Down.Left.Posx)
                            {
                                fichas[i, j].Colores = Color.White;
                                i++;
                                j--;
                            }
                        }
                    }
                }
                if (j != 0) {
                    if (fichas[i, j].Left.Colores == Color.Black)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Left.Colores == Color.Black)
                        {
                            aux = aux.Left;
                        }
                        if (aux.Left.Colores == Color.White)
                        {
                            for (int o = j - 1; o > aux.Left.Posx; o--)
                            {
                                fichas[i, o].Colores = Color.White;
                            }
                        }
                    }
                }
            }
            else if (fichas[i, j].Colores == Color.Black)
            {
                if (i != 0) {
                    if (fichas[i, j].Up.Colores == Color.White)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Up.Colores == Color.White)
                        {
                            aux = aux.Up;
                        }
                        if (aux.Up.Colores == Color.Black)
                        {
                            for (int o = i - 1; o > aux.Up.Posy; o--)
                            {
                                fichas[o, j].Colores = Color.Black;
                            }
                        }
                    }
                }
                if (i != 0 && j != 7) {
                    if (fichas[i, j].Up.Right.Colores == Color.White)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Up.Right.Colores == Color.White)
                        {
                            aux = aux.Up.Right;
                        }
                        if (aux.Up.Right.Colores == Color.Black)
                        {
                            while (i > aux.Up.Right.Posy && j < aux.Up.Right.Posx)
                            {
                                fichas[i, j].Colores = Color.Black;
                                i--;
                                j++;
                            }
                        }
                    }
                }
                if (i != 0 && j != 0) {
                    if (fichas[i, j].Up.Left.Colores == Color.White)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Up.Left.Colores == Color.White)
                        {
                            aux = aux.Up.Left;
                        }
                        if (aux.Up.Left.Colores == Color.Black)
                        {
                            while (i > aux.Up.Left.Posy && j > aux.Up.Left.Posx)
                            {
                                fichas[i, j].Colores = Color.Black;
                                i--;
                                j--;
                            }
                        }
                    }
                }
                if (j != 7) {
                    if (fichas[i, j].Right.Colores == Color.White)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Right.Colores == Color.White)
                        {
                            aux = aux.Right;
                        }
                        if (aux.Right.Colores == Color.Black)
                        {
                            for (int o = j + 1; o < aux.Right.Posx; o++)
                            {
                                fichas[i, o].Colores = Color.Black;
                            }
                        }
                    }
                }
                if (i != 7 && j != 7) {
                    if (fichas[i, j].Down.Right.Colores == Color.White)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Down.Right.Colores == Color.White)
                        {
                            aux = aux.Down.Right;
                        }
                        if (aux.Down.Right.Colores == Color.Black)
                        {
                            while (i < aux.Down.Right.Posy && j < aux.Down.Right.Posx)
                            {
                                fichas[i, j].Colores = Color.Black;
                                i++;
                                j++;
                            }
                        }
                    }
                }
                if (i != 7) {
                    if (fichas[i, j].Down.Colores == Color.White)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Down.Colores == Color.White)
                        {
                            aux = aux.Down;
                        }
                        if (aux.Down.Colores == Color.Black)
                        {
                            for (int o = i + 1; o < aux.Down.Posy; o++)
                            {
                                fichas[o, j].Colores = Color.Black;
                            }
                        }
                    }
                }
                if (i != 7 && j != 0) {
                    if (fichas[i, j].Down.Left.Colores == Color.White)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Down.Left.Colores == Color.White)
                        {
                            aux = aux.Down.Left;
                        }
                        if (aux.Down.Left.Colores == Color.Black)
                        {
                            while (i < aux.Down.Left.Posy && j > aux.Down.Left.Posx)
                            {
                                fichas[i, j].Colores = Color.Black;
                                i++;
                                j--;
                            }
                        }
                    }
                }
                if (j != 0) {
                    if (fichas[i, j].Left.Colores == Color.White)
                    {
                        Coin aux = fichas[i, j];
                        while (aux.Left.Colores == Color.White)
                        {
                            aux = aux.Left;
                        }
                        if (aux.Left.Colores == Color.Black)
                        {
                            for (int o = j - 1; o > aux.Left.Posx; o--)
                            {
                                fichas[i, o].Colores = Color.Black;
                            }
                        }
                    }
                }
            }
        }

        public void checkAround()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(i == 0 && j == 0)
                    {
                        fichas[i, j].Right = fichas[i, j + 1];
                        fichas[i, j].Down = fichas[i + 1, j];
                        fichas[i, j].Up = new Coin();
                        fichas[i, j].Left = new Coin();
                    }
                    else if (i == 0 && j == 7)
                    {
                        fichas[i, j].Left = fichas[i, j - 1];
                        fichas[i, j].Down = fichas[i + 1, j];
                        fichas[i, j].Up = new Coin();
                        fichas[i, j].Right = new Coin();
                    }
                    else if (i > 0 && i < 7 && j > 0 && j <7)
                    {
                        fichas[i, j].Up = fichas[i - 1, j];
                        fichas[i, j].Down = fichas[i + 1, j];
                        fichas[i, j].Right = fichas[i, j + 1];
                        fichas[i, j].Left = fichas[i, j - 1];
                    }
                    else if (i > 0 && i < 7 && j == 0)
                    {
                        fichas[i, j].Up = fichas[i - 1, j];
                        fichas[i, j].Down = fichas[i + 1, j];
                        fichas[i, j].Right = fichas[i, j + 1];
                        fichas[i, j].Left = new Coin();
                    }
                    else if (i > 0 && i < 7 && j == 7)
                    {
                        fichas[i, j].Up = fichas[i - 1, j];
                        fichas[i, j].Down = fichas[i + 1, j];
                        fichas[i, j].Left = fichas[i, j - 1];
                        fichas[i, j].Right = new Coin();
                    }
                    else if (i == 7 && j == 0)
                    {
                        fichas[i, j].Up = fichas[i - 1, j];
                        fichas[i, j].Right = fichas[i, j + 1];
                        fichas[i, j].Down = new Coin();
                        fichas[i, j].Left = new Coin();
                    }
                    else if (i == 7 && j > 0 && j < 7)
                    {
                        fichas[i, j].Up = fichas[i - 1, j];
                        fichas[i, j].Right = fichas[i, j + 1];
                        fichas[i, j].Left = fichas[i, j - 1];
                        fichas[i, j].Down = new Coin();
                    }
                    else if (i == 7 && j == 7)
                    {
                        fichas[i, j].Up = fichas[i - 1, j];
                        fichas[i, j].Left = fichas[i, j - 1];
                        fichas[i, j].Down = new Coin();
                        fichas[i, j].Right = new Coin();
                    }
                    else if (i == 0 && j > 0 && j < 7)
                    {
                        fichas[i, j].Down = fichas[i + 1, j];
                        fichas[i, j].Left = fichas[i, j - 1];
                        fichas[i, j].Right = fichas[i, j + 1];
                        fichas[i, j].Up = new Coin();
                    }
                }
            }
        }

        public Coin[,] obtenerTablero()
        {
            return fichas;
        }

    }
}