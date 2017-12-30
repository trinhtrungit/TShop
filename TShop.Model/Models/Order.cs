using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string CustomerMobile { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string CustomerEmail { set; get; }

        [MaxLength(300)]
        public string CustomerMessages { set; get; }

        [Required]
        [MaxLength(500)]
        public string CustomerAddress { set; get; }

        public DateTime? CreateDate { set; get; }

        [MaxLength(100)]
        public string CreateBy { set; get; }

        public int Status { set; get; }

        [MaxLength(100)]
        public string PaymentMethod { set; get; }

        [Required]
        [MaxLength(100)]
        public string PaymentStatus { set; get; }

        public virtual IEnumerable<DetailOrder> DetailOrders { set; get; }
    }
}