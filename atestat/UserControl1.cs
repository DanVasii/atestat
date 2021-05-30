using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atestat
{
    public partial class UCLoginElev : UserControl
    {
       

        

        public UCLoginElev()
        {
            InitializeComponent();
        }

        private void UCElev_Load(object sender, EventArgs e)
        {
            MySqlConnection conn;

            btnLogin.Parent = panel1;
            
            label1.Parent = panel1;
            label2.Parent = panel1;
            label3.Parent = panel1;
            textBox1.Parent = panel1;
            textBox2.Parent = panel1;

            string connstring = @"server=localhost;userid=root;password=;database=atestat";
            try
            {
                conn = new MySqlConnection(connstring);

                String query = "SELECT * FROM test";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                System.Data.DataSet ds = new DataSet();

                da.Fill(ds, "test");

                DataTable dt = ds.Tables["test"];

                label1.Text = dt.Rows[0][1].ToString();

            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Connection error");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UCtest ucc = new UCtest();
            UCElev uc = new UCElev();
            ucc.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucc);

            //string correctUser = "gigi";
           // string correctPass = "1234";

            string userid = textBox1.Text;
            string password = textBox2.Text;

            /*if(userid == correctUser && password == correctPass)
            {

                panel1.Controls["UCElev"].BringToFront();
            }*/

            panel1.Controls["UCtest"].BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
