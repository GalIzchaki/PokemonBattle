using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonBattle
{
    class Psyduck : WaterPokemon
    {
        
        public Psyduck(int health) : base(health, Properties.Resources.Psyduck) { }
        public Psyduck() : this(26) { }


        public override Attack attack()
        {
            Random rnd = new Random();
            return new Attack(this, rnd.Next(1, 6));
        }
    }
}
