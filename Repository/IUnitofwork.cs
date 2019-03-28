using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUnitofwork:IDisposable
    {
        CatagoryRepository catagory { get; }
        ProductRepository products { get; }
        int complete();

    }
}
