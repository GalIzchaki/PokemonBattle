using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace PokemonBattle
{
    [Serializable]
    class PokemonGameSerializationString
    {
        public int CurrentTurn { get; set; }
        public PokemonSerializationString[] pokemons { get; set; }

        public PokemonGameSerializationString() : this(0,null) { }

        public PokemonGameSerializationString(int currentTurn, ArrayList pokemons)
        {
            this.CurrentTurn = currentTurn;
            if (pokemons != null)
            {
                this.pokemons = new PokemonSerializationString[pokemons.Count];
                for (int i = 0; i < pokemons.Count; i++)
                {
                    this.pokemons[i] = new PokemonSerializationString((Pokemon)pokemons[i]);
                }
            }
        }
    }
}
