using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Design
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomMaskedTextBoxDate : UserControl
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
        public CustomMaskedTextBoxDate()
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
                maskedTextBox1.UseSystemPasswordChar = value;
            }
        }
        [Category("Myself added")]
        public bool Multiline
        {
            get { return maskedTextBox1.Multiline; }
            set { maskedTextBox1.Multiline = value; }
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
                maskedTextBox1.BackColor = value;
            }
        }
        [Category("Myself added")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                maskedTextBox1.ForeColor = value;
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
                maskedTextBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("Myself added")]
        public string Texts
        {
            get
            {
                if (isPlaceHolder) { return ""; }
                else
                    return maskedTextBox1.Text;
            }
            set
            {
                maskedTextBox1.Text = value;
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
                    maskedTextBox1.ForeColor = value;
            }
        }
        [Category("Myself added")]
        public string PlaceHolderText
        {
            get { return placeHolderText; }
            set
            {
                placeHolderText = value;
                maskedTextBox1.Text = "";
                SetPlaceHolder();
            }
        }
        [Category("Myself added")]
        public bool IsPlaceHolder { get => isPlaceHolder; set => isPlaceHolder = value; }
        [Category("Myself added")]
        public bool IsPasswordChar { get => isPasswordChar; set => isPasswordChar = value; }
        [Category("Myself added")]
        public new string Mask
        {
            get
            {
                return maskedTextBox1.Mask;
            }
            set
            {
                maskedTextBox1.Mask = value;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            if (borderRadius > 1) //rounded
            {
                //-fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = Rounding.GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = Rounding.GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
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
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) && PlaceHolderText != "")
            {
                isPlaceHolder = true;
                maskedTextBox1.Text = PlaceHolderText;
                maskedTextBox1.ForeColor = placeHolderColor;
                if (isPasswordChar)
                {
                    maskedTextBox1.UseSystemPasswordChar = false;
                }
            }
        }
        private void RemovePlaceHolder()
        {
            if (isPlaceHolder && PlaceHolderText != "")
            {
                isPlaceHolder = false;
                maskedTextBox1.Text = "";
                maskedTextBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                {
                    maskedTextBox1.UseSystemPasswordChar = true;
                }
            }
        }
        private void SetTextBoxRoundRegion()
        {
            GraphicsPath pathText;
            if (Multiline)
            {
                pathText = Rounding.GetFigurePath(maskedTextBox1.ClientRectangle, borderRadius - borderSize);
                maskedTextBox1.Region = new Region(pathText);
            }
            else
            {
                pathText = Rounding.GetFigurePath(maskedTextBox1.ClientRectangle, borderSize);
                maskedTextBox1.Region = new Region(pathText);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (maskedTextBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                maskedTextBox1.Multiline = true;
                maskedTextBox1.MinimumSize = new Size(0, txtHeight);
                maskedTextBox1.Multiline = false;
            }

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void maskedTextBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void maskedTextBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder();
        }
    }
}
