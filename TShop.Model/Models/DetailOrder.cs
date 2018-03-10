﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Model.Models
{
    [Table("DetailOrders")]
    public class DetailOrder
    {
        [Key]
        [Column(Order = 1)]
        public int OrderId { set; get; }
        [Key]
        [Column(Order = 2)]
        public int ProductId { set; get; }
        public int Quantity { set; get; }

        [ForeignKey("OrderId")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
    }
}
