using System;
using System.Collections.Generic;
using TShop.Data.Infrastructure;
using TShop.Data.Repositories;
using TShop.Model.Models;

namespace TShop.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        Post GetById(int id);

        IEnumerable<Post> GetMultiByPaging(int page, int pageSize, out int rowTotals);

        IEnumerable<Post> GetMultiByTagPaging(string tag, int page, int pageSize, out int rowTotals);

        IEnumerable<Post> GetMultiByCategoryPaging(int categoryId, int page, int pageSize, out int rowTotals);

        void SaveChange();
    }

    public class PostService : IPostService
    {
        private IPostRepository _postRepository;
        private IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            this._postRepository.Add(post);
        }

        public void Update(Post post)
        {
            this._postRepository.Update(post);
        }

        public void Delete(int id)
        {
            this._postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return this._postRepository.GetAll(new string[] { "PostCategory" });
        }

        public Post GetById(int id)
        {
            return this._postRepository.GetSingleById(id);
        }

        public IEnumerable<Post> GetMultiByPaging(int page, int pageSize, out int rowTotals)
        {
            return this._postRepository.GetMultiPaging(x => x.Status, out rowTotals, page, pageSize);
        }

        public IEnumerable<Post> GetMultiByTagPaging(string tag, int page, int pageSize, out int rowTotals)
        {
            return this._postRepository.GetAllByTag(tag, page, pageSize, out rowTotals);
        }

        public IEnumerable<Post> GetMultiByCategoryPaging(int categoryId, int page, int pageSize, out int rowTotals)
        {
            return this._postRepository.GetMultiPaging(n => n.CategoryId == categoryId && n.Status, out rowTotals, page, pageSize, new String[] { "PostCategory" });
        }

        public void SaveChange()
        {
            this._unitOfWork.Commit();
        }
    }
}