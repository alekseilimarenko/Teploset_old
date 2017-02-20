using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teploset.Models
{
    public class AboutCatalog
    {
        public Guid AboutId { get; set; }
        public Guid LangTypeId { get; set; }
        public DateTime DateTimeOpen { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public string Body { get; set; }
    }
}