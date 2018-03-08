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
        public Product Add ( Product product, out string message )
        {
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

            //Verify unique product, find a product by name
            var existing = GetProductByName(product.Name); // pass the name of the product you're trying to add in
            if (existing != null)
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
        public Product Edit ( Product product, out string message )
        {
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
            existing = existing ?? GetById(product.Id);
            if (existing == null)
            {
                message = "Product not found.";
                return null;
            };

            // Clone the object
            //_products[existingIndex] = Clone(product);
            Copy(existing, product);
            message = null;

            //Return a copy
            return product;
        }

        protected abstract Product AddCore( Product product );
        protected abstract IEnumerable<Product> GetAllCore();
        protected abstract Product GetCore( int id );

        /// <summary>Gets all products.</summary>
        /// <returns>The list of products.</returns>
        public IEnumerable<Product> GetAll ()
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
        public void Remove ( int id )
        {
            //TODO: Return an error if id <= 0

            if (id > 0)
            {
                var existing = GetById(id);
                if (existing != null)
                    _products.Remove(existing);
            };
        }

        #region Private Members

        //Clone a product
        private Product Clone ( Product item )
        {
            var newProduct = new Product();
            Copy(newProduct, item);

            return newProduct;
        }

        //Copy a product from one object to another
        private void Copy ( Product target, Product source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Description = source.Description;
            target.Price = source.Price;
            target.IsDiscontinued = source.IsDiscontinued;
        }

        //private int FindEmptyProductIndex()
        //{
        //    for (var index = 0; index < _products.Length; ++index)
        //    {
        //        if (_products[index] == null)
        //            return index;
        //    };

        //    return -1;
        //}

        //Find a product by its ID
        private Product GetById ( int id )
        {
            //for (var index = 0; index < _products.Length; ++index)
            foreach (var product in _products)
            {
                if (product.Id == id)
                    return product;
            };

            return null;
        }

        private Product GetProductByName ( string name ) // foreach will be used for this
        {
            foreach (var product in _products) // basically copy/paste the code from GetById
            {
                //product.Name.CompareTo
                if (String.Compare(product.Name, name, true) == 0) // this is not case sensitive and that must be changed using String.Compare
                    return product;                         // or product.Name.CompareTo
            };

            return null;
        }

        private readonly List<Product> _products = new List<Product>();
        private int _nextId = 1;

        #endregion
    }
}
