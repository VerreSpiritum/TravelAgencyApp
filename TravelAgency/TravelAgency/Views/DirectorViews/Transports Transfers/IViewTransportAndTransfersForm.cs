using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views
{
    internal interface IViewTransportAndTransfersForm
    {
        void ShowForm();
        void CloseForm();
        void addOnPanelForm(Form form);
        void OpenWindow();
        void ChangeStyle(string text);

        event EventHandler OpenFormEditTransports;
        event EventHandler OpenFormToShowTransfers;
        event EventHandler OpenFormCreateNewTransport;
        event EventHandler OpenFormShowTransports;
        event EventHandler OpenFormEditTransfers;
        event EventHandler OpenFormCreateTransfers;
    }
}
