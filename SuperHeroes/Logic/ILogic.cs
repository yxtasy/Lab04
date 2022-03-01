using SuperHeroes.Models;
using System.Collections.Generic;

namespace SuperHeroes.Logic
{
    interface ILogic
    {
        double AVGpwr { get; }
        double AVGspeed { get; }

        void AddToArmy(Superhero superhero);
        void EditSuperhero(Superhero superhero);
        void RemoveFromArmy(Superhero superhero);
        void SetupCollections(IList<Superhero> superheroes, IList<Superhero> fighters);
    }
}