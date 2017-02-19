using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teploset.EF;

namespace Teploset.EF.Tests
{
    [TestClass]
    public class BaseTest
    {
        protected TeplosetUnitOfWork unit;
        protected Entities Db;

        [TestInitialize]
        public void Initialize()
        {
            const bool isLocal = true;
            //unit = new TeplosetUnitOfWork(Db);
        }
    }
}
