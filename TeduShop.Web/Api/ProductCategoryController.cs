using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Service;
using TeduShop.Web.Infrastructure.Core;
using TeduShop.Web.Models;
using TeduSop.Model.Models;
using TeduShop.Web.Infrastructure.Extensions;

namespace TeduShop.Web.Api
{
    [RoutePrefix("api/productcategory")]
    public class ProductCategoryController : ApiControllerBase
    {
        IProductCategoryService _productCategoryService;
        public ProductCategoryController(IErrorService errorService,IProductCategoryService productCategoryService) 
            : base(errorService)
        {
            this._productCategoryService = productCategoryService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var model = _productCategoryService.GetAll();
                    var reponseData = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
                    response = request.CreateResponse(HttpStatusCode.OK, reponseData);
                    return response;
                }
                return response;
            });
        }
    }
}