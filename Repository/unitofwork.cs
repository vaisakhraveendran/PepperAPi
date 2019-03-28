using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class unitofwork : IUnitofwork
    {

        private readonly PepperEntities context;
        private Repository<ProductCatagory> _userRepository;

        private CatagoryRepository Catagory;
        public unitofwork()
        {
            context = new PepperEntities();
             this.Catagory = new CatagoryRepository(context);
            products = new ProductRepository(context);

        }

        public CatagoryRepository catagory
        {
            get
            {

                return Catagory;
            }

        }

        public ProductRepository products
        {
            get;private set;
        }

        public int complete()
        {
            return context.SaveChanges();

        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
