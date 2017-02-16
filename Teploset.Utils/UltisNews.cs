using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teploset.EF;
using Teploset.EF.Classes;
using Teploset.EF.Entities;
using Teploset.EF.Interfaces;

namespace Teploset.Utils
{
    public static class UltisNews
    {
        public static List<News> SelectLastNewsListForMainPage(
            ITeplosetRepository repository,
            int countNews, 
            string langType)
        {
            if (langType == "ru")
            {
               return repository.
                        Newses.
                        Where(i=>i.LangTypeId == Consts.ruLang).
                        Take(countNews).
                        OrderByDefault().
                        ToList();
            }
            return repository.
                        Newses.
                        Where(i => i.LangTypeId == Consts.uaLang).
                        Take(countNews).
                        OrderByDefault().
                        ToList();
        }
    }
}
