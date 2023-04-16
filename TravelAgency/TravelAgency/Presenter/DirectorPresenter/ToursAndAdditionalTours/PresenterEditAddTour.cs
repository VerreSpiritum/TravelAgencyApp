using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.ToursAndAdditionalTours;
using TravelAgency.Views.DirectorViews.ToursAndAdditionalTours;

namespace TravelAgency.Presenter.DirectorPresenter.ToursAndAdditionalTours
{
    internal class PresenterEditAddTour
    {
        IViewEditAddTour view;
        ModelEditAddTour model;

        public PresenterEditAddTour(IViewEditAddTour view, ModelEditAddTour model)
        {
            this.view = view;
            this.model = model;

            view.SearchAddTour += View_SearchTour;
            view.EditAddTours += View_EditThisTour;
        }

        private void View_EditThisTour(object sender, EventArgs e)
        {
            model.UpdateIntoTour(view.InfoToEdit, view.cityInTour, view.ID);
            if (String.IsNullOrEmpty(model.Error))
            {
                view.Error = model.Error;
            }
        }

        private void View_SearchTour(object sender, EventArgs e)
        {
            view.LastInfoInTable = model.GetLastInfo(view.ID);
            view.LastCitiesInTour = model.GetLastInfoInTourCity(view.ID);
        }

        public void Show()
        {
            view.DepCity = model.GetCity(true);
            view.CitiesToVisit = model.GetCity(false);
            view.ShowForm(model.GetListOfTourNum());
        }
        public void Show(int ID)
        {
            view.DepCity = model.GetCity(true);
            view.CitiesToVisit = model.GetCity(false);

            view.ID = ID;
            view.LastInfoInTable = model.GetLastInfo(ID);
            view.LastCitiesInTour = model.GetLastInfoInTourCity(ID);

            view.isFromTable = true;
            view.ShowForm(model.GetListOfTourNum());
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
