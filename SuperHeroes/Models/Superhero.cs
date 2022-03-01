using Microsoft.Toolkit.Mvvm.ComponentModel;
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
    public class Superhero : ObservableObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private int strength;

        public int Strength
        {
            get { return strength; }
            set { SetProperty(ref strength, value); }
        }

        private int speed;

        public int Speed
        {
            get { return speed; }
            set { SetProperty(ref speed, value); }
        }

        private Side side;

        public Side Side
        {
            get { return side; }
            set { SetProperty(ref side, value); }
        }

        public Superhero Copy()
        {
            return new Superhero { Name = this.Name, Strength = this.Strength, Speed = this.Speed, Side = this.Side };
        }

    }
}
