using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Model.Models
{
     [Table("Tags")]
    public class Tag
    {
        [Key]
        [Required]
        public string Id { set; get; }
        public string TagName { set; get; }
        public string TagType { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}
