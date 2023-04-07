using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;
using TravelAgency.Views.DirectorViews.Transports_Transfers;

namespace TravelAgency.Presenter.DirectorPresenter.TransposrtAndTransfersPresenters
{
    internal class PresenterEditTransport
    {
        ModelEditTransports model;
        IViewEditTransport view;

        public PresenterEditTransport(ModelEditTransports model, IViewEditTransport view)
        {
            this.model = model;
            this.view = view;

            view.searchInfo += View_searchInfo;
            view.sendInfo += View_sendInfo;
        }

        private void View_sendInfo(object sender, EventArgs e)
        {
            model.UpdateInfo(view.InfoToUpdate, view.AddOrDeleteFacilities, view.ID);
            if(model.Error != null)
            {
                view.ResultOfAdding = model.Error;
            }
        }

        private void View_searchInfo(object sender, EventArgs e)
        {
            if (model.GetInfo(view.ID) == 1)
            {
                view.facilites = model.GetFacilites();
                view.Facilities = model.Facilities;
                view.AddInfo(model.infoToShow);
                view.ResultOfSearching = 1;
            }
            else
            {
                view.ResultOfSearching = 0;
            }
        }

        public void Show()
        {
            view.facilites = model.GetFacilites();
            view.AddFacilities();
            view.ShowForm();
            view.IsFromTable = false;
        }
        public void Show(int talonNum)
        {
            view.ID = talonNum;
            view.facilites = model.GetFacilites();
            view.AddFacilities();
            model.GetInfo(talonNum);

            view.Facilities = model.Facilities;
            view.AddInfo(model.infoToShow);
            view.IsFromTable = true;
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
