using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teploset.EF.Entities;
using Teploset.EF.Interfaces;

namespace Teploset.EF.Concrete
{
    public class EfTeplosetRepository : ITeplosetRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Post> Posts
        {
            get { return context.Posts; }
        }

        public IEnumerable<News> Newses
        {
            get { return context.Newses; }

        }

        public IEnumerable<Vacancy> Vacancies
        {
            get { return context.Vacancies; }
        }
    }
}
