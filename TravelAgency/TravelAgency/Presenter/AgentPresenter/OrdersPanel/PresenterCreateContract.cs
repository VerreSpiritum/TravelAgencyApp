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
        private int agent;

        public PresenterCreateContract(IViewCreateContract view, ModelCreateContract model, int id_agent)
        {
            this.view = view;
            this.model = model;
            agent = id_agent;
            
            view.GetInfoAboutAboutPrice += ViewOnGetInfoAboutAboutPrice;
            view.sendInfo += ViewOnsendInfo;
        }

        private void ViewOnsendInfo(object sender, EventArgs e)
        {
            view.TextOfContract = model.GetContract(view.Book, agent);
            view.DataTableInfoAboutBooking = model.GetInfo();

        }

        private void ViewOnGetInfoAboutAboutPrice(object sender, EventArgs e)
        {
            
            model.GetPrice(view.Book, view.Client);
            List<double> temp = new List<double> { Convert.ToInt32(model.Cost), (int)model.Discount, (int)(model.Cost - model.Discount)};
            view.costChanging = temp;

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
