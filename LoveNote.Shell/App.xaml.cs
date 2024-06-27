using LoveNote.Shell.ViewModels;
using LoveNote.Shell.Views;
using System.Configuration;
using System.Data;
using System.Windows;
using TookKit.Mvvm;
using TookKit.Mvvm.Interfaces;

namespace LoveNote.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : ApplicationBase
    {
        public override Window CreateShell()
        {
            //return Container.GetService<ShellView>();

            //var view = Container.GetService<ShellView>();
            //var vm = Container.GetService<ShellViewModel>();
            //view.DataContext = vm;
            //return view;

            return Container.GetService<ShellView>();
        }

        public override void ConfigureModules(IModuleManager moduleManager)
        {
            base.ConfigureModules(moduleManager);

            moduleManager.AddModule<ShellModule>();
        }
    }
}