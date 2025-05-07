using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

/// <summary>
///     A custom-styled button with a sunset-inspired gradient and rounded corners.
/// </summary>
namespace DayZTool
{
    public class HomePageButtons : Button
    {
        private bool hovered = false;

        public HomePageButtons()
        {
            this.Cursor = Cursors.Hand;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            hovered = true;
            Invalidate(); // Forces repaint to show hover effect
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            hovered = false;
            Invalidate(); // Forces repaint to remove hover effect
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;

            // Gradient changes on hover
            Color topColor = hovered ? ColorTranslator.FromHtml("#C88C5D") : ColorTranslator.FromHtml("#817674");
            Color bottomColor = hovered ? ColorTranslator.FromHtml("#D9B382") : ColorTranslator.FromHtml("#DEC29B");

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect, topColor, bottomColor, LinearGradientMode.Vertical))
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 15;
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    g.FillPath(brush, path);

                    using (Pen pen = new Pen(ColorTranslator.FromHtml("#0A0B05"), 2))
                    {
                        g.DrawPath(pen, path);
                    }

                    TextRenderer.DrawText(
                        g,
                        Text,
                        Font,
                        rect,
                        ColorTranslator.FromHtml("#423E3F"),
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                    );
                }
            }
        }
    }

}
