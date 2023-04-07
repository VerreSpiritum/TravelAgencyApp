using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views.DirectorViews.Transports_Transfers
{
    internal interface IViewCreateTransfer 
    {
        Dictionary<string, object> dataToAdd { get; set; }
        event EventHandler CreateTransfer;
        event EventHandler ShowCountOfSeats;
        string Error { get; set; }
        string Name { get; set; }

        void SetCount(int count);
        void ShowForm(List<string> transport, List<string> depCity, List<string> cityToVisit);
        void CloseForm();
    }
}
