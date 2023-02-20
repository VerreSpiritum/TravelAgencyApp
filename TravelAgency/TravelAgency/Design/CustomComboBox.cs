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
    internal class CustomComboBox: ComboBox
    {
        //What i need to do
        /*Make field to 
         * To change size
         * To set border size
         * To set border color
         * To set border radius
         * To set color of control
         */
        #region --- Fields ---
        private int borderSize = 1;
        private Color borderColor = Color.Black;
        private int borderRadius = 0;
        private Color skinColor = Color.White;

        //constructor to open fields

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
        #endregion

    }
}
