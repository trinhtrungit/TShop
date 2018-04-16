using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TShop.Data.Infrastructure;
using TShop.Data.Repositories;
using TShop.Model.Models;

namespace TShop.UnitTest.RepositoriesTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory _dbFacetory;
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        [TestInitialize]
        public void Intialize()
        {
            _dbFacetory = new DbFactory();
            _postCategoryRepository = new PostCategoryRepository(_dbFacetory);
            _unitOfWork = new UnitOfWork(_dbFacetory);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory postCategory = new PostCategory();
            postCategory.Name = "Post category name 1";
            postCategory.Alias = "category-1";
            postCategory.FeatureImage = "abc.com";
            postCategory.Status = true;
            var result = _postCategoryRepository.Add(postCategory);

            _unitOfWork.Commit();
            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Id);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var lstPostCate = _postCategoryRepository.GetAll();
            Assert.AreEqual(10, lstPostCate.Count());
        }
    }
}