using Microsoft.Practices.Prism.MefExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ViewSwitchingDemo.MVVM
{
    public class MyBootstrapper : MefBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.GetExportedValue<ShellWindow>();
        }
        protected override void ConfigureAggregateCatalog()
        {
            var assemblyCatalog = new AssemblyCatalog(typeof(MyBootstrapper).Assembly);
            AggregateCatalog.Catalogs.Add(assemblyCatalog);

            assemblyCatalog = new AssemblyCatalog(typeof(ModulA.ModulAMEF).Assembly);
            AggregateCatalog.Catalogs.Add(assemblyCatalog);

            assemblyCatalog = new AssemblyCatalog(typeof(ModulB.ModulBMEF).Assembly);
            AggregateCatalog.Catalogs.Add(assemblyCatalog);

            base.ConfigureAggregateCatalog();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (ShellWindow)Shell;
            Application.Current.MainWindow.Show();
        }
    }
}
