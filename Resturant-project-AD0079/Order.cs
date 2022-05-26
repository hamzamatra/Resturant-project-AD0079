using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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
            //try
            //{
            //    string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\assignment_visual programing\\data-base";
            //    OleDbConnection connection = new OleDbConnection(connectionstring);

            //    string commandstring = "select * form Resturant ";
            //    OleDbCommand command = new OleDbCommand(commandstring, connection);

            //    OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            //    DataTable table = new DataTable();
            //    adapter.Fill(table);
            //    dataGridView1.DataSource = table;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:D:\\assignment_visual programing\\data-base";
            OleDbConnection connection = new OleDbConnection(connectionstring);

            string commandstring = "select * form Resturant ";
            OleDbCommand command = new OleDbCommand(commandstring, connection);

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            this.BackColor = Color.White;
        }

        private void btnchoosefood_Click(object sender, EventArgs e)
        {
           // txtchoosemenu.Text = lstmenu.SelectedItem.ToString();   
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            //txtDrinks.Text = lstDrinks.SelectedItem.ToString();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            txtchoosemenu.Text = null;
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            //tDrinks.Text = null;
        }
    }
}
