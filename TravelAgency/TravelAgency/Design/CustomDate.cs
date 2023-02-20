using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TravelAgency.Design
{
    internal class CustomDate: DateTimePicker
    {
        //Fields
        //-> Appearance
        private Color skinColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;
        private int borderRadius = 0;
        //-> Other Values
        private bool droppedDown = false;

        private Image calendarIcon = Properties.Resources.blackCalendar;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;

        //Properties
        public Color SkinColor
        {
            get { return skinColor; }
            set
            {
                skinColor = value;
                calendarIcon = Properties.Resources.blackCalendar;
                this.Invalidate();
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public int BorderRadius 
        { 
            get => borderRadius; set => borderRadius = value; 
        }

        //Constructor
        public CustomDate()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5F);
        }
        //Overridden methods
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }
        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            droppedDown = false;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
            RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
            

            using (Graphics graphics = this.CreateGraphics())
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                //Draw surface
                graphics.FillRectangle(skinBrush, clientArea);
                //Draw text
                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
                //Draw open calendar icon highlight
                if (droppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);

                if (borderRadius > 1) //rounded
                {
                    //-fields
                    var rectBorderSmooth = this.ClientRectangle;
                    var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                    int smoothSize = borderSize > 0 ? borderSize : 1;

                    using (GraphicsPath pathBorderSmooth = Rounding.GetFigurePath(rectBorderSmooth, borderRadius))
                    using (GraphicsPath pathBorder = Rounding.GetFigurePath(rectBorder, borderRadius - borderSize))
                    using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                    {
                        //Draw
                        this.Region = new Region(pathBorderSmooth);
                        //if (BorderRadius > 15) SetTextBoxRoundRegion();
                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        penBorder.Alignment = PenAlignment.Center;
                        penBorder.Alignment = PenAlignment.Inset;

                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graphics.DrawPath(penBorder, pathBorder);

                        

                    }
                }
                else //normal
                {
                    
                    
                    //Draw border 
                    if (borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                    //Draw icon
                }
                graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height) / 2);
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iconButtonArea.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else this.Cursor = Cursors.Default;
        }
        //Private methods
        private int GetIconButtonWidth()
        {
            int textWidh = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidh <= this.Width - (calendarIconWidth + 20))
                return calendarIconWidth;
            else return arrowIconWidth;
        }
    }
}
