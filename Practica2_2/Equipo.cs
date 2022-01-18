using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_2
{
    public partial class Equipo : Form
    {
        public Equipo()
        {
            InitializeComponent();
        }
        int punt=0;
        int punt2 = 0;
        int contj = 0;
        int contpor = 0;
        List<jugador> jugadores_portero = new List<jugador>();
        List<jugador_campo> jugadores = new List<jugador_campo>();
        jugador j2;
        jugador_campo j1;
        private void button1_Click(object sender, EventArgs e) //Chekea cada boton y realiza la operacion necesaria
        {
            if (Rbdl.Checked)
            {
                j1 = new jugador_campo(Tnombre.Text, NumU.Value, nummin.Value, Rbdl.Text, numgol.Value);
                jugadores.Add(j1);
                lbnomm.Text = jugadores[0].name;
                Lbnbm.Text = NumU.Value.ToString();
                lbminm.Text = nummin.Value.ToString();
                lbgolm.Text = numgol.Value.ToString();
                Lbposm.Text = Rbdl.Text;               
                contj++;
            }
            if (Rbdf.Checked) 
            {
                j1 = new jugador_campo(Tnombre.Text, NumU.Value, nummin.Value, Rbdf.Text, numgol.Value);
                jugadores.Add(j1);
                lbnomm.Text = j1.name;
                Lbnbm.Text = j1.numero.ToString();                                                                                  
                lbminm.Text = j1.minutos.ToString();
                lbgolm.Text = j1.goles.ToString();
                Lbposm.Text = j1.posicion;
                contj++;
            }
            if (Rbmd.Checked)
            {
                j1 = new jugador_campo(Tnombre.Text, NumU.Value, nummin.Value, Rbmd.Text, numgol.Value);
              
                jugadores.Add(j1);
                lbnomm.Text = Tnombre.Text;
                Lbnbm.Text = NumU.Value.ToString();
                lbminm.Text = nummin.Value.ToString();
                lbgolm.Text = numgol.Value.ToString();
                Lbposm.Text = Rbmd.Text;
                contj++;
            }
            if (Rbpr.Checked) 
            {
                j2 = new jugador(Tnombre.Text, NumU.Value, nummin.Value, Rbpr.Text);               
                jugadores_portero.Add(j2);
                lbnomm.Text = Tnombre.Text;
                Lbnbm.Text = NumU.Value.ToString();
                lbminm.Text = nummin.Value.ToString();
                Lbposm.Text = Rbpr.Text;
                lbgolm.Text = "0";
                
                contpor++;
            }
        }

        private void Rbpr_Click(object sender, EventArgs e)
        {
            numgol.Enabled = false;

        }
        private void Rbdf_Click(object sender, EventArgs e)
        {
            numgol.Enabled =true;

        }
        private void Rbmd_Click(object sender, EventArgs e)
        {
            numgol.Enabled = true;

        }
        private void Rbdl_Click(object sender, EventArgs e)
        {
            numgol.Enabled = true;

        }
        private void Btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
        private void Btmostrar_Click(object sender, EventArgs e)
        {


            if (Rbpr.Checked)
            {
                lbnomm.Text = jugadores_portero[punt].name;
                Lbnbm.Text = jugadores_portero[punt].numero.ToString();
                lbminm.Text = jugadores_portero[punt].minutos.ToString();
                lbgolm.Text = "0";
                Lbposm.Text = jugadores_portero[punt].posicion;
            }
            else
            {
                lbnomm.Text = jugadores[punt2].name;
                Lbnbm.Text = jugadores[punt2].numero.ToString();
                lbminm.Text = jugadores[punt2].minutos.ToString();
                lbgolm.Text = jugadores[punt2].goles.ToString();
                Lbposm.Text = jugadores[punt2].posicion;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Rbpr.Checked)
            {
                if (punt > 0) punt--;
                lbnomm.Text = jugadores_portero[punt].name;
                Lbnbm.Text = jugadores_portero[punt].numero.ToString();
                lbminm.Text = jugadores_portero[punt].minutos.ToString();
                lbgolm.Text = "0";
                Lbposm.Text = jugadores_portero[punt].posicion;
            }
            else
            {
                if (punt2 > 0) punt2--;
                lbnomm.Text = jugadores[punt2].name;
                Lbnbm.Text = jugadores[punt2].numero.ToString();
                lbminm.Text = jugadores[punt2].minutos.ToString();
                lbgolm.Text = jugadores[punt2].goles.ToString();
                Lbposm.Text = jugadores[punt2].posicion;
            }
        } //Boton de Retoceder en la lista 

        private void button2_Click(object sender, EventArgs e)
        {
            if (Rbpr.Checked)
            {
                if (punt < jugadores_portero.Count()-1) punt++;
                lbnomm.Text = jugadores_portero[punt].name;
                Lbnbm.Text = jugadores_portero[punt].numero.ToString();
                lbminm.Text = jugadores_portero[punt].minutos.ToString();
                lbgolm.Text = "0";
                Lbposm.Text = jugadores_portero[punt].posicion;
            }
            else
            {
                if (punt2 < jugadores.Count()-1) punt2++;
                lbnomm.Text = jugadores[punt2].name;
                Lbnbm.Text = jugadores[punt2].numero.ToString();
                lbminm.Text = jugadores[punt2].minutos.ToString();
                lbgolm.Text = jugadores[punt2].goles.ToString();
                Lbposm.Text = jugadores[punt2].posicion;
            }
        }//Boton de avanzar 
    }
}
