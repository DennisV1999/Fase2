using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _IPC2_F1E1_201800593.Classes;
using System.Drawing;

namespace _IPC2_F1E1_201800593.Classes
{
    public class Board
    {
        public static readonly int negro = -1;
        public static readonly int vacio = 0;
        public static readonly int blanco = 1;
        private Coin[,] fichas = new Coin[8, 8];

        private int[,] tablero = new int[8, 8];

        public void limpiarTablero()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tablero[i,j] = vacio;
                    fichas[i, j] = new Coin();
                }
            }
        }
        
        public void setColor(int i, int j, string color)
        {
            if(color == "blanco")
            {
                tablero[i, j] = blanco;
                fichas[i, j].Colores = Color.White;
            }
            else if(color == "negro")
            {
                tablero[i, j] = negro;
                fichas[i, j].Colores = Color.Black;
            }
            
        }

        public void checkIfCornered()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(tablero[i,j] == blanco)
                    {
                        
                        //if(i == 0 && j != 7 && j != 0)
                        //{
                        //    if(tablero[i+1,j] == negro && tablero[i, j+1] == negro && tablero[i, j-1] == negro)
                        //    {
                        //        tablero[i, j] = negro;
                        //    }
                        //}
                        //else if(i > 0 && i < 7 && j > 0 && j < 7)
                        //{
                        //    if ((tablero[i + 1, j] == negro && tablero[i-1, j] == negro && tablero[i, j + 1] == negro && tablero[i, j - 1] == negro)
                        //        ||())
                        //    {
                        //        tablero[i, j] = negro;
                        //    }
                        //}
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
                    
                }
            }
        }

        public int[,] obtenerTablero()
        {
            return tablero;
        }

    }
}