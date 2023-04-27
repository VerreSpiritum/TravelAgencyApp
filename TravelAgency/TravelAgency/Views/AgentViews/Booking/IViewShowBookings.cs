using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views.AgentViews.Booking
{
    internal interface IViewShowBookings
    {
        void ShowForm();
        void CloseForm();
        int TalonNum { get; set; }
        DataTable bookingInfo { get; set; }
        int CheckError { get; set; }

        event EventHandler DeleteBooking;
        event EventHandler AddContract;
    }
}
