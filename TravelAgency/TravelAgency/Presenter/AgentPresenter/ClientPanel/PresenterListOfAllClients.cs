using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Views;

namespace TravelAgency.Presenter
{
    internal class PresenterListOfAllClients
    {
        public ModelListOfAllClients model;
        public IViewListOfAllClients view;

        public event EventHandler OpenFormToEditEmployee;

        public PresenterListOfAllClients(ModelListOfAllClients model, IViewListOfAllClients view)
        {
            this.model = model; 
            this.view = view;

            view.DeleteCustomer += View_DeleteClient;
            
        }

        private void View_DeleteClient(object sender, EventArgs e)
        {
            if (model.DeleteCustomer(view.TalonNum) == 1)
            {
                view.CheckError = 1;
            }
        }

        public void Show()
        {
            view.clientInfo = model.GetInfoAboutCustomer();
            view.ShowForm();
        }

        public void Close()
        {
            view.CloseForm();
        }

    }
}
