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
        
        void CloseForm();
        void ShowForm(List<string> transport, List<string> depCity, List<string> cityToVisit);
        
        event EventHandler SearchInfo;
        event EventHandler UpdateInfo;
    }
}
