using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
                var listPosts = teplosetUnit.PostCatalog.Select(new Guid("e409af66-0169-4f26-af48-54af19bcaa53")).ToList();

                Assert.IsNotNull(listPosts);

                transAction.Rollback();
            }
        }

        [TestMethod]
        public void CanPaginate()
        {
           //var listPosts = _repository
           //             .PostCatalog
           //             .Select(Consts.UaLang)
           //             .OrderByDefault()
           //             .ToList();

           // Assert.IsNotNull(listPosts);
        }
    }
}
