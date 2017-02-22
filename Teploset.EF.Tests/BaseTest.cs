using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teploset.EF.Tests
{
    [TestClass]
    public class BaseTest
    {
        protected TeplosetUnitOfWork teplosetUnit;
        protected Entities Db;

        [TestInitialize]
        public void Initialize()
        {
            const bool isLocal = true;
            var p = UtilsConnection.GetDefaultEntitiesMssqlConnectionParams();
            Entities Db = UtilsConnection.GetInternalEntities(p);
            teplosetUnit = new TeplosetUnitOfWork(Db);
        }
    }
}
