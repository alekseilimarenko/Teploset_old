using System.Collections.Generic;
using Teploset.EF;
using Teploset.EF.Classes;

namespace Teploset.Utils
{
    public static class UltisNews
    {
        public static List<NewsCatalog> SelectLastNewsListForMainPage(
            TeplosetUnitOfWork repository,
            int countNews, 
            string langType)
        {
            /*if (langType == "ru")
            {
               return repository.
                        Newses.
                        Where(i=>i.LangTypeId == Consts.RuLang).
                        Take(countNews).
                        OrderByDefault().
                        ToList();
            }
            return repository.
                        Newses.
                        Where(i => i.LangTypeId == Consts.UaLang).
                        Take(countNews).
                        OrderByDefault().
                        ToList();
                        */
            return null;
        }
    }
}
