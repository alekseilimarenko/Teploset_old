using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teploset.EF.Tests
{
    [TestClass]
    public class BaseTest
    {
        protected TeplosetUnitOfWork unit;
        //protected Entities Db;

        [TestInitialize]
        public void Initialize()
        {
            const bool isLocal = true;
            var p = UtilsConnection.GetDefaultEntitiesMssqlConnectionParams();
            //Entities Db = UtilsConnection.GetInternalEntities(p);
            //unit = new TeplosetUnitOfWork(Db);
        }
    }
}
