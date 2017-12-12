using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required]
        public string CustomerName { set; get; }
        [Required]
        public string CustomerMobile { set; get; }
        [Required]
        public string CustomerEmail { set; get; }
        public string CustomerMessages { set; get; }
        [Required]
        public string CustomerAddress { set; get; }
        public DateTime? CreateDate { set; get; }
        public string CreateBy { set; get; }
        public int Status { set; get; }
        public string PaymentMethod { set; get; }
        [Required]
        public string PaymentStatus { set; get; }

        public virtual IEnumerable<DetailOrder> DetailOrders { set; get; }
    }
}
