using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonBattle
{
    class Attack
    {

        private int damage;
        public int Damage 
        { 
            get { return damage; } 
            set { this.damage = value; }
        }

        private Pokemon attacker;
        public Pokemon Attacker { get { return attacker;  } }


        public Attack(Pokemon attacker, int damage)
        {
            this.damage = damage;
            this.attacker = attacker;
        }
    }
}
