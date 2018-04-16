using System;
using System.Collections.Generic;
using TShop.Data.Infrastructure;
using TShop.Data.Repositories;
using TShop.Model.Models;

namespace TShop.Service
{
    public interface IProductService
    {
        void Add(Product product);

        void Update(Product product);

        void Delete(int id);

        IEnumerable<Product> GetAll();

        Product GetById(int id);

        IEnumerable<Product> GetAllByPaging(int page, int pageSize, out int rowTotal);

        IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int rowTotals);

        IEnumerable<Product> GetAllByProductCategory(int categoryId, int page, int pageSize, out int rowTotals);

        void SaveChanges();
    }

    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Product product)
        {
            this._productRepository.Add(product);
        }

        public void Update(Product product)
        {
            this._productRepository.Update(product);
        }

        public void Delete(int id)
        {
            this._productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return this._productRepository.GetAll(new string[] { "ProductCategory" });
        }

        public Product GetById(int id)
        {
            return this._productRepository.GetSingleById(id);
        }

        public IEnumerable<Product> GetAllByPaging(int page, int pageSize, out int rowTotals)
        {
            return this._productRepository.GetMultiPaging(n => n.Status, out rowTotals, page, pageSize);
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int rowTotals)
        {
            return this._productRepository.GetByTagPaging(tag, page, pageSize, out rowTotals);
        }

        public IEnumerable<Product> GetAllByProductCategory(int categoryId, int page, int pageSize, out int rowTotals)
        {
            return this._productRepository.GetMultiPaging(n => n.Status && n.CategoryId == categoryId, out rowTotals, page, pageSize, new String[] { "ProductCategory" });
        }

        public void SaveChanges()
        {
            this._unitOfWork.Commit();
        }
    }
}