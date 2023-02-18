using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views
{
    internal interface IViewHumanResoucesForm
    {
        void ShowForm();
        void CloseForm();
        void addOnPanelCreateNewStaff(CreateNewStaff form);

        event EventHandler OpenFormCreateNewStaff;
    }
}
