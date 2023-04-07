using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;
using TravelAgency.Views.DirectorViews.Transports_Transfers;

namespace TravelAgency.Presenter.DirectorPresenter.TransposrtAndTransfersPresenters
{
    internal class PresenterEditTransfer
    {
        IViewEditTransfer view;
        ModelEditTransfer model;

        public PresenterEditTransfer(IViewEditTransfer view, ModelEditTransfer model)
        {
            this.view = view;
            this.model = model;

            view.SearchInfo += View_SearchInfo;
            view.UpdateInfo += View_UpdateInfo;
        }

        private void View_UpdateInfo(object sender, EventArgs e)
        {
            if(model.CreateNewTransfer(view.dataToUpdate, view.ID) == 0)
            {
                view.Error = model.Error;
            }
        }

        private void View_SearchInfo(object sender, EventArgs e)
        {
            view.ResultOfSearching = model.GetInfoFormA(view.ID);
            view.InfoFromTable = model.InfoTable;
        }

        public void Show()
        {
            model.GetInfo();
            view.ShowForm(model.AvailableTransport, model.AvailableDepartureCity, model.AvailableCityToVisit);
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
