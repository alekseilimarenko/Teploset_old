using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teploset.EF.Tests
{
    [TestClass]
    public class BaseTest
    {
        protected TeplosetUnitOfWork Unit;
        protected Entities Db;

        public BaseTest(TeplosetUnitOfWork repo)
        {
            Unit = repo;
        }

        [TestInitialize]
        public void Initialize()
        {
            const bool isLocal = true;
            //var p = UtilsConnection.GetDefaultEntitiesMssqlConnectionParams();
            //Entities Db = UtilsConnection.GetInternalEntities(p);
            Unit = new TeplosetUnitOfWork(Db);
        }
    }
}
