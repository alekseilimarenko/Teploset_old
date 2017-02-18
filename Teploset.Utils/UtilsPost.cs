using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Teploset.EF;
using Teploset.EF.Classes;
using Teploset.EF.Entities;
using Teploset.EF.Interfaces;

namespace Teploset.Utils
{
    public static class UtilsPost
    {
        public static List<Post> SelectLastPostsListForMainPage(
            ITeplosetRepository repository,
            int countPost,
            string langType)
        {
            if (langType == "ru")
            {
                return repository.
                            Posts.
                            Where(i => i.LangTypeId == Consts.RuLang)
                            .Take(countPost)
                            .OrderByDefault()
                            .ToList();
            }
            return repository.
                            Posts.
                            Where(i => i.LangTypeId == Consts.UaLang)
                            .Take(countPost)
                            .OrderByDefault()
                            .ToList();
        }
    }
}
