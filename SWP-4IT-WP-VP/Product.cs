using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_4IT_WP_VP
{
    internal class Product
    {
        public Product()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }   
        public decimal MinStock { get; set; }

        //Color, Type, Brand, MinStock
    }
}
