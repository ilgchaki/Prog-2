using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ataques //Esta es la clase ataques
    {
        public Ataques(string name , string tipo, int dmg)
        {
            this.name = name;
            this.tipo = tipo;
            this.dmg = dmg;
        }
        public string name { get; private set; }
        public string tipo { get; private set; }
        public int dmg { get; private set; }

        public Ataques(string name, string tipo="Estado") 
        {
            this.name = name;
            this.tipo = tipo;          
        }
    }
}
