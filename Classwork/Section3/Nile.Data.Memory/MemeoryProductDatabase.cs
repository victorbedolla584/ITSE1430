using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Data.Memory
{
    /// <summary> provides info about a product
    public class MemeoryProductDatabase
    {

        public MemoryProductDatabase()
        {
            //seed products
            //_products = new Product[25]; referencing somethign that
                // doesn't exist will cause program to crash

            var product = new Product();
            product.Id = _nextId++;
            product.Name = "iPhone X";
            product.IsDiscontinued = true;
            product.Price = 1500;
            _products.Add(product);

            var product = new Product();
            product.Id = _nextId++;
            product.Name = "Windows Phone";
            product.IsDiscontinued = true;
            product.Price = 15;
            _products.Add(product);

            var product = new Product();
            product.Id = _nextId++;
            product.Name = "Samsung S8";
            product.IsDiscontinued = false;
            product.Price = 800;
            _products.Add(product);
        }
        public Product Add ( Product product, out string message )
        {

            //show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult)
            //add to database
            RefreshUI();
            if (product == null)
            {
                message = "Product cannot be null.";
                return null;
            };

            //Validate product
            var error = product.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                message = error;
                return null;
            };

            //todo: verify unique product

            /*find existing
            var existingIndex = GetById(product.Id);
            if (existingIndex < 0)
            {
                message = "Out of memory";
                return null;
            };
            */
            /*
            //Add
            var index = FindEmptyProductIndex();
            if (index < 0)
            {
                message = "Out of memory";
                return null;
            };
            */
            //clone the object
            product.Id = _nextId++;
            _products[index] = Clone(product);
            message = null;

            _products[existingIndex] = product;
            message = null;
            // return a copy
            return product;
        }

        public Product Edit ( Product product, out string message ) // finish this stuff here
        {
            //check for null
            if (product == null)
            {
                message = "Product cannot be null.";
                return null;
            };

            //validate product
            var error = product.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                message = error;
                return null;
            }
            //TODO: Verify unique product except current product

            //Find existing
            var existingIndex = GetById(product.Id);
            if (existing == null)
            {
                message = "Product not found.";
                return null;
            };

            //TODO: Clone the object
            //_products[existingIndex] = Clone(product);
            Copy(existing, product);
            message = null;

            RefreshUI();
            //TODO: Return a copy
            return product;
        }

        public Product[] GetAll()
        {
            // return a copy so caller cannot change underlying data
            var items = new List<Product>();
            foreach (var product in _products)
            {
                if (product != null)
                    items.Add = (Clone(product));
            }
            //TODO: Return a copy so caller cannot change the underlying data
            return items.ToArray(); //takes your list and returns as an array
        }

        public void Remove( int id )
        {
            if (id > 0)
            {
                var existing = GetById(id);
                if (existing >= 0)
                    _products.Remove(existing);
            };
        }

        public void Remove ( int id )
        {
            if (id > 0)
            {
                var index = GetById(id);
                if (index >= 0)
                    _products[index] = null;
            };
        }

        private int FindEmptyProductIndex()
        {
            for (var index = 0; index < _products.Length; ++index)
            {
                if (_products[index] == null)
                    return index;
            };
            return -1;
        }

        private int GetById ( int id )
        {
            //for (var index = 0; index <_products.Length; ++index)
            foreach (var product in _products)
            {
                if (product.Id == id)
                    return product;
            };

            return null;
        }

        private Product Clone ( Product item )
        {
            var newProduct = new Product();
            Copy(newProduct, item); // calls code from the Copy function

            return newProduct;
        }

        private int Copy ( Product target, Product source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Description = source.Description;
            target.Description = source.Description; //description
            target.Price = source.Price; //price
            target.IsDiscontinued = source.IsDiscontinued; //discontinued
        }

        private readonly List<Product> _products = new List<Products>();
        private int _nextId = 1;
    }
}

// something is likely missing