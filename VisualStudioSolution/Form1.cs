using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoClipExtractor
{
    public partial class Form1 : Form
    {
        private string selectedVideoFilename = "";
        private string defaultTimeValue = "00:00:00";
        private string outputFileModifier = "-CLIP";

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            resetFields();
        }

        private void chooseVideoFile()
        {
            openFileDialog1.DefaultExt = "mp4";
            openFileDialog1.Filter = "MP4 files (*.mp4)|*.mp4|MKV files (*.mkv)|*.mkv|AVI files (*.avi)|*.avi";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedVideoFilename
                    = textBox1.Text
                    = openFileDialog1.FileName;
            }
            labelOutputFile.Text = Path.GetDirectoryName(selectedVideoFilename)
                + "\\" + Path.GetFileNameWithoutExtension(selectedVideoFilename)
                + outputFileModifier
                + Path.GetExtension(selectedVideoFilename);
            labelOutputLength.Text = "00:jer:00";

            labelOutputFileLabel.Visible = true;
            labelOutputLengthLabel.Visible = true;
        }

        private void resetFields()
        {
            openFileDialog1.FileName = "";
            textBox1.Text = "";
            textBoxFrom.Text = defaultTimeValue;
            textBoxTo.Text = defaultTimeValue;
            labelOutputFile.Text = "";
            labelOutputFileLabel.Visible = false;
            labelOutputLength.Text = "";
            labelOutputLengthLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chooseVideoFile();
        }

        private void textBoxFrom_Click(object sender, EventArgs e)
        {
            if (textBoxFrom.Text == defaultTimeValue) {
                textBoxFrom.Text = "";
            }
        }

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFrom.Text == defaultTimeValue)
            {
                textBoxFrom.Text = "";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resetFields();
        }

    }
}
