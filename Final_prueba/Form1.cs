using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_prueba
{
    public partial class Form1 : Form
    {
        int timeLeft;
        bool meta1 = false;
        bool meta2 = false;
        bool meta3 = false;
        bool meta4 = false;
        bool meta5 = false;
        bool meta6 = false;
        public Form1()
        {
            InitializeComponent();
        }
        Objeto obs = new Objeto("obs", "obs_1");
        Meta m1 = new Meta(1, 100);
        Meta m2 = new Meta(2, 200);                                         
        Meta m3 = new Meta(3, 300);
        Meta m4 = new Meta(4, 400);
        Meta m5 = new Meta(5, 500);                                        //Aqui creamos todas las variables y lista                                                                          //que utilizaremos en el codigo
        Meta m6 = new Meta(6, 600);
        Point inicio = new Point(58, 228);
        Point inicio2 = new Point(58, 228);
        Point inicio3 = new Point(58, 228);
        Point inicio4 = new Point(58, 228);
        Point inicio5 = new Point(58, 228);
        Point inicio6 = new Point(58, 228);
        Player p1 = new Player(0, "Aron");      
        List<Point> Lista = new List<Point>();
        List<Point> ListaDef = new List<Point>();
        List<Point> ListaDef2 = new List<Point>();
        List<Point> ListaDef3 = new List<Point>();
        List<Point> ListaDef4 = new List<Point>();
        List<Point> ListaDef5 = new List<Point>();
        List<Point> ListaDef6 = new List<Point>();
        float Lerp(float a, float b, float t)
        {
            //return firstFloat * by + secondFloat * (1 - by);
            return (1 - t) * a + t * b;
        }// Funcion lerp base
        void Refrescar()
        {
            this.Refresh();
            Lbpoints.Text = (ListaDef.Count() - 1).ToString();
            Lbresultado.Text = "";
            Lbmoney.Text = p1.Money.ToString();
        }//Funcion que refresaca la informacion en pantalla
        Point Lerp(Point a, Point b, float t)
        {
            float retX = Lerp(a.X, b.X, t);
            float retY = Lerp(a.Y, b.Y, t);
            return new Point(((int)retX), ((int)retY));
        }// Funcion lerp para recorer la linea entre dos puntos
        private void Form1_Load(object sender, EventArgs e)
        {
            Lista.Add(new Point(cuadrado.Location.X, cuadrado.Location.Y));
            ListaDef.Add(new Point(cuadrado.Location.X, cuadrado.Location.Y));
            ListaDef2.Add(new Point(cuadrado2.Location.X, cuadrado.Location.Y));
        }
        private void BtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Boton de salida
        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
            timeLeft = 30;
            Lbtime.Text = "30 seconds";
            Timer.Start();
        }    //Botones que se encargan de ocultar y  
        private void button14_Click(object sender, EventArgs e)
        {
            timeLeft = 30;
            Lbtime.Text = "30 seconds";
            Timer.Start();
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }   //mostrar los paneles de cada nivel
        private void button15_Click(object sender, EventArgs e)
        {
            timeLeft = 30;
            Lbtime.Text = "30 seconds";
            Timer.Start();
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            timeLeft = 30;
            Lbtime.Text = "30 seconds";
            Timer.Start();
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            timeLeft = 30;
            Lbtime.Text = "30 seconds";
            Timer.Start();
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = true;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            timeLeft = 30;
            Lbtime.Text = "30 seconds";
            Timer.Start();
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = true;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel3.Visible = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel3.Visible = true;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            Timer.Stop();
            ListaDef.Clear();
            ListaDef.Add(inicio);
            ListaDef2.Clear();
            ListaDef3.Clear();
            ListaDef4.Clear();
            ListaDef5.Clear();
            ListaDef6.Clear();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                Lbtime.Text = timeLeft + " seconds";
            }
            else
            {
                Timer.Stop();
                Lbtime.Text = "Time's up!";
                MessageBox.Show("Se acabo tu tiempo.", "lost");
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel3.Visible = true;
            }
        } //Funcion que controla el tick del timer
        private async void button1_Click(object sender, EventArgs e)
        {
            Refrescar();
            if (ListaDef.Count() == 0)
            {
                ListaDef.Add(inicio);
            }
            meta1 = true;
            int i = 1;
            Graphics g = pictureBox1.CreateGraphics();
            foreach (var punto in ListaDef)
            {
                float t = 0.2f;
                Point inic = new Point(cuadrado.Location.X, cuadrado.Location.Y);
                if (cuadrado.Bounds.IntersectsWith(pictureBox2.Bounds) || cuadrado.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    Lbresultado.Text = "HAS PERDIDO";

                    cuadrado.Location = inicio;
                    break;
                }
                Point ind = punto;
                while (ind != ListaDef[i] && meta1 != false)
                {
                    meta1 = true;
                    ind = Lerp(ind, ListaDef[i], t);
                    cuadrado.Location = ind;
                    if (cuadrado.Bounds.IntersectsWith(pictureBox2.Bounds) || cuadrado.Bounds.IntersectsWith(pictureBox3.Bounds))
                    {
                        Lbresultado.Text = "HAS PERDIDO";
                        await Task.Delay(1000);
                        cuadrado.Location = inicio;
                        Lbpoints.Text = (ListaDef.Count()).ToString();
                        this.Refresh();
                        meta1 = false;
                        break;
                    }
                    await Task.Delay(300);
                    t += 0.2f;
                }
                if (i < ListaDef.Count - 1)
                {
                    i++;
                }
                if (meta1 == false)
                {
                    break;
                }
                if (ListaDef.Count == 0)
                {
                    break;
                }
            }
            if (cuadrado.Bounds.IntersectsWith(Meta1.Bounds) && meta1 == true)
            {
                Lbresultado.Text = "HAS Ganado";
                await Task.Delay(1000);
                p1.SetMoney(m1.puntos);
                m1.GetPuntos();
                ListaDef.Clear();
                ListaDef.Add(inicio);
                cuadrado.Location = inicio;
                Refrescar();
                button14.Enabled = true;
                button14.Visible = true;
            }
            else
            {
                ListaDef.Clear();
                ListaDef.Add(inicio);
                cuadrado.Location = inicio;
                Refrescar();
            }
        }
        private async void Btnivel2_Click(object sender, EventArgs e)
        {
            Refrescar();
            if (ListaDef2.Count() == 0)
            {
                ListaDef2.Add(inicio2);
            }
            meta2 = true;
            int i = 1;
            Graphics g2 = pictureBox11.CreateGraphics();
            foreach (var punto in ListaDef2)
            {
                float t = 0.2f;
                Point inic = new Point(cuadrado2.Location.X, cuadrado2.Location.Y);
                if (cuadrado2.Bounds.IntersectsWith(pictureBox8.Bounds) || cuadrado2.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    Lbresultado.Text = "HAS PERDIDO";
                    cuadrado2.Location = inicio2;
                    break;
                }
                Point ind = punto;
                while (ind != ListaDef2[i])
                {
                    meta2 = true;
                    ind = Lerp(ind, ListaDef2[i], t);
                    cuadrado2.Location = ind;
                    if (cuadrado2.Bounds.IntersectsWith(pictureBox8.Bounds) || cuadrado2.Bounds.IntersectsWith(pictureBox9.Bounds))
                    {
                        Lbresultado.Text = "HAS PERDIDO";
                        await Task.Delay(1000);
                        cuadrado2.Location = inicio2;
                        Lbpoints.Text = (ListaDef2.Count()).ToString();
                        this.Refresh();
                        meta2 = false;
                        break;
                    }
                    await Task.Delay(300);
                    t += 0.2f;
                }
                if (i < ListaDef2.Count - 1)
                {
                    i++;
                }
                if (meta2 == false)
                {
                    break;
                }
                if (ListaDef2.Count == 0)
                {
                    break;
                }
            }
            Lbpoints.Text = (ListaDef2.Count()).ToString();
            if (cuadrado2.Bounds.IntersectsWith(Meta2.Bounds) && meta2 == true)
            {
                Lbresultado.Text = "HAS ganado";
                await Task.Delay(1000);
                p1.SetMoney(m2.puntos);
                m2.GetPuntos();
                ListaDef2.Clear();
                ListaDef2.Add(inicio2);
                cuadrado2.Location = inicio2;
                Refrescar();
                button15.Enabled = true;
                button15.Visible = true;
            }
            else
            {
                ListaDef2.Clear();
                ListaDef2.Add(inicio2);
                cuadrado2.Location = inicio2;
                Refrescar();
            }
        }
        private async void Btnivel3_Click(object sender, EventArgs e)
        {
            Refrescar();
            if (ListaDef3.Count() == 0)
            {
                ListaDef3.Add(inicio3);
            }
            meta3 = true;
            int i = 1;
            Graphics g3 = pictureBox15.CreateGraphics();
            foreach (var punto in ListaDef3)
            {
                float t = 0.2f;
                Point inic = new Point(cuadrado3.Location.X, cuadrado3.Location.Y);
                if (cuadrado3.Bounds.IntersectsWith(pictureBox13.Bounds) || cuadrado3.Bounds.IntersectsWith(pictureBox12.Bounds) || cuadrado3.Bounds.IntersectsWith(pictureBox16.Bounds))
                {
                    Lbresultado.Text = "HAS PERDIDO";
                    cuadrado3.Location = inicio3;
                    break;
                }
                Point ind = punto;
                while (ind != ListaDef3[i])
                {
                    meta3 = true;
                    ind = Lerp(ind, ListaDef3[i], t);
                    cuadrado3.Location = ind;
                    if (cuadrado3.Bounds.IntersectsWith(pictureBox13.Bounds) || cuadrado3.Bounds.IntersectsWith(pictureBox12.Bounds) || cuadrado3.Bounds.IntersectsWith(pictureBox16.Bounds))
                    {
                        Lbresultado.Text = "HAS PERDIDO";
                        await Task.Delay(1000);
                        cuadrado3.Location = inicio3;
                        Lbpoints.Text = (ListaDef3.Count()).ToString();
                        this.Refresh();
                        meta3 = false;
                        break;
                    }
                    await Task.Delay(300);
                    t += 0.2f;
                }
                if (i < ListaDef3.Count - 1)
                {
                    i++;
                }
                if (meta3 == false)
                {
                    break;
                }
                if (ListaDef3.Count == 0)
                {
                    break;
                }
            }
            if (cuadrado3.Bounds.IntersectsWith(Meta3.Bounds) && meta3 == true)
            {
                Lbresultado.Text = "HAS ganado";
                await Task.Delay(1000);
                p1.SetMoney(m3.puntos);
                m3.GetPuntos();
                ListaDef3.Clear();
                ListaDef3.Add(inicio3);
                cuadrado3.Location = inicio3;
                Refrescar();
                button16.Enabled = true;
                button16.Visible = true;
            }
            else
            {
                ListaDef3.Clear();
                ListaDef3.Add(inicio3);
                cuadrado3.Location = inicio3;
                Refrescar();
            }
        }
        private async void Btnivel4_Click(object sender, EventArgs e)
        {
            Refrescar();
            if (ListaDef4.Count() == 0)
            {
                ListaDef4.Add(inicio4);
            }
            meta4 = true;
            int i = 1;
            Graphics g4 = pictureBox20.CreateGraphics();
            foreach (var punto in ListaDef4)
            {
                float t = 0.2f;
                Point inic = new Point(cuadrado4.Location.X, cuadrado4.Location.Y);
                if (cuadrado4.Bounds.IntersectsWith(pictureBox17.Bounds) || cuadrado4.Bounds.IntersectsWith(pictureBox18.Bounds) || cuadrado4.Bounds.IntersectsWith(pictureBox10.Bounds))
                {
                    Lbresultado.Text = "HAS PERDIDO";
                    cuadrado4.Location = inicio4;
                    break;
                }
                Point ind = punto;
                while (ind != ListaDef4[i])
                {
                    meta4 = true;
                    ind = Lerp(ind, ListaDef4[i], t);
                    cuadrado4.Location = ind;
                    if (cuadrado4.Bounds.IntersectsWith(pictureBox17.Bounds) || cuadrado4.Bounds.IntersectsWith(pictureBox18.Bounds) || cuadrado4.Bounds.IntersectsWith(pictureBox10.Bounds))
                    {
                        Lbresultado.Text = "HAS PERDIDO";
                        await Task.Delay(1000);
                        cuadrado4.Location = inicio4;
                        Lbpoints.Text = (ListaDef4.Count()).ToString();
                        this.Refresh();

                        meta4 = false;
                        break;
                    }
                    await Task.Delay(300);
                    t += 0.2f;
                }
                if (i < ListaDef4.Count - 1)
                {
                    i++;
                }
                if (meta4 == false)
                {
                    break;
                }
                if (ListaDef4.Count == 0)
                {
                    break;
                }
            }
            if (cuadrado4.Bounds.IntersectsWith(Meta4.Bounds) && meta4 == true)
            {
                Lbresultado.Text = "HAS ganado";
                await Task.Delay(1000);
                p1.SetMoney(m4.puntos);
                m4.GetPuntos();
                ListaDef4.Clear();
                ListaDef4.Add(inicio4);
                cuadrado4.Location = inicio4;
                Refrescar();
                button17.Enabled = true;
                button17.Visible = true;
            }
            else
            {
                ListaDef4.Clear();
                ListaDef4.Add(inicio4);
                cuadrado4.Location = inicio4;
                Refrescar();
            }
        }   //Estos metodos asincronos se encarga de gestionar cada nivel
        private async void Btnivel5_Click(object sender, EventArgs e)
        {
            Refrescar();
            if (ListaDef5.Count() == 0)
            {
                ListaDef5.Add(inicio5);
            }
            meta5 = true;
            int i = 1;
            Graphics g5 = pictureBox25.CreateGraphics();
            foreach (var punto in ListaDef5)
            {
                float t = 0.2f;
                Point inic = new Point(cuadrado5.Location.X, cuadrado5.Location.Y);
                if (cuadrado5.Bounds.IntersectsWith(pictureBox21.Bounds) || cuadrado5.Bounds.IntersectsWith(pictureBox22.Bounds) || cuadrado5.Bounds.IntersectsWith(pictureBox23.Bounds))
                {
                    Lbresultado.Text = "HAS PERDIDO";
                    cuadrado5.Location = inicio5;
                    break;
                }
                Point ind = punto;
                while (ind != ListaDef5[i])
                {
                    meta5 = true;
                    ind = Lerp(ind, ListaDef5[i], t);
                    cuadrado5.Location = ind;
                    if (cuadrado5.Bounds.IntersectsWith(pictureBox21.Bounds) || cuadrado5.Bounds.IntersectsWith(pictureBox22.Bounds) || cuadrado5.Bounds.IntersectsWith(pictureBox23.Bounds))
                    {
                        Lbresultado.Text = "HAS PERDIDO";
                        await Task.Delay(1000);
                        cuadrado5.Location = inicio5;
                        Lbpoints.Text = (ListaDef5.Count()).ToString();
                        this.Refresh();
                        meta5 = false;
                        break;
                    }
                    await Task.Delay(300);
                    t += 0.2f;
                }
                if (i < ListaDef5.Count - 1)
                {
                    i++;
                }
                if (meta5 == false)
                {
                    break;
                }
                if (ListaDef5.Count == 0)
                {
                    break;
                }
            }
            if (cuadrado5.Bounds.IntersectsWith(Meta5.Bounds) && meta5 == true)
            {
                Lbresultado.Text = "HAS ganado";
                await Task.Delay(1000);
                p1.SetMoney(m5.puntos);
                m5.GetPuntos();
                ListaDef5.Clear();
                ListaDef5.Add(inicio5);
                cuadrado5.Location = inicio5;
                Refrescar();
                button18.Enabled = true;
                button18.Visible = true;
            }
            else
            {
                ListaDef5.Clear();
                ListaDef5.Add(inicio5);
                cuadrado5.Location = inicio5;
                Refrescar();
            }
        }
        private async void Btnivel6_Click(object sender, EventArgs e)
        {
            Refrescar();
            if (ListaDef6.Count() == 0)
            {
                ListaDef6.Add(inicio6);
            }
            meta6 = true;
            int i = 1;
            Graphics g6 = pictureBox30.CreateGraphics();
            foreach (var punto in ListaDef6)
            {
                float t = 0.2f;
                Point inic = new Point(cuadrado6.Location.X, cuadrado6.Location.Y);
                if (cuadrado6.Bounds.IntersectsWith(pictureBox26.Bounds) || cuadrado6.Bounds.IntersectsWith(pictureBox27.Bounds) || cuadrado6.Bounds.IntersectsWith(pictureBox28.Bounds))
                {
                    Lbresultado.Text = "HAS PERDIDO";

                    cuadrado6.Location = inicio6;
                    break;

                }
                Point ind = punto;
                while (ind != ListaDef6[i])
                {
                    meta5 = true;
                    ind = Lerp(ind, ListaDef6[i], t);
                    cuadrado6.Location = ind;
                    if (cuadrado6.Bounds.IntersectsWith(pictureBox26.Bounds) || cuadrado6.Bounds.IntersectsWith(pictureBox27.Bounds) || cuadrado6.Bounds.IntersectsWith(pictureBox28.Bounds))
                    {
                        Lbresultado.Text = "HAS PERDIDO";
                        await Task.Delay(1000);
                        cuadrado6.Location = inicio6;
                        Lbpoints.Text = (ListaDef6.Count()).ToString();
                        this.Refresh();
                        meta6 = false;
                        break;
                    }
                    await Task.Delay(300);
                    t += 0.2f;
                }
                if (i < ListaDef6.Count - 1)
                {
                    i++;
                }
                if (meta6 == false)
                {
                    break;
                }
                if (ListaDef6.Count == 0)
                {
                    break;
                }
            }
            if (cuadrado6.Bounds.IntersectsWith(Meta6.Bounds) && meta6 == true)
            {
                Lbresultado.Text = "HAS ganado";
                await Task.Delay(1000);
                p1.SetMoney(m6.puntos);
                m6.GetPuntos();
                ListaDef6.Clear();
                ListaDef6.Add(inicio6);
                cuadrado6.Location = inicio6;
                Refrescar();
                button18.Enabled = true;
                button18.Visible = true;
            }
            else
            {
                ListaDef6.Clear();
                ListaDef6.Add(inicio6);
                cuadrado6.Location = inicio6;
                Refrescar();
            }
        }
        private void pictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            if (ListaDef2.Count() == 0)
            {
                ListaDef2.Add(inicio2);
            }
            Graphics g2 = pictureBox11.CreateGraphics();
            Pen Lapiz = new Pen(Color.Red, 2);
            g2.DrawRectangle(Lapiz, new Rectangle(e.X, e.Y, 2, 2));
            ListaDef2.Add(new Point(e.X, e.Y));
            Lbpoints.Text = (ListaDef2.Count() - 1).ToString();
            if (ListaDef2.Count > 1)
            {
                g2.DrawLine(Lapiz, ListaDef2[ListaDef2.Count - 1], ListaDef2[ListaDef2.Count - 2]);
            }
        }             
        private void pictureBox15_MouseDown(object sender, MouseEventArgs e)
        {
            if (ListaDef3.Count() == 0)
            {
                ListaDef3.Add(inicio3);
            }
            Graphics g3 = pictureBox15.CreateGraphics();
            Pen Lapiz = new Pen(Color.Red, 2);
            g3.DrawRectangle(Lapiz, new Rectangle(e.X, e.Y, 2, 2));
            ListaDef3.Add(new Point(e.X, e.Y));
            Lbpoints.Text = (ListaDef3.Count() - 1).ToString();
            if (ListaDef3.Count > 1)
            {
                g3.DrawLine(Lapiz, ListaDef3[ListaDef3.Count - 1], ListaDef3[ListaDef3.Count - 2]);
            }
        }
        private void pictureBox20_MouseDown(object sender, MouseEventArgs e)
        {
            if (ListaDef4.Count() == 0)
            {
                ListaDef4.Add(inicio4);
            }
            Graphics g4 = pictureBox20.CreateGraphics();
            Pen Lapiz = new Pen(Color.Red, 2);
            g4.DrawRectangle(Lapiz, new Rectangle(e.X, e.Y, 2, 2));
            ListaDef4.Add(new Point(e.X, e.Y));
            Lbpoints.Text = (ListaDef4.Count() - 1).ToString();
            if (ListaDef4.Count > 1)
            {
                g4.DrawLine(Lapiz, ListaDef4[ListaDef4.Count - 1], ListaDef4[ListaDef4.Count - 2]);
            }
        } //Metodos que controlan cuando se hace click en el picture box 
        private void pictureBox25_MouseDown(object sender, MouseEventArgs e)
        {
            if (ListaDef5.Count() == 0)
            {
                ListaDef5.Add(inicio5);
            }
            Graphics g5 = pictureBox25.CreateGraphics();
            Pen Lapiz = new Pen(Color.Red, 2);
            g5.DrawRectangle(Lapiz, new Rectangle(e.X, e.Y, 2, 2));
            ListaDef5.Add(new Point(e.X, e.Y));
            Lbpoints.Text = (ListaDef5.Count() - 1).ToString();
            if (ListaDef5.Count > 1)
            {
                g5.DrawLine(Lapiz, ListaDef5[ListaDef5.Count - 1], ListaDef5[ListaDef5.Count - 2]);
            }
        } //y dibujan los puntos 
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen Lapiz = new Pen(Color.Red, 2);
            g.DrawRectangle(Lapiz, new Rectangle(e.X, e.Y, 2, 2));
            Lista.Add(new Point(e.X, e.Y));
            ListaDef.Add(new Point(e.X, e.Y));
            Lbpoints.Text = (ListaDef.Count() - 1).ToString();
            if (ListaDef.Count > 1)
            {
                g.DrawLine(Lapiz, ListaDef[ListaDef.Count - 1], ListaDef[ListaDef.Count - 2]);
            }
        }
        private void pictureBox30_MouseDown(object sender, MouseEventArgs e)
        {
            if (ListaDef6.Count() == 0)
            {
                ListaDef6.Add(inicio6);
            }
            Graphics g6 = pictureBox30.CreateGraphics();
            Pen Lapiz = new Pen(Color.Red, 2);
            g6.DrawRectangle(Lapiz, new Rectangle(e.X, e.Y, 2, 2));
            ListaDef6.Add(new Point(e.X, e.Y));
            Lbpoints.Text = (ListaDef6.Count() - 1).ToString();
            if (ListaDef6.Count > 1)
            {
                g6.DrawLine(Lapiz, ListaDef6[ListaDef6.Count - 1], ListaDef6[ListaDef6.Count - 2]);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            p1.SetName("Aron");
            cuadrado.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado2.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado3.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado4.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado5.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado6.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
        }
        private void Btcompra1_Click(object sender, EventArgs e)
        {
            if (p1.Money >= 200 || Btcompra1.Text == "Seleccionar")
            {
                if (Btcompra1.Text != "Seleccionar")
                {
                    p1.offMoney(200);
                    Btcompra1.Text = "Seleccionar";
                    MessageBox.Show("Comprado. \n saldo actual: " + p1.Money + " Points", "Compra realizada");
                }
                p1.SetName("Pichu");
            }
            else MessageBox.Show("No tienes suficientes puntos. \n saldo actual: " + p1.Money + " Points", "No points");
            cuadrado.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado2.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado3.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado4.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado5.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado6.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
        }
        private void Btcompra2_Click(object sender, EventArgs e)
        {
            if (p1.Money >= 400 || Btcompra2.Text == "Seleccionar")
            {
                if (Btcompra2.Text != "Seleccionar")
                {
                    p1.offMoney(400);
                    Btcompra2.Text = "Seleccionar";
                    MessageBox.Show("Comprado. \n saldo actual: " + p1.Money + " Points", "Compra realizada");
                }
                p1.SetName("Eevee");
            }
            else MessageBox.Show("No tienes suficientes puntos. \n saldo actual: " + p1.Money + " Points", "No points");
            cuadrado.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado2.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado3.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado4.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado5.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado6.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
        } //Son los metodos que gestiona el sistema de compra de skins
        private void Btcompra3_Click(object sender, EventArgs e)
        {
            if (p1.Money >= 600 || Btcompra3.Text == "Seleccionar")
            {
                if (Btcompra3.Text != "Seleccionar")
                {
                    p1.offMoney(600);
                    Btcompra3.Text = "Seleccionar";
                    MessageBox.Show("Comprado. \n saldo actual: " + p1.Money + " Points", "Compra realizada");
                }
                p1.SetName("Zubat");
            }
            else MessageBox.Show("No tienes suficientes puntos. \n saldo actual: " + p1.Money + " Points", "No points");
            cuadrado.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado2.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado3.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado4.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado5.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado6.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
        }
        private void Btcompra4_Click(object sender, EventArgs e)
        {
            if (p1.Money >= 800 || Btcompra4.Text == "Seleccionar")
            {
                if (Btcompra4.Text != "Seleccionar")
                {
                    p1.offMoney(800);
                    Btcompra4.Text = "Seleccionar";
                    MessageBox.Show("Comprado. \n saldo actual: " + p1.Money + " Points", "Compra realizada");
                }
                p1.SetName("Burmy");
            }
            else MessageBox.Show("No tienes suficientes puntos. \n saldo actual: " + p1.Money + " Points", "No points");
            cuadrado.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado2.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado3.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado4.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado5.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
            cuadrado6.Image = Image.FromFile(String.Format("../Resources/{0}.gif", p1.name));
        }
    }
}
