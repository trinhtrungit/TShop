using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShop.Model.Models;
using TShop.Data.Repositories;
using TShop.Data.Infrastructure;

namespace TShop.Service
{
    public interface IProductCategoryService
    {
        void Add(ProductCategory productcategory);
        void Update(ProductCategory productcategory);
        void Delete(int id);
        void SaveChange();
        ProductCategory GetById(int id);
        IEnumerable<ProductCategory> GetAll();
        IEnumerable<ProductCategory> GetByParentId(int parentId);
    }
    class ProductCategoryService : IProductCategoryService
    {
        IProductCategoryRepository _productCategoryRepository;
        IUnitOfWork _unitOfWork;
        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._productCategoryRepository = productCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(ProductCategory productCategory)
        {
            this._productCategoryRepository.Add(productCategory);
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
    }
}
