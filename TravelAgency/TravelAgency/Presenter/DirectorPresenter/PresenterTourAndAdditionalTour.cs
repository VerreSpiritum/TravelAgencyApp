using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Director.DirectorView;
using System.Windows.Forms;

namespace TravelAgency.Presenter.DirectorPresenter
{
    internal class PresenterTourAndAdditionalTour
    {
        IViewTourAndAdditionalTour view;
        public event EventHandler ShowAllTours;
        public event EventHandler EditTour;
        public event EventHandler CreateTour;
        public event EventHandler ShowAllAddTours;
        public event EventHandler EditAddTour;
        public event EventHandler CreateAddTour;

        public PresenterTourAndAdditionalTour(IViewTourAndAdditionalTour view)
        {
            this.view = view;
            view.ShowAllTours += View_ShowAllTours;
            view.ShowAllAddTours += View_ShowAllAddTours;
            view.CreateTour += View_CreateTour;
            view.CreateAddTour += View_CreateAddTour;
            view.EditTour += View_EditTour;
            view.EditAddTour += View_EditAddTour;
        }

        private void View_EditAddTour(object sender, EventArgs e)
        {
            EditAddTour?.Invoke(this, EventArgs.Empty);
        }

        private void View_EditTour(object sender, EventArgs e)
        {
            EditTour?.Invoke(this, EventArgs.Empty);
        }

        private void View_CreateAddTour(object sender, EventArgs e)
        {
            CreateAddTour?.Invoke(this, EventArgs.Empty);
        }

        public void ChangeStyle(string text)
        {
            view.ChangeStyle(text);
        }
        private void View_CreateTour(object sender, EventArgs e)
        {
            CreateTour?.Invoke(this, EventArgs.Empty);
        }

        private void View_ShowAllAddTours(object sender, EventArgs e)
        {
            ShowAllAddTours?.Invoke(this, EventArgs.Empty);
        }

        private void View_ShowAllTours(object sender, EventArgs e)
        {
            ShowAllTours?.Invoke(this, EventArgs.Empty);
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
