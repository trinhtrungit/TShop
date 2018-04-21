namespace TShop.Web.Models
{
    public class PostTagViewModel
    {
        public string TagId { set; get; }
        public int PostId { set; get; }
        public virtual TagViewModel Tag { set; get; }
        public virtual PostViewModel Post { set; get; }
    }
}