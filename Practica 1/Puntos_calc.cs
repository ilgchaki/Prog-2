using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Puntos_calc : Form
    {
        Graphics graf;
        Pen bic = new Pen(Color.Red, 5);
        Cordenada c1 = new Cordenada();
        Cordenada c2 = new Cordenada();
        
        public Puntos_calc()
        {
            InitializeComponent();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (Rd1.Checked)
            {
                c1.Setx(Numx.Value);
                c1.Sety(Numy.Value);
            }
            else if (Rd2.Checked)
            {
                c2.Setx(Numx.Value);
                c2.Sety(Numy.Value);
            }

            Numx.Value = 0;
            Numy.Value = 0;
        }

        private void Btcalc_Click(object sender, EventArgs e) // calcula la distancia entre los punto y dibuja la linea
        {
            int xcentro = pictureBox1.Width / 2;
            int ycentro = pictureBox1.Height / 2;
            

            
            double resultx =  Math.Abs(Math.Pow(Convert.ToDouble(c1.x - c2.x),2));
            double resulty = Math.Abs(Math.Pow(Convert.ToDouble(c1.y - c2.y), 2));
            double result = Math.Abs(Math.Sqrt(Math.Abs(resultx - resulty)));
            Lbresult.Text = "La distacia del punto(" + c1.x + "," + c1.y + ") y el punto (" + c2.x + "," + c2.y + ")\n es: " + result + "cm";
            graf = pictureBox1.CreateGraphics();
            graf.TranslateTransform(xcentro, ycentro);
            graf.ScaleTransform(1, -1);
            graf.DrawLine(bic, Convert.ToInt32(c1.x)*5, Convert.ToInt32(c1.y) * 5, Convert.ToInt32(c2.x) * 5, Convert.ToInt32(c2.y) * 5);

        }
        private void Btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) //En esta funcion dibuja la grafica 
        {
            int xcentro = pictureBox1.Width / 2;
            int ycentro = pictureBox1.Height / 2;
            Pen lapiz = new Pen(Color.Black, 2);
            Pen lapiz2 = new Pen(Color.Black, 2);
            e.Graphics.TranslateTransform(xcentro, ycentro);
            e.Graphics.ScaleTransform(1, -1);

            e.Graphics.DrawLine(lapiz, xcentro * -1, 0, xcentro * 2,0);
            e.Graphics.DrawLine(lapiz, 0, ycentro , 0, ycentro * -1);
            for (int i = - xcentro; i < xcentro; i+=8)
            {
                e.Graphics.DrawLine(lapiz2, 5, i, -5, i);
                e.Graphics.DrawLine(lapiz2,i, 5, i, -5);
            }
        }
    }
}
