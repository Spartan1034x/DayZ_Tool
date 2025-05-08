namespace DayZTool
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            lnkPicCredit = new LinkLabel();
            lnkProgram = new LinkLabel();
            SuspendLayout();
            // 
            // lnkPicCredit
            // 
            lnkPicCredit.AutoSize = true;
            lnkPicCredit.BackColor = Color.Transparent;
            lnkPicCredit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkPicCredit.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkPicCredit.LinkColor = Color.FromArgb(128, 128, 255);
            lnkPicCredit.Location = new Point(12, 640);
            lnkPicCredit.Name = "lnkPicCredit";
            lnkPicCredit.Size = new Size(124, 28);
            lnkPicCredit.TabIndex = 0;
            lnkPicCredit.TabStop = true;
            lnkPicCredit.Text = "Art: suzuki88";
            lnkPicCredit.LinkClicked += lnkPicCredit_LinkClicked;
            // 
            // lnkProgram
            // 
            lnkProgram.AutoSize = true;
            lnkProgram.BackColor = Color.Transparent;
            lnkProgram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkProgram.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkProgram.LinkColor = Color.FromArgb(128, 128, 255);
            lnkProgram.Location = new Point(1029, 640);
            lnkProgram.Name = "lnkProgram";
            lnkProgram.Size = new Size(163, 28);
            lnkProgram.TabIndex = 1;
            lnkProgram.TabStop = true;
            lnkProgram.Text = "By: Spartan1034x";
            lnkProgram.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1204, 677);
            Controls.Add(lnkProgram);
            Controls.Add(lnkPicCredit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DayZ Tool";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnkPicCredit;
        private LinkLabel lnkProgram;
    }
}
