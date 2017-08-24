using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulB
{
    [ModuleExport(typeof(ModulBMEF),
        InitializationMode = InitializationMode.WhenAvailable)]
    public class ModulBMEF : IModule
    {
        private readonly IRegionViewRegistry regionViewRegestry;

        [ImportingConstructor]
        public ModulBMEF(IRegionViewRegistry registry)
        {
            regionViewRegestry = registry;
        }

        public void Initialize()
        {
            regionViewRegestry.RegisterViewWithRegion("Sidemenu", typeof(ModulB.ModuleBTestButton));
        }
    }
}
