using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views.AgentViews.Service_Panel;

namespace TravelAgency.Presenter.AgentPresenter.ServicePanel
{
    internal class PresenterServicePanel
    {
        IViewServicePanel view;
        public event EventHandler ShowTour;
        public event EventHandler ShowAddTour;
        public event EventHandler ShowHotel;
        public event EventHandler ShowTransfer;

        public PresenterServicePanel(IViewServicePanel view)
        {
            this.view = view;

            view.ShowTour += View_ShowTour;
            view.ShowAddTour += View_ShowAddTour;
            view.ShowHotel += View_ShowHotel;
            view.ShowTransfer += View_ShowTransfer;
        }

        private void View_ShowTransfer(object sender, EventArgs e)
        {
            ShowTransfer?.Invoke(this, EventArgs.Empty);
        }

        private void View_ShowHotel(object sender, EventArgs e)
        {
            ShowHotel?.Invoke(this, EventArgs.Empty);
        }

        private void View_ShowAddTour(object sender, EventArgs e)
        {
            ShowAddTour?.Invoke(this, EventArgs.Empty);

        }

        private void View_ShowTour(object sender, EventArgs e)
        {
            ShowTour?.Invoke(this, EventArgs.Empty);
        }

        public void AddOnPanel(Form form)
        {
            view.addOnPanelForm(form);
        }
        public void Show()
        {
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
