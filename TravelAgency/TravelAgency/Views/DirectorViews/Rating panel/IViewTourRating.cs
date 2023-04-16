using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views.DirectorViews.Booker_panel
{
    internal interface IViewTourRating
    {
        void ShowForm();
        void CloseForm();

        DataTable ListOfStaff { get; set; }
    }
}
