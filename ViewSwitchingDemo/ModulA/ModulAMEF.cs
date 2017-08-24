using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulA
{
    [ModuleExport(typeof(ModulAMEF),
        InitializationMode = InitializationMode.WhenAvailable)]
    public class ModulAMEF : IModule
    {
        private readonly IRegionViewRegistry regionViewRegestry;

        [ImportingConstructor]
        public ModulAMEF(IRegionViewRegistry registry)
        {
            regionViewRegestry = registry;
        }

        public void Initialize()
        {
            regionViewRegestry.RegisterViewWithRegion("Sidemenu", typeof(ModulA.ModuleATestButton));
        }
    }
}
