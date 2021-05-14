using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atestat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender,EventArgs e)
        {
            UserControl1 login_elev = new UserControl1();
            login_elev.Dock = DockStyle.Fill;
            panel1.Controls.Add(login_elev);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_woc1_Click(object sender, EventArgs e)
        {
            panel1.Controls["UserControl1"].BringToFront();
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
    }
}
