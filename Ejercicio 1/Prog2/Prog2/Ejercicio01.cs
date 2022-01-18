using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Prog2
{
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
    public partial class Ejercicio01 : Form
    {
        Ally a1 = new Ally("Luis", 150, 11);
        Enemy e1 = new Enemy("Orc", 300, 13);
        public Ejercicio01()
        {
            InitializeComponent();
            Refrescar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbcharacters.SelectedIndex)
            {
                case 0:
                    Lbname1.Text = a1.name;
                    Lblife1.Text = a1.health.ToString();
                    Lbdmg1.Text = a1.dmg.ToString();
                    break;
                case 1:
                    Lbname2.Text = e1.name;
                    Lblife2.Text = e1.health.ToString();
                    Lbdmg2.Text = e1.dmg.ToString();
                    break;
                default:

                    break;
            }
        }

        private void Btnstart_Click(object sender, EventArgs e)
        {
            cbcharacters.Items.Add(a1.name);
            cbcharacters.Items.Add(e1.name);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (e1.health % 3 == 0)
            {
                e1.Sethealth(e1.health - a1.dmg * 2 + 3);
                if (e1.health < 0) e1.Sethealth(0);
                Lblife2.Text = e1.health.ToString();
                Lbresult.Text = a1.name + " Ataca a " + e1.name + " su vida pasa a " + e1.health + "\n el escudo a reducido en 3 el Daño \n Golpe critico";
            }
            else
            {
                e1.Sethealth(e1.health - a1.dmg + 3);
                if (e1.health < 0) e1.Sethealth(0);
                Lblife2.Text = e1.health.ToString();
                Lbresult.Text = a1.name + " Ataca a " + e1.name + " su vida pasa a " + e1.health + "\n el escudo a reducido en 3 el Daño";
            }
            if (e1.health <= 0) Lbresult.Text = "Enorabuena " + a1.name + " Ha ganado";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Ternario shield <=0 ?damage:damage-shield;
            if (a1.health % 3 == 0)
            {
                a1.Sethealth(a1.health - e1.dmg * 2 + 4);
                if (a1.health < 0) a1.Sethealth(0);
                Lblife1.Text = a1.health.ToString();
                Lbresult.Text = e1.name + " Ataca a " + a1.name + " su vida pasa a " + a1.health + "\n el escudo a reducido en 4 el Daño \n Golpe critico";
            }
            else
            {
                a1.Sethealth(a1.health - e1.dmg + 4);
                if (a1.health < 0) a1.Sethealth(0);
                Lblife1.Text = a1.health.ToString();
                Lbresult.Text = e1.name + " Ataca a " + a1.name + " su vida pasa a " + a1.health + "\n el escudo a reducido en 4 el Daño";
            }
            if (a1.health <= 0) Lbresult.Text = "Enorabuena " + e1.name + " Ha ganado";

            Refrescar();
        }
        private void Refrescar()
        {
            Lbname1.Text = a1.name;
            Lblife1.Text = a1.health.ToString();
            Lbdmg1.Text = a1.dmg.ToString();

            Lbname2.Text = e1.name;
            Lblife2.Text = e1.health.ToString();
            Lbdmg2.Text = e1.dmg.ToString();
        }

        private void BtVida_Click(object sender, EventArgs e)
        {
            if (Bar1.Value < 50) Bar1.SetState(3);
            if (Bar1.Value < 20) Bar1.SetState(2);
            if (Bar1.Value !=0)  Bar1.Value = Bar1.Value - 10;


        }
    }
}
