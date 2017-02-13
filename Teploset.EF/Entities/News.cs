using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teploset.EF.Entities
{
    public class News
    {
        public Guid NewsId { get; set; }
        public Guid LangTypeId { get; set; }
        public DateTime DateTimeOpen { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public string NewsTitle { get; set; }
        public string NewsBody { get; set; }
        public string File1 { get; set; }

        public string File2 { get; set; }
    }
}
