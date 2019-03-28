using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public  class CatagoryRepository:Repository<ProductCatagory>
    {


       public CatagoryRepository(PepperEntities context) : base(context) { }


    }
}
