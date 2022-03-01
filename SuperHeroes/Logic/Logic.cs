﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using SuperHeroes.Models;
using SuperHeroes.Services;

namespace SuperHeroes.Logic
{
    class Logic
    {
        IList<Superhero> superheroes;
        IList<Superhero> fighters;
        IMessenger messenger;
        ISuperheroEditorService editorService;

        public Logic(IMessenger messenger,ISuperheroEditorService editorService)
        {
            this.messenger = messenger;
            this.editorService = editorService;
        }
        public double AVGpwr {
            get
             {
                return Math.Round(fighters.Count == 0 ? 0 : fighters.Average(t => t.Strength),2);
             } 
            }
        public double AVGspeed
        {
            get
            {
                return Math.Round(fighters.Count == 0 ? 0 : fighters.Average(t => t.Speed), 2);
            }
        }
        public void SetupCollections(IList<Superhero> superheroes,IList<Superhero> fighters)
        {
            this.superheroes = superheroes;
            this.fighters = fighters;
        }

        public void AddToArmy(Superhero superhero)
        {
            fighters.Add(superhero.Copy());
            messenger.Send("Superhero added", "SuperheroInfo");
        }
        public void RemoveFromArmy(Superhero superhero)
        {
            fighters.Remove(superhero);
            messenger.Send("Superhero removed", "SuperheroInfo");
        }
        public void EditSuperhero(Superhero superhero)
        {
            editorService.Edit(superhero);
        }
    }
}
