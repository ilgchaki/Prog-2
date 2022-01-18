using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_prueba
{
    class Player //Creamos la clase player que guardar los puntos para comprar
    {
        public Player(int money,string name)
        {
            this.Money = money;
            this.name = name;
        }
        public int Money { get; private set; }
        public string name { get; private set; }
        public void SetMoney(int value)
        {
            Money = Money + value;
        }
        public void offMoney(int value)
        {
            Money = Money - value;
        }
        public void SetName(string value)
        {
            name = value;
        }
    }
}
