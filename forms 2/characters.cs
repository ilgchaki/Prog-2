using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_2
{
    class character
    {

        public character(string name ="name"  ,int health=10,int dmg=0 )
        {
            this.name = name;
            this.health = health;
            this.dmg = dmg;
        }
        public string name { get; private set;}
        public int health{ get; private set;}
        public int dmg { get; private set; }
        public void Setname( string value)
        {
            name = value;
        }
        public void Sethealth(int value)
        {
            health = value;
        }
    }
    class Player : character
    {
        public Player(string name = "name", int health = 10):base(name,health)
        {
            
        }

    }
    class Enemy : character
    {
        enum state
        {
            Idle,
            Hostile,
            Patrol
        }
        public Enemy(string name = "name", int health = 10) : base(name, health)
        {

        }

        public void StateMachine()
        {

        }
    }

    class Ally : character
    {
        public Ally(string name = "name", int health = 10) : base(name, health)
        {

        }

    }
}
