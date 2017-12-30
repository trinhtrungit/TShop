using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string TagId { set; get; }

        [Key]
        public int PostId { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }

        [ForeignKey("PostId")]
        public virtual Post Post { set; get; }
    }
}