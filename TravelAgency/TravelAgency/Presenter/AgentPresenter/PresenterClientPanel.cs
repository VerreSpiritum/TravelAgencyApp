using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Director.DirectorView;
using TravelAgency.Views.DirectorViews;

namespace TravelAgency.Presenter.DirectorPresenter
{
    internal class PresenterClientPanel
    {
        IViewClientPanel view;

        public event EventHandler AddClient;
        public event EventHandler ShowListOfCLient;

        public PresenterClientPanel(IViewClientPanel view)
        {
            this.view = view;

            view.AddClient += View_AddClient;
            view.ShowListOfCLient += View_ShowListOfCLient;
        }

        private void View_ShowListOfCLient(object sender, EventArgs e)
        {
            ShowListOfCLient?.Invoke(this, EventArgs.Empty);
        }

        private void View_AddClient(object sender, EventArgs e)
        {
            AddClient?.Invoke(this, EventArgs.Empty);
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
