using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views.DirectorViews.Transports_Transfers
{
    internal interface IViewShowTransports
    {
        int IdT { get; set; }
        int CheckError { get; set; }
        DataTable TransportInfo { get; set; }

        event EventHandler DeleteTransport;
        event EventHandler EditTransport;

        void ShowForm();
        void CloseForm();
    }
}
