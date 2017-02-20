using System;

namespace Teploset.Models
{
    public class Vacancy
    {
        public Guid VacId { get; set; }

        public Guid LangTypeId { get; set; }

        public DateTime DateTimeCreate { get; set; }

        public string VacancyName { get; set; }

        public string Rank { get; set; }

        public string Comment { get; set; }
    }
}
