using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository:Repository<Product>
    {

      public  ProductRepository(PepperEntities contex) : base(contex)
        {

        }

    }
}
