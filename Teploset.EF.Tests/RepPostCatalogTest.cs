using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teploset.Classes;
using Teploset.Controllers;
using Teploset.Models;

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
        public void CanPaginate_And_Send_Pagination_View_Model()
        {
            using (var trans = teplosetUnit.Db.Database.BeginTransaction())
            {
                PostController controller = new PostController(teplosetUnit);

                PostsListViewModel result = (PostsListViewModel) controller.Index("ua", 2).Model;

                PagingInfo pageInfo = result.PagingInfo;

                List<PostCatalog> posts = result.Posts.ToList();

                Assert.AreEqual(pageInfo.CurrentPage, 2);
                Assert.AreEqual(pageInfo.ItemsPerPage, 3);
                Assert.AreEqual(pageInfo.TotalItems, 5);
                Assert.AreEqual(pageInfo.TotalPages, 2);

                Assert.IsTrue(posts.Count == 2);
                Assert.AreEqual(posts[0].LangTypeId, new Guid("e409af66-0169-4f26-af48-54af19bcaa53"));

                trans.Rollback();
            }
        }

        [TestMethod]
        public void Can_Genarate_Page_Links()
        {
            HtmlHelper myHelper = null;

            PagingInfo pagingInfo = new PagingInfo
            {
                CurrentPage = 2,
                TotalItems = 28,
                ItemsPerPage = 10
            };

            Func<int, string> pageUrlDelegate = i => "Page" + i;

            MvcHtmlString result = myHelper.PageLinks(pagingInfo, pageUrlDelegate);

            Assert.AreEqual(@"<a class=""btn btn-default"" href=""Page1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Page2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Page3"">3</a>", result.ToString());
        }
    }
}