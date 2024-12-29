using System.Configuration;
using System.Data;
using System.Windows;
using Note.Shell.ViewModels;
using Note.Shell.Views;
using TookKit.Mvvm;
using TookKit.Mvvm.Interfaces;

namespace Note.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : ApplicationBase
    {
        public override void ConfigureModules(IModuleManager moduleManager)
        {
            moduleManager.AddModule<ShellModule>();
        }


        public override Window CreateShell()
        {
            //1.return new ShellView();
            //2.return Container.GetService<ShellView>();

            var view=Container.GetService<ShellView>();
            var vm=Container.GetService<ShellViewModel>();
            //view.DataContext = vm;
            return view;
        }

        public override string SetModuleCatalog(string moduleCatalog = "./Modules")
        {
            return "./";
        }

    }
}
