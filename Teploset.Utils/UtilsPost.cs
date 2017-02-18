using System.Collections.Generic;
using Teploset.EF;
using Teploset.EF.Classes;

namespace Teploset.Utils
{
    public static class UtilsPost
    {
        public static List<PostCatalog> SelectLastPostsListForMainPage(
            TeplosetRepository<PostCatalog> repository,
            int countPost,
            string langType)
        {
            //if (langType == "ru")
            //{
            //    return repository.
            //                Posts.
            //                Where(i => i.LangTypeId == Consts.RuLang)
            //                .Take(countPost)
            //                .OrderByDefault()
            //                .ToList();
            //}
            //return repository.
            //                Posts.
            //                Where(i => i.LangTypeId == Consts.UaLang)
            //                .Take(countPost)
            //                .OrderByDefault()
            //                .ToList();

            return null;
        }
    }
}
