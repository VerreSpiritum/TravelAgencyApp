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
        void addOnPanelForm(Form form);
        void OpenWindow();
        void ChangeStyle(string text);

        event EventHandler OpenFormEditEmployee;
        event EventHandler OpenFormToShowUsers;
        event EventHandler OpenFormCreateNewStaff;
        event EventHandler OpenFormCreateNewUser;
        event EventHandler OpenFormShowStaff;
    }
}
