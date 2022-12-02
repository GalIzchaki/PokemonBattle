using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace PokemonBattle
{
    [Serializable]
    class PokemonSerializationString
    {
        public int Health { get; set; }
        public string Type { get; set; }

        public PokemonSerializationString() { }

        public PokemonSerializationString(Pokemon pokemnon)
        {
            this.Health = pokemnon.Health;
            this.Type = pokemnon.GetType().FullName;
        }

        public Pokemon deserialize()
        {
            Pokemon p = (Pokemon) Assembly.GetExecutingAssembly().CreateInstance(this.Type);
            p.Health = this.Health;
            return p;
        }
    }
}
