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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:D:\\assignment_visual programing\\data-base";
            OleDbConnection connection = new OleDbConnection(connectionstring);
            string commandstring = "Insert into Food (ID , Food)  Valuse('hotdog')";
            OleDbCommand command = new OleDbCommand(commandstring, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static Update getuodatefood(string food) 
        {
            Update update = new Update();
            string connectionstring = string.Format(" selcet * form food = {0}",food);
            OleDbCommand commandstring = new OleDbCommand(connectionstring );
            OleDbDataReader foodreder = commandstring.ExecuteReader();

            if (foodreder.HasRows)
            {
                while (foodreder.Read()) 
                {
                   update.Updatfood = foodreder.GetInt32(1);
                }
            }
            return update;
        }

        private void btnaddfood_Click(object sender, EventArgs e)
        {
            //lstmenu.Items.Add(txtaddfood.Text);
        }

        private void btnadddrinks_Click(object sender, EventArgs e)
        {
            //lstDrinks.Items.Add(txtadddrinks.Text);
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            txtaddfood.Text = "";
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
           //xtadddrinks.Text = "";
        }
    }
}
