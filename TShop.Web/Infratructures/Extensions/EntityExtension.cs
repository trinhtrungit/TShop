using TShop.Model.Models;
using TShop.Web.Models;

namespace TShop.Web.Infratructures.Extensions
{
    public static class EntityExtension
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVM)
        {
            postCategory.Id = postCategoryVM.Id;
            postCategory.Name = postCategoryVM.Name;
            postCategory.Alias = postCategoryVM.Alias;
            postCategory.FeatureImage = postCategoryVM.FeatureImage;
            postCategory.ParentId = postCategoryVM.ParentId;
            postCategory.DisplayOrder = postCategoryVM.DisplayOrder;
            postCategory.HomeFlag = postCategoryVM.HomeFlag;
            postCategory.CreateDate = postCategoryVM.CreateDate;
            postCategory.CreateBy = postCategoryVM.CreateBy;
            postCategory.UpdateDate = postCategoryVM.UpdateDate;
            postCategory.UpdateBy = postCategoryVM.UpdateBy;
            postCategory.MetaKeyword = postCategoryVM.MetaKeyword;
            postCategory.MetaDescription = postCategoryVM.MetaDescription;
            postCategory.Status = postCategoryVM.Status;
        }

        public static void UpdatePost(this Post post, PostViewModel postVM)
        {
            post.Id = postVM.Id;
            post.Name = postVM.Name;
            post.Alias = postVM.Alias;
            post.FeatureImage = postVM.FeatureImage;
            post.PostContent = postVM.PostContent;
            post.Description = postVM.Description;
            post.CategoryId = postVM.CategoryId;
            post.HomeFlag = postVM.HomeFlag;
            post.FeatureImage = postVM.FeatureImage;
            post.HotFlag = postVM.HotFlag;
            post.ViewCount = postVM.ViewCount;
            post.CreateDate = postVM.CreateDate;
            post.CreateBy = postVM.CreateBy;
            post.UpdateDate = postVM.UpdateDate;
            post.UpdateBy = postVM.UpdateBy;
            post.MetaKeyword = postVM.MetaKeyword;
            post.MetaDescription = postVM.MetaDescription;
            post.Status = postVM.Status;
        }
    }
}