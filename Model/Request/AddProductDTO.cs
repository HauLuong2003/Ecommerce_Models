using Ecommerce_Models.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Models.Model.Request
{
    public class AddProductDTO
    {
        public Product Product { get; set; }
        public Detail Detail { get; set; }
        public Price Price { get; set; }
    }
}
