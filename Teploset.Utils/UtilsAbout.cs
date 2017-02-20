using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teploset.EF;
using Teploset.EF.Classes;

namespace Teploset.Utils
{
    public static class UtilsAbout
    {
        public static AboutCatalog GetAbout(TeplosetUnitOfWork teplosetUnit, string langType)
        {
            return (langType == "ua" ? teplosetUnit.AboutCatalog.Select(Consts.UaLang)
                                     : teplosetUnit.AboutCatalog.Select(Consts.RuLang)).First();
        }
    }
}
