using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TShop.Model.Abstracts;

namespace TShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {set; get;}
        [Required]
        public string Name {set; get;}
        [Required]
        public string Alias {set; get;}
        [Required]
        public string Image {set; get;}

        public XElement MoreImages { set; get; }
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
    }
}
