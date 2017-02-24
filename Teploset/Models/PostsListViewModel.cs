using System.Linq;

namespace Teploset.Models
{
    public class PostsListViewModel
    {
        public IQueryable<EF.PostCatalog> Posts { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}