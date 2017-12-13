using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string Id { set; get; }
        public string FooterContent { set; get; }
    }
}
