using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atestat
{
    public partial class UCclaselemele : UserControl
    {
        public UCclaselemele()
        {
            InitializeComponent();
        }

        private void UCclaselemele_Load(object sender, EventArgs e)
        {
            Label label1, label2, label3;
            PictureBox pb1;



            for( int i = 1 ; i <= 10 ; i++)
            {
                label1 = new Label();
                label2 = new Label();
                label3 = new Label();
                pb1 = new PictureBox();

                Panel parent1 = new Panel();
                parent1.SuspendLayout();
                parent1.Controls.Add(label1);
                parent1.Controls.Add(label2);
                parent1.Controls.Add(label3);
                parent1.Controls.Add(pb1);
                parent1.Size = new System.Drawing.Size(230, 200);

                parent1.BackColor = Color.LightSteelBlue;
                
                pb1.Location = new System.Drawing.Point(0, 0);
                pb1.Name = "pictureBox1";
                pb1.Size = new System.Drawing.Size(230, 120);
                pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                label2.Name = "label1";
                label1.AutoSize = true;
                label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                label1.Location = new System.Drawing.Point(10, 125);
                label1.Size = new System.Drawing.Size(52, 21);
                label1.TabIndex = 3;
                label1.Text = "label1";

                label2.Name = "label2";
                label2.AutoSize = true;
                label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                label2.Location = new System.Drawing.Point(10, 144);
                label2.Size = new System.Drawing.Size(52, 21);
                label2.TabIndex = 3;
                label2.Text = "label2";

                label3.Name = "label3";
                label3.AutoSize = true;
                label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                label3.Location = new System.Drawing.Point(10, 167);
                label3.Size = new System.Drawing.Size(52, 21);
                label3.TabIndex = 3;
                label3.Text = "label3";

                parent1.ResumeLayout();

                flowLayoutPanel1.Controls.Add(parent1);
            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
