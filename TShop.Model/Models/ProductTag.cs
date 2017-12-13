using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Model.Models
{
     [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public string TagId { set; get; }
        [Key]
        public string ProductId { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tags { set; get; }
        [ForeignKey("ProductId")]
        public virtual Product Products { set; get; }
    }
}
