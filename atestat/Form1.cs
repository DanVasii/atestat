using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace atestat
{
    public partial class Form1 : Form
    {
        Context c = new Context();
        public Form1()
        {
            userManager um = new userManager();
        
          
                um.init();
                um.login_user("Costin", "vostin");
       
            InitializeComponent();
        }
        private void Form1_Load(object sender,EventArgs e)
        {
            c.set(panel1);

            UserControl1 login_elev = new UserControl1();
            login_elev.set_context(c);
            login_elev.Dock = DockStyle.Fill;
            panel1.Controls.Add(login_elev);

            UserControl3 panel_admin = new UserControl3();
            panel_admin.Dock = DockStyle.Fill;
            panel1.Controls.Add(panel_admin);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            panel1.Controls["UserControl3"].BringToFront();
         
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                var p = new Pen(Color.Black, 3);
                var point1 = new Point(234, 118);
                var point2 = new Point(293, 228);
                g.DrawLine(p, point1, point2);
            }
        }

        private void button_woc2_Click(object sender, EventArgs e)
        {
            panel1.Controls["UserControl1"].BringToFront();
        }
    }
}
