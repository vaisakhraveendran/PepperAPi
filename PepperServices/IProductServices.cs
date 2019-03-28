using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PepperModals;

namespace PepperServices
{
    public interface IProductServices
    {
        List<ProductCatalogEntity> GetCatagoryListService();

    }
}
