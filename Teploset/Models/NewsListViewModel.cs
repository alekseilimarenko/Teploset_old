using System.Linq;

namespace Teploset.Models
{
    public class NewsListViewModel
    {
        public IQueryable<EF.NewsCatalog> Newses { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}