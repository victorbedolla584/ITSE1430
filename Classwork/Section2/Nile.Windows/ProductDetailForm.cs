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
    public /*abstract*/ partial class ProductDetailForm : Form
    {
        #region Construction

        public ProductDetailForm()
        {
            InitializeComponent();
        }

        public ProductDetailForm( string title) : this() //: base()
        {
            //InitializeComponent();

            Text = title; // assigns title to the text
        }

        public ProductDetailForm( Product product ) :this("Edit Product")
        {
            //InitializeComponent();
            //Text = "Edit Product";

            Product = product; // or is it just product with a lowercase p?
        }
        #endregion
        //
        //some lines misplaced and belong in other files, ask to see something to use to fix in your own time
        //

        public Product Product { get; set; }

        //public abstract partial class DialogResult ShowDialogEx();

        /*
        public virtual DialogResult ShowDialogEx () // is something missing from earlier?
        {
            return ShowDialog();
        }
        */
        protected override void OnLoad( EventArgs e )
        {
            //Call base type
            //OnLoad(e);
            base.OnLoad(e);
            
            //load product
            if (this.Product != null) { // can also use the keyword 'this'
                _name.Text = Product.Name; // they must be your field names
                                           //System.NullReferenceException: 'Object reference not set to an instance of an object.'
                _description.Text = Product.Description;
                _price.Text = Product.Price.ToString();
                _discontinued.Checked = Product.IsDiscontinued; // always remember to check your field names
            };
            /*
             * var price2 = product.ActualPrice;

            var error = product.Validate();

            var str = product.ToString();

            var productB = new Product();
             */
            ValidateChildren();
        }

        private void _buttonCancel_Click( object sender, EventArgs e ) // from cancel button
        {
        }
        
        private void _buttonSave_Click( object sender, EventArgs e ) // from save button
        {
            //force validation of child controls
            if (!ValidateChildren())
                return;
            // Create product
            var product = new Product();
            // check ProductDetailForm.Designer.cs for some of these
            product.Name = _name.Text; // interacts with name text boc
            product.Description = _description.Text; // interacts with desciption text box
            product.Price = ConvertToPrice(_price); // interacts with price text box
            product.IsDiscontinued = _discontinued.Checked; // interacts with discontinued checkbox
                                                            // be consistent with names, make them simple and descriptive, these were all the names
                                                            // taken directly from ProductDetailForm.cs[Design]

            //validate
                //always validate yourself, never leave it up to user interface
            var message = product.Validate();
            if (!String.IsNullOrEmpty(message))
            {
                //_errorProvider.SetError(_name, message); // names must be wrong
                DisplayError(message);
                return;
            }

            //return from form
            Product = product;
            DialogResult = DialogResult.OK;

            // setting this to None will prevent close if needed
            //DialogResult = DialogResult.None;
            // both mostly do the same
            Close(); // save button should now be working correctly
        }

        private void DisplayError (string message )
        {
            MessageBox.Show(this, message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private decimal ConvertToPrice (TextBox control )
        {
            if (Decimal.TryParse(control.Text, out var price))
                return price;

            return -1;
        }

        private void _name_Validating (object sender, System.ComponentModel.CancelEventArgs)
            {
            var textbox = sender as TextBox;

            if (String.IsNullOrEmpty(textbox.Text))
            {
                _errorProvider.SetError(textbox, "Name is required");
                e.Cancel = true;
            } else
                _errorProvider.SetError
        }

        private void _Price_Validating( object sender, System.ComponentModel.CancelEventArgs)
            {
            var textbox = sender as TextBox;

            var price = ConvertToPrice(textbox);
            if ()
                _error
        }

        private void _checkIsDiscontinued_TextChanged( object sender, EventArgs e )
        {

        }
    }
}