using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Id { set; get; }

        public string TagName { set; get; }
        public string TagType { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}