using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views.DirectorViews;

namespace TravelAgency
{
    public partial class RatingsPanel : Form, IViewRatingPanel
    {
        private List<Label> menu = new List<Label>();
        public RatingsPanel()
        {
            InitializeComponent();

            tourRatingL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            menu.Add(tourRatingL);
            menu.Add(agencyPopL);

        }
        #region --- Interface ---

        public event EventHandler tourRating;
        public event EventHandler AgecyPopylarity;

        public void ShowForm()
        {
            this.Show();
        }
        public void CloseForm()
        {
            this.Hide();
        }
        public void addOnPanelForm(Form form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            panelToWork.Controls.Add(form);
        }

        public void OpenWindow()
        {
            tourRatingL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            agencyPopL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
        }
        
        public void ChangeStyle(string text)
        {
            foreach(Label control in menu)
            {
                if (control.Text == text)
                {
                    control.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
                }
                else
                {
                    control.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
                }
            }
        }
        #endregion

        private void tourRatingL_Click(object sender, EventArgs e)
        {
            tourRatingL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            agencyPopL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            tourRating?.Invoke(this, EventArgs.Empty);  
        }

        private void agencyPopL_Click(object sender, EventArgs e)
        {
            agencyPopL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            tourRatingL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            AgecyPopylarity?.Invoke(this, EventArgs.Empty);
        }
    }
}
