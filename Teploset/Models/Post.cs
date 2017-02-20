using System;

namespace Teploset.Models
{
    public class Post
    {
        public Guid PostId { get; set; }
        public Guid LangTypeId { get; set; }
        public DateTime DateTimeOpen { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }

    }
}
