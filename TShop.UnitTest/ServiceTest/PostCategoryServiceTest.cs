using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TShop.Data.Infrastructure;
using TShop.Data.Repositories;
using TShop.Model.Models;
using TShop.Service;

namespace TShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockPostCategoryRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _postCategoryService;
        private List<PostCategory> _lstPostCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockPostCategoryRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _postCategoryService = new PostCategoryService(_mockPostCategoryRepository.Object, _mockUnitOfWork.Object);
            _lstPostCategory = new List<PostCategory> {
                new PostCategory() {Id = 7, Name = "Category 7", Alias = "category-7", FeatureImage = "a.com", Status = true},
                new PostCategory() {Id = 8, Name = "Category 8", Alias = "category-8", FeatureImage = "a.com", Status = true},
                new PostCategory() {Id = 9, Name = "Category 9", Alias = "category-9", FeatureImage = "a.com", Status = true},
                new PostCategory() {Id = 10, Name = "Category 10", Alias = "category-10", FeatureImage = "a.com", Status = true}
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            // Set up
            _mockPostCategoryRepository.Setup(n => n.GetAll(null)).Returns(_lstPostCategory);
            // call service
            var result = _postCategoryService.GetAll() as List<PostCategory>;
            // compare
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count);
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory postCate = new PostCategory();
            postCate.Id = 1;
            postCate.Name = "Test";
            postCate.Alias = "Test";
            postCate.FeatureImage = "Test";
            postCate.Status = true;

            _mockPostCategoryRepository.Setup(n => n.Add(postCate)).Returns(postCate);
            // call add method
            var result = _postCategoryService.Add(postCate);
            // compare
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Id);
        }
    }
}