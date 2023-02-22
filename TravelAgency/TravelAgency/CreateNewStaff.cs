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
using TravelAgency.Views;

namespace TravelAgency
{
    public partial class CreateNewStaff : Form, IViewCreateNewStaff
    {
        public CreateNewStaff()
        {
            InitializeComponent();
            
            nameL.ForeColor = surnameL.ForeColor = secondNameL.ForeColor = ColorTranslator.FromHtml("#7B7B7B");
        }

       
        public void CloseForm()
        {
            this.Hide();
        }

        public void ShowForm()
        {
            this.Show();
        }

        private void customComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void customMaskedTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void customTextBox3__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
