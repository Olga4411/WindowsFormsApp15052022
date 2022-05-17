
namespace WindowsFormsApp15052022
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
            this.bt_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trB_red = new System.Windows.Forms.TrackBar();
            this.trB_green = new System.Windows.Forms.TrackBar();
            this.trB_blue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trB_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trB_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trB_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(21, 305);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 0;
            this.bt_start.Text = "START";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(139, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(207, 43);
            this.progressBar1.TabIndex = 2;
            // 
            // trB_red
            // 
            this.trB_red.Location = new System.Drawing.Point(361, 96);
            this.trB_red.Maximum = 255;
            this.trB_red.Name = "trB_red";
            this.trB_red.Size = new System.Drawing.Size(289, 40);
            this.trB_red.TabIndex = 0;
            this.trB_red.TickFrequency = 10;
            this.trB_red.Scroll += new System.EventHandler(this.trB_red_Scroll);
            // 
            // trB_green
            // 
            this.trB_green.Location = new System.Drawing.Point(361, 164);
            this.trB_green.Maximum = 255;
            this.trB_green.Name = "trB_green";
            this.trB_green.Size = new System.Drawing.Size(289, 40);
            this.trB_green.TabIndex = 3;
            this.trB_green.TickFrequency = 10;
            this.trB_green.Scroll += new System.EventHandler(this.trB_green_Scroll);
            // 
            // trB_blue
            // 
            this.trB_blue.Location = new System.Drawing.Point(361, 220);
            this.trB_blue.Maximum = 255;
            this.trB_blue.Name = "trB_blue";
            this.trB_blue.Size = new System.Drawing.Size(289, 40);
            this.trB_blue.TabIndex = 4;
            this.trB_blue.TickFrequency = 10;
            this.trB_blue.Scroll += new System.EventHandler(this.trB_blue_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "RED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "GREEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "BLUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trB_blue);
            this.Controls.Add(this.trB_green);
            this.Controls.Add(this.trB_red);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trB_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trB_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trB_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trB_red;
        private System.Windows.Forms.TrackBar trB_green;
        private System.Windows.Forms.TrackBar trB_blue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

