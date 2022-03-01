using Microsoft.Toolkit.Mvvm.ComponentModel;
using SuperHeroes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes.ViewModels
{
    class MainViewModel : ObservableRecipient
    {
        public ObservableCollection<Superhero> AllHeroes;
        public ObservableCollection<Superhero> ChoosenOnes;

        public MainViewModel()
        {
            AllHeroes = new ObservableCollection<Superhero>();
            ChoosenOnes = new ObservableCollection<Superhero>();
            AllHeroes.Add(new Superhero {Name="AAA", Strength=100, Speed=50, Side=Side.Evil });
            AllHeroes.Add(new Superhero { Name = "BBB", Strength = 50, Speed = 75, Side = Side.Good });
            AllHeroes.Add(new Superhero { Name = "CCC", Strength = 66, Speed = 65, Side = Side.Natural });
            AllHeroes.Add(new Superhero { Name = "DDD", Strength = 35, Speed = 48, Side = Side.Evil });

            ChoosenOnes.Add(AllHeroes[1].Copy());
        }


    }
}
