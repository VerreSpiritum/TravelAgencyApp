using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.AgentModels;
using TravelAgency.Views.AgentViews;

namespace TravelAgency.Presenter.AgentPresenter
{
    internal class PresenterPersonalInfo
    {
        public ModelPersonalInfo model;
        public IViewPersonalInfo view;

        public PresenterPersonalInfo(ModelPersonalInfo model, IViewPersonalInfo view)
        {
            this.model = model;
            this.view = view;
        }
        
        public void Show(int TalonNum)
        {
            model.GetInfo(TalonNum);
            view.Info = model.infoAboutPerson;

            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
