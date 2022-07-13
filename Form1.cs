using ShopDemo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopDemo
{
    public partial class Form1 : Form
    {
        private Store _store = new Store();
        private List<Item> ShoppingCartData = new List<Item>();
        BindingSource cartBinding = new BindingSource();
        BindingSource itemsBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;
        public Form1()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = _store.Items.Where(x => x.Sold == false).ToList();
            ItemListBox.DataSource = itemsBinding;

            ItemListBox.DisplayMember = "Display";
            ItemListBox.ValueMember = "Display";

            cartBinding.DataSource = ShoppingCartData;
            ShoppingCartListBox.DataSource = cartBinding;

            ShoppingCartListBox.DisplayMember = "Display";
            ShoppingCartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = _store.Vendors;
            VendorsListbox.DataSource = vendorsBinding;

            VendorsListbox.DisplayMember = "Display";
            VendorsListbox.ValueMember = "Display";
        }
        private void SetupData()
        {

            _store.Vendors.Add(new Vendor { firstName = "İbrahim", lastName = "newq" });
            _store.Vendors.Add(new Vendor { firstName = "Türkay", lastName = "Shorty" });

            _store.Items.Add(new Item
            {
                Title = "Slaves",
                Description = "a book of Isaac Bashevis Singer",
                Price = 10.5M,
                Owner = _store.Vendors[0]
            });

            _store.Items.Add(new Item
            {
                Title = "Enemies",
                Description = "A book of Isaac Bashevis Singer",
                Price = 29.99M,
                Owner = _store.Vendors[1]
            });

            _store.Items.Add(new Item
            {
                Title = "I, Cladius",
                Description = "A book about roman empire",
                Price = 57.88M,
                Owner = _store.Vendors[0]
            });
            _store.Items.Add(new Item
            {
                Title = "Collections 1",
                Description = "A collection of Nazım Hikmet works",
                Price = 100.00M,
                Owner = _store.Vendors[1]
            });

            _store.Name = "Seconds are better!";


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            /// Figure out what is selected from the item list
            /// Copy that item to the shopping cart
            /// Do we remowe the item from the items list? - No
            Item selectedItem = (Item)ItemListBox.SelectedItem;

            //MessageBox.Show(selectedItem.Title);
            ShoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            // Mark each item in the chart as sold.
            // Clear the cart

            foreach (Item item in ShoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;

            }

            ShoppingCartData.Clear();

            itemsBinding.DataSource = _store.Items.Where(x => x.Sold == false).ToList();
            StoreProfitValue.Text = string.Format("${0}", storeProfit);
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }
    }
}
