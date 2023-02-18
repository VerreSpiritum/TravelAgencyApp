using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Views;

namespace TravelAgency.Presenter
{
    internal class PresenterHumanResoucesForm
    {
        IViewHumanResoucesForm view;
        ModelHumanResoucesForm model;

        public event EventHandler OpenFormToCreateNewStaff;

        public PresenterHumanResoucesForm(IViewHumanResoucesForm view, ModelHumanResoucesForm model)
        {
            this.view = view;
            this.model = model;

            view.OpenFormCreateNewStaff += View_OpenFormCreateNewStaff;
        }

        private void View_OpenFormCreateNewStaff(object sender, EventArgs e)
        {
            if(OpenFormToCreateNewStaff != null)
            {
                OpenFormToCreateNewStaff(this, EventArgs.Empty);
            }
        }

        public void Show() 
        {
            view.ShowForm();
        }
        
        public void Close()
        {
            view.CloseForm();
        }

        public void AddOnPanelCreateNewStaff(CreateNewStaff form)
        {
            view.addOnPanelCreateNewStaff(form);
        }
    }
}
