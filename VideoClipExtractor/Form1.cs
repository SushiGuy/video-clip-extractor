using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace videoClipExtractor
{
    public partial class Form1 : Form
    {
        private string selectedVideoFilename = "";
        private string defaultTimeValue = "00:00:00";
        private string outputFileModifier = "-CLIP";
        private string timeFormat = "HH:mm:ss";
        private string ffmpegPath = AppDomain.CurrentDomain.BaseDirectory + @"ffmpeg\ffmpeg.exe";
        private string ffmpegArgs = "";

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

        private TimeSpan calculateTimeDiff(string time1, string time2)
        {
            DateTime dt1 = DateTime.ParseExact(time1, timeFormat, new DateTimeFormatInfo());
            DateTime dt2 = DateTime.ParseExact(time2, timeFormat, new DateTimeFormatInfo());
            TimeSpan ts = dt1.Subtract(dt2);
            return ts;
        }

        private bool validateTime(string time)
        {
            DateTime outTime;
            return DateTime.TryParseExact(time, timeFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out outTime);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chooseVideoFile();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        /// <summary>
        /// Clear default text on focus (currently on click...change to focus?)
        /// </summary>
        private void textBoxFrom_Click(object sender, EventArgs e)
        {
            if (textBoxFrom.Text == defaultTimeValue)
            {
                textBoxFrom.Text = "";
            }
        }

        /// <summary>
        /// Clear default text on focus (currently on click...change to focus?)
        /// </summary>
        private void textBoxTo_Click(object sender, EventArgs e)
        {
            if (textBoxFrom.Text == defaultTimeValue)
            {
                textBoxFrom.Text = "";
            }
        }

        private void validateTimes()
        {
            if (validateTime(textBoxFrom.Text) && validateTime(textBoxTo.Text))
            {
                labelOutputLengthLabel.Visible = true;
                labelOutputLength.Text = calculateTimeDiff(textBoxTo.Text, textBoxFrom.Text)
                    .ToString();
            }
            previewCommand();
        }

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {
            validateTimes();
        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            validateTimes();
        }

        private void previewCommand()
        {
            ffmpegArgs = $" -ss {textBoxFrom.Text} -t {labelOutputLength.Text} -i \"{textBox1.Text}\" -c copy \"{labelOutputFile.Text}\"";
            string cmdPreview = ffmpegPath;
            textBoxPreview.Text = ffmpegPath + ffmpegArgs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // var proc = new ProcessAsync(exeName, "args");
            // string output = proc.Run().Result;
            // string output = ExtractClip(exeName, "args");
            string output = ExtractClip(ffmpegPath, ffmpegArgs);
            MessageBox.Show(output);
        }

        private string ExtractClip(string fileName, string arguments)
        {
            string args = $"/C \"{fileName} {arguments}\"";
            var psi = new ProcessStartInfo
            {
                FileName = fileName,
                Arguments = args,
                UseShellExecute = false,
                // RedirectStandardInput = true;
                RedirectStandardOutput = true,
                // CreateNoWindow = true,
                // WindowStyle = ProcessWindowStyle.Hidden
            };

            string output;
            Process cmd = new Process();
            cmd.StartInfo = psi;
            cmd.Start();
            // using (var process = Process.Start(psi))
            // {
                output = cmd.StandardOutput.ReadToEnd();
                cmd.WaitForExit();
            // }

            //cmd.StartInfo.FileName = fileName;
            //cmd.StartInfo.Arguments = arguments;
            //cmd.StartInfo.UseShellExecute = false;
            //// cmd.StartInfo.RedirectStandardInput = true;
            //cmd.StartInfo.RedirectStandardOutput = true;
            //cmd.StartInfo.CreateNoWindow = true;
            //cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            // cmd.Start();

            // cmd.StandardInput.Flush();
            // cmd.StandardInput.Close();
            //StringBuilder output2 = new StringBuilder();
            //while (!cmd.StandardOutput.EndOfStream)
            //{
            //    string line = cmd.StandardOutput.ReadLine();
            //    output2.Append(line);
            //}
            // string err = cmd.StandardError.ReadToEnd();
            // string output = cmd.StandardOutput.ReadToEnd();
            // MessageBox.Show(output2);
            // cmd.WaitForExit();

            // Console.WriteLine(retVal);
            // return output2.ToString();
            return output;
        }

        private static string ExtractClip2(string exePath, string parameters)
        {
            string result = String.Empty;

            using (Process p = new Process())
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = exePath;
                p.StartInfo.Arguments = parameters;
                p.Start();
                p.WaitForExit();

                result = p.StandardOutput.ReadToEnd();
            }

            return result;
        }
    }
}
