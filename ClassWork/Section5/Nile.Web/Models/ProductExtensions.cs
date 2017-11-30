using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nile.Web.Models
{
    public static class ProductExtensions
    {
        public static ProductViewModel ToModel(this Product source)
        {
            return new ProductViewModel() {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
                Price = source.Price,
                isDiscontinued = source.IsDiscontinued
            };
        }

        public static IEnumerable<ProductViewModel> ToModel( this IEnumerable<Product> source )
        {
            foreach (var item in source)
                yield return item.ToModel();
            //return from item in source
            //   select new item.ToModel();
        }

        public static Product ToDomain( this ProductViewModel source )
        {
            return new Product() {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
                Price = source.Price,
                IsDiscontinued = source.isDiscontinued
            };
        }

    }
}