using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;
using TravelAgency.Views.DirectorViews.Transports_Transfers;

namespace TravelAgency.Presenter.DirectorPresenter.TransposrtAndTransfersPresenters
{
    internal class PresenterShowTransport
    {
        IViewShowTransports view;
        ModelShowTransports model;

        public event EventHandler OpenFormToEdit;
        public int ID;

        public PresenterShowTransport(IViewShowTransports view, ModelShowTransports model)
        {
            this.view = view;
            this.model = model;

            view.DeleteTransport += View_DeleteTransport;
            view.EditTransport += View_EditTransport;
        }

        private void View_EditTransport(object sender, EventArgs e)
        {
            ID = view.IdT;
            OpenFormToEdit?.Invoke(this, EventArgs.Empty);
        }

        private void View_DeleteTransport(object sender, EventArgs e)
        {
            view.CheckError = model.DeleteTransport(view.IdT);
        }

        public void Show()
        {
            view.TransportInfo = model.GetInfoAboutTransport();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }

}
