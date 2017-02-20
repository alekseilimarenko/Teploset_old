using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using Teploset.EF;
using Teploset.EF.Classes;

namespace Teploset.Utils
{
    public static class UtilsPost
    {
        public static List<PostCatalog> SelectPostsList(
            TeplosetUnitOfWork teplosetUnit,
            int countPost,
            string langType)
        {
            List<PostCatalog> res;

            if (langType == "ru")
            {
                res = countPost != 0 ? teplosetUnit.PostCatalog.Select(Consts.RuLang).OrderByDefault().Take(countPost).ToList() 
                        : teplosetUnit.PostCatalog.Select(Consts.RuLang).OrderByDefault().ToList();
            }
            else
            {
                res = countPost != 0 ? teplosetUnit.PostCatalog.Select(Consts.UaLang).OrderByDefault().Take(countPost).ToList()
                    : teplosetUnit.PostCatalog.Select(Consts.UaLang).OrderByDefault().ToList();
            }

            return res;
        }
    }
}
