using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShop.Model.Abstracts;

namespace TShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        [Required]
        public string FeatureImage { set; get; }
        public int? ParentId { set; get; }
        public int? DisplayOrder { set; get; }
        public int? HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posts { set; get; }
    }
}
