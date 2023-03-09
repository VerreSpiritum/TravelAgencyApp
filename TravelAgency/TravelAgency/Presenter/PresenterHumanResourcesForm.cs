using System;
using TravelAgency.Models;
using TravelAgency.Views;
using System.Windows.Forms;

namespace TravelAgency.Presenter
{
    internal class PresenterHumanResourcesForm
    {
        IViewHumanResoucesForm view;
        ModelHumanResourcesForm model;

        public event EventHandler OpenFormToCreateNewStaff;
        public event EventHandler OpenFormToEditEmployee;
        public event EventHandler OpenFormToDeleteEmployee;
        public event EventHandler OpenFormToCreateNewUser;

        public PresenterHumanResourcesForm(IViewHumanResoucesForm view, ModelHumanResourcesForm model)
        {
            this.view = view;
            this.model = model;

            view.OpenFormCreateNewStaff += View_OpenFormCreateNewStaff;
            view.OpenFormEditEmployee += View_OpenFormEditEmployee;
            view.OpenFormDeleteEmployee += View_OpenFormDeleteEmployee;
            view.OpenFormCreateNewUser += View_OpenFormCreateNewUser;
        }

        private void View_OpenFormCreateNewUser(object sender, EventArgs e)
        {
            if (OpenFormToCreateNewUser != null)
                OpenFormToCreateNewUser(this, EventArgs.Empty);
        }

        private void View_OpenFormDeleteEmployee(object sender, EventArgs e)
        {
            if (OpenFormToDeleteEmployee != null)
                OpenFormToDeleteEmployee(this, EventArgs.Empty);
        }

        private void View_OpenFormEditEmployee(object sender, EventArgs e)
        {
            if (OpenFormToEditEmployee != null)
                OpenFormToEditEmployee(this, EventArgs.Empty);
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

        public void AddOnPanelCreateNewStaff(Form form)
        {
            view.addOnPanelCreateNewStaff(form);
        }
    }
}
