
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
            this.btnProf = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnElev = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMare = new System.Windows.Forms.Panel();
            this.ctrlPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMare.SuspendLayout();
            this.ctrlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnProf);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnElev);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(984, 535);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnProf
            // 
            this.btnProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProf.BackColor = System.Drawing.Color.Transparent;
            this.btnProf.BorderColor = System.Drawing.Color.Red;
            this.btnProf.ButtonColor = System.Drawing.Color.Red;
            this.btnProf.FlatAppearance.BorderSize = 0;
            this.btnProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProf.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProf.Location = new System.Drawing.Point(173, 252);
            this.btnProf.Name = "btnProf";
            this.btnProf.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnProf.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnProf.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnProf.Size = new System.Drawing.Size(155, 55);
            this.btnProf.TabIndex = 1;
            this.btnProf.Text = "Profesor";
            this.btnProf.TextColor = System.Drawing.Color.White;
            this.btnProf.UseVisualStyleBackColor = false;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // btnElev
            // 
            this.btnElev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnElev.BackColor = System.Drawing.Color.Transparent;
            this.btnElev.BorderColor = System.Drawing.Color.Red;
            this.btnElev.ButtonColor = System.Drawing.Color.Red;
            this.btnElev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElev.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnElev.Location = new System.Drawing.Point(173, 252);
            this.btnElev.Name = "btnElev";
            this.btnElev.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnElev.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnElev.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnElev.Size = new System.Drawing.Size(155, 55);
            this.btnElev.TabIndex = 2;
            this.btnElev.Text = "Elev";
            this.btnElev.TextColor = System.Drawing.Color.White;
            this.btnElev.UseVisualStyleBackColor = false;
            this.btnElev.Click += new System.EventHandler(this.btnElev_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(488, 535);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pnlMare
            // 
            this.pnlMare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMare.BackColor = System.Drawing.Color.Transparent;
            this.pnlMare.Controls.Add(this.splitContainer1);
            this.pnlMare.Location = new System.Drawing.Point(0, 25);
            this.pnlMare.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMare.Name = "pnlMare";
            this.pnlMare.Size = new System.Drawing.Size(984, 535);
            this.pnlMare.TabIndex = 1;
            // 
            // ctrlPanel
            // 
            this.ctrlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlPanel.BackColor = System.Drawing.Color.DarkGray;
            this.ctrlPanel.Controls.Add(this.backButton);
            this.ctrlPanel.Controls.Add(this.exitButton);
            this.ctrlPanel.Location = new System.Drawing.Point(0, 0);
            this.ctrlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlPanel.Name = "ctrlPanel";
            this.ctrlPanel.Size = new System.Drawing.Size(984, 25);
            this.ctrlPanel.TabIndex = 2;
            this.ctrlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctrlPanel_MouseDown);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.Location = new System.Drawing.Point(4, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "< Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::atestat.Properties.Resources.delete_48px;
            this.exitButton.Location = new System.Drawing.Point(960, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(24, 25);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 559);
            this.ControlBox = false;
            this.Controls.Add(this.ctrlPanel);
            this.Controls.Add(this.pnlMare);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Window_event);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMare.ResumeLayout(false);
            this.ctrlPanel.ResumeLayout(false);
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
        private ePOSOne.btnProduct.Button_WOC btnElev;
        private ePOSOne.btnProduct.Button_WOC btnProf;
        private System.Windows.Forms.Panel pnlMare;
        private System.Windows.Forms.Panel ctrlPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exitButton;
    }
}

