using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        [MaxLength(300)]
        public string Name { set; get; }

        public int GroupId { set; get; }

        [MaxLength(300)]
        public string Url { set; get; }

        [MaxLength(50)]
        public string Target { set; get; }

        public bool Status { set; get; }

        [ForeignKey("GroupId")]
        public virtual GroupMenu GroupMenu { set; get; }
    }
}