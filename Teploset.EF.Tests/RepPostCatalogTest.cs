using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teploset.EF.Classes;

namespace Teploset.EF.Tests
{
    [TestClass]
    public class RepPostCatalogTest : BaseTest
    {
        [TestMethod]
        public void SelectPostFromDbTest()
        {
            using (var transaction = unit.Db.Database.BeginTransaction())
            {
                var posts = unit.PostCatalog.Select(new Guid(Consts.UaLang.ToString()));

                Assert.IsNotNull(posts);

                transaction.Rollback();
            }
        }
    }
}
