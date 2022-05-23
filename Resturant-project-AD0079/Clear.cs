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
    public partial class Clear : Form
    {
        public Clear()
        {
            InitializeComponent();
        }

        private void btnclearfood_Click(object sender, EventArgs e)
        {
            lstmenu.Items.RemoveAt(lstmenu.SelectedIndex);
        }

        private void btncleardrinks_Click(object sender, EventArgs e)
        {
            lstDrinks.Items.RemoveAt(lstDrinks.SelectedIndex);
        }
    }
}
