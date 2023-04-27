using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Views.AgentViews.Service_Panel
{
    internal interface IViewShowTourToStaff
    {
        void ShowForm(DataTable dt);
        void CloseForm();
    }
}
