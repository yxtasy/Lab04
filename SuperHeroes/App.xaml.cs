using Microsoft.Toolkit.Mvvm.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SuperHeroes.Logic;
using SuperHeroes.Services;
using Microsoft.Toolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;

namespace SuperHeroes
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            Ioc.Default.ConfigureServices(
             new ServiceCollection()
                 .AddSingleton<ILogic, Logic.Logic>()                 
                 .BuildServiceProvider()
             );
        }

            //.AddSingleton<IMessenger>(WeakReferenceMessenger.Default)
        //.AddSingleton<ISuperheroEditorService, TrooperEditorViaWindow>()
    }
}
