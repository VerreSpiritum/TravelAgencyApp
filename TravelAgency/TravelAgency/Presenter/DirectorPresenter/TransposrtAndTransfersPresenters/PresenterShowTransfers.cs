using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;
using TravelAgency.Views.DirectorViews.Transports_Transfers;

namespace TravelAgency.Presenter.DirectorPresenter.TransposrtAndTransfersPresenters
{
    internal class PresenterShowTransfers
    {
        private ModelShowTransfers model;
        private IViewShowTransfers view;

        public event EventHandler EditTransfer;
        public int ID;

        public PresenterShowTransfers(ModelShowTransfers model, IViewShowTransfers view)
        {
            this.model = model;
            this.view = view;

            view.DeleteTransfer += View_DeleteTransfer;
            view.EditTransfer += View_EditTransfer;
        }

        private void View_EditTransfer(object sender, EventArgs e)
        {
            ID = view.IdT;
            EditTransfer?.Invoke(sender, e);
        }

        private void View_DeleteTransfer(object sender, EventArgs e)
        {
            view.CheckError = model.DeleteTransfer(view.IdT);
        }

        public void Show()
        {
            view.TransfersInfo = model.GetInfoAboutTransfer();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
