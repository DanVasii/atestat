using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat
{
    public partial class UserControl3 : UserControl
    {
        //int tlpRow = -1;

        public UserControl3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            addClass class_add = new addClass();
            class_add.Dock = DockStyle.Fill;
            

            addProf prof_add = new addProf();
            prof_add.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(prof_add);
            splitContainer1.Panel2.Controls.Add(class_add);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls["addProf"].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //here we show the addclass uc
            splitContainer1.Panel2.Controls["addClass"].BringToFront();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
