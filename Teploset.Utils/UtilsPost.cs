using System;
using System.Collections.Generic;
using System.Linq;
using Teploset.EF;
using Teploset.EF.Entities;
using Teploset.EF.Interfaces;

namespace Teploset.Utils
{
    public class UtilsPost
    {
        public static List<Post> SelectLastPostsListForMainPage(
            ITeplosetRepository repository,
            int countPost)
        {
            var res = repository.Posts.OrderByDefault().Take(countPost).ToList();
            return res;
        }
    }
}
