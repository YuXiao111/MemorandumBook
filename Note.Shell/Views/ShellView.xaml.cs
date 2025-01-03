﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using TookKit.Mvvm.Attributes;

namespace Note.Shell.Views
{
    /// <summary>
    /// ShellView.xaml 的交互逻辑
    /// </summary>
    [DependencyInjection(TookKit.Mvvm.Enums.Lifetime.Singleton)]
    [View]
    public partial class ShellView : MetroWindow
    {
        public ShellView()
        {
            InitializeComponent();
        }
    }
}
