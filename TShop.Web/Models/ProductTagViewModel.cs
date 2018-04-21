namespace TShop.Web.Models
{
    public class ProductTagViewModel
    {
        public string TagId { set; get; }

        public int ProductId { set; get; }

        public virtual TagViewModel Tag { set; get; }

        public virtual ProductViewModel Product { set; get; }
    }
}