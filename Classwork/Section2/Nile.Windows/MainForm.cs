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
    }
}
