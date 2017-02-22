using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teploset.EF.Tests
{
    [TestClass]
    public class RepVacancyCatalogTest : BaseTest
    {
        [TestMethod]
        public void CanSelectVacancyFromDb()
        {
            using (var trans = teplosetUnit.Db.Database.BeginTransaction())
            {
                var vacancy =
                    teplosetUnit.VacancyCatalog.Select(new Guid("e409af66-0169-4f26-af48-54af19bcaa53"))
                        .FirstOrDefault();

                Assert.AreEqual(new Guid("e409af66-0169-4f26-af48-54af19bcaa53"), vacancy.LangTypeId);

                trans.Rollback();
            }
        }
    }
}
