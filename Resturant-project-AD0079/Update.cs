﻿using System;
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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void btnaddfood_Click(object sender, EventArgs e)
        {
            lstmenu.Items.Add(txtaddfood.Text);
        }

        private void btnadddrinks_Click(object sender, EventArgs e)
        {
            lstDrinks.Items.Add(txtadddrinks.Text);
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            txtaddfood.Text = "";
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            txtadddrinks.Text = "";
        }
    }
}
