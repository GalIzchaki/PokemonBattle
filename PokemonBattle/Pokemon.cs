using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PokemonBattle
{
    abstract class Pokemon
    {
        
        public int Health { get; set; } 
        public bool Alive { get { return Health > 0; } }
        public Bitmap Image { get; set; }

        public Pokemon(int health, Bitmap image)
        {
            this.Health = health;
            this.Image = image;
        }

        public Pokemon(int health) : this(health, null) { }

        public abstract Attack attack();

        public virtual void defend(Attack attack)
        {
            if (attack.Damage > this.Health)
                this.Health = 0;
            else
                this.Health -= attack.Damage;
        }

    }
}
