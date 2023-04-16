using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.DirectorModels.Booker_panel;
using TravelAgency.Views.DirectorViews.Booker_panel;

namespace TravelAgency.Presenter.DirectorPresenter.Booker_panel
{
    internal class PresenterProfit
    {
        ModelProfit model;
        IViewProfit view;

        public PresenterProfit(ModelProfit model, IViewProfit view)
        {
            this.model = model;
            this.view = view;

            view.SearchInfo += View_SearchInfo;
        }

        private void View_SearchInfo(object sender, EventArgs e)
        {
            view.ListOfStaff = model.GetInfo(view.StartD, view.EndD);
        }

        public void Show()
        {
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
