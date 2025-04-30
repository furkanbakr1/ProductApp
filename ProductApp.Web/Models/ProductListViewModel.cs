using System.Collections.Generic;

namespace ProductApp.Web.Models
{
    public class ProductListViewModel
    {
        public List<ProductDto>? Products { get; set; }
        public PaginationInfo? PageInfo { get; set; }
    }
}
