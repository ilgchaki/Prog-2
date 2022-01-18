/*Modificado por: Iago López Gómez  22/12/2021*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iago_lopez_1
{
    public partial class Form1 : Form
    {
        int tiempo=0;
        Ally a1 = new Ally(100, "Ando", 1, 10);
        Ally a2 = new Ally(120, "Sara", 2, 30);
        Ally a3 = new Ally(160, "Anra", 3, 20);
        Enemy e1 = new Enemy(100, "Lara", 1);
        Enemy e2 = new Enemy(200, "para", 2);
        Enemy e3 = new Enemy(150, "sara", 3);
        
        List<Enemy> Lista_enemigos = new List<Enemy>();
        List<Ally> Lista_aliados = new List<Ally>();
        int select = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void refrescar()
        {
            Lbenemy1.Text = e1.Nombre;
            Lbenemy2.Text = e2.Nombre;
            Lbenemy3.Text = e3.Nombre;
            Lbenemyt1.Text = e1.Conversor();
            Lbenemyt2.Text = e2.Conversor();
            Lbenemyt3.Text = e3.Conversor();
            Lbname.Text= Lista_aliados[select].Nombre;
            Lbtype.Text = Lista_aliados[select].Conversor();
            Lblife.Text = Lista_aliados[select].Life.ToString();
            Lblife_e1.Text = e1.Life.ToString();
            Lblife_e2.Text = e2.Life.ToString();
            Lblife_e3.Text = e3.Life.ToString();
            if (e1.Life<=0) PEnemy1.Image = Properties.Resources.Grave;
            if (e2.Life <= 0) Penemy2.Image = Properties.Resources.Grave;
            if (e3.Life <= 0) PEnemy3.Image = Properties.Resources.Grave;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer Timer = new Timer();
            Timer.Start();
            Lista_aliados.Add(a1);
            Lista_aliados.Add(a2);
            Lista_aliados.Add(a3);
            Lista_enemigos.Add(e1);
            Lista_enemigos.Add(e2);
            Lista_enemigos.Add(e3);
            Cbally.Items.Add(a1);
            Cbally.Items.Add(a2);
            Cbally.Items.Add(a3);
            Cbally.DisplayMember = "Nombre";
            refrescar();
        }


        private void Btstart_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int turn = rand.Next(0,3);
            Lista_enemigos[turn].Damage((Lista_aliados[select].Type), Lista_aliados[select].Atacck);
            refrescar();
        }

        private void Cbally_SelectedValueChanged(object sender, EventArgs e)
        {
            Lbname.Text=Cbally.Text;
            switch (Cbally.Text)
            {
                case "Ando":
                    Pallly.Image = Properties.Resources.SpearCaptain;
                    Lbtype.Text = a1.Conversor();
                    select = 0;
                    break;
                case "Sara":
                    Pallly.Image = Properties.Resources.AxeCaptain02;
                    Lbtype.Text = a2.Conversor();
                    select = 1;
                    break;
                case "Anra":
                    Pallly.Image = Properties.Resources.SwordSoldier01;
                    Lbtype.Text = a3.Conversor();
                    select = 2;
                    break;
                default:
                    break;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempo++;
            lbtime.Text = tiempo.ToString();
        }
    }
}
