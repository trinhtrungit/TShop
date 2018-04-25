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

        public static void UpdateProductCategory(this ProductCategory productCategory, ProductCategoryViewModel productCategoryView)
        {
            productCategory.Id = productCategoryView.Id;
            productCategory.Name = productCategoryView.Name;
            productCategory.Alias = productCategoryView.Alias;
            productCategory.FeatureImage = productCategoryView.FeatureImage;
            productCategory.ParentId = productCategoryView.ParentId;
            productCategory.DisplayOrder = productCategoryView.DisplayOrder;
            productCategory.HomeFlag = productCategoryView.HomeFlag;
            productCategory.CreateDate = productCategoryView.CreateDate;
            productCategory.CreateBy = productCategoryView.CreateBy;
            productCategory.UpdateDate = productCategoryView.UpdateDate;
            productCategory.UpdateBy = productCategoryView.UpdateBy;
            productCategory.MetaKeyword = productCategoryView.MetaKeyword;
            productCategory.MetaDescription = productCategoryView.MetaDescription;
            productCategory.Status = productCategoryView.Status;
        }

        public static void UpdateProduct(this Product product, ProductViewModel productViewModel)
        {
            product.Id = productViewModel.Id;
            product.Name = productViewModel.Name;
            product.Alias = productViewModel.Alias;
            product.Image = productViewModel.Image;
            product.MoreImages = productViewModel.MoreImages;
            product.Price = productViewModel.Price;
            product.Quantity = productViewModel.Quantity;
            product.Varranty = productViewModel.Varranty;
            product.ProductContent = productViewModel.ProductContent;
            product.Description = productViewModel.Description;
            product.CategoryId = productViewModel.CategoryId;
            product.HotFlag = productViewModel.HotFlag;
            product.HomeFlag = productViewModel.HomeFlag;
            product.ViewCount = productViewModel.ViewCount;
            product.CreateDate = productViewModel.CreateDate;
            product.CreateBy = productViewModel.CreateBy;
            product.UpdateDate = productViewModel.UpdateDate;
            product.UpdateBy = productViewModel.UpdateBy;
            product.MetaKeyword = productViewModel.MetaKeyword;
            product.MetaDescription = productViewModel.MetaDescription;
        }
    }
}