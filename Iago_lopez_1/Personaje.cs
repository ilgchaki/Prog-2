/*Creador: Iago López Gómez  22/12/2021*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iago_lopez_1
{
    class Personaje 
    {
        public string Nombre { get;  set; }
        public int Life { get;  set; }
        public int Type { get; set; }
        public Personaje(int Life, string Nombre,int type)
        {
            this.Life = Life;
            this.Type = type;
            this.Nombre = Nombre;
        }
        public string Conversor()
        {
            string type="";
            switch (this.Type)
            {
                case 1:
                    type = "Lanza";
                    break;
                case 2:
                    type = "Hacha";
                    break;
                case 3:
                    type = "Espada";
                    break;

                default:
                    break;
            }

            return type;
        }
        public virtual void Damage(int type,int dmg)
        {

        }           
    }

}
