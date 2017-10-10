using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    /// <summary>Base class for product database.</summary>
    public class ProductDatabase
    {
        public ProductDatabase ()
        {
            _products[0] = new Product();
            _products[0].Name = "Bike Rack";
            _products[0].Price = 350;
            _products[1] = new Product();
            _products[1].Name = "Bike";
            _products[1].Price = 7650;
            _products[1].IsDiscontinued = true;
            _products[2].Name = "WP";
            _products[2].Price = 176;
            _products[2].IsDiscontinued = true;
        }
        /// <summary>Adds a product</summary>
        /// <param name="Product">The product to add</param>
        /// <returns>The added product.</returns>
        public Product Add (Product Product)
        {
            //TODO: Implement Add
            return Product;
        }
        /// <summary>Get a specific product</summary>
        /// <returns>The product, if it exists</returns>
        public Product Get()
        {
            //TODO: Implement Get
            return null;
        }

        /// <summary>Gets all products</summary>
        /// <returns></returns>
        public Product[] GetAll()
        {
            var items = new Product[_products.Length];
            var index = 0;
            foreach( var product in _products)
            {
                items[index++ ] = copyProduct(product);
            };
            return items;
        }
        /// <summary> Removes the product.</summary>
        /// <param name="product">The product to remove.</param>
        public void Remove(Product product)
        {
            //TODO: Implement remove
           
        }
        /// <summary>Updates a product</summary>
        /// <param name="product">The product to update</param>
        /// <returns>The updated product.</returns>
        public Product Update (Product product)
        {
            //TODO: Implement Update
            return product;
        }

        private Product copyProduct ( Product product)
        {
            if (product == null)
                return null;

            var newProduct = new Product();
            newProduct.Name = product.Name;
            newProduct.Price = product.Price;
            newProduct.IsDiscontinued = product.IsDiscontinued;
            return newProduct;
        }
        private Product[] _products = new Product[100];
    }
}
