using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Cordenada //Clase cordenadas
    {
        static public int count = 0;
        public decimal x { get; private set; }
        public decimal y { get; private set; }
        public Cordenada(decimal x = 0, decimal y = 0)
        {
            this.x = x;
            this.y = y;
            count++;
        }
        public void  Setx(Decimal value)
            {
            x = value;
            }
        public void Sety(decimal value)
        {
            y= value;
        }
        ~Cordenada()
        {
            count--;
        }
    }
}
