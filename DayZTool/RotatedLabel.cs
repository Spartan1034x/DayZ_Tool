using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DayZTool
{
    internal class RotatedLabel : Control
    {
        public float Angle { get; set; } = 0f;

        public RotatedLabel()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (SolidBrush brush = new SolidBrush(this.ForeColor))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.TranslateTransform(this.Width / 2f, this.Height / 2f);
                e.Graphics.RotateTransform(Angle);
                SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font);
                e.Graphics.DrawString(this.Text, this.Font, brush, -textSize.Width / 2, -textSize.Height / 2);
                e.Graphics.ResetTransform();
            }
        }
    }
}
