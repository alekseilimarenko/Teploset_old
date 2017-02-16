using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teploset.EF.Entities;

namespace Teploset.EF.Interfaces
{
    public interface ITeplosetRepository
    {
        IEnumerable<Post> Posts { get; }

        IEnumerable<News> Newses { get; }

        IEnumerable<Vacancy> Vacancies { get; }
    }
}
