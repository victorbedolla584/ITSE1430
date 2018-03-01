/*
 * ITSE 1430
 * Classwork
 */
using System;
using System.Windows.Forms;

//fix these dang errors

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

            //PlayingWithProductMembers();
            /*seed products
            _products = new Product[25];

            var product = new Product();
            product.Name = "iPhone X";
            product.IsDiscontinued = true;
            product.Price = 1500;
            _products[0] = product;

            var product = new Product();
            product.Name = "Windows Phone";
            product.IsDiscontinued = true;
            product.Price = 15;
            _products[1] = product;

            var product = new Product();
            product.Name = "Samsung S8";
            product.IsDiscontinued = false;
            product.Price = 800;
            _products[2] = product;
            */

            RefreshUI();
        }

        private void RefreshUI()
        {
            //get products
            var products = _database.GetAll();

            //bind to grid
            dataGridView1.DataSource = products;
        }

        private Product GetSelectedProduct ( )
        {
            if (dataGridView1.SelectedRows.Count > 0)
                return dataGridView1.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        //Just a method to play around with members of our Product class
        private void PlayingWithProductMembers()
        {
            //Create a new product
            var product = new Product();

            //Cannot use properties as out parameters
            Decimal.TryParse("123", out var price);
            product.Price = price;

            //Get the property Name, no need for a function
            var name = product.Name;
            //var name = product.GetName();

            //Set the property Name, Price and IsDiscontinued
            product.Name = "Product A";
            product.Price = 50;
            product.IsDiscontinued = true;

            //ActualPrice is calculated so you cannot set it
            //product.ActualPrice = 10;
            var price2 = product.ActualPrice;

            //product.SetName("Product A");
            //product.Description = "None";

            //Validate the product
            var error = product.Validate();

            //Convert anything to a string
            var str = product.ToString();

            //Create another product
            var productB = new Product();
            //productB.Name = "Product B";
            //productB.SetName("Product B");
            //productB.Description = product.Description;            

            //Validate the new product
            error = productB.Validate();
        }

        #region Event Handlers

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnProductAdd( object sender, EventArgs e )
        {
            var button = sender as ToolStripMenuItem;

            var form = new ProductDetailForm("Add Product");

            //Show form modally
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //add to database
            _database.Add(form.Product, out var message);
            if (!String.IsNullOrEmpty(message))
                MessageBox.Show(message);

            //"Add" the product
            //_product = form.Product;

            /*find empty array element
            for (var index = 0; index < _products.Length; ++index)
            {
                if (_products[index] == null)
                {
                    _products[index] = form.Product;
                    break;
                }
            }
            */
        }
        /*
        private int FindEmptyProductIndex ()
        {
            for (var index = 0; index < _products.Length; ++index)
            {
                if (_products[index] == null)
                    return index;
            };
            return -1;
        }
        */

        private void OnProductEdit( object sender, EventArgs e )
        {
            //get the first product
            var products = _database.GetAll();
            var product = (products.Length > 0) ? products[0] : null;
            if (product == null)
                return;

            var index = FindEmptyProductIndex() - 1;
            if (index < 0)
                return;

            //get the selected product

            // if (_product == null)
            //      return;

            var form = new ProductDetailForm(product);
            var result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;

            //"Editing" the product
            //_product = form.Product;
            _database.Edit(form.Product, out var message);
            if (!String.IsNullOrEmpty(message))
                MessageBox.Show(message);

            RefreshUI();
        }

        private void OnProductRemove( object sender, EventArgs e )
        {
            /*
            var index = FindEmptyProductIndex() - 1;
            if (index < 0)
                return;
                */

            //get the selected product
            var product = GetSelectedProoduct();
            if (product == null)
                return;
            /*
            //get the first product
            var products = _database.GetAll();
            var product = (products.Length > 0) ? products[0] : null;
            if (product == null)
                return;
                */
            if (!ShowConfirmation("Are you sure?", "Remove Product"))
                return;

            //Remove product
            _database.Remove(product.Id);
            //_products[index] = null;

            RefreshUI();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Not implemented", "Help About", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion

        private bool ShowConfirmation( string message, string title )
        {
            return MessageBox.Show(this, message, title
                             , MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                           == DialogResult.Yes;
        }

        private MemoryProductDatabase _database = new MemoryProductDatabase();

        private Product GetSelectedProoduct()
        {
            if (dataGridView)
        }
    }
}
