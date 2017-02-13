using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teploset.EF.Entities
{
    public class Vacancy
    {
        public Guid VacId { get; set; }
        public string VacancyName { get; set; }
        public string Rank { get; set; }
        public string Comment { get; set; }
    }
}
