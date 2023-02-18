using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Design
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomTextBox : UserControl
    {
        private Color borderColor = Color.White;
        private int borderSize = 2;
        private bool underlineStyle = false;

        private int borderRadius = 0;
        private Color placeHolderColor = Color.DarkGray;
        private string placeHolderText = "";
        private bool isPlaceHolder = false;
        private bool isPasswordChar = false;

        //Constructor
        public CustomTextBox()
        {
            InitializeComponent();
        }

        //Events
        public event EventHandler _TextChanged;


        //Properties
        [Category("Myself added")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
        [Category("Myself added")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
        [Category("Myself added")]
        public bool UnderlineStyle { get => underlineStyle; set { underlineStyle = value; this.Invalidate(); } }
        [Category("Myself added")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set 
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value; 
            }
        }
        [Category("Myself added")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("Myself added")]
        public override Color BackColor
        {
            get 
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("Myself added")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("Myself added")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("Myself added")]
        public string Texts
        {
            get 
            {
                if(isPlaceHolder) { return ""; }
                else
                    return textBox1.Text; 
            }
            set
            {
                textBox1.Text = value;
                SetPlaceHolder();
            }
        }
        [Category("Myself added")]
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
        [Category("Myself added")]
        public Color PlaceHolderColor 
        {
            get { return placeHolderColor; }
            set 
            {
                placeHolderColor = value;
                if (isPasswordChar)
                    textBox1.ForeColor = value;
            }
        }
        [Category("Myself added")]
        public string PlaceHolderText 
        {
            get { return placeHolderText; }
            set
            {
                placeHolderText = value;
                textBox1.Text = "";
                SetPlaceHolder();
            }
        }
        [Category("Myself added")]
        public bool IsPlaceHolder { get => isPlaceHolder; set => isPlaceHolder = value; }
        [Category("Myself added")]
        public bool IsPasswordChar { get => isPasswordChar; set => isPasswordChar = value; }

        //Overridden methods
        private GraphicsPath GetFigurePath(RectangleF rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Width - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Width - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);

            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            if(borderRadius > 1) //rounded
            {
                //-fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using(GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using(GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using(Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using(Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //Draw
                    this.Region = new Region(pathBorderSmooth);
                    if (BorderRadius > 15) SetTextBoxRoundRegion();
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = PenAlignment.Center;
                    penBorder.Alignment = PenAlignment.Inset;

                    if (underlineStyle)
                    {
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graphics.SmoothingMode = SmoothingMode.None;
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }                        
                    else
                    {
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        graphics.DrawPath(penBorder, pathBorder);
                        
                    }
                        
                }
            }
            else //normal
            {
                //Draw borders
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;

                    if (underlineStyle)
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5F);
                }
            }
           
        }

        private void SetPlaceHolder()
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) && PlaceHolderText != "")
            {
                isPlaceHolder= true;
                textBox1.Text = PlaceHolderText;
                textBox1.ForeColor = placeHolderColor;
                if(isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = false;
                }
            }
        }
        private void RemovePlaceHolder()
        {
            if (isPlaceHolder && PlaceHolderText != "")
            {
                isPlaceHolder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = true;
                }
            }
        }
        private void SetTextBoxRoundRegion()
        {
            GraphicsPath pathText;
            if(Multiline)
            {
                pathText = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathText);
            }
            else
            {
                pathText = GetFigurePath(textBox1.ClientRectangle, borderSize);
                textBox1.Region = new Region(pathText);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if(textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline= true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder();
        }
    }
}
