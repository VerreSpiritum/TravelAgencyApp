using System;
using TravelAgency.Models.AgentModels.BookingsPanel;
using TravelAgency.Views.AgentViews.Booking;

namespace TravelAgency.Presenter.AgentPresenter.OrdersPanel
{
    public class PresenterShowAllContract
    {
        private ModelShowAllContract model;
        private IViewShowAllContract view;

        public PresenterShowAllContract(ModelShowAllContract model, IViewShowAllContract view)
        {
            this.model = model;
            this.view = view;
            
            view.GetText += ViewOnGetText;
        }

        private void ViewOnGetText(object sender, EventArgs e)
        {
            view.text = model.GetContract(view.ID);
        }

        public void Show()
        {
            view.ShowForm(model.GetInfo());
        }

        public void Close()
        {
            view.CloseForm();
        }
    }
}