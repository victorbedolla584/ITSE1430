using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    /// <summary> Provides information about a product. </summary>
    public class Product
    {
        internal decimal DiscountPercentage = 0.10M;

        public string Name
        {
            get { return _name ?? "";  } // value it returns is up to you so long as compiler runs the program
            set { _name = value; }
        }
        public string Description
        {
            get { return _description ?? ""; } //with the addition of ?? "" it is gauranteed to never return null
            set { _description = value ?? ""; }
        }

        //using auto property here
        public decimal Price
        {
            //get { return _price; } // value it returns is up to you so long as compiler runs the program
            //set { _price = value; }
            get; set;
        } = 0;
        /*public int ShowingOffAccessibility
        {
            get { }
            internal set { } // allows in most cases that anybody in the accessibiiy, must be wid eopen
                    //getter & setter you're changing must be more more acccsible
        }
        */
        public decimal ActualPrice
        {
            get
            {
                if (IsDiscontinued)
                    return Price - (Price * DiscountPercentage);

                return Price;
            }

            //set {}
        }
        public bool IsDiscontinued
        {
            get { return _isDiscontinued; } // value it returns is up to you so long as compiler runs the program
            set { _isDiscontinued = value; }
        }
        /*
        /// <summary> Gets the product name. </summary>
        /// <param name="value"> The name. </param>
        public string GetName () // to expose functionality, use a function. These are methods if they are within a function.
        {
            return _name ?? ""; // this will never return a null as it forces you to use a method
        }
        */
        /*
        /// <summary> Sets the product name. </summary>
        /// <param name="value"> The name. </param>"
        public void SetName ( string value )
        {
            _name = value ?? "";
        }
        */

        /// <summary> Validates the product. <summary>
        /// <returns> Error message, if any. </returns>
        public string Validate ()
        {
            if (String.IsNullOrEmpty(_name))
                return "Name cannot be empty.";

            //Price >= 0
            if (_price < 0)
                return "Price must be >= 0";

            return "";
        }

        // not local variables, they are fields. outside of functions it is a field
        private string _name;
        private string _description;
        private decimal _price;
        private bool _isDiscontinued;
    }
}
