using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopManegementSystemCSharp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer obj = new Customer();
            obj.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee obj1 = new Employee();
            obj1.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product obj2 = new Product();
            obj2.ShowDialog();
        }

        private void addCoffeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCoffee obj3 = new AddCoffee();
            obj3.ShowDialog();
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceOrder obj4 = new PlaceOrder();
            obj4.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete obj5 = new Delete();
            obj5.ShowDialog();
        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report obj6 = new Report();
            obj6.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj7 = new Form1();
            obj7.ShowDialog();

           

        }
    }
}
