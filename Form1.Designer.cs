
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
            this.excursion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(448, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sample Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diameter (in)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Speed";
            // 
            // sample_rate
            // 
            this.sample_rate.Location = new System.Drawing.Point(522, 62);
            this.sample_rate.Name = "sample_rate";
            this.sample_rate.Size = new System.Drawing.Size(141, 20);
            this.sample_rate.TabIndex = 5;
            this.sample_rate.Text = "5000";
            // 
            // Dia
            // 
            this.Dia.Location = new System.Drawing.Point(522, 109);
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
            this.speed.Location = new System.Drawing.Point(522, 159);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(141, 21);
            this.speed.TabIndex = 7;
            this.speed.SelectedIndexChanged += new System.EventHandler(this.speed_SelectedIndexChanged);
            // 
            // excursion
            // 
            this.excursion.FormattingEnabled = true;
            this.excursion.Items.AddRange(new object[] {
            "33",
            "45",
            "78"});
            this.excursion.Location = new System.Drawing.Point(522, 204);
            this.excursion.Name = "excursion";
            this.excursion.Size = new System.Drawing.Size(141, 21);
            this.excursion.TabIndex = 9;
            this.excursion.Text = ".006";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max Excursion (in)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.excursion);
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
        private System.Windows.Forms.ComboBox excursion;
        private System.Windows.Forms.Label label4;
    }
}

