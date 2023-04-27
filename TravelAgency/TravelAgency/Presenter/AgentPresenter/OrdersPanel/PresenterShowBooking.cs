using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.AgentModels.BookingsPanel;
using TravelAgency.Views.AgentViews.Booking;

namespace TravelAgency.Presenter.AgentPresenter.OrdersPanel
{
    internal class PresenterShowBooking
    {
        ModelShowBookings model;
        IViewShowBookings view;

        public PresenterShowBooking(ModelShowBookings model, IViewShowBookings view)
        {
            this.model = model;
            this.view = view;

            view.DeleteBooking += View_DeleteBooking;
        }

        private void View_DeleteBooking(object sender, EventArgs e)
        {
            if (model.DeleteBooking(view.TalonNum) == "")
                view.CheckError = 1;
            else
                view.CheckError = 0;
        }

        public void Show()
        {
            view.bookingInfo = model.GetInfo();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
