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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //PlayingwithProductMembers();
            /*
            //Product p; // shows the product automatically

            var product = new Product();

            //var name = product.GetName(); //can now manipulate the value
            //product.Name = "Product A";
            //product.SetName("Product A"); // sets a name for product A
            //product.Description = "None";
            var error = product.Validate();

            var str = product.ToString();

            var productB = new Product();
            //productB.Name = "Product B";
            //product.SetName("Product B"); // sets a name for product B
            //productB.Description = product.Description;
            error = productB.Validate();
            */
        }

        private void PlayingwithProductMembers ()
        {
            var product = new Product();

            Decimal.TryParse("123", out decimal _price); // product.Price doesn't work because it is a getter or a setter

            var name = product.Name; // in the case of a read it will call the (?)
            product.Name = "Product A";

            product.Price = 50;
            product.IsDiscontinued = true;
            //product.ActualPrice = 10;
                // these here were the naming issues, I think
            var price2 = product.ActualPrice;

            var error = product.Validate();

            var str = product.ToString();

            var productB = new Product();

            //product.SetName("Product B"); // sets a name for product B

            error = productB.Validate();
        }

        private void _miProductAdd_Click( object sender, EventArgs e ) // your version of OnProductAdd
        {
            var button = sender as ToolStripMenuItem; // ?
            //MessageBox.Show(this, "Not implemented", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var form = new ProductDetailForm();
            form.Text = "Add Product";

            //show form modally (or modelessly.) Takes ctrl
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            //TODO
            _product = form.Product;
        }

        /*
        // no name
        private void OnFileExit ( object sender, EventArgs e ) // your version of OnProductExit
        {
            Close();
        }
        */

        private void aboutToolStripMenuItem_Click( object sender, EventArgs e ) // ABOUT
        {
            MessageBox.Show(this, "Not implemented", "Help about", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void _miProductEdit_Click( object sender, EventArgs e ) // EDIT, your own OnProductEdit
        {
            //MessageBox.Show(this, "Not implemented", "Product edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (_product == null)
                return;

            var form = new ProductDetailForm();
            form.Text = "Edit Product";
            form.Product = _product;

            //show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            //"editing" the product
            _product = form.Product;
        }

        private void _miProductRemove_Click( object sender, EventArgs e ) // REMOVE
        {
            if (!ShowConfirmation("Are you sure?", "Remove product")) // displays nothing after clicking no
            return;

            //"deleting" the product
            _product = null; // "removes" the product
        }

        private void _miExit_Click( object sender, EventArgs e ) // EXIT
        {
            //MessageBox.Show(this, "Not implemented", "File Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Close();
        }
        private void OnHelpAbout( object sender, EventArgs e )// ABOUT but did not appear ealier upon double-clicking
        {
            MessageBox.Show(this, "Not implemented", "About", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Close();
        }
        private bool ShowConfirmation ( string message, string title )
        {
            return (MessageBox.Show(this, message, title,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes); // if confirmation returns true then falsa
        }
        private Product _product;
    }
}
