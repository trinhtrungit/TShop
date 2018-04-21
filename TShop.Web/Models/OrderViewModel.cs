using System;
using System.Collections.Generic;

namespace TShop.Web.Models
{
    public class OrderViewModel
    {
        public int Id { set; get; }

        public string CustomerName { set; get; }

        public string CustomerMobile { set; get; }

        public string CustomerEmail { set; get; }
        public string CustomerMessages { set; get; }
        public string CustomerAddress { set; get; }

        public DateTime? CreateDate { set; get; }

        public string CreateBy { set; get; }

        public int Status { set; get; }

        public string PaymentMethod { set; get; }

        public string PaymentStatus { set; get; }

        public virtual IEnumerable<DetailOrderViewModel> DetailOrders { set; get; }
    }
}