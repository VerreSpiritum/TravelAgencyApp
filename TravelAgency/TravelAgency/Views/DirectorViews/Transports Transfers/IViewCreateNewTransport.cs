using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views.DirectorViews.Transports_Transfers
{
    internal interface IViewCreateNewTransport
    {
        DataTable facilites { get; set; }
        string Name { get; set; }
        int CountOfSeats { get; set; }
        string ReleaseDate { get; set; }
        string ShortInfo { get; set; }
        string linkPhoto { get; set; }
        List<string> Facilities { get; set; }

        string ResultOfAdding { get; set; }


        event EventHandler sendInfo;

        void CloseForm();
        void ShowForm();
    }
}
