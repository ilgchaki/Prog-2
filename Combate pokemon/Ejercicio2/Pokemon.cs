using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Pokemon //Esta es la clase Padre pokemons 
    {
        public  Pokemon( string name, int life)
        {
            this.name = name;
            this.life = life;
        }
        public string name { get; private set; }
        public int life { get; private set; }
        public Ataques atack1 { get; private set; }
        public Ataques atack2 { get; private set; }                             //Tine sus gets  en publico y set en privado 
        public Ataques atack3 { get; private set; }
        public Ataques atack4 { get; private set; }

        public void SetLife(int value) 
        {
            life = value;
        }
        public  virtual int Getdamage(Ataques atack,int value=1) //Funcion para calcular el daño echo
        {
            return atack.dmg;
        }
        public void Setatack1(Ataques value)
        {
            atack1 = value;
        }
        public void Setatack2(Ataques value)
        {
            atack2 = value;
        }
        public void Setatack3(Ataques value)                    //Funciones para añadir los ataques a cada pokemon
        {
            atack3 = value;
        }
        public void Setatack4(Ataques value)
        {
            atack4 = value;
        }
        public void ReceiveDamage(int damage)//Funcion para calcular el daño recibido
        {
            life -= damage;
        }
    }
    class Aliado : Pokemon //Clase aliado hija de pokemon
    {
        public Aliado(string name, int life, int defensa = 1, int Ataque = 1):base( name,life)
        {

        }
        public int Ataque { get; private set; }
        public void SetAtaque(int value)
        {
            Ataque = value;
        }
        public int defensa { get; private set; }
        public void Setdefensa(int value)
        {
            if(defensa<10) defensa = value;
        }
        public override int Getdamage(Ataques atack,int value) //Hago un override del metodo Getdmage para aplicar el ataque y 
        {
            return (atack.dmg+Ataque)*value;                    //las debilidades del pokemon aliado
        }
    }
    class Enemigo : Pokemon //Clase enemigo hija de pokemon
    {
        public string tipo { get; private set; }
        public Enemigo(string name, int life, string tipo) : base(name, life)
        {
            this.tipo=tipo;
        }
    }
}
