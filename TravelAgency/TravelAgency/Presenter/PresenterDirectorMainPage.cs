using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Views;
using Npgsql;
using System.Windows.Forms;

namespace TravelAgency.Presenter
{
    internal class PresenterDirectorMainPage
    {
        ModelDirectorMainPage model = new ModelDirectorMainPage();
        IViewDirectorMainPage view;

        public event EventHandler OpenHumanResourcesForm;
        public event EventHandler OpenTransportsAndTransfersForm;
        public event EventHandler OpenTourAddTourForm;
        public event EventHandler OpenHotelInfoForm;
        public event EventHandler CloseConnection;
        public event EventHandler OpenBookerForm;
        public event EventHandler OpenRatingsFrom;

        public PresenterDirectorMainPage(IViewDirectorMainPage view, ModelDirectorMainPage model)
        {
            this.model = model;
            this.view = view;

            view.OpenHumanResourcesForm += View_OpenHumanResourcesForm;
            view.OpenTransportsAndTransfersForm += View_OpenTransportsAndTransfersForm;
            view.OpenHotelInfoForm += View_OpenHotelInfoForm;
            view.OpenTourAddTourForm += View_OpenTourAddTourForm;
            view.CloseConnection += View_CloseConnection;
            view.BookerForm += View_BookerForm;
            view.RatingsForm += View_RatingsForm;
        }

        private void View_RatingsForm(object sender, EventArgs e)
        {
            OpenRatingsFrom?.Invoke(this, EventArgs.Empty);
        }

        private void View_BookerForm(object sender, EventArgs e)
        {
            OpenBookerForm?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenTourAddTourForm(object sender, EventArgs e)
        {
            OpenTourAddTourForm?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenHotelInfoForm(object sender, EventArgs e)
        {
            OpenHotelInfoForm?.Invoke(this, EventArgs.Empty);
        }

        private void View_CloseConnection(object sender, EventArgs e)
        {
            if (CloseConnection != null) 
                CloseConnection(this, EventArgs.Empty);

        }

        private void View_OpenTransportsAndTransfersForm(object sender, EventArgs e)
        {
            OpenTransportsAndTransfersForm?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenHumanResourcesForm(object sender, EventArgs e)
        {
            if(OpenHumanResourcesForm != null) 
                OpenHumanResourcesForm(this, EventArgs.Empty);
        }

        public void AddOnPanel(Form form)
        {
            view.addOnPanel(form);
        }

        public void Show()
        {
            view.ShowForm();
        }
    }
}
