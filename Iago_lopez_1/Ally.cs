using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iago_lopez_1
{
    class Ally : Personaje, IAlly
    {
        public int Atacck { get; set; }
        public Ally(int Life, string Nombre, int type, int Atacck) : base(Life, Nombre, type)
        {
            this.Life = Life;
            this.Nombre = Nombre;
            this.Atacck = Atacck;
        }
        public override void Damage(int type, int dmg)
        {


        }
    }
}
