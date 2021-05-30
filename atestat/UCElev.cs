using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat
{
    public partial class UCElev : UserControl
    {
        public Context ctx;

        public UCElev()
        {
            InitializeComponent();
        }

        public void set_context(Context c)
        {
            ctx = c;
        }

        private void UCElev_Load(object sender, EventArgs e)
        {
            UCclaselemele ucClase = new UCclaselemele();
            ucClase.Dock = DockStyle.Fill;

            UCcatalog ucCatalog = new UCcatalog();
            ucCatalog.Dock = DockStyle.Fill;

            UCanunturi ucAnunt = new UCanunturi();
            ucAnunt.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(ucClase);
            splitContainer1.Panel2.Controls.Add(ucCatalog);
            splitContainer1.Panel2.Controls.Add(ucAnunt);
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls["UCcatalog"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls["UCanunturi"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls["UCclaselemele"].BringToFront();
        }
    }
}
