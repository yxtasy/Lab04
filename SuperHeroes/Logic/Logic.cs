using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Toolkit.Mvvm.Messaging;
using SuperHeroes.Models;
using SuperHeroes.Services;

namespace SuperHeroes.Logic
{
    class Logic : ILogic
    {
        IList<Superhero> superheroes;
        IList<Superhero> fighters;
        IMessenger messenger;
        ISuperheroEditorService editorService;

        public Logic(IMessenger messenger, ISuperheroEditorService editorService)
        {
            this.messenger = messenger;
            this.editorService = editorService;
        }
        public double AVGpwr
        {
            get
            {
                return Math.Round(fighters.Count == 0 ? 0 : fighters.Average(t => t.Strength), 2);
            }
        }
        public double AVGspeed
        {
            get
            {
                return Math.Round(fighters.Count == 0 ? 0 : fighters.Average(t => t.Speed), 2);
            }
        }
        public void SetupCollections(IList<Superhero> superheroes, IList<Superhero> fighters)
        {
            this.superheroes = superheroes;
            this.fighters = fighters;
        }

        public void AddToChoosenOnes(Superhero superhero)
        {
            fighters.Add(superhero.Copy());
            messenger.Send("Superhero added", "SuperheroInfo");
        }
        public void RemoveFromChoosenOnes(Superhero superhero)
        {
            fighters.Remove(superhero);
            messenger.Send("Superhero removed", "SuperheroInfo");
        }
        public void EditSuperheros(Superhero superhero)
        {
            editorService.Edit(superhero);
        }
    }
}
