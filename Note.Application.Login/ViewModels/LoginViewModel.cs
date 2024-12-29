using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TookKit.Mvvm.Attributes;
using TookKit.Mvvm.Bindings;

namespace Note.Application.Login.ViewModels
{
    [DependencyInjection(TookKit.Mvvm.Enums.Lifetime.Transient)]
    class LoginViewModel:ObservableObject
    {

    }
}
