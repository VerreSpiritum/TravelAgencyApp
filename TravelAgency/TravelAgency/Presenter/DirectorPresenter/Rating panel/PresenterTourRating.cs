using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.Booker_panel;
using TravelAgency.Views.DirectorViews.Booker_panel;

namespace TravelAgency.Presenter.DirectorPresenter.Booker_panel
{
    internal class PresenterTourRating
    {
        ModelTourRating model;
        IViewTourRating view;

        public PresenterTourRating(ModelTourRating model, IViewTourRating view)
        {
            this.model = model;
            this.view = view;
        }

        public void Show()
        {
            view.ListOfStaff = model.GetInfo();
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
