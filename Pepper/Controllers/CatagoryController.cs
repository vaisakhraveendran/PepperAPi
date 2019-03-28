using PepperServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PepperModals;

namespace Pepper.Controllers
{
   [Authorize]
    public class CatagoryController : ApiController
    {

        private readonly IProductServices _productServices;

        #region Public Constructor

        /// <summary>
        /// Public constructor to initialize product service instance
        /// </summary>
        public CatagoryController()
        {
            _productServices = new ProductServices();
        }

        #endregion
        // GET api/values
        public IEnumerable<ProductCatalogEntity> Get()
        {
          return _productServices.GetCatagoryListService();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
