namespace WeatherEditor
{
    partial class RadiansHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadiansHelp));
            pictureBox1 = new PictureBox();
            Radians = new Label();
            button1 = new Button();
            label1 = new Label();
            nudDegrees = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            nudRadians = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDegrees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRadians).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(697, 315);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Radians
            // 
            Radians.AutoSize = true;
            Radians.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Radians.Location = new Point(317, 9);
            Radians.Name = "Radians";
            Radians.Size = new Size(189, 59);
            Radians.TabIndex = 1;
            Radians.Text = "Radians";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(349, 588);
            button1.Name = "button1";
            button1.Size = new Size(124, 41);
            button1.TabIndex = 2;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(352, 425);
            label1.Name = "label1";
            label1.Size = new Size(119, 38);
            label1.TabIndex = 3;
            label1.Text = "Convert:";
            // 
            // nudDegrees
            // 
            nudDegrees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudDegrees.Location = new Point(204, 484);
            nudDegrees.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudDegrees.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudDegrees.Name = "nudDegrees";
            nudDegrees.Size = new Size(150, 34);
            nudDegrees.TabIndex = 4;
            nudDegrees.ValueChanged += nudDegrees_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 487);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 5;
            label2.Text = "Degrees:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(454, 487);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 7;
            label3.Text = "Radians:";
            // 
            // nudRadians
            // 
            nudRadians.DecimalPlaces = 2;
            nudRadians.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudRadians.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudRadians.Location = new Point(554, 484);
            nudRadians.Maximum = new decimal(new int[] { 3142, 0, 0, 196608 });
            nudRadians.Minimum = new decimal(new int[] { 3142, 0, 0, -2147287040 });
            nudRadians.Name = "nudRadians";
            nudRadians.Size = new Size(150, 34);
            nudRadians.TabIndex = 6;
            nudRadians.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // RadiansHelp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(824, 653);
            Controls.Add(label3);
            Controls.Add(nudRadians);
            Controls.Add(label2);
            Controls.Add(nudDegrees);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(Radians);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RadiansHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Radians Help";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDegrees).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRadians).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Radians;
        private Button button1;
        private Label label1;
        private NumericUpDown nudDegrees;
        private Label label2;
        private Label label3;
        private NumericUpDown nudRadians;
    }
}