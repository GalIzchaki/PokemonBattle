using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonBattle
{
    abstract class FirePokemon : Pokemon
    {
        public FirePokemon(int health, System.Drawing.Bitmap image) : base(health, image) { }

        public override void defend(Attack attack)
        {
            if (attack.Attacker is WaterPokemon)
                attack.Damage *= 2;

            base.defend(attack);
        }

    }
}
