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
    public partial class Menu : Form
    {
        private string SHOWNAME;
        public Menu()
        {
            InitializeComponent();

            
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void txtshowusername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void lblshowname_Click(object sender, EventArgs e)
        {
            
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Mainmenu men = new Mainmenu();
            men.TopLevel = false;
            this.panel3.Controls.Add(men);
            men.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           Update udp = new Update();
            udp.TopLevel = false;
            this.panel3.Controls.Add(udp);
            udp.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear cle = new Clear();
            cle.TopLevel = false;
             this.panel3.Controls.Add(cle);
            cle.Show();
        }
    }
}
