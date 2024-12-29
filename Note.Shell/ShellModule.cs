using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note.Application.Share.Login;
using Note.Shell.Services;
using Note.Shell.ViewModels;
using Note.Shell.Views;
using TookKit.Mvvm.Interfaces;

namespace Note.Shell
{
    public class ShellModule : IModule
    {
        public void RegisterTypes(IContainer container)
        {
            //container.Register<ShellView>();
            //container.Register<ShellViewModel>();

            //container.Register<ISession,Session>();
        }
    }
}
