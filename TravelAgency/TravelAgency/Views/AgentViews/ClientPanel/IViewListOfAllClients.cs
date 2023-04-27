using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views
{
    internal interface IViewListOfAllClients
    {
        int TalonNum { get; set; }
        int CheckError { get; set; }
        DataTable clientInfo { get; set; }

        event EventHandler DeleteCustomer;

        void ShowForm();
        void CloseForm();

    }
}
