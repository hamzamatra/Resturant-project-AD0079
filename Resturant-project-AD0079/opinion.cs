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
    public partial class opinion : Form
    {
        public opinion()
        {
            InitializeComponent();
        }

        private void btnaddopinion_Click(object sender, EventArgs e)
        {
              lblopinion.Text = txtopinion.Text;
        }

        private void btnclearopinion_Click(object sender, EventArgs e)
        {
            txtopinion.Text = "";
            lblopinion.Text = "";
        }
    }
}
