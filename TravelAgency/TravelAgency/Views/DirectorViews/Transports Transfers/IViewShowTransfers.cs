using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views.DirectorViews.Transports_Transfers
{
    internal interface IViewShowTransfers
    {
        void ShowForm();
        void CloseForm();

        int IdT { get; set; }
        DataTable TransfersInfo { get; set; }
        int CheckError { get; set; }

        event EventHandler DeleteTransfer;
        event EventHandler EditTransfer;
    }
}
