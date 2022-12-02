using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonBattle
{
    class Squirtle : WaterPokemon
    {
        public Squirtle(int health) : base(health, Properties.Resources.Squirtle1) { }
        public Squirtle() : this(17) { }


        public override Attack attack()
        {
            Random rnd = new Random();
            return new Attack(this, rnd.Next(1, 4));
        }
    }
}
