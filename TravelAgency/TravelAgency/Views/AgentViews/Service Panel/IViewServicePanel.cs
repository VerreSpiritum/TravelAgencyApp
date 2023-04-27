using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views.AgentViews.Service_Panel
{
    internal interface IViewServicePanel
    {
        void ShowForm();
        void CloseForm();

        void OpenWindow();
        void addOnPanelForm(Form form);
        void ChangeStyle(string text);

        event EventHandler ShowTour;
        event EventHandler ShowAddTour;
        event EventHandler ShowHotel;
        event EventHandler ShowTransfer;
    }
}
