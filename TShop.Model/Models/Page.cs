using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TShop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        [MaxLength(300)]
        public string Title { set; get; }

        public string PageContent { set; get; }

        [MaxLength(400)]
        public string MetaKeyword { set; get; }

        [MaxLength(400)]
        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}