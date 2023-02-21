using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Design
{
    internal class CustomComboBox : ComboBox
    {
        public CustomComboBox()
        {
          
            SetStyle(ControlStyles.UserPaint, true);
            
        }
        private int cornerRadius = 12;
        protected override void OnPaint(PaintEventArgs paintEvent)
        {
            Graphics graphics = paintEvent.Graphics;

            SolidBrush backgroundBrush = new SolidBrush(this.BackColor);
            graphics.FillRectangle(backgroundBrush, ClientRectangle);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectangle = new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            GraphicsPath graphicsPath = RoundedRectangle(rectangle, cornerRadius, 0);
            SolidBrush brush = new SolidBrush(Color.Red);
            graphics.FillPath(brush, graphicsPath);

            rectangle = new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 100);
            graphicsPath = RoundedRectangle(rectangle, cornerRadius, 2);
            brush = new SolidBrush(Color.Green);
            graphics.FillPath(brush, graphicsPath);
        }

        private GraphicsPath RoundedRectangle(Rectangle rectangle, int cornerRadius, int margin)
        {
            GraphicsPath roundedRectangle = new GraphicsPath();
            roundedRectangle.AddArc(rectangle.X + margin, rectangle.Y + margin, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRectangle.AddArc(rectangle.X + rectangle.Width - margin - cornerRadius * 2, rectangle.Y + margin, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRectangle.AddArc(rectangle.X + rectangle.Width - margin - cornerRadius * 2, rectangle.Y + rectangle.Height - margin - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRectangle.AddArc(rectangle.X + margin, rectangle.Y + rectangle.Height - margin - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRectangle.CloseFigure();
            return roundedRectangle;
        }

        // Constructor
        //    public CustomComboBox()
        //    {
        //        // Set the control style to enable double buffering
        //        this.SetStyle(ControlStyles.UserPaint, true);
        //        this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
        //    }

        //    // Override the OnPaint method to draw the rounded appearance
        //    protected override void OnPaint(PaintEventArgs e)
        //    {
        //        base.OnPaint(e);

        //        // Draw a rounded rectangle around the control
        //        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        //        using (GraphicsPath path = CreateRoundedRectanglePath(this.ClientRectangle, 12))
        //        {
        //            using (Pen pen = new Pen(Color.Red, 1))
        //            {
        //                e.Graphics.DrawPath(pen, path);
        //            }
        //        }
        //    }

        //    // Method for creating a rounded rectangle path
        //    private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        //    {
        //        GraphicsPath path = new GraphicsPath();
        //        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        //        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
        //        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
        //        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
        //        path.CloseFigure();
        //        return path;
        //    }
        //}
    }
}
