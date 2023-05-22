using System;
using System.Data;

namespace TravelAgency.Views.AgentViews.Booking
{
    public interface IViewShowAllContract
    {
        void ShowForm(DataTable info);
        void CloseForm();
        string text { get; set; }
        int ID { get; set; }
        event EventHandler GetText;
    }
}