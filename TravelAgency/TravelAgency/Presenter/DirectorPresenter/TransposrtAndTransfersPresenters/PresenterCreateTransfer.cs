using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;
using TravelAgency.Views.DirectorViews.Transports_Transfers;

namespace TravelAgency.Presenter.DirectorPresenter.TransposrtAndTransfersPresenters
{
    internal class PresenterCreateTransfer
    {
        private ModelCreateNewTransfer model;
        private IViewCreateTransfer view;

        public PresenterCreateTransfer(ModelCreateNewTransfer model, IViewCreateTransfer view)
        {
            this.model = model;
            this.view = view;

            view.CreateTransfer += View_CreateTransfer;
            view.ShowCountOfSeats += View_ShowCountOfSeats;
        }

        private void View_ShowCountOfSeats(object sender, EventArgs e)
        {
            view.SetCount(model.FindCountOfSeats(view.dataToAdd["Name"].ToString()));
        }

        private void View_CreateTransfer(object sender, EventArgs e)
        {
            if(model.CreateNewTransfer(view.dataToAdd) == 0)
            {
                view.Error = model.Error;
            }
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
