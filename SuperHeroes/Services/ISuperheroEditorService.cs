using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHeroes.Models;

namespace SuperHeroes.Services
{
    interface ISuperheroEditorService
    {
        void Edit(Superhero superhero);
    }
}
