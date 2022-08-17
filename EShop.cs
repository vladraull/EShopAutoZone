using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop
{
    public class EShop
    {
        public List<Part> Parts { get; set; }
        public List<Product> Products { get; set; }
        public EShop()
        {
            Parts = new List<Part>();
            Products = new List<Product>();
        }
    }
}
