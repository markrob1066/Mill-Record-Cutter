
namespace Mill_Record_Cutter
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
            this.file_open = new System.Windows.Forms.Button();
            this.gen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sample_rate = new System.Windows.Forms.TextBox();
            this.Dia = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.TextBox();
            this.safeHeight = new System.Windows.Forms.TextBox();
            this.feedRate = new System.Windows.Forms.TextBox();
            this.inFilename = new System.Windows.Forms.TextBox();
            this.excursion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // file_open
            // 
            this.file_open.Location = new System.Drawing.Point(43, 50);
            this.file_open.Name = "file_open";
            this.file_open.Size = new System.Drawing.Size(161, 50);
            this.file_open.TabIndex = 0;
            this.file_open.Text = "File Open";
            this.file_open.UseVisualStyleBackColor = true;
            this.file_open.Click += new System.EventHandler(this.file_open_Click);
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(43, 130);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(161, 50);
            this.gen.TabIndex = 1;
            this.gen.Text = "Generate G Code";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sample Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diameter (in)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Speed";
            // 
            // sample_rate
            // 
            this.sample_rate.Location = new System.Drawing.Point(589, 56);
            this.sample_rate.Name = "sample_rate";
            this.sample_rate.Size = new System.Drawing.Size(141, 20);
            this.sample_rate.TabIndex = 5;
            this.sample_rate.Text = "5000";
            // 
            // Dia
            // 
            this.Dia.Location = new System.Drawing.Point(589, 103);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(141, 20);
            this.Dia.TabIndex = 6;
            this.Dia.Text = "3";
            // 
            // speed
            // 
            this.speed.FormattingEnabled = true;
            this.speed.Items.AddRange(new object[] {
            "33",
            "45",
            "78"});
            this.speed.Location = new System.Drawing.Point(589, 153);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(141, 21);
            this.speed.TabIndex = 7;
            this.speed.SelectedIndexChanged += new System.EventHandler(this.speed_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max Excursion (in)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Safe Height (in)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Feed Rate (in/min)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Depth (in)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Input Filename";
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(589, 256);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(141, 20);
            this.depth.TabIndex = 18;
            this.depth.Text = ".005";
            // 
            // safeHeight
            // 
            this.safeHeight.Location = new System.Drawing.Point(589, 302);
            this.safeHeight.Name = "safeHeight";
            this.safeHeight.Size = new System.Drawing.Size(141, 20);
            this.safeHeight.TabIndex = 19;
            this.safeHeight.Text = "1";
            // 
            // feedRate
            // 
            this.feedRate.Location = new System.Drawing.Point(589, 347);
            this.feedRate.Name = "feedRate";
            this.feedRate.Size = new System.Drawing.Size(141, 20);
            this.feedRate.TabIndex = 20;
            this.feedRate.Text = "5";
            // 
            // inFilename
            // 
            this.inFilename.Location = new System.Drawing.Point(150, 394);
            this.inFilename.Name = "inFilename";
            this.inFilename.Size = new System.Drawing.Size(580, 20);
            this.inFilename.TabIndex = 21;
            // 
            // excursion
            // 
            this.excursion.Location = new System.Drawing.Point(589, 199);
            this.excursion.Name = "excursion";
            this.excursion.Size = new System.Drawing.Size(141, 20);
            this.excursion.TabIndex = 22;
            this.excursion.Text = ".006";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Audio To G Code Ver 1.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.excursion);
            this.Controls.Add(this.inFilename);
            this.Controls.Add(this.feedRate);
            this.Controls.Add(this.safeHeight);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.sample_rate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.file_open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button file_open;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sample_rate;
        private System.Windows.Forms.TextBox Dia;
        private System.Windows.Forms.ComboBox speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.TextBox safeHeight;
        private System.Windows.Forms.TextBox feedRate;
        private System.Windows.Forms.TextBox inFilename;
        private System.Windows.Forms.TextBox excursion;
        private System.Windows.Forms.Label label9;
    }
}

