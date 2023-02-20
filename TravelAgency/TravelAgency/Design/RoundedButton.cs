using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace TravelAgency.Design
{
    public class RoundedButton: Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;


        //Properties
        [Category("Round Button")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }
        [Category("Round Button")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set 
            {
                if (value <= Height)
                {
                    borderRadius = value;
                }
                else
                {
                    borderRadius = Height;
                }
                Invalidate();
            }
        }
        [Category("Rounded Button")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value;
                Invalidate();
            }
        }

        [Category("Rounded Button")]
        public Color BackgroundColor
        {
            get { return BackColor; }
            set 
            { 
                base.BackColor= value;
               
            }
        }

        [Category("Rounded Button")]
        public Color TextColor
        {
            get { return ForeColor; } 
            set { base.ForeColor = value; }
        }

        //Constructor
        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;
            Resize += new EventHandler(Button_resize);
        }

        private void Button_resize(object sender, EventArgs e)
        {
            if (borderRadius > Height)
                borderRadius = Height;
        }

        //Methods

        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectBorder = new RectangleF(1, 1, Width - 0.8f, Height - 1);

            if(borderRadius > 2) //Round Button
            {
                using (GraphicsPath pathSurface = Rounding.GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = Rounding.GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;

                    Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);

                }
            }
            else
            {
                Region = new Region(rectSurface);
                if(borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }

                }
            }

        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
