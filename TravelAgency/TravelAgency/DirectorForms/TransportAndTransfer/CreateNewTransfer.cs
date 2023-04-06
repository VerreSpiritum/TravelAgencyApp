using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Design;
using TravelAgency.Views;
using TravelAgency.Views.DirectorViews.Transports_Transfers;

namespace TravelAgency
{
    public partial class CreateNewTransfer : Form
    {
        private string name;
        private List<CheckBox> radioButtons = new List<CheckBox>();
        private List<string> facility = new List<string>();

        public CreateNewTransfer()
        {
            InitializeComponent();
            
            createTransportB.BackgroundColor = ColorTranslator.FromHtml("#5AACB8"); 
        }
        #region --- Interface ---

        public void CloseForm()
        {
            this.Close();
        }

        public void ShowForm()
        {
            this.Show();
        }
        #endregion
       

        private void ReleaseDateTB__TextChanged(object sender, EventArgs e)
        {
            
            if (CostTB.Texts == null)
                CostTB.BorderColor = Color.Red;
            else
                CostTB.BorderColor = Color.Black;
        }

        private void customMaskedTextBoxDate1__TextChanged(object sender, EventArgs e)
        {
            
            if (CountOfSeatsTB.Texts == null)
                CountOfSeatsTB.BorderColor = Color.Red;
            else
                CountOfSeatsTB.BorderColor = Color.Black;
        }

        private void createTransportB_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateNewTransfer_Load(object sender, EventArgs e)
        {

        }
    }
}
