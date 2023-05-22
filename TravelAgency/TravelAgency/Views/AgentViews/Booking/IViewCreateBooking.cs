using System;
using System.Collections.Generic;
using System.Data;

namespace TravelAgency.Views.AgentViews.Booking
{
    public interface IViewCreateBooking
    {
        void ShowForm();
        DataTable infoTour { get; set; }
        int ID { get; set; }
        DataTable infoAddTour { get; set; }
        DataTable infoCitiesAndHotels { get; set; }
        DataTable client { get; set; }
        int IDTransport { get; set; }
        DataTable Transport { get; set; }
        int IDclient { get; set; }
        int IDAT { get; set; }
        List<int> HotelInTour { get; set; }
        string Error { get; set; }

        void CloseForm();
        
        event EventHandler GetAddTour;
        event EventHandler GetCitiesFromTour;
        event EventHandler GetCitiesFromAddTour;
        event EventHandler CreateBook;
        event EventHandler GetTransport;
    }
}