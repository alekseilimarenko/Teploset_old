using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Teploset.Controllers;

namespace Teploset.EF.Tests
{
    [TestClass]
    public class RepPostCatalogTest : BaseTest
    {
        [TestMethod]
        public void CanSelectPost()
        {
            using (var transAction = teplosetUnit.Db.Database.BeginTransaction())
            {
                var post = teplosetUnit.PostCatalog.Select(new Guid("e409af66-0169-4f26-af48-54af19bcaa53")).FirstOrDefault();

                Assert.AreEqual(new Guid("e409af66-0169-4f26-af48-54af19bcaa53"), post.LangTypeId);

                transAction.Rollback();
            }
        }

        [TestMethod]
        public void CanPaginate()
        {
            using (var trans = teplosetUnit.Db.Database.BeginTransaction())
            {
                var listPosts = teplosetUnit
                    .PostCatalog
                    .Select(new Guid("e409af66-0169-4f26-af48-54af19bcaa53"))
                    .ToList();

                PostController controller = new PostController(teplosetUnit);

                IEnumerable<PostCatalog> res =
                    (IEnumerable<PostCatalog>)controller.Index("ua", 2).Model;

                List<PostCatalog> posts = res.ToList();
                //Assert.IsTrue(posts.Count == 2);
                Assert.AreEqual(posts[0].LangTypeId, new Guid("e409af66-0169-4f26-af48-54af19bcaa53"));

                trans.Rollback();
            }
        }
    }
}
