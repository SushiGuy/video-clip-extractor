namespace videoClipExtractor
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOutputFileLabel = new System.Windows.Forms.Label();
            this.labelOutputFile = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelOutputLengthLabel = new System.Windows.Forms.Label();
            this.labelOutputLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "";
            this.textBox1.Location = new System.Drawing.Point(176, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(313, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Video file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time to";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(100, 93);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrom.TabIndex = 4;
            this.textBoxFrom.Text = "00:00:00";
            this.textBoxFrom.Click += new System.EventHandler(this.textBoxFrom_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(100, 119);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTo.TabIndex = 5;
            this.textBoxTo.Text = "00:00:00";
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBoxTo_TextChanged);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(11, 9);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(243, 13);
            this.label0.TabIndex = 6;
            this.label0.Text = "Use this tool to extract a short clip from a video file";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "e.g. \"00:03:17\" for 3m17s mark";
            // 
            // labelOutputFileLabel
            // 
            this.labelOutputFileLabel.AutoSize = true;
            this.labelOutputFileLabel.Location = new System.Drawing.Point(39, 150);
            this.labelOutputFileLabel.Name = "labelOutputFileLabel";
            this.labelOutputFileLabel.Size = new System.Drawing.Size(55, 13);
            this.labelOutputFileLabel.TabIndex = 9;
            this.labelOutputFileLabel.Text = "Output file";
            // 
            // labelOutputFile
            // 
            this.labelOutputFile.AutoSize = true;
            this.labelOutputFile.Location = new System.Drawing.Point(97, 150);
            this.labelOutputFile.Name = "labelOutputFile";
            this.labelOutputFile.Size = new System.Drawing.Size(59, 13);
            this.labelOutputFile.TabIndex = 10;
            this.labelOutputFile.Text = "[output file]";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(495, 41);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 20);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelOutputLengthLabel
            // 
            this.labelOutputLengthLabel.AutoSize = true;
            this.labelOutputLengthLabel.Location = new System.Drawing.Point(23, 172);
            this.labelOutputLengthLabel.Name = "labelOutputLengthLabel";
            this.labelOutputLengthLabel.Size = new System.Drawing.Size(71, 13);
            this.labelOutputLengthLabel.TabIndex = 12;
            this.labelOutputLengthLabel.Text = "Output length";
            // 
            // labelOutputLength
            // 
            this.labelOutputLength.AutoSize = true;
            this.labelOutputLength.Location = new System.Drawing.Point(97, 172);
            this.labelOutputLength.Name = "labelOutputLength";
            this.labelOutputLength.Size = new System.Drawing.Size(75, 13);
            this.labelOutputLength.TabIndex = 13;
            this.labelOutputLength.Text = "[output length]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 228);
            this.Controls.Add(this.labelOutputLength);
            this.Controls.Add(this.labelOutputLengthLabel);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelOutputFile);
            this.Controls.Add(this.labelOutputFileLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOutputFileLabel;
        private System.Windows.Forms.Label labelOutputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelOutputLengthLabel;
        private System.Windows.Forms.Label labelOutputLength;
    }
}

