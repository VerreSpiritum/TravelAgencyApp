using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TravelAgency.Director.DirectorView
{
    internal interface IViewTourAndAdditionalTour
    {
        event EventHandler ShowAllTours;
        event EventHandler EditTour;
        event EventHandler CreateTour;
        event EventHandler ShowAllAddTours;
        event EventHandler EditAddTour;
        event EventHandler CreateAddTour;

        void ShowForm();
        void CloseForm();

        void OpenWindow();
        void addOnPanelForm(Form form);
        void ChangeStyle(string text);
    }
}
