using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_project_AD0079
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void btnchoosefood_Click(object sender, EventArgs e)
        {
            txtchoosemenu.Text = lstmenu.SelectedItem.ToString();   
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            txtDrinks.Text = lstDrinks.SelectedItem.ToString();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            txtchoosemenu.Text = null;
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            txtDrinks.Text = null;
        }
    }
}
