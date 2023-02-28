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
    [DefaultEvent("OnSelectedIndexChanged")]
    internal class CustomComboBox: UserControl
    {
        #region --- Fields ---
        private Color backColor = Color.White;
        private Color iconColor = Color.Black;
        private Color listBackColor = Color.WhiteSmoke;
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.Violet;

        private int borderSize = 1;
        private int borderRadius = 0;
        #endregion
        #region --- Properties ---
        //Properties
        //-> Appearance
        [Category("RJ Code - Appearance")]
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
        [Category("RJ Code - Appearance")]

        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        [Category("RJ Code - Appearance")]
        public Color IconColor
        {
            get { return iconColor; }
            set
            {
                iconColor = value;
                btnIcon.Invalidate();//Redraw icon
            }
        }

        [Category("RJ Code - Appearance")]
        public Color ListBackColor
        {
            get { return listBackColor; }
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        [Category("RJ Code - Appearance")]
        public Color ListTextColor
        {
            get { return listTextColor; }
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }

        [Category("RJ Code - Appearance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                base.BackColor = borderColor; //Border Color
            }
        }

        [Category("RJ Code - Appearance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);//Border Size
                AdjustComboBoxDimension();
            }
        }

        [Category("RJ Code - Appearance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        [Category("RJ Code - Appearance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;//Optional
            }
        }

        [Category("RJ Code - Appearance")]
        public string Texts
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        [Category("RJ Code - Appearance")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }
        #endregion
        #region --- Items ---
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;
        #endregion
        #region --- Events ---
        public event EventHandler OnSelectedIndexChanged; //default event
        private void CmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            lblText.Text = cmbList.Text;
        }
        private void CmbList_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = cmbList.Text;
        }
        private void AdjustComboBoxDimension()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        private void LblText_Click(object sender, EventArgs e)
        {
            this.OnClick(e);

            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Fields
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;
            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void BtnIcon_Click(object sender, EventArgs e)
        {
            //Open dropdown list
            cmbList.Select();
            cmbList.DroppedDown = true;
        }
        #endregion
        //protected override void OnPaint(PaintEventArgs pevent)
        //{
        //    base.OnPaint(pevent);
        //    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        //    RectangleF rectSurface = new RectangleF(0, 0, Width, Height);

        //    RectangleF rectBorder = new RectangleF(1, 1, Width - 0.8f, Height - 1);
        //    //RectangleF rectBorder = new RectangleF(-5, -5, Width -5, Height -5);


        //    if (borderRadius > 2) //Round Button
        //    {
        //        using (GraphicsPath pathSurface = Rounding.GetFigurePath(rectSurface, borderRadius))
        //        using (GraphicsPath pathBorder = Rounding.GetFigurePath(rectBorder, borderRadius - 1F))
        //        using (Pen penSurface = new Pen(backColor, 1))
        //        using (Pen penBorder = new Pen(borderColor, borderSize))
        //        {
        //            penBorder.Alignment = PenAlignment.Inset;

        //            Region = new Region(pathSurface);
        //            pevent.Graphics.DrawPath(penSurface, pathSurface);

        //            if (borderSize >= 1)
        //                pevent.Graphics.DrawPath(penBorder, pathBorder);

        //        }
        //    }
        //    else
        //    {
        //        Region = new Region(rectSurface);
        //        if (borderSize >= 1)
        //        {
        //            using (Pen penBorder = new Pen(borderColor, borderSize))
        //            {
        //                penBorder.Alignment = PenAlignment.Inset;
        //                pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
        //            }

        //        }
        //    }

        //}
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
                //Draw borders
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = PenAlignment.Inset;

                    
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5F);
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

        public CustomComboBox()
        {
            cmbList = new ComboBox();
            lblText= new Label();
            btnIcon= new Button();

            //Drop down
            cmbList.BackColor = backColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += CmbList_SelectedIndexChanged;
            cmbList.TextChanged += CmbList_TextChanged;

            //button: Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.Margin = new Padding(10);
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.FlatAppearance.BorderColor = Color.White;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += BtnIcon_Click;
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            //label: Text
            lblText.Margin = new Padding(7, 10, 0, 10);
            lblText.AutoSize = false;
            lblText.Dock = DockStyle.Fill;
            lblText.Padding = new Padding(0, 0, 0, 0);
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Font = new Font(this.Font.Name, 10f);
            lblText.Click += LblText_Click;
            
            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(200, 46);
            this.Size = new Size(200, 46);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);
            base.BackColor = backColor;
            this.ResumeLayout();
            AdjustComboBoxDimension();
        }

        
    }
}
