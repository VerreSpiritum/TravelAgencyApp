using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.ToursAndAdditionalTours;
using TravelAgency.Views.DirectorViews.ToursAndAdditionalTours;

namespace TravelAgency.Presenter.DirectorPresenter.ToursAndAdditionalTours
{
    internal class PresenterShowRooms
    {
        IViewShowRooms view;
        ModelShowRooms model;

        public PresenterShowRooms(IViewShowRooms view, ModelShowRooms model)
        {
            this.view = view;
            this.model = model;

            view.DeleteRoom += View_DeleteRoom;
        }

        private void View_DeleteRoom(object sender, EventArgs e)
        {
            view.CheckError = model.DeleteRoom(view.ID);
        }

        public void Show()
        {
            view.ListOfRooms = model.ShowRooms();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
