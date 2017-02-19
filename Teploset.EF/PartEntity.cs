using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teploset.EF
{
    public partial class Entities : DbContext
    {
        public Entities(string connString) : base(connString)
        {
            
        }

        public Entities(DbConnection conn, bool contextOwnsConnection) : base(conn, contextOwnsConnection)
        {
            
        }
    }
}
