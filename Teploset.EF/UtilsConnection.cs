using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using devuaUtilsMsSql.Objects;

namespace Teploset.EF
{
    public class UtilsConnection
    {
        /*
        private static string ConnectionString
        {
            get
            {
                return
                    "Data Source=1; InegratedSecurity=true;Initial Catalog=1;";
            }
        }

        public static Entities GetInternalEntities(ObjectMssqlConnectionParams connParams)
        {
            var conn = CreateEntityConnection(ConnectionString, connParams);
            var res = new Entities(conn, true);
            return res;
        }

        private static EntityConnection CreateEntityConnection(string connectionString, ObjectMssqlConnectionParams connParams)
        {
            var sqlBuider = new SqlConnectionStringBuilder
            {
                ConnectionString = connectionString,
                DataSource = connParams.Server,
                InitialCatalog = connParams.DataBase,
                IntegratedSecurity = true,
                MultipleActiveResultSets = true
            };


            var entityBuilder = new EntityConnectionStringBuilder
            {
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = sqlBuider.ToString(),
                Metadata = @"res://Entity.csdl|res://Entity.ssdl|res://Entity.msl"
            };


            return new EntityConnection(entityBuilder.ToString());
        }

        public static ObjectMssqlConnectionParams GetDefaultEntitiesMssqlConnectionParams()
        {
            var p = new ObjectMssqlConnectionParams()
            {
                DataBase = "Teploset",
                Server = "VOYAGER"
            };

            return p;
        }*/
    }
}
