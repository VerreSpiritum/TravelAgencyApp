using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views.DirectorViews.ToursAndAdditionalTours
{
    internal interface IViewEditTour
    {
        List<string> DepCity { get; set; }
        List<string> CitiesToVisit { get; set; }
        string Error { get; set; }
        Dictionary<string, object> InfoToEdit { get; }

        List<object> LastInfoInTable { get; set; }
        DataTable LastCitiesInTour { get; set; }
        DataTable cityInTour { get; }
        int ID { get; set; }
        bool isFromTable { get; set; }

        event EventHandler EditThisTour;
        event EventHandler SearchTour;

        void ShowForm(List<object> tourNum);
        void CloseForm();
    }
}
