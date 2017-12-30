using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Email { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string Mobile { set; get; }

        public string Address { set; get; }

        [MaxLength(256)]
        public string Facebook { set; get; }

        [MaxLength(100)]
        public string Department { set; get; }

        public bool Status { set; get; }
    }
}