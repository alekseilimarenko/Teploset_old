using System;
using System.Collections.Generic;
using System.Data.Entity;
using Teploset.EF.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teploset.EF.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<News> Newses { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }

    }
}
