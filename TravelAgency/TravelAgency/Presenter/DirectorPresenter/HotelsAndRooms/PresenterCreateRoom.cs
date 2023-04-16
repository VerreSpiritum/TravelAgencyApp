using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.HotelsAndRooms;
using TravelAgency.Views.DirectorViews.HotelAndRooms;

namespace TravelAgency.Presenter.DirectorPresenter.ToursAndAdditionalTours
{
    internal class PresenterCreateRoom
    {
        IViewCreateRooms view;
        ModelCreateRoom model;

        public PresenterCreateRoom(IViewCreateRooms view, ModelCreateRoom model)
        {
            this.view = view;
            this.model = model;

            view.CreateRoom += View_CreateRoom;
        }

        private void View_CreateRoom(object sender, EventArgs e)
        {
            view.Error = model.CreateNewRoom(view.Name, view.RoomGrade, view.Meals, view.Photo, view.Info, view.Period, view.Price, view.Facilities);
        }

        public void Show()
        {
            view.facilites = model.GetFacilities();
            view.Hotel = model.GetHotels();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
