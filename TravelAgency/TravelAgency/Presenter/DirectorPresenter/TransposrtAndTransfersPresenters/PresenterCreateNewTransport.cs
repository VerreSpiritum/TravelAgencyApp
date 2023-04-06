using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;
using TravelAgency.Views.DirectorViews.Transports_Transfers;

namespace TravelAgency.Presenter.DirectorPresenter.TransposrtAndTransfersPresenters
{
    internal class PresenterCreateNewTransport
    {
        ModelCreateNewTransport model;
        IViewCreateNewTransport view;

        public PresenterCreateNewTransport(ModelCreateNewTransport model, IViewCreateNewTransport view)
        {
            this.view = view;
            this.model = model;

            view.sendInfo += View_sendInfo;
        }

        private void View_sendInfo(object sender, EventArgs e)
        {
            model.CreateNewTransport(view.Name, view.ShortInfo, view.ReleaseDate, view.CountOfSeats, view.linkPhoto, view.Facilities);
            if(model.Error != null)
                view.ResultOfAdding = model.Error;
        }

        public void Show()
        {
            view.facilites = model.GetFacilites();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
