﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views.AgentViews.Booking;

namespace TravelAgency.Presenter.AgentPresenter.OrdersPanel
{
    internal class PresenterOrdersPanel
    {
        IViewOrdersPanel view;

        public event EventHandler ShowAllBookings;
        public event EventHandler ShowAllContracts;


        public PresenterOrdersPanel(IViewOrdersPanel view)
        {
            this.view = view;

            view.ShowContracts += View_ShowContracts;
            view.ShowAllBookings += View_ShowAllBookings;
        }

        private void View_ShowAllBookings(object sender, EventArgs e)
        {
            ShowAllBookings?.Invoke(this, EventArgs.Empty);
        }

        private void View_ShowContracts(object sender, EventArgs e)
        {
            ShowAllContracts?.Invoke(this, EventArgs.Empty);
        }

        public void AddOnPanel(Form form)
        {
            view.addOnPanelForm(form);
        }

        public void Show()
        {
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }

    }
}
