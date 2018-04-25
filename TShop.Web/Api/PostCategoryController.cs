using AutoMapper;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TShop.Model.Models;
using TShop.Service;
using TShop.Web.Infratructures.Cores;
using TShop.Web.Infratructures.Extensions;
using TShop.Web.Models;

namespace TShop.Web.Api
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        private IPostCategoryService _postCategoryService;

        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService)
            : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage requestMessage)
        {
            return CreateHttpReponse(requestMessage, () =>
            {
                var lstCategory = _postCategoryService.GetAll();
                var lstCategoryVM = Mapper.Map<List<PostCategoryViewModel>>(lstCategory);
                HttpResponseMessage response = requestMessage.CreateResponse(HttpStatusCode.OK, lstCategoryVM);
                return response;
            });
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage requestMessage, PostCategoryViewModel postCategoryVM)
        {
            return CreateHttpReponse(requestMessage, () =>
            {
                PostCategory postCategory = new PostCategory();
                postCategory.UpdatePostCategory(postCategoryVM);
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    var category = _postCategoryService.Add(postCategory);
                    _postCategoryService.saveChange();
                    response = requestMessage.CreateResponse(HttpStatusCode.Created, category);
                }
                else
                {
                    response = requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return response;
            });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage requestMessage, PostCategoryViewModel postCategoryVM)
        {
            return CreateHttpReponse(requestMessage, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    PostCategory postCategory = _postCategoryService.GetById(postCategoryVM.Id);
                    postCategory.UpdatePostCategory(postCategoryVM);
                    _postCategoryService.Update(postCategory);
                    _postCategoryService.saveChange();
                    response = requestMessage.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    response = requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return response;
            });
        }

        [Route("delete")]
        public HttpResponseMessage Delete(HttpRequestMessage requestMessage, int id)
        {
            return CreateHttpReponse(requestMessage, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.saveChange();
                    response = requestMessage.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    response = requestMessage.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return response;
            });
        }
    }
}