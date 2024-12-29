using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note.Application.Share.Login;
using System.Windows;
using TookKit.Mvvm.Attributes;

namespace Note.Shell.Services
{
    [DependencyInjection(TookKit.Mvvm.Enums.Lifetime.Singleton,typeof(ISession))]
    class Session : ISession
    {
        public string Title { get; set; } = "笔记信息管理系统";
        public Window MainWindow { get; set; }
    }
}
