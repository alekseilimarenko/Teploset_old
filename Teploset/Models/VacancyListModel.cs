using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teploset.Models
{
    public class VacancyListModel
    {
        public IQueryable<EF.VacancyCatalog> Vacancies { get; set; }
    }
}