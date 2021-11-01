using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebApp.Models
{
    public class Coffee
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Coffee()
        {

        }
        
    }
}
