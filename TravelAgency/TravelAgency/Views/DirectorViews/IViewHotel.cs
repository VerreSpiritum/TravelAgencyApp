using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views.DirectorViews
{
    internal interface IViewHotel
    {
        void ShowForm();
        void CloseForm();
        void addOnPanelForm(Form form);

        event EventHandler ShowHotels;
        event EventHandler CreateHotel;
        event EventHandler EditHotel;
        event EventHandler ShowRoom;
        event EventHandler CreateRoom;
        event EventHandler EditRooms;

    }
}
