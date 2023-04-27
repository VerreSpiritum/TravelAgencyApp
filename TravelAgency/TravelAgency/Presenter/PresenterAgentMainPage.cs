using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Views;
using Npgsql;
using System.Windows.Forms;
using TravelAgency.Models.AgentModels;

namespace TravelAgency.Presenter
{
    internal class PresenterAgentMainPage
    {
        IViewAgentMainPage view;
        ModelAgentMainForm model;

        public event EventHandler OpenPersonalInfo;
        public event EventHandler OpenClientForm;
        public event EventHandler OpenOrdersPanel;
        public event EventHandler OpenServicesPanel;
        public event EventHandler CloseConnection;


        public PresenterAgentMainPage(IViewAgentMainPage view, ModelAgentMainForm model)
        {
            this.view = view;
            this.model = model;

            view.OpenPersonalInfoForm += View_OpenPersonalInfoForm;
            view.OpenClientForm += View_OpenClientForm;
            view.OpenOrdersPanel += View_OpenOrdersPanel;
            view.CloseConnection += View_CloseConnection;
            view.OpenPanelToShowServices += View_OpenPanelToShowServices;
        }

        private void View_OpenPanelToShowServices(object sender, EventArgs e)
        {
            OpenServicesPanel?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenOrdersPanel(object sender, EventArgs e)
        {
            OpenOrdersPanel?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenClientForm(object sender, EventArgs e)
        {
            OpenClientForm?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenPersonalInfoForm(object sender, EventArgs e)
        {
            OpenPersonalInfo?.Invoke(this, EventArgs.Empty);
        }

       

        private void View_CloseConnection(object sender, EventArgs e)
        {
            if (CloseConnection != null) 
                CloseConnection(this, EventArgs.Empty);

        }

        public int GetTalonNum(string login)
        {
            return model.GetTalonNum(login);
        }
      
        public void AddOnPanel(Form form)
        {
            view.addOnPanel(form);
        }

        public void Show()
        {
            view.ShowForm();
        }
    }
}
