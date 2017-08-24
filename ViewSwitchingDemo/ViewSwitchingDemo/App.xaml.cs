using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ViewSwitchingDemo.MVVM;

namespace ViewSwitchingDemo
{
    public partial class App : Application
    {
        MyBootstrapper bs = new MyBootstrapper();
        protected override void OnStartup(StartupEventArgs e)
        {
            bs.Run();
        }
    }
}
