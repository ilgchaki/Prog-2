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

namespace Ejercicio2
{
    public partial class Combate_pokemon : Form
    {
        bool win=false;
        bool lose = false;
        Ataques a1 = new Ataques("Esfera aural", "Lucha", 60);
        Ataques a2 = new Ataques("Pulso umbrío", "Siniestro", 50);
        Ataques a3 = new Ataques("Danza espada", "Estado");
        Ataques a4 = new Ataques("Rizo defensa", "Estado");
        Ataques a5 = new Ataques("Lenguetazo", "Fantasma", 25);             //Creo Los ataque y los pokemon respectivamente
        Ataques a7 = new Ataques("Golpe cuerpo", "Normal", 40);
        Ataques a6 = new Ataques("Eco metalico", "Acero", 15);
        Enemigo e1 = new Enemigo("Gastly", 200, "Fantasma");
        Enemigo e2 = new Enemigo("Aron", 200, "Acero");
        Enemigo e3 = new Enemigo("Snorlax", 200, "Normal");
        Aliado A1 = new Aliado("Lucario", 200);
        public Combate_pokemon()
        {
            InitializeComponent();
            InsertarAtaquesAliado();
            InsertarAtaquesEnemy();
            Refrescar();
        }
        public void InsertarAtaquesEnemy()//Inserto los ataque a cada pokemon
        {
            e1.Setatack1(a5) ;
            e2.Setatack1(a6);
            e3.Setatack1(a7);
        }
        public void InsertarAtaquesAliado()//Inserto los ataque a cada pokemon
        {
            A1.Setatack1(a1);
            A1.Setatack2(a2);
            A1.Setatack3(a3);
            A1.Setatack4(a4);         
            Rbt1.Text = A1.atack1.name;
            Rbt2.Text = A1.atack2.name;
            Rbt3.Text = A1.atack3.name;
            Rbt4.Text = A1.atack4.name;       
        } 
        private void PicAlly_Click(object sender, EventArgs e)
        {

        }
        private void Btattack_Click(object sender, EventArgs e)
        {
            if(win==false && lose==false)//Compruebo si he ganado o he perdido antes de hacer  nada
            {
                int daño = 0;
                int mul = 1;
                if (Rbt1.Checked)
                {
                    mul = ComprobacionEfecto(A1.atack1.tipo);
                    daño = A1.Getdamage(a1, mul);
                    e1.SetLife(e1.life - daño);
                }
                else if (Rbt2.Checked)
                {
                    mul = ComprobacionEfecto(A1.atack2.tipo);
                    daño = A1.Getdamage(a2, mul);
                    e1.SetLife(e1.life - daño);
                }
                else if (Rbt3.Checked)
                {
                    mul = 3;
                    A1.SetAtaque(A1.Ataque + 5);
                }
                else if (Rbt4.Checked)
                {
                    mul = 4;
                    A1.Setdefensa(A1.defensa + 5);
                }
                switch (mul)
                {
                    case 0:
                        Lbtext.Text = "OH! No es efectivo  contra " + e1.name + " No recibe daño";
                        break;
                    case 1:
                        Lbtext.Text = "Es efectivo  contra " + e1.name + " Recibe " + daño + " de daño ";
                        break;
                    case 2:
                        Lbtext.Text = "Es muy efectivo  contra " + e1.name + " Recibe " + daño + " de daño ";
                        break;
                    case 3:
                        Lbtext.Text = "Aumentas tu ataque  ";
                        break;
                    case 4:
                        if (A1.defensa<10) Lbtext.Text = "Aumentas tu defensa ";
                        else Lbtext.Text = "No puede aumentar mas tu defensa ";
                        break;
                    default:
                        break;
                }
                comprobarvidaEnemy();             
                if (e1.life <= 0)
                {
                    e1 = e2;
                    if (e2.life <= 0)
                    {
                        e1 = e3;
                    }
                }
                comprobarvidaEnemy();
                if (e1.life <= 0)
                {
                    Lbtext.Text = "Felicidades has ganado";
                    win = true;
                }
                LbText2.Text = e1.name + " Contrataca y te inflinje " + (e1.atack1.dmg - A1.defensa).ToString() + " De daño";
                A1.ReceiveDamage(e1.atack1.dmg - A1.defensa);
                comprobarvidaAlly();
                if (A1.life<=0)
                {
                    A1.SetLife(0);
                    HpAlly.Value = A1.life;
                    lose = true;
                }
            }
            else
            {
                LbText2.Text = "";
                if (win==true) Lbtext.Text = "Ya has ganado reinicia para volver a combatir";
                if (lose==true) Lbtext.Text = "Has Perdido reinicia para volver a intentarlo";
            }
            Refrescar();
        }
        public  int ComprobacionEfecto(string tipo)
        {
            if (tipo=="Lucha" && e1.tipo=="Fantasma") return 0;
            if (tipo == "Lucha" && e1.tipo == "Acero") return 2;
            if (tipo == "Lucha" && e1.tipo == "Normal") return 2;
            if (tipo == "Siniestro" && e1.tipo == "Fantasma") return 2;
            if (tipo == "Siniestro" && e1.tipo == "Acero")  return 1;          
            if (tipo == "Siniestro" && e1.tipo == "Normal") return 1;                     
            else return 0;
        }//Funcion que calcula el multiplicador dependiendo de los tipos
        public void comprobarvidaAlly()
        {
            if (A1.life >= 0)
            {
                HpAlly.Value = A1.life;
                if (A1.life < 100) HpAlly.SetState(3);
                if (A1.life < 40) HpAlly.SetState(2);
            }
            else
            {
                HpAlly.Value = 0;
                Lbtext.Text = A1.name + " Esta fuera de combate ";              
            }
        }//Funcion que comprueba la vida del aliado  y modifica la barra de vida
        public void comprobarvidaEnemy()
        {
            if (e1.life>=0)
            {
                Hpenemy.Value = e1.life;
                if (e1.life > 100) Hpenemy.SetState(1);
                if (e1.life < 100) Hpenemy.SetState(3);
                if (e1.life < 40) Hpenemy.SetState(2);
            }
            else
            {
                Hpenemy.Value = 0;
                Lbtext.Text = e1.name + " Ya no puede combatir ";
                Hpenemy.SetState(1);               
            }


        } //Funcion que comprueba la vida del enemigo y modifica la barra de vida
        private void Refrescar()
        {
            Lbname1.Text = A1.name;          
            Lbhp.Text = "Hp: " + A1.life;
            Lbnameenemy.Text = e1.name;
            string text = e1.name;          
            if (e1.life>=0)LbLifeenemy.Text = "Hp: " + e1.life;
            else LbLifeenemy.Text = "Hp: " + 0;
            PicEnemy.Image = Image.FromFile(String.Format("../imagenes/{0}.gif", text)) ;                   
        } //Funcion que comprueba y refresca los parametros en pantalla
    }
    public static class ModifyProgressBarColor //Este es el metodo que me permita cambiar la barra de color
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
