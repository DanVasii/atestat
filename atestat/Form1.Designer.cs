
using System;

namespace atestat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_woc2 = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_woc2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.button_woc1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(987, 524);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_woc2
            // 
            this.button_woc2.BackColor = System.Drawing.Color.Transparent;
            this.button_woc2.BorderColor = System.Drawing.Color.Silver;
            this.button_woc2.ButtonColor = System.Drawing.Color.Red;
            this.button_woc2.FlatAppearance.BorderSize = 0;
            this.button_woc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_woc2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_woc2.Location = new System.Drawing.Point(160, 235);
            this.button_woc2.Name = "button_woc2";
            this.button_woc2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_woc2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_woc2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_woc2.Size = new System.Drawing.Size(155, 57);
            this.button_woc2.TabIndex = 1;
            this.button_woc2.Text = "Profesor";
            this.button_woc2.TextColor = System.Drawing.Color.White;
            this.button_woc2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_woc1
            // 
            this.button_woc1.BackColor = System.Drawing.Color.Transparent;
            this.button_woc1.BorderColor = System.Drawing.Color.Red;
            this.button_woc1.ButtonColor = System.Drawing.Color.Red;
            this.button_woc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_woc1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_woc1.Location = new System.Drawing.Point(160, 235);
            this.button_woc1.Name = "button_woc1";
            this.button_woc1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_woc1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_woc1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_woc1.Size = new System.Drawing.Size(155, 57);
            this.button_woc1.TabIndex = 2;
            this.button_woc1.Text = "Elev";
            this.button_woc1.TextColor = System.Drawing.Color.White;
            this.button_woc1.UseVisualStyleBackColor = false;
            this.button_woc1.Click += new System.EventHandler(this.button_woc1_Click);
          
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 524);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 524);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Window_event);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }


        private void Window_event(object sender, EventArgs e)
        {
            //now we should resize all the components
            this.pictureBox1.Size = new System.Drawing.Size(this.Width/2,this.Height);
            this.pictureBox2.Size = new System.Drawing.Size(this.Width / 2, this.Height);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public int screen_width = 0;
        public int screen_height = 0;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private ePOSOne.btnProduct.Button_WOC button_woc2;
    }
}

