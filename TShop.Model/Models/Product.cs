using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TShop.Model.Abstracts;

namespace TShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        [MaxLength(300)]
        public string Name { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(300)]
        public string Alias { set; get; }

        [Required]
        [MaxLength(300)]
        public string Image { set; get; }

        [Column(TypeName = "xml")]
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

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCagory { set; get; }

        public virtual IEnumerable<DetailOrder> DetailOrders { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}