using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class ProductDetailForm : Form
    {
        public ProductDetailForm()
        {
            InitializeComponent();
        }

        public Product Product { get; set; }
        
        private void _buttonCancel_Click( object sender, EventArgs e ) // from cancel button
        {
        }
        
        private void _buttonSave_Click( object sender, EventArgs e ) // from save button
        {
            // Create product
            var product = new Product();
            // check ProductDetailForm.Designer.cs for some of these
            product.Name = _name.Text; // interacts with name text boc
            product.Description = _description.Text; // interacts with desciption text box
            product.Price = ConvertToPrice(_price); // interacts with price text box
            product.IsDiscontinued = _discontinued.Checked; // interacts with discontinued checkbox
            // be consistent with names, make them simple and descriptive, these were all the names
            // taken directly from ProductDetailForm.cs[Design]



            //return fro mform
            Product = product;

            DialogResult = DialogResult.OK;
            //DialogResult = DialogResult.None; // both mostly do the same
            Close(); // save button should now be working correctly
        }

        private decimal ConvertToPrice (TextBox control )
        {
            if (Decimal.TryParse(control.Text, out var price))
                return price;

            return -1;
        }

        private void _checkIsDiscontinued_TextChanged( object sender, EventArgs e )
        {

        }
    }
}