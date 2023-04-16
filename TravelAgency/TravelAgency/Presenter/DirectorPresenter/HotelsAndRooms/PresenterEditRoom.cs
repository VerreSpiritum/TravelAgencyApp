using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.HotelsAndRooms;
using TravelAgency.Views.DirectorViews.HotelAndRooms;

namespace TravelAgency.Presenter.DirectorPresenter.ToursAndAdditionalTours
{
    internal class PresenterEditRoom
    {
        IViewEditRoom view;
        ModelEditRoom model;

        public PresenterEditRoom(IViewEditRoom view, ModelEditRoom model)
        {
            this.view = view;
            this.model = model;

            view.CreateRoom += View_CreateRoom;
            view.SearchRoom += View_SearchRoom;
        }

        private void View_SearchRoom(object sender, EventArgs e)
        {
            model.GetLastRoomInfo(view.ID);

            view.RoomGrade = model.roomGrade;
            view.Meals = model.meals;
            view.Photo = model.photo;
            view.Info = model.info;
            view.Period = model.period;
            view.Price = model.price;

            view.Facilities = model.GetFacilitiesInRoom(view.ID);
        }

        private void View_CreateRoom(object sender, EventArgs e)
        {
            view.Error = model.EditRoom(view.Name, view.RoomGrade, view.Meals, view.Photo, view.Info, view.Period, view.Price, view.Facilities, view.ID);
        }

        public void Show()
        {
            view.facilites = model.GetFacilities();
            view.Hotel = model.GetHotels();
            view.idRoom = model.GetInfoAboutRooms();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
