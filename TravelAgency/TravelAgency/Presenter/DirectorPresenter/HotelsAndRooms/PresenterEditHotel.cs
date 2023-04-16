using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Models.DirectorModels.HotelsAndRooms;
using TravelAgency.Views.DirectorViews.HotelAndRooms;

namespace TravelAgency.Presenter.DirectorPresenter.ToursAndAdditionalTours
{
    internal class PresenterEditHotel
    {
        IViewEditHotel view;
        ModelEditHotel model;

        public PresenterEditHotel(IViewEditHotel view, ModelEditHotel model)
        {
            this.view = view;
            this.model = model;

            view.SearchHotel += View_SearchHotel;
            view.EditHotels += View_EditHotel;
        }

        private void View_SearchHotel(object sender, EventArgs e)
        {
            model.GetInfo(view.ID);
            view.Name = model.Name;
            view.CheckOut = model.CheckOut;
            view.CheckIn = model.CheckIn;
            view.Category = model.Category;
            view.City = model.City;
            view.Location = model.Location;
            view.Photo = model.Photo;

            view.Facilities = model.GetFacilitiesInHotel(view.ID);
            
        }

        private void View_EditHotel(object sender, EventArgs e)
        {
            view.Error = model.UpdateHotel(view.Name, view.Category, view.City, view.Location, view.Photo, view.CheckIn, view.CheckOut, view.Facilities, view.ID);
        }

        public void Show()
        {
            view.facilites = model.GetFacilities();
            view.cities = model.GetCity();
            view.IDhotel = model.GetID();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
