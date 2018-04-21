using System.Collections.Generic;

namespace TShop.Web.Models
{
    public class TagViewModel
    {
        public string Id { set; get; }

        public string TagName { set; get; }
        public string TagType { set; get; }

        public virtual IEnumerable<ProductTagViewModel> ProductTags { set; get; }
        public virtual IEnumerable<PostTagViewModel> PostTags { set; get; }
    }
}