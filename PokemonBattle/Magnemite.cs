using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonBattle
{
    class Magnemite : ElectricPokemon
    {
        public Magnemite(int health) : base(health, Properties.Resources.Magnemite) { }
        public Magnemite() : this(22) { }


        public override Attack attack()
        {
            Random rnd = new Random();
            return new Attack(this, rnd.Next(1, 3));
        }
    }
}
