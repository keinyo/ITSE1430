using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {
       
        //TODO: UPDATE DOCTAGS
        //TODO: MOVE TO SECTION 4
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        /// <exception cref="ArgumentException">Product is null</exception>
        /// <exception cref="ValidationException"></exception>>
  
        public Product Add( Product product )
        {
            //TODO: Validate
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Product was null");
            //return null;

            //System.ComponentModel.DataAnnotations.Validator.
            //Using IValidatableObject
            //if (!ObjectValidator.TryValidate(product, out var errors))
            //    throw new System.ComponentModel.DataAnnotations.ValidationException("Product was not valid", nameof(product));
            //return null;

            ObjectValidator.Validate(product);

            //Emulate database by storing copy
            try
            {
                return AddCore(product);
            } catch (Exception e)
            {
                //Throw different exception
                throw new Exception("Add failed", e);

                //re-throw
                throw;

                //Silently Ignore - almost always bad
            };
           
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get( int id)
        {
            //Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id),"Id must be > 0.");

            
            return GetCore(id);
        }

        protected abstract Product GetCore( int id );

        protected abstract Product AddCore( Product product );
     
        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll()
        {
            return GetAllCore();
            
            //How many products?
         //  var count = 0;
         //  foreach (var product in _products)
         //  {
         //      if (product != null)
         //          ++count;
         //  };
         //  var items = new Product[count];
         //  var index = 0;
         //
         //  foreach (var product in _products)
         //  {
         //      if (product != null)  
         //      items[index++] = CopyProduct(product);
         //      
         //  };
         //
         //  return items;

        }
        protected abstract IEnumerable<Product> GetAllCore();

        /// <summary>Removes the product.</summary>
        /// <param name="product">The product to remove.</param>
        public void Remove( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            RemoveCore(id);
        }

        protected abstract void RemoveCore( int id );

        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update( Product product )
        {
            //TODO: Validate
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            //if (!String.IsNullOrEmpty(product.Validate()))
            //    return null;

            //using IValidatableObject
            //if (!ObjectValidator.TryValidate(product, out var errors))
            //    throw new ArgumentNullException("Product is invalid", nameof(product));
            ObjectValidator.Validate(product);

            //throw expression
            //Get existing product
            var existing = GetCore(product.Id) ?? throw new Exception("Product not found.");
            //if (existing == null)
            //    throw new Exception("Product not found");

            return UpdateCore(existing, product);
            
        }

        protected abstract Product UpdateCore( Product existing, Product newItem );

        private Product CopyProduct( Product product )
        {
            if (product == null)
                return null;

            var newProduct = new Product();
            newProduct.Name = product.Name;
            newProduct.Price = product.Price;
            newProduct.IsDiscontinued = product.IsDiscontinued;

            return newProduct;
        }

        private Product FindProduct (int id)
        {
            foreach (var product in _products)
            {
                if (product.Id == id)
                    return product;
            };

            return null;
        }

        //private Product[] _products = new Product[100];
        private List<Product> _products = new List<Product>();
        private int _nextId = 1;
       // private List<int> _ints;
    }
}