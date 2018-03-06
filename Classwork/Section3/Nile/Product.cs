/*
 * ITSE 1430
 * Classwork
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    /// <summary>Provides information about a product.</summary>
    public class Product : IValidatableObject // resides in 
    {
        internal decimal DiscountPercentage = 0.10M;

        public int Id { get; set; }

        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value ?? ""; }
        }

        /// <summary>Gets or sets the name.</summary>
        /// <value></value>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        //Using auto property here
        /// <summary>Gets or sets the price.</summary>
        public decimal Price { get; set; } = 0;
        //public decimal Price
        //{
        //    get { return _price; }
        //    set { _price = value; }
        //}

        //public int ShowingOffAccessibility
        //{
        //    get { }
        //    internal set { }
        //}

        /// <summary>Gets the price, with any discontinued discounts.</summary>
        public decimal ActualPrice
        {
            get 
            {
                if (IsDiscontinued)
                    return Price - (Price * DiscountPercentage);

                return Price;
            }
            
            //set { }
        }

        /// <summary>Determines if the product is discontinued.</summary>
        public bool IsDiscontinued { get; set; }
        //public bool IsDiscontinued
        //{
        //    get { return _isDiscontinued; }
        //    set { _isDiscontinued = value; }
        //}

        ///// <summary>Get the product name.</summary>
        ///// <returns>The name.</returns>
        //public string GetName ()
        //{
        //    return _name ?? "";
        //}

        ///// <summary>Sets the product name.</summary>
        ///// <param name="value">The name.</param>
        //public void SetName ( string value )
        //{
        //    _name = value ?? "";
        //}

        /* <summary>Validates the product.</summary>
        /// <returns>Error message, if any.</returns>
        public string Validate ()
        {
            //Name is required
            if (String.IsNullOrEmpty(_name))
                return "Name cannot be empty";

            //Price >= 0
            if (Price < 0)
                return "Price must be >= 0";

            return "";
        }*/

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var errors = new List<ValidationResult>();

            //Name is required
            if (String.IsNullOrEmpty(_name))
                errors.Add(new ValidationResult("Name cannot be empty",
                    new[] { "Name" })); // can also add to which property the interface goes with

            //Price >= 0
            if (Price < 0)
                errors.Add(new ValidationResult("Price must be >= 0",
                    new[] { "Price" }));

            return errors;
        }

        private string _name;
        private string _description;

        //Using auto properties
        //private decimal _price;
        //private bool _isDiscontinued;
    }
}
