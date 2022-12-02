using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonBattle
{
    abstract class WaterPokemon : Pokemon
    {
        public WaterPokemon(int health, System.Drawing.Bitmap image) : base(health, image) { }

        public override void defend(Attack attack)
        {
            if (attack.Attacker is ElectricPokemon)
                attack.Damage *= 2;
            if (attack.Attacker is FirePokemon)
                attack.Damage /= 2;

            base.defend(attack);
        }
    }
}
