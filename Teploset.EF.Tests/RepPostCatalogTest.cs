using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Teploset.EF.Classes;

namespace Teploset.EF.Tests
{
    [TestClass]
    public class RepPostCatalogTest
    {
        //private List<PostCatalog> Posts()
        //{
        //    Mock < TeplosetUnitOfWork > mock = new Mock<TeplosetUnitOfWork>();

        //    return mock.Setup(m => m.PostCatalog).Returns(new List<PostCatalog>
        //    {
        //        new PostCatalog{PostId = "", PostTitle = "Сообщение 1"}
        //    });
        //}

        [TestMethod]
        public void SelectPostFromDbTest()
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
