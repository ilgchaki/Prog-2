using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_2
{
    class jugador
    {
        public static int cont = 0;

        public jugador( string name , decimal numero , decimal minutos,string posicion) 
        {
            this.name = name;
            this.numero = numero;
            this.minutos = minutos;
            this.posicion = posicion;

            
            cont++;
        } //classe jugador
        public string name { get; private set; }
        public decimal numero { get; private set; }
        public int id { get; private set; }
        public decimal minutos { get; private set; }
        public string posicion { get; private set; }
        public jugador Self
        {
            get { return this; }
        }

    }
    class jugador_campo : jugador
    {
        public jugador_campo(string name, decimal numero, decimal minutos, string posicion, decimal goles) : base(name, numero, minutos, posicion)
        {
            this.goles = goles;
        }
        public decimal goles { get; private set; }
        public override string ToString()
        {
            return name;
        }
    } //clase jugado de campo con goles

}
