using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views
{
    internal interface IViewCreateUsers
    {
        void ShowForm();

        void CloseForm();

        event EventHandler UpdateInfo;
        event EventHandler CanClose;

        string ErrorMess { get; set; }
        string Password { get; set; }
        int TalonNum { get; set; }
    }
}
