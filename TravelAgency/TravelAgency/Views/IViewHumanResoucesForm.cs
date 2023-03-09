using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views
{
    internal interface IViewHumanResoucesForm
    {
        void ShowForm();
        void CloseForm();
        void addOnPanelCreateNewStaff(Form form);

        event EventHandler OpenFormEditEmployee;
        event EventHandler OpenFormDeleteEmployee;
        event EventHandler OpenFormCreateNewStaff;
        event EventHandler OpenFormCreateNewUser;
    }
}
