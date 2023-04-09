using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.ToursAndAdditionalTours;
using TravelAgency.Views.DirectorViews.ToursAndAdditionalTours;

namespace TravelAgency.Presenter.DirectorPresenter.ToursAndAdditionalTours
{
    internal class PresenterCreateNewTour
    {
        IViewCreateNewTour view;
        ModelCreateNewTour model;

        public PresenterCreateNewTour(IViewCreateNewTour view, ModelCreateNewTour model)
        {
            this.view = view;
            this.model = model;

            view.CreateTour += View_CreateTour;
        }

        private void View_CreateTour(object sender, EventArgs e)
        {
            model.InsertIntoTour(view.InfoToAdd, view.cityInTour);
            if (!String.IsNullOrEmpty(model.Error))
                view.Error = model.Error;
        }

        public void Show()
        {
            view.DepCity = model.GetCity(true);
            view.CitiesToVisit = model.GetCity(false);
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
