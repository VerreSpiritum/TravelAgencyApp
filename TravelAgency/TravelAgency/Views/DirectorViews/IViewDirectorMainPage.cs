using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views
{
    public interface IViewDirectorMainPage
    {
        bool humanResourcesOpen { get; set; }

        void ShowForm();
        void addOnPanel(Form form);

        event EventHandler OpenHumanResourcesForm;
        event EventHandler OpenTransportsAndTransfersForm;
        event EventHandler CloseConnection;
        event EventHandler OpenHotelInfoForm;
        event EventHandler OpenTourAddTourForm;
        event EventHandler BookerForm; 
        event EventHandler RatingsForm;
    }
}
