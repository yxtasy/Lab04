using SuperHeroes.Models;
using System.Collections.Generic;

namespace SuperHeroes.Logic
{
    interface ILogic
    {
        double AVGpwr { get; }
        double AVGspeed { get; }

        void AddToChoosenOnes(Superhero superhero);
        void EditSuperheros(Superhero superhero);
        void RemoveFromChoosenOnes(Superhero superhero);
        void SetupCollections(IList<Superhero> superheroes, IList<Superhero> fighters);
    }
}