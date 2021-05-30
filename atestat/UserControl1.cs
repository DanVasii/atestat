using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat
{
    public partial class UserControl1 : UserControl
    {
        public Context ctx;
        public userManager um = new userManager();
        public UserControl1()
        {
            InitializeComponent();
        }
        public void set_context(Context c)
        {
            ctx = c;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
        
        }
        protected override void OnPaint(PaintEventArgs e)
        {
          
           
        }
        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login button 
            um.init();
            int logged = um.login_user(textBox1.Text, textBox2.Text);
            if (logged!=0)
            {
                //this is true then change the tex 
                label3.Text = "Logged in success!";
                ctx.set_logged(logged);
                ctx.show();
            }
            else
            {
                label3.Text = "There is an error";
            }
            
            um.close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
