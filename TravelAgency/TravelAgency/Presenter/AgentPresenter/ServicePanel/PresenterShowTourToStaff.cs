using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.AgentModels.ServicePanel;
using TravelAgency.Views.AgentViews.Service_Panel;

namespace TravelAgency.Presenter.AgentPresenter.ServicePanel
{
    internal class PresenterShowTourToStaff
    {
        IViewShowTourToStaff view;
        ModelShowTourToStaff model;

        public PresenterShowTourToStaff(IViewShowTourToStaff view, ModelShowTourToStaff model)
        {
            this.view = view;
            this.model = model;
        }

        public void Show()
        {
            view.ShowForm(model.ShowTours());
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
