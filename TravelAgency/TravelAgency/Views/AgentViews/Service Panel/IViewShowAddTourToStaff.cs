using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Views.AgentViews.Service_Panel
{
    internal interface IViewShowAddTourToStaff
    {
        void ShowForm(DataTable dt);
        void CloseForm();

    }
}
