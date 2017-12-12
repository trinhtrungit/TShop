using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }
        public int GroupId { set; get; }
        public string Url { set; get; }
        public string Target { set; get; }
        public bool Status { set; get; }

        [ForeignKey("GroupId")]
        public virtual GroupMenu GroupMenu { set; get; }
    }
}
