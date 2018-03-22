﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Data
{
    /// <summary>Provides an in-memory product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {
        public Product Add( Product product, out string message )
        {
            //Check for null
            if (product == null)
            {
                message = "Product cannot be null.";
                return null;
            };

            //Validate product using IValidatableObject
            var errors = product.Validate();
            //var errors = ObjectValidator.Validate(product);
            /*
            if (errors.Count() > 0)
            {
                //Get first error
                message = errors.ElementAt(0).ErrorMessage;
                return null;
            };
            */

            //Verify unique product, find a product by name
            var error = errors.FirstOrDefault(); // pass the name of the product you're trying to add in
            if (error != null)
            {
                message = "Product already exists.";
                return null;
            };

            message = null;
            return AddCore(product);
        }

        /// <summary>Edits an existing product.</summary>
        /// <param name="product">The product to update.</param>
        /// <param name="message">Error message.</param>
        /// <returns>The updated product.</returns>
        /// <remarks>
        /// Returns an error if product is null, invalid, product name
        /// already exists or if the product cannot be found.
        /// </remarks>
        public Product Edit( Product product, out string message )
        {
            message = "";

            //Check for null
            if (product == null)
            {
                message = "Product cannot be null.";
                return null;
            };

            //Validate product using IValidatableObject
            //var error = product.Validate();
            var errors = ObjectValidator.Validate(product);
            if (errors.Count() > 0)
            {
                //Get first error
                message = errors.ElementAt(0).ErrorMessage;
                return null;
            };

            //TODO: Verify unique product except current product
            var existing = GetProductByName(product.Name); // pass the name of the product you're trying to add in
            if (existing != null && existing.Id != product.Id)
            {
                message = "Product already exists.";
                return null;
            };

            //Find existing
            existing = existing ?? GetCore(product.Id);
            if (existing == null)
            {
                message = "Product not found.";
                return null;
            };

            return UpdateCore(product);
        }

        protected abstract Product AddCore( Product product );
        protected abstract IEnumerable<Product> GetAllCore();
        protected abstract Product GetCore( int id );
        protected abstract void RemoveCore( int id );
        protected abstract Product UpdateCore( Product product ); //accepts and returns a product

        /// <summary>Gets all products.</summary>
        /// <returns>The list of products.</returns>
        public IEnumerable<Product> GetAll()
        {
            return GetAllCore();
        }
        /*public Product[] GetAll ()
        {
            //Return a copy so caller cannot change the underlying data
            var items = new List<Product>();

            //for (var index = 0; index < _products.Length; ++index)
            foreach (var product in _products)
            {
                if (product != null)                
                    items.Add(Clone(product));
            };

            return items;
        }*/

        /// <summary>Removes a product.</summary>
        /// <param name="id">The product ID.</param>
        public void Remove( int id )
        {
            //TODO: Return an error if id <= 0

            if (id > 0)
            {
                RemoveCore(id);
            };
        }

        private Product GetProductByNameCore( string name );
    }
}