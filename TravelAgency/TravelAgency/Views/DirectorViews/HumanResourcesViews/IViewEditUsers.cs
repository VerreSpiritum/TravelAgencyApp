using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views
{
    internal interface IViewEditUsers
    {
         void ShowForm();

         void CloseForm();

         event EventHandler GetInfo;
         event EventHandler UpdateInfo;

         string Login { get; set; }
         string Password { get; set; }
    }
}
