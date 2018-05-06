using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        [Required]
        public string FeatureImage { set; get; }

        public int? ParentId { set; get; }
        public int? DisplayOrder { set; get; }
        public int? HomeFlag { set; get; }

        public DateTime? CreateDate { set; get; }

        public string CreateBy { set; get; }

        public DateTime? UpdateDate { set; get; }

        public string UpdateBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }
        [Required]
        public bool Status { set; get; }

        public virtual IEnumerable<ProductViewModel> Products { set; get; }
    }
}