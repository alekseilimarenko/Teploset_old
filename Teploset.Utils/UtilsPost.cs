using System.Collections.Generic;
using System.Linq;
using Teploset.EF;
using Teploset.EF.Classes;

namespace Teploset.Utils
{
    public static class UtilsPost
    {
        public static List<PostCatalog> SelectLastPostsListForMainPage(
            TeplosetUnitOfWork teplosetUnit,
            int countPost,
            string langType)
        {
            if (langType == "ru")
            {
                return teplosetUnit
                        .PostCatalog
                        .Select(Consts.RuLang)
                        .OrderByDefault()
                        .Take(countPost)
                        .ToList();
            }
            return teplosetUnit
                        .PostCatalog
                        .Select(Consts.UaLang)
                        .OrderByDefault()
                        .Take(countPost)
                        .ToList();
        }
    }
}
