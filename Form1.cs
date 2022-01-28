using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4Guía4
{
    public partial class Form1 : Form
    {

        enum Posicion
        {
            izquierda,derecha,arriba,abajo
        }

        private int x;
        private int y;
        private Posicion objposicion, limitex, limitey;
        private int limitX; 
        private int limitY;

        

        public Form1()
        {
            InitializeComponent();
            x = 50;
            y = 50;
            objposicion = Posicion.abajo;

            /*
            limitex = (Posicion)Convert.ToInt16(value: Size.Width);
            limitey = (Posicion)Convert.ToInt16(value: Size.Height);

            limitX = Convert.ToInt32(limitex);
            limitY = Convert.ToInt32(limitey);
            */

            limitX = 559;
            limitY = 289;

        }

        private void timermov_Tick(object sender, EventArgs e)
        {
            if (objposicion == Posicion.derecha && x <= limitX)
            { x += 10; }

            else if (objposicion == Posicion.izquierda && x > 0)
            { x -= 10; }

            else if (objposicion == Posicion.arriba && y > 0)
            { y -= 10; }

            else if (objposicion == Posicion.abajo && y <= limitY) 
            { y += 10; }

            /*else if(x.Equals(limitex) || y.Equals(limitey))
            {
                MessageBox.Show("hola");
            }*/

            Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("jettValorant.jpg"), x, y, 65, 65);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                objposicion = Posicion.izquierda;
            }
            if(e.KeyCode == Keys.Right)
            {
                objposicion = Posicion.derecha;
            }
            if(e.KeyCode == Keys.Up)
            {
                objposicion = Posicion.arriba;
            }
            if(e.KeyCode == Keys.Down)
            {
                objposicion = Posicion.abajo;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
