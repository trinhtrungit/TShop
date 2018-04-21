using System;
using System.Collections.Generic;

namespace TShop.Web.Models
{
    public class ProductViewModel
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

        public string Image { set; get; }

        public string MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? Promotion { set; get; }
        public int? Quantity { set; get; }
        public int? Varranty { set; get; }
        public string ProductContent { set; get; }
        public string Description { set; get; }
        public int CategoryId { set; get; }
        public bool? HotFlag { set; get; }
        public bool? HomeFlag { set; get; }
        public int? ViewCount { set; get; }

        public DateTime? CreateDate { set; get; }

        public string CreateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        public string UpdateBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { set; get; }

        public virtual ProductCategoryViewModel ProductCategory { set; get; }

        public virtual IEnumerable<DetailOrderViewModel> DetailOrders { set; get; }
        public virtual IEnumerable<ProductTagViewModel> ProductTags { set; get; }
    }
}