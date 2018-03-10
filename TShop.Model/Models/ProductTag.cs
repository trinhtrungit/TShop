using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(TypeName = "varchar", Order = 1)]
        [MaxLength(50)]
        public string TagId { set; get; }

        [Key]
        [Column(Order = 2)]
        public int ProductId { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
    }
}