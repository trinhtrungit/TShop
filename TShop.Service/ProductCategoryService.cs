using System.Collections.Generic;
using TShop.Data.Infrastructure;
using TShop.Data.Repositories;
using TShop.Model.Models;

namespace TShop.Service
{
    public interface IProductCategoryService
    {
        ProductCategory Add(ProductCategory productcategory);

        void Update(ProductCategory productcategory);

        void Delete(int id);

        void SaveChange();

        ProductCategory GetById(int id);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> SearchByKeyword(string keyWord);

        IEnumerable<ProductCategory> GetByParentId(int parentId);
    }

    internal class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._productCategoryRepository = productCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public ProductCategory Add(ProductCategory productCategory)
        {
            return this._productCategoryRepository.Add(productCategory);
        }

        public void Update(ProductCategory productcategory)
        {
            this._productCategoryRepository.Update(productcategory);
        }

        public void Delete(int id)
        {
            this._productCategoryRepository.Delete(id);
        }

        public void SaveChange()
        {
            this._unitOfWork.Commit();
        }

        public ProductCategory GetById(int id)
        {
            return this._productCategoryRepository.GetSingleById(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return this._productCategoryRepository.GetAll();
        }

        public IEnumerable<ProductCategory> GetByParentId(int parentId)
        {
            return this._productCategoryRepository.GetMulti(n => n.Status && n.ParentId == parentId);
        }

        public IEnumerable<ProductCategory> SearchByKeyword(string keyWord)
        {
            if (string.IsNullOrEmpty(keyWord))
            {
                return this._productCategoryRepository.GetAll();
            }
            else
            {
                return this._productCategoryRepository.GetMulti(n => n.Name.Contains(keyWord) || n.MetaDescription.Contains(keyWord));
            }
        }
    }
}