using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TravelAgency.Design
{
    internal class CustomComboBox : ComboBox
    {
        //What i need to do
        /*Make field to 
         * To change size
         * To set border size
         * To set border color
         * To set border radius
         * To set color of control
         * To set color of text;
         */
        #region --- Fields ---
        private int borderSize = 1;
        private Color borderColor = Color.Green;
        private int borderRadius = 0;
        private Color skinColor = Color.White;
        private Color textColor = Color.Green;

        //properties

        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        public Color SkinColor
        {
            get
            {
                return skinColor;
            }
            set
            {
                skinColor = value;
                this.Invalidate();
            }
        }
        public Color TextColor
        {
            get
            {
                return textColor;
            }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }
        #endregion

        //Constructor
        public CustomComboBox()
        {
            this.SetStyle(ControlStyles.UserPaint, true); //to have opportunity create own style of control
            this.MinimumSize = new Size(0, 46);
            this.Font = new Font("Franclin Gothic Book", 14F);
        }

        #region --- Override methods ---

        protected override void OnPaint(PaintEventArgs e)
        {
            RectangleF clientArea = new RectangleF(0, 0, this.Width, this.Height);

            using (Graphics graphics = this.CreateGraphics())
            using (Pen borderPen = new Pen(borderColor, borderSize))
            using (SolidBrush backBrush = new SolidBrush(skinColor))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                borderPen.Alignment = PenAlignment.Inset; //border painting out of rectangle

                //draw surface
                graphics.FillRectangle(backBrush, clientArea);
                //Draw text
                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);

                
                if(borderRadius > 1) //if rounded
                {
                    var rectBorderSmooth = this.ClientRectangle;
                    var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                    int smoothSize = borderSize > 0? borderSize : 1;

                    using (GraphicsPath pathBorderSmooth = Rounding.GetFigurePath(rectBorder, borderRadius))
                    using (GraphicsPath pathBorder = Rounding.GetFigurePath(rectBorder, borderRadius - borderSize))
                    using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                    {
                        this.Region = new Region(pathBorderSmooth);
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;

                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graphics.DrawPath(borderPen, pathBorder);

                    }
                }
                else
                {
                    if (borderSize >= 1) graphics.DrawRectangle(borderPen, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                }
            }
        }
        #endregion
        #region --- Overriding events ---


        #endregion

    }
}
