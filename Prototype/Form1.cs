using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Screen : Form
    {
        public Screen()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void groepenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGroups();
        }

        private void profielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOwnProfile();
        }



        //Panel 1
        private void ShowOwnProfile()
        {
            panel1.Visible = true;
        }

        //Panel 2
        private void ShowOtherProfile()
        {

        }

        //Panel 3
        private void ShowGroup()
        {

        }

        //Panel 4
        private void ShowGroups()
        {
            
        }

        //Close all open windows
        private void CloseScreen()
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
