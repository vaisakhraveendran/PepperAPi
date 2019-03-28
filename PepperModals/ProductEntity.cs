using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepperModals
{
    public partial class ProductEntity
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string url { get; set; }
        public int CatogoryID { get; set; }

    }
}
