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
        private IViewShowAddTours view;
        private ModelShowAddTours model;
        private int id;

        public int ID { get => id; }
        public event EventHandler EditTour;

        public PresenterShowAddTours(IViewShowAddTours view, ModelShowAddTours model)
        {
            this.view = view;
            this.model = model;

            view.DeleteTour += View_DeleteTour;
            view.EditTour += View_EditTour;
        }

        private void View_EditTour(object sender, EventArgs e)
        {
            id = view.ID;
            EditTour?.Invoke(this, EventArgs.Empty);
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
