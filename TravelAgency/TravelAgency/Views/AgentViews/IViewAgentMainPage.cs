using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views
{
    public interface IViewAgentMainPage
    {
        bool humanResourcesOpen { get; set; }

        void ShowForm();
        void addOnPanel(Form form);

        event EventHandler OpenPersonalInfoForm;
        event EventHandler OpenClientForm;
        event EventHandler OpenOrdersPanel;
        event EventHandler CloseConnection;
        event EventHandler OpenPanelToShowServices;
    }
}
