using System;
using System.Windows.Forms;

namespace Mill_Record_Cutter
{
    public partial class Form1 : Form
    {

        Int32 len;
        Int32 samples;
        double rpm;
        double r;
        double theta;

        double x, y;
        System.IO.Stream fileInStream;

        public Form1()
        {
            InitializeComponent();
        }

        private void file_open_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openInFileDialog = new OpenFileDialog())
            {
                openInFileDialog.InitialDirectory = "c:\\";
                openInFileDialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
                openInFileDialog.FilterIndex = 1;
                openInFileDialog.RestoreDirectory = true;

                if (openInFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openInFileDialog.FileName;

                    //Read the contents of the file into a stream
                    fileInStream = openInFileDialog.OpenFile();
                    len = (Int32)fileInStream.Length;
                    inFilename.Text = openInFileDialog.FileName;
                }
            }
         }

        private void gen_Click(object sender, EventArgs e)
        {
            string fileName;
            string gcode;
            double data;
            int d;
            
            fileName = openOutFile();
            if (fileName == "")
                MessageBox.Show("Could not open file.", "Error", MessageBoxButtons.OK);
            var sr = new System.IO.StreamWriter(fileName,false,System.Text.Encoding.ASCII);
            sr.WriteLine("%");
            sr.WriteLine("(G20 inch units, G40 remove cutter dia comp, G54 use work coord 1 )");
            sr.WriteLine("G20 G40 G54");
            // add some extra samples to make sure loop overlaps
            samples = Convert.ToInt32((60.0 / rpm) * Convert.ToDouble(sample_rate.Text) * 1.01);
            for (Int32 i = 0; i < samples; ++i)
            {

                theta = ((double)i / (double)samples) * 2 * Math.PI;
                if (i >= len)
                    data = 0.0;
                else
                {
                    d = fileInStream.ReadByte();
                    if (d > 127)  // convert to signed
                        d -= 256;
                    data = Convert.ToDouble(d);
                    data = (data / 128.0) * Convert.ToDouble(excursion.Text);
                }
                r = Convert.ToDouble(Dia.Text) / 2.0 + data;
                y = Math.Sin(theta) * r;
                x = Math.Cos(theta) * r;
                if (i == 0)  // do inital rapid move to start position at safe height then plunge to cutting depth
                {
                    gcode = String.Format("G00 F20 X{0:F6} Y{1:F6} Z{2:F3}", x, y, Convert.ToDouble(safeHeight.Text));
                    sr.WriteLine(gcode);
                    gcode = String.Format("G00 F20 Z0.1");
                    sr.WriteLine(gcode);
                    gcode = String.Format("G01 F{0:F1} Z{1:F4}", Convert.ToDouble(feedRate.Text), -Convert.ToDouble(depth.Text));
                    sr.WriteLine(gcode);
                }
             gcode = String.Format("G01 X{0:F6} Y{1:F6}", x, y);
             sr.WriteLine(gcode);
            }
            sr.WriteLine("G00 Z{0:F0}", Convert.ToDouble(safeHeight.Text));  // write end of program
            sr.WriteLine("M02");
            sr.WriteLine("%");
            MessageBox.Show("Write Complete", "File Write", MessageBoxButtons.OK);
            sr.Close();
        }

        String openOutFile()
        {
            // Displays a SaveFileDialog so the user can select the CNC file name 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CNC File|*.nc|Text File|*.txt";
            saveFileDialog1.Title = "Save an CNC File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
                return (saveFileDialog1.FileName);
            else
                return ("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            speed.SelectedIndex = 0; // set to 33 rpm default

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
             
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inFilename_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(speed.SelectedItem))
            {
                case 33:
                    rpm = 33.3333333;
                    break;
                case 45:
                    rpm = 45.0;
                    break;
                case 78:
                    rpm = 78.26;
                    break;
                default:
                    rpm = 33.3333333;
                    break;

            }
        }
    }
}
