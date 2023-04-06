using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TravelAgency.Views
{
    internal interface IViewShowUsers
    {
        void ShowForm();
        void CloseForm();
        void addOnPanelForm(Form form);
        void RefreshTable();

        DataTable userInfo { get; set; }
        int CheckError { get; set; }
        string LoginToAccess { get; set; }
        int TalonNum { get; set; }

        event EventHandler DeleteUser;
        event EventHandler EditUser;
        event EventHandler CreateUser;
    }
}
