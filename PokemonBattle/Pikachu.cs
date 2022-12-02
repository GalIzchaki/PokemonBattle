using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonBattle
{
    class Pikachu : ElectricPokemon
    {

        public Pikachu(int health) : base(health, Properties.Resources.Pikachu) { }
        public Pikachu() : this(25) { }

        public override Attack attack()
        {
            Random rnd = new Random();
            return new Attack(this, rnd.Next(2,5));
        }
    }
}
