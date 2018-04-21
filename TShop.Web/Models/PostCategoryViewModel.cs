using System;
using System.Collections.Generic;

namespace TShop.Web.Models
{
    public class PostCategoryViewModel
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string Alias { set; get; }

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

        public bool Status { set; get; }

        public virtual IEnumerable<PostViewModel> Posts { set; get; }
    }
}