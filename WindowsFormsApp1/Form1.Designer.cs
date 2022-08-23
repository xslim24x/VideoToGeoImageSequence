namespace WindowsFormsApp1
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
            this.openfile = new System.Windows.Forms.Button();
            this.latitude = new System.Windows.Forms.Label();
            this.longnitude = new System.Windows.Forms.Label();
            this.lat = new System.Windows.Forms.TextBox();
            this.logn = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(56, 49);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(98, 41);
            this.openfile.TabIndex = 0;
            this.openfile.Text = "Open File";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // latitude
            // 
            this.latitude.AutoSize = true;
            this.latitude.Location = new System.Drawing.Point(53, 174);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(59, 17);
            this.latitude.TabIndex = 1;
            this.latitude.Text = "Latitude";
            this.latitude.Click += new System.EventHandler(this.lat_Click);
            // 
            // longnitude
            // 
            this.longnitude.AutoSize = true;
            this.longnitude.Location = new System.Drawing.Point(56, 241);
            this.longnitude.Name = "longnitude";
            this.longnitude.Size = new System.Drawing.Size(79, 17);
            this.longnitude.TabIndex = 2;
            this.longnitude.Text = "Longnitude";
            this.longnitude.Click += new System.EventHandler(this.long_Click);
            // 
            // lat
            // 
            this.lat.Location = new System.Drawing.Point(209, 174);
            this.lat.Name = "lat";
            this.lat.Size = new System.Drawing.Size(157, 22);
            this.lat.TabIndex = 3;
            this.lat.TextChanged += new System.EventHandler(this.lat_TextChanged);
            // 
            // logn
            // 
            this.logn.Location = new System.Drawing.Point(209, 241);
            this.logn.Name = "logn";
            this.logn.Size = new System.Drawing.Size(157, 22);
            this.logn.TabIndex = 4;
            this.logn.TextChanged += new System.EventHandler(this.logn_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(56, 339);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 5;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.logn);
            this.Controls.Add(this.lat);
            this.Controls.Add(this.longnitude);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.Label longnitude;
        private System.Windows.Forms.TextBox lat;
        private System.Windows.Forms.TextBox logn;
        private System.Windows.Forms.Button submit;
    }
}

