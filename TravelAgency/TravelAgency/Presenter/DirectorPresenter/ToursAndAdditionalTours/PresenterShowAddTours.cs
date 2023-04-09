using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.ToursAndAdditionalTours;
using TravelAgency.Views.DirectorViews.ToursAndAdditionalTours;

namespace TravelAgency.Presenter.DirectorPresenter.ToursAndAdditionalTours
{
    internal class PresenterShowAddTours
    {
        IViewShowAddTours view;
        ModelShowAddTours model;

        public PresenterShowAddTours(IViewShowAddTours view, ModelShowAddTours model)
        {
            this.view = view;
            this.model = model;

            view.DeleteTour += View_DeleteTour;
        }

        private void View_DeleteTour(object sender, EventArgs e)
        {
            view.CheckError = model.DeleteTour(view.ID);
        }

        public void Show()
        {
            view.ListOfTours = model.ShowTours();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
