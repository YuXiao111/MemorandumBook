using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Note.Application.Share.Login
{
    /// <summary>
    /// 会话缓存接口
    /// </summary>
    public interface ISession
    {
        string Title { get; set; }
        Window MainWindow { get; set; }

    }
}
