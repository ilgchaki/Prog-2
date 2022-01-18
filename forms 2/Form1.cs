using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_2
{
    
    public partial class Form1 : Form
    {
        Player p1 = new Player("Andrea", 100);
        Ally a1 = new Ally("Luis", 150);
        character c3 = new character("Darko", 200);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            cbcharacters.Items.Add(p1.name);
            cbcharacters.Items.Add(a1.name);
        }

        private void Title1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbcharacters.SelectedIndex)
            {
                case 0:
                    Title1.Text = p1.name;
                    label3.Text = p1.health.ToString();
                    break;
                case 1:
                    Title1.Text = a1.name;
                    label3.Text = a1.health.ToString();
                    break;
                default:
                    Title1.Text = "Not found";
                    label3.Text = "Not found";
                    break;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
