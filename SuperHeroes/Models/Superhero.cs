using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes.Models
{
    public enum Side
    {
        Good,
        Evil,
        Natural
    }
    class Superhero
    {
        private int name;

        public int Name
        {
            get { return name; }
            set { name = value; }
        }

        private int strength;

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private Side side;

        public Side Side
        {
            get { return side; }
            set { side = value; }
        }

        public Superhero Copy()
        {
            return new Superhero { Name = this.Name, Strength = this.Strength, Speed = this.Speed, Side = this.Side };
        }

    }
}
