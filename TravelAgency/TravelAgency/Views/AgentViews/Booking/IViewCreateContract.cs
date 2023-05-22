using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views.AgentViews.Booking
{
    internal interface IViewCreateContract
    {
        string ResultOfAdding { get; set; } 
        int Book { get; set; }
        string Client { get; set; }
        string TextOfContract { get; set; }

        DataTable DataTableInfoAboutBooking { get; set; }
        List<double> costChanging { get; set; }

        event EventHandler sendInfo;
        event EventHandler GetInfoAboutAboutPrice;
        
        
        void CloseForm();

        void ShowForm();
    }
}
