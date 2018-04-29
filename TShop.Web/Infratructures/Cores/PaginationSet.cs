using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TShop.Web.Infratructures.Cores
{
    public class PaginationSet<T>
    {
        public int PageIndex { set; get; }
        public int Count {
            get
                {
                    return (Items != null) ? Items.Count() : 0;
                }
        }
        public int TotalPages { set; get; }
        public int TotalCounts { set; get; }
        public IEnumerable<T> Items { set; get; }
    }
}