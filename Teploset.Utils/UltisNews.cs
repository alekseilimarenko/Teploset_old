using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teploset.EF;
using Teploset.EF.Entities;
using Teploset.EF.Interfaces;

namespace Teploset.Utils
{
    public static class UltisNews
    {
        public static List<News> SelectLastNewsListForMainPage(
            ITeplosetRepository repository,
            int countNews)
        {
            var res = repository.Newses.OrderByDefault().Take(countNews).ToList();
            return res;
        }
    }
}
