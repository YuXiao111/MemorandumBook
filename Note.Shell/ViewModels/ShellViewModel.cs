using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Note.Application.Share.Login;
using TookKit.Mvvm.Attributes;
using TookKit.Mvvm.Bindings;

namespace Note.Shell.ViewModels
{
    [DependencyInjection(TookKit.Mvvm.Enums.Lifetime.Singleton)]
    class ShellViewModel
    {
        private ContentControl container = null;
        public ICommand ContentControlLoadedCommand { get; }
        public ISession Session { get;  }

        public ShellViewModel(ISession session)
        {
            Session = session;
            ContentControlLoadedCommand = new RelayCommand<ContentControl>(OnContentControlLoadedCommand);
        }

        private void OnContentControlLoadedCommand(ContentControl obj)
        {
            this.container = obj;
            this.container.Content = TookKit.Mvvm.Container.Default.GetService("LoginView");
        }
    }
}
