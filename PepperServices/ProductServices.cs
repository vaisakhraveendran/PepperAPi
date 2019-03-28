using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PepperModals;
using AutoMapper;

namespace PepperServices
{
    public class ProductServices:IProductServices
    {
        private IUnitofwork unitofwork;

        public ProductServices()
        {
            unitofwork = new unitofwork();
        }

        public List<ProductCatalogEntity> GetCatagoryListService()
        {
            var productscatagory =unitofwork.catagory.GetAll().ToList();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ProductCatagory, ProductCatalogEntity>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new List<ProductCatalogEntity>();
            var dest = mapper.Map<List<ProductCatagory>, List<ProductCatalogEntity>>(productscatagory);


            return dest;

        }
    }
}
