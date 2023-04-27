using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models.AgentModels.ClientInfo;
using TravelAgency.Views.AgentViews.ClientPanel;

namespace TravelAgency.Presenter.AgentPresenter.ClientPanel
{
    internal class PresenterCreateNewClient
    {
        ModelAddNewClient model;
        IViewAddNewClient view;

        public PresenterCreateNewClient(ModelAddNewClient model, IViewAddNewClient view)
        {
            this.model = model;
            this.view = view;

            view.sendInfo += View_sendInfo;
        }

        private void View_sendInfo(object sender, EventArgs e)
        {
            view.ResultOfAdding = model.InsertIntoTable(view.Name, view.SecondName, view.Surname, view.Gender, view.PhoneNumber, 
                view.Email, view.BirthDate, view.RegistryEntryNum, view.IdentCode, view.PassportNumber);
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
