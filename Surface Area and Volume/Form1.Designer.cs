namespace Surface_Area_and_Volume
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxRadius = new System.Windows.Forms.TextBox();
            this.textBoxRadiusV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ButtonCl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxRadius
            // 
            this.txtBxRadius.Location = new System.Drawing.Point(136, 139);
            this.txtBxRadius.Name = "txtBxRadius";
            this.txtBxRadius.Size = new System.Drawing.Size(100, 20);
            this.txtBxRadius.TabIndex = 0;
            // 
            // textBoxRadiusV
            // 
            this.textBoxRadiusV.Location = new System.Drawing.Point(322, 139);
            this.textBoxRadiusV.Name = "textBoxRadiusV";
            this.textBoxRadiusV.Size = new System.Drawing.Size(100, 20);
            this.textBoxRadiusV.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Radius";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(133, 171);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(46, 13);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "\'Answer\'";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Surface Area";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Radius";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(349, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Volume";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(319, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "\'Answer\'";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Surface_Area_and_Volume.Properties.Resources.sphere;
            this.pictureBox2.Location = new System.Drawing.Point(447, 256);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 191);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(504, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "Sphere";
            // 
            // ButtonCl
            // 
            this.ButtonCl.Location = new System.Drawing.Point(241, 232);
            this.ButtonCl.Name = "ButtonCl";
            this.ButtonCl.Size = new System.Drawing.Size(86, 23);
            this.ButtonCl.TabIndex = 10;
            this.ButtonCl.Text = "CALCULATE";
            this.ButtonCl.UseVisualStyleBackColor = true;
            this.ButtonCl.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(660, 471);
            this.Controls.Add(this.ButtonCl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxRadiusV);
            this.Controls.Add(this.txtBxRadius);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBxRadius;
        private System.Windows.Forms.TextBox textBoxRadiusV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ButtonCl;
    }
}

