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
            var price2 = product.ActualPrice;

            var error = product.Validate();

            var str = product.ToString();

            var productB = new Product();

            //product.SetName("Product B"); // sets a name for product B

            error = productB.Validate();
        }

        private void _miProductAdd_Click( object sender, EventArgs e ) // add
        {
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

        private void aboutToolStripMenuItem_Click( object sender, EventArgs e ) // about
        {
            MessageBox.Show(this, "Not implemented", "Help about", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void _miProductEdit_Click( object sender, EventArgs e ) // edit
        {
            MessageBox.Show(this, "Not implemented", "Product edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void _miProductRemove_Click( object sender, EventArgs e ) // remove
        {
            if (!ShowConfirmation("Are you sure?", "Remove product")) // displays nothing after clicking no
            return;
            MessageBox.Show("Not implemented"); // if clicking yes when asked to be sure, this displays
        }

        private void _miExit_Click( object sender, EventArgs e ) // exit
        {
            MessageBox.Show(this, "Not implemented", "File Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        private void OnHelpAbout( object sender, EventArgs e )// About but did not appear ealier upon double-clicking
        {
            MessageBox.Show(this, "Not implemented", "About", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
