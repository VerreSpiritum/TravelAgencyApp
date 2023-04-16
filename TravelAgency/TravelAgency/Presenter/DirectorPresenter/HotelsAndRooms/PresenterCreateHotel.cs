using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.HotelsAndRooms;
using TravelAgency.Views.DirectorViews.HotelAndRooms;

namespace TravelAgency.Presenter.DirectorPresenter.ToursAndAdditionalTours
{
    internal class PresenterCreateHotel
    {
        IViewCreateHotel view;
        ModelCreateHotel model;

        public PresenterCreateHotel(IViewCreateHotel view, ModelCreateHotel model)
        {
            this.view = view;
            this.model = model;

            view.CreateHotel += View_CreateHotel;
        }

        private void View_CreateHotel(object sender, EventArgs e)
        {
            view.Error = model.CreateNewHotel(view.Name, view.Category, view.City, view.Location, view.Photo, view.CheckIn, view.CheckOut, view.Facilities);
        }

        public void Show()
        {
            view.facilites = model.GetFacilities();
            view.cities = model.GetCity();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
