using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views.DirectorViews.HotelAndRooms
{
    internal interface IViewEditHotel
    {
        List<string> Facilities { get; set; }
        List<int> IDhotel { get; set; }
        DataTable facilites { get; set; }
        List<string> cities { get; set; }

        int ID { get; set; }
        string Name { get; set; }
        string Category { get; set; }
        string City { get; set; }
        string Location { get; set; }
        string Photo { get; set; }
        string CheckIn { get; set; }
        string CheckOut { get; set; }
        string Error { get; set; }

        void ShowForm();
        void CloseForm();

        event EventHandler EditHotels;
        event EventHandler SearchHotel;

    }
}
