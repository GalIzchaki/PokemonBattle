using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonBattle
{
    class Charmander : FirePokemon
    {
        public Charmander(int health) : base(health, Properties.Resources.Charmander) { }
        public Charmander() : this(26) { }

        public override Attack attack()
        {
            Random rnd = new Random();
            return new Attack(this, rnd.Next(2, 4));
        }
    }
}
