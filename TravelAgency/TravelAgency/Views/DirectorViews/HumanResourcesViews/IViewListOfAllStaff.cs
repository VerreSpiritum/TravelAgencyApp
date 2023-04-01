using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views
{
    internal interface IViewListOfAllStaff
    {
        int TalonNum { get; set; }
        int CheckError { get; set; }
        DataTable staffInfo { get; set; }

        event EventHandler DeleteEmployee;
        event EventHandler EditEmployee;

        void ShowForm();
        void CloseForm();

    }
}
