using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.ToursAndAdditionalTours;
using TravelAgency.Views.DirectorViews.ToursAndAdditionalTours;

namespace TravelAgency.Presenter.DirectorPresenter.ToursAndAdditionalTours
{
    internal class PresenterShowHotels
    {
        IViewShowHotels view;
        ModelShowHotels model;

        public PresenterShowHotels(IViewShowHotels view, ModelShowHotels model)
        {
            this.view = view;
            this.model = model;

            view.DeleteHotel += View_DeleteHotel;
        }

        private void View_DeleteHotel(object sender, EventArgs e)
        {
            view.CheckError = model.DeleteHotel(view.ID);
        }

        public void Show()
        {
            view.ListOfHotels = model.ShowHotels();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
