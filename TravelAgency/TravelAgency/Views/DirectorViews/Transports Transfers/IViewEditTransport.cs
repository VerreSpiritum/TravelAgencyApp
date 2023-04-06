using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views.DirectorViews.Transports_Transfers
{
    internal interface IViewEditTransport
    {
        int ID { get; set; }
        List<string> Facilities { get; set; }
        string ResultOfAdding { get; set; }
        int ResultOfSearching { get; set; }
        bool IsFromTable { get; set; }

        DataTable facilites { get; set; }
        Dictionary<string, object> InfoToUpdate { get; set; }
        Dictionary<string, bool> AddOrDeleteFacilities {  get; set; }

        event EventHandler sendInfo;
        event EventHandler searchInfo;

        void CloseForm();
        void AddInfo(List<object> info);
        void AddFacilities();
        void ShowForm();
    }
}
