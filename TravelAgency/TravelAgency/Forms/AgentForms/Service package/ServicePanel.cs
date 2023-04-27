using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views.AgentViews.Service_Panel;

namespace TravelAgency
{
    public partial class ServicePanel : Form, IViewServicePanel
    {
        private List<Label> menu = new List<Label>();
        public ServicePanel()
        {
            InitializeComponent();

            allTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            menu.Add(allTourL);
            menu.Add(allAddTourL);

        }
        #region --- Interface ---
        public event EventHandler ShowTour;
        public event EventHandler ShowAddTour;
        public event EventHandler ShowHotel;
        public event EventHandler ShowTransfer;

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
            allTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allAddTourL.Font = hotelInfo.Font = TransferInfoL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

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

        private void allTourL_Click(object sender, EventArgs e)
        {
            allTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allAddTourL.Font = hotelInfo.Font = TransferInfoL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);
            
            ShowTour?.Invoke(this, EventArgs.Empty);
        }

        private void allAddTourL_Click(object sender, EventArgs e)
        {
            allAddTourL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allTourL.Font = hotelInfo.Font = TransferInfoL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            ShowAddTour?.Invoke(this, EventArgs.Empty); 
        }

        private void hotelInfo_Click(object sender, EventArgs e)
        {
            hotelInfo.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allAddTourL.Font = allTourL.Font = TransferInfoL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            ShowHotel?.Invoke(this, EventArgs.Empty);
        }

        private void TransferInfoL_Click(object sender, EventArgs e)
        {
            TransferInfoL.Font = new Font("Franklin Gothic", 16, FontStyle.Bold);
            allAddTourL.Font = hotelInfo.Font = allTourL.Font = new Font("Franklin Gothic Book", 16, FontStyle.Regular);

            ShowTransfer?.Invoke(this, EventArgs.Empty);
        }
    }
}
