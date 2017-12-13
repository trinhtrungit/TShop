using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public string TagId { set; get; }
        [Key]
        public string PostId { set; get; }

        [ForeignKey("TagId")]
        public virtual Tag Tags { set; get; }
        [ForeignKey("PostId")]
        public virtual Post Posts { set; get; }
    }
}
