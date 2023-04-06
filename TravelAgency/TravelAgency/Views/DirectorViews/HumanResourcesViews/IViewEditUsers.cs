using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views
{
    internal interface IViewEditUsers
    {
        void ShowForm(string login);

        void CloseForm();

        event EventHandler GetInfo;
        event EventHandler UpdateInfo;
        event EventHandler CloseWindow;

        string Login { get; set; }
        string Password { get; set; }
    }
}
