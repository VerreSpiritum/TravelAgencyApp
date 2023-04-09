using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views.DirectorViews.ToursAndAdditionalTours
{
    internal interface IViewShowAddTours
    {
        void ShowForm();
        void CloseForm();

        int ID { get; set; }
        DataTable ListOfTours { get; set; }
        int CheckError { get; set; }

        event EventHandler DeleteTour;
        event EventHandler EditTour;
    }
}
