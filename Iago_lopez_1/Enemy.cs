using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iago_lopez_1
{
    class Enemy : Personaje, IEnemy
    {
        public Enemy(int Life, string Nombre, int type) : base(Life, Nombre, type)
        {
            this.Life = Life;
            this.Nombre = Nombre;
            this.Type = type;
        }
        public void SetLife(int dmg)
        {
            this.Life = this.Life - dmg;
        }
        public override void Damage(int type, int dmg)
        {
            switch (type)
            {
                case 1:
                    if (this.Type == 1)
                    {                        
                        this.SetLife(dmg);
                    }
                    if (this.Type == 2)
                    {
                        dmg= dmg/2;
                        SetLife(dmg);
                    }
                    if (this.Type == 3)
                    {
                        dmg = 2 * dmg;
                        this.SetLife(dmg);
                    }
                    break;
                case 2:
                    if (this.Type == 2)
                    {                      
                        this.SetLife(dmg);
                    }
                    if (this.Type == 3)
                    {
                        dmg = dmg / 2;
                        this.SetLife(dmg);
                    }
                    if (this.Type == 1)
                    {
                        dmg = 2 * dmg;
                        this.SetLife(dmg);
                    }
                    break;

                case 3:
                    if (this.Type == 3)
                    {                       
                        this.SetLife(dmg);
                    }
                    if (this.Type == 1)
                    {
                        dmg = dmg / 2;
                        this.SetLife(dmg);
                    }
                    if (this.Type == 2)
                    {
                        dmg= 2 * dmg;
                        this.SetLife(dmg);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
