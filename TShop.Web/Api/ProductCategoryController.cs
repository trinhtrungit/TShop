using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using TShop.Model.Models;
using TShop.Service;
using TShop.Web.Infratructures.Cores;
using TShop.Web.Models;
using TShop.Web.Infratructures.Extensions;

namespace TShop.Web.Api
{
    [RoutePrefix("api/productcategory")]
    public class ProductCategoryController : ApiControllerBase
    {
        private IProductCategoryService _productCategoryService;
        public ProductCategoryController(IErrorService errorServicce, IProductCategoryService productCategoryService) : base(errorServicce)
        {
            this._productCategoryService = productCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage requestMessage, string keyWord, int pageIndex, int PageSize = 20)
        {
            return CreateHttpReponse(requestMessage, () =>
            {
                int totalRows = 0;
                var listProductCate = this._productCategoryService.SearchByKeyword(keyWord);
                totalRows = listProductCate.Count();
                var query = listProductCate.OrderBy(n => n.CreateDate).Skip(pageIndex * PageSize).Take(PageSize);
                var listProductCateVM = Mapper.Map<List<ProductCategoryViewModel>>(query);
                var paginationSet = new PaginationSet<ProductCategoryViewModel>() {
                    Items = listProductCateVM,
                    TotalCounts = totalRows,
                    PageIndex = pageIndex,
                    TotalPages = (int)Math.Ceiling((decimal)totalRows / PageSize)
                }; 
                HttpResponseMessage responseMess = requestMessage.CreateResponse(HttpStatusCode.OK, paginationSet);
                return responseMess;
            });
        }

        [Route("getallcategories")]
        public HttpResponseMessage Get(HttpRequestMessage requestMessage)
        {
            return CreateHttpReponse(requestMessage, () =>
            {
                var listProductCate = this._productCategoryService.GetAll();
                var listProductCateVM = Mapper.Map<List<ProductCategoryViewModel>>(listProductCate);
                HttpResponseMessage responseMess = requestMessage.CreateResponse(HttpStatusCode.OK, listProductCateVM);
                return responseMess;
            });
        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage requestMessage, ProductCategoryViewModel productCategoryViewModel)
        {
            return CreateHttpReponse(requestMessage, () =>
            {
                HttpResponseMessage responseMess = null;
                if (ModelState.IsValid)
                {
                    ProductCategory productCategory = new ProductCategory();
                    productCategory.UpdateProductCategory(productCategoryViewModel);
                    var productCate = _productCategoryService.Add(productCategory);
                    _productCategoryService.SaveChange();
                    var reponseData = Mapper.Map<ProductCategory, ProductCategoryViewModel>(productCate);
                    responseMess = requestMessage.CreateResponse(HttpStatusCode.Created, reponseData);
                }
                else
                {
                    responseMess = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return responseMess;
            });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage requestMessage, ProductCategoryViewModel productCategoryViewModel)
        {
            return CreateHttpReponse(requestMessage, () =>
            {
                HttpResponseMessage responseMess = null;
                if (ModelState.IsValid)
                {
                    ProductCategory productCategory = _productCategoryService.GetById(productCategoryViewModel.Id);
                    productCategory.UpdateProductCategory(productCategoryViewModel);
                    _productCategoryService.Update(productCategory);
                    _productCategoryService.SaveChange();
                    responseMess = requestMessage.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    responseMess = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return responseMess;
            });
        }

        [Route("delete")]
        public HttpResponseMessage Delete(HttpRequestMessage requestMessage, int id)
        {
            return CreateHttpReponse(requestMessage, () =>
            {
                HttpResponseMessage responseMess = null;
                if (ModelState.IsValid)
                {
                    _productCategoryService.Delete(id);
                    _productCategoryService.SaveChange();
                    responseMess = requestMessage.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    responseMess = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return responseMess;
            });
        }
    }
}
