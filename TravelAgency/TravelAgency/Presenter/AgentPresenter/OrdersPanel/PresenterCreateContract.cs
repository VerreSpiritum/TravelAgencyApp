using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Forms.AgentForms.OrdersPanel;
using TravelAgency.Views.AgentViews.Booking;

namespace TravelAgency.Presenter.AgentPresenter.OrdersPanel
{
    internal class PresenterCreateContract
    {
        IViewCreateContract view;
        ModelCreateContract model;

        public PresenterCreateContract(IViewCreateContract view, ModelCreateContract model)
        {
            this.view = view;
            this.model = model;
        }

        public void Show()
        {
            view.DataTableInfoAboutBooking = model.GetInfo();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
