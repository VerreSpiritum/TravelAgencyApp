using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views.DirectorViews.ToursAndAdditionalTours
{
    internal interface IViewCreateNewAddTour
    {
        List<string> DepCity { get; set; }
        List<string> CitiesToVisit { get; set; }
        string Error { get; set; }
        Dictionary<string, object> InfoToAdd { get; }
        DataTable cityInTour { get; }

        event EventHandler CreateTour;

        void ShowForm();
        void CloseForm();
    }
}
