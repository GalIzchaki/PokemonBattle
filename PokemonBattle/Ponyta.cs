using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonBattle
{
    class Ponyta : FirePokemon
    {
        public Ponyta(int health) : base(health, Properties.Resources.Ponyta) { }
        public Ponyta() : this(20) { }

        public override Attack attack()
        {
            Random rnd = new Random();
            return new Attack(this, rnd.Next(3, 5));
        }
    
    }
}
