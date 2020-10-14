using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _IPC2_F1E1_201800593.Classes;

namespace _IPC2_F1E1_201800593
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public ImageButton[,] btnGrid = new ImageButton[8, 8];
        public Label[] lblGrid = new Label[8];
        public string alfabeto = "ABCDEFGH";
        public string numeros = "12345678";
        public static int turn = 1;
        public static Board tablero = new Board();
        protected void Page_Load(object sender, EventArgs e)
        {
            Unit width = BoardPanel.Width;
            int cellsize = Convert.ToInt32(width.Value)/8;
            
            for (int i = 0;i < 8; i++)
            {
                for(int j = 0;j < 8; j++)
                {
                    int u = 0;
                    int r = 0;
                    u = i;
                    r = j;
                    btnGrid[i, j] = new ImageButton();
                    btnGrid[i, j].Width = cellsize;
                    btnGrid[i, j].Height = cellsize;
                    btnGrid[i, j].Click += new ImageClickEventHandler((send,l) => Grid_Button_Click(send,l,u,r));
                    btnGrid[i, j].Style.Add("margin-bottom", "-5px");
                    btnGrid[i, j].ImageUrl = "~/img/default.png";
                    btnGrid[i, j].CausesValidation = false;

                    BoardPanel.Controls.Add(btnGrid[i, j]);
                }
            }
            btnGrid[3, 3].Enabled = false;
            btnGrid[3, 4].Enabled = false;
            btnGrid[4, 3].Enabled = false;
            btnGrid[4, 4].Enabled = false;


            int m = 0;
            foreach(char c in alfabeto)
            {
                lblGrid[m] = new Label();

                lblGrid[m].Text = c.ToString();
                lblGrid[m].Width = cellsize;
                lblGrid[m].Height = 60;
                lblGrid[m].Font.Size = FontUnit.XLarge;
                lblGrid[m].Font.Bold = true;
                lblGrid[m].Style.Add("text-align", "center");
                lblGrid[m].ForeColor = Color.Black;


                TopPanel.Controls.Add(lblGrid[m]);
            }
            int n = 0;
            foreach (char c in alfabeto)
            {
                lblGrid[n] = new Label();

                lblGrid[n].Text = c.ToString();
                lblGrid[n].Width = cellsize;
                lblGrid[n].Height = 60;
                lblGrid[n].Font.Size = FontUnit.XLarge;
                lblGrid[n].Font.Bold = true;
                lblGrid[n].Style.Add("text-align", "center");
                lblGrid[n].ForeColor = Color.Black;

                BottomPanel.Controls.Add(lblGrid[n]);
            }
            int o = 0;
            foreach (char c in numeros)
            {
                lblGrid[o] = new Label();

                lblGrid[o].Text = c.ToString();
                lblGrid[o].Width = cellsize;
                lblGrid[o].Height = 50;
                lblGrid[o].Font.Size = FontUnit.XLarge;
                lblGrid[o].Font.Bold = true;
                lblGrid[o].Style.Add("text-align", "center");
                lblGrid[o].ForeColor = Color.Black;

                LeftPanel.Controls.Add(lblGrid[o]);
            }
            int p = 0;
            foreach (char c in numeros)
            {
                lblGrid[p] = new Label();

                lblGrid[p].Text = c.ToString();
                lblGrid[p].Width = cellsize;
                lblGrid[p].Height = 50;
                lblGrid[p].Font.Size = FontUnit.XLarge;
                lblGrid[p].Font.Bold = true;
                lblGrid[p].Style.Add("text-align", "center");
                lblGrid[p].ForeColor = Color.Black;

                RightPanel.Controls.Add(lblGrid[p]);
            }
            updateBoard();
        }

        private void Grid_Button_Click(object sender, EventArgs e,int i, int j)
        {
            ImageButton clickedbtn = (ImageButton)sender;
            if (turn == 1)
            {
                clickedbtn.ImageUrl = "~/img/negro.png";
                clickedbtn.Enabled = false;
                turn = 2;
                lbljugador.Text = "Turno de: Jugador 2";
                
                checkBoard(i,j);
            }
            else if(turn == 2)
            {
                clickedbtn.ImageUrl = "~/img/blanco.png";
                clickedbtn.Enabled = false;
                turn = 1;
                lbljugador.Text = "Turno de: Jugador 1";
                checkBoard(i,j);
            }
        }
        public void checkBoard(int i, int j)
        {
            if (btnGrid[i, j].ImageUrl.ToString().Contains("blanco"))
            {
                tablero.setColor(i, j, "blanco");
            }
            else if (btnGrid[i, j].ImageUrl.ToString().Contains("negro"))
            {
                tablero.setColor(i, j, "negro");
            }
            updateBoard();
        }
        public void updateBoard()
        {
            Coin[,] fichas = tablero.obtenerTablero();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (fichas[i, j].Colores == Color.White)
                    {
                        btnGrid[i, j].ImageUrl = "~/img/blanco.png";
                    }
                    else if (fichas[i, j].Colores == Color.Black)
                    {
                        btnGrid[i, j].ImageUrl = "~/img/negro.png";
                    }
                }
            }
        }

        public void checkForValidMove()
        {
            Coin[,] fichas = tablero.obtenerTablero();

            if(turn == 1)
            {
                for(int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if(fichas[i,j].Colores == Color.Black)
                        {
                        }
                    }
                }
            }
        }
    }
}