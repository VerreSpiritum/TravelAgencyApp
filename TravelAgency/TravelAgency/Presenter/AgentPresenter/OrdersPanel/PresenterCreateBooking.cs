using System;
using System.Data.SqlTypes;
using TravelAgency.Models.AgentModels.BookingsPanel;
using TravelAgency.Views.AgentViews.Booking;

namespace TravelAgency.Presenter.AgentPresenter.OrdersPanel
{
    public class PresenterCreateBooking
    {
        private ModelCreateBooking model;
        private IViewCreateBooking view;

        public PresenterCreateBooking(ModelCreateBooking model, IViewCreateBooking view)
        {
            this.model = model;
            this.view = view;
            
            view.GetAddTour += ViewOnGetAddTour;
            view.GetCitiesFromAddTour += ViewOnGetCitiesFromAddTour;
            view.CreateBook += ViewOnCreateBook;
            view.GetTransport += ViewOnGetTransport;
        }

        private void ViewOnGetTransport(object sender, EventArgs e)
        {
            view.Transport = model.GetTransport(view.ID);
        }

        private void ViewOnCreateBook(object sender, EventArgs e)
        {
            model.CreateBooking(view.ID, view.IDclient);
            
            if(view.IDAT > 0 && String.IsNullOrEmpty(model.Error))
                model.CreateBookingWithAddTour(view.IDAT);
            if(view.HotelInTour != null && String.IsNullOrEmpty(model.Error))
                model.CreateBookingWithHotel(view.HotelInTour);
            if(view.IDTransport > 0 && String.IsNullOrEmpty(model.Error))
                model.CreateBookingWithTransfer(view.IDTransport);
            if (model.Error != null)
                view.Error = model.Error;
        }

        private void ViewOnGetCitiesFromAddTour(object sender, EventArgs e)
        {
            view.infoCitiesAndHotels = model.GetHotelAddTour(view.ID);
        }

        private void ViewOnGetAddTour(object sender, EventArgs e)
        {
            view.infoAddTour = model.GetAddTour(view.ID);
            view.infoCitiesAndHotels = model.GetHotelTour(view.ID);
        }
        
        
        
        public void Show()
        {
            view.infoTour = model.GetTour();
            view.client = model.GetClient();
            view.ShowForm();
        }

        public void Close()
        {
            view.CloseForm();
        }
    }
}