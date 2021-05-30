using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace atestat
{


    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        static Form1 _obj;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return pnlMare; }
            set { pnlMare = value; }
            
        }

        public Button BackButton
        {
            get { return backButton; }
            set { backButton = value; }
        }

        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender,EventArgs e)
        {
            splitContainer1.Parent = pnlMare;
            pictureBox1.Parent = splitContainer1.Panel1;
            pictureBox2.Parent = splitContainer1.Panel2;

            
            btnElev.Parent = pictureBox2;
            btnElev.BackColor = Color.Transparent;
            btnElev.FlatAppearance.BorderSize = 0;
            btnElev.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btnProf.Parent = pictureBox1;
            btnProf.BackColor = Color.Transparent;
            btnProf.FlatAppearance.BorderSize = 0;
            btnProf.FlatAppearance.MouseOverBackColor = Color.Transparent;

            backButton.Visible = false;

            _obj = this;
            UCLoginElev uc = new UCLoginElev();
            uc.Dock = DockStyle.Fill;
            pnlMare.Controls.Add(uc);

            
        }

        private void ctrlPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {     
            if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
        
        private void btnProf_Click(object sender, EventArgs e)
        {

        }

        private void btnElev_Click(object sender, EventArgs e)
        {
            pnlMare.Controls["UCLoginElev"].BringToFront();
            
            backButton.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlMare.Controls["UCLoginElev"].SendToBack();
            backButton.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
