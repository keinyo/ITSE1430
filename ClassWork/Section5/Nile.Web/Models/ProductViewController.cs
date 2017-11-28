using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nile.Web.Models
{
    public class ProductViewController
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool isOwned { get; set; }
    }
}