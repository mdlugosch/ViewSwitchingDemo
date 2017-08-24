using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using ModulA.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModulA.ViewModels
{
    class ModulAViewModel
    {
        OpenCommand open;
        public OpenCommand Open
        {
            get
            {
                if (open == null)
                {
                    open = new OpenCommand(this);
                }
                return open;
            }
        }

        public ModulAViewModel() { }

        public void ShowModuleWindow()
        {
            // RegionManager initialisieren
            var regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();

            // Is die Region vorhanden?
            if (regionManager.Regions["Workspace"] != null)
            {
                // Stelle Liste mit Views aus der Region zusammen
                List<object> views = new List<object>(regionManager.Regions["Workspace"].Views);

                // Itariere über die Views und entferne alle Views aus der Region
                foreach (object view in views)
                {
                    regionManager.Regions["Workspace"].Remove(view);
                }

                // Füge neue View der Region hinzu
                regionManager.RegisterViewWithRegion("Workspace", typeof(ModulA.Views.ModulAView));
            }
        }
    }
}
