using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views.DirectorViews.Transports_Transfers
{
    internal interface IViewEditTransfer
    {
        int ID { get; set; }
        string Error { get; set; }
        int ResultOfSearching { get; set; }
        List<object> InfoFromTable { get; set; }
        Dictionary<string, object> dataToUpdate { get; }
        bool IsFromTable { get; set; }

        void CloseForm();
        void ShowForm(List<string> transport, List<string> depCity, List<string> cityToVisit);
        void ShowInfoFromTable(List<object> info, int id);


        event EventHandler SearchInfo;
        event EventHandler UpdateInfo;
    }
}
