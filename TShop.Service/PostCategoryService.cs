using System.Collections.Generic;
using TShop.Data.Infrastructure;
using TShop.Data.Repositories;
using TShop.Model.Models;

namespace TShop.Service
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);

        void Update(PostCategory postCategory);

        void Delete(int id);

        void saveChange();

        PostCategory GetById(int id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetMultiByParentId(int parentId);
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository _postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = _postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public PostCategory Add(PostCategory postCategory)
        {
            return this._postCategoryRepository.Add(postCategory);
        }

        public void Update(PostCategory postCategory)
        {
            this._postCategoryRepository.Update(postCategory);
        }

        public void Delete(int id)
        {
            this._postCategoryRepository.Delete(id);
        }

        public void saveChange()
        {
            this._unitOfWork.Commit();
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return this._postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetMultiByParentId(int parentId)
        {
            return this._postCategoryRepository.GetMulti(n => n.Status && n.ParentId == parentId);
        }

        public PostCategory GetById(int id)
        {
            return this._postCategoryRepository.GetSingleById(id);
        }
    }
}