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
     
    public partial class Form1 : Form
    {
        private List<User> user = new List<User>();

        public Form1()
        {
            InitializeComponent();

            BackColor = Color.Brown;

            User user1 = new User("hamza","123");
            User user2 = new User("aws", "123");

            user.Add(user1);
            user.Add(user2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            
            foreach(User user in user)
            {
                if (username == user.UserName || password == user.password)
                {
                   Menu menu = new Menu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show(" The user name or passwprd incorect ");
                }
            }
        }
    }
}
