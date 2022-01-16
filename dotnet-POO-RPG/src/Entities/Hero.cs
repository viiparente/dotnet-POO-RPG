using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_POO_RPG.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;

        public Hero()
        {

        }

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a sua espada.";
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
    }
}
