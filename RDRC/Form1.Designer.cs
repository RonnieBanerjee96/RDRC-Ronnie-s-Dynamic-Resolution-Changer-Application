namespace RDRC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_cr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_sr = new System.Windows.Forms.Label();
            this.label_sh = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_sw = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label_file = new System.Windows.Forms.Label();
            this.button_launch = new System.Windows.Forms.Button();
            this.label_startfreq_number = new System.Windows.Forms.Label();
            this.label_startfreq = new System.Windows.Forms.Label();
            this.label_selectedfreq_number = new System.Windows.Forms.Label();
            this.label_selectfreq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Resolutions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "123";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Apply Resolution";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Display Details:";
            // 
            // label_cr
            // 
            this.label_cr.AutoSize = true;
            this.label_cr.Location = new System.Drawing.Point(277, 42);
            this.label_cr.Name = "label_cr";
            this.label_cr.Size = new System.Drawing.Size(97, 13);
            this.label_cr.TabIndex = 1;
            this.label_cr.Text = "Current Resolution:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Height:";
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(12, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(244, 381);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Width";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Height";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Refresh Rate";
            this.columnHeader3.Width = 70;
            // 
            // label_sr
            // 
            this.label_sr.AutoSize = true;
            this.label_sr.Location = new System.Drawing.Point(275, 136);
            this.label_sr.Name = "label_sr";
            this.label_sr.Size = new System.Drawing.Size(105, 13);
            this.label_sr.TabIndex = 1;
            this.label_sr.Text = "Selected Resolution:";
            // 
            // label_sh
            // 
            this.label_sh.AutoSize = true;
            this.label_sh.Location = new System.Drawing.Point(356, 180);
            this.label_sh.Name = "label_sh";
            this.label_sh.Size = new System.Drawing.Size(25, 13);
            this.label_sh.TabIndex = 1;
            this.label_sh.Text = "123";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Width:";
            // 
            // label_sw
            // 
            this.label_sw.AutoSize = true;
            this.label_sw.Location = new System.Drawing.Point(356, 158);
            this.label_sw.Name = "label_sw";
            this.label_sw.Size = new System.Drawing.Size(25, 13);
            this.label_sw.TabIndex = 2;
            this.label_sw.Text = "123";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Height:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_file
            // 
            this.label_file.AutoSize = true;
            this.label_file.Location = new System.Drawing.Point(277, 327);
            this.label_file.Name = "label_file";
            this.label_file.Size = new System.Drawing.Size(95, 13);
            this.label_file.TabIndex = 6;
            this.label_file.Text = "Select Application:";
            // 
            // button_launch
            // 
            this.button_launch.Location = new System.Drawing.Point(278, 364);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(160, 23);
            this.button_launch.TabIndex = 5;
            this.button_launch.Text = "Launch";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // label_startfreq_number
            // 
            this.label_startfreq_number.AutoSize = true;
            this.label_startfreq_number.Location = new System.Drawing.Point(356, 113);
            this.label_startfreq_number.Name = "label_startfreq_number";
            this.label_startfreq_number.Size = new System.Drawing.Size(25, 13);
            this.label_startfreq_number.TabIndex = 1;
            this.label_startfreq_number.Text = "123";
            // 
            // label_startfreq
            // 
            this.label_startfreq.AutoSize = true;
            this.label_startfreq.Location = new System.Drawing.Point(276, 113);
            this.label_startfreq.Name = "label_startfreq";
            this.label_startfreq.Size = new System.Drawing.Size(73, 13);
            this.label_startfreq.TabIndex = 2;
            this.label_startfreq.Text = "Refresh Rate:";
            // 
            // label_selectedfreq_number
            // 
            this.label_selectedfreq_number.AutoSize = true;
            this.label_selectedfreq_number.Location = new System.Drawing.Point(357, 202);
            this.label_selectedfreq_number.Name = "label_selectedfreq_number";
            this.label_selectedfreq_number.Size = new System.Drawing.Size(25, 13);
            this.label_selectedfreq_number.TabIndex = 1;
            this.label_selectedfreq_number.Text = "123";
            // 
            // label_selectfreq
            // 
            this.label_selectfreq.AutoSize = true;
            this.label_selectfreq.Location = new System.Drawing.Point(277, 202);
            this.label_selectfreq.Name = "label_selectfreq";
            this.label_selectfreq.Size = new System.Drawing.Size(73, 13);
            this.label_selectfreq.TabIndex = 2;
            this.label_selectfreq.Text = "Refresh Rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.label_file);
            this.Controls.Add(this.button_launch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_selectfreq);
            this.Controls.Add(this.label_startfreq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_sw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_sr);
            this.Controls.Add(this.label_selectedfreq_number);
            this.Controls.Add(this.label_sh);
            this.Controls.Add(this.label_startfreq_number);
            this.Controls.Add(this.label_cr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RDRC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_cr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label_sr;
        private System.Windows.Forms.Label label_sh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_sw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_file;
        private System.Windows.Forms.Button button_launch;
        private System.Windows.Forms.Label label_startfreq_number;
        private System.Windows.Forms.Label label_startfreq;
        private System.Windows.Forms.Label label_selectedfreq_number;
        private System.Windows.Forms.Label label_selectfreq;
    }
}

