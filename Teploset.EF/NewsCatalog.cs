//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teploset.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewsCatalog
    {
        public System.Guid NewsId { get; set; }
        public System.Guid LangTypeId { get; set; }
        public System.DateTime DateTimeOpen { get; set; }
        public System.DateTime DateTimeCreate { get; set; }
        public string NewsTitle { get; set; }
        public string NewsBody { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    
        public virtual LangCatalog LangCatalog { get; set; }
    }
}
