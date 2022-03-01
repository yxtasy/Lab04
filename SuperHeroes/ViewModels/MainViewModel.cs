using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using Microsoft.Toolkit.Mvvm.Input;
using SuperHeroes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SuperHeroes.ViewModels
{
    class MainViewModel : ObservableRecipient
    {
        public ObservableCollection<Superhero> AllHeroes;
        public ObservableCollection<Superhero> ChoosenOnes;

        public MainViewModel() : this(IsInDesignMode ? null : Ioc.Default.GetService<IArmyLogic>())
        {

        }
        public MainViewModel()
        {
            AllHeroes = new ObservableCollection<Superhero>();
            ChoosenOnes = new ObservableCollection<Superhero>();
            AllHeroes.Add(new Superhero {Name="AAA", Strength=100, Speed=50, Side=Side.Evil });
            AllHeroes.Add(new Superhero { Name = "BBB", Strength = 50, Speed = 75, Side = Side.Good });
            AllHeroes.Add(new Superhero { Name = "CCC", Strength = 66, Speed = 65, Side = Side.Natural });
            AllHeroes.Add(new Superhero { Name = "DDD", Strength = 35, Speed = 48, Side = Side.Evil });

            ChoosenOnes.Add(AllHeroes[1].Copy());

            // setup logic collections here

            AddToChoosenOnes = new RelayCommand(
                () => logic.AddToChoosenOnes(SelectedFromAllHeroes),
                () => SelectedFromAllHeroes != null
                );

            RemoveFromChoosenOnes = new RelayCommand(
                () => logic.RemoveFromChoosenOnes(SelectedFromAllHeroes),
                () => SelectedFromChoosenOne != null
                );

            EditAllHeroes = new RelayCommand(
                () => logic.EditAllHeroes(SelectedFromAllHeroes),
                () => SelectedFromAllHeroes != null
                );

        }

        public ICommand AddToChoosenOnes { get; set; }
        public ICommand RemoveFromChoosenOnes { get; set; }
        public ICommand EditAllHeroes { get; set; }

        private Superhero selectedFromAllHeroes;

        public Superhero SelectedFromAllHeroes
        {
            get { return selectedFromAllHeroes; }
            set {
                SetProperty(ref selectedFromAllHeroes, value);
                (AddToChoosenOnes as RelayCommand).NotifyCanExecuteChanged();
                (EditAllHeroes as RelayCommand).NotifyCanExecuteChanged();
            }
        }

        private Superhero selectedFromChoosenOnes;

        public Superhero SelectedFromChoosenOne
        {
            get { return selectedFromAllHeroes; }
            set
            {
                SetProperty(ref selectedFromAllHeroes, value);
                (AddToChoosenOnes as RelayCommand).NotifyCanExecuteChanged();
                (EditAllHeroes as RelayCommand).NotifyCanExecuteChanged();
            }
        }


        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }
    }
}
