using System;
using TravelAgency.Models;
using TravelAgency.Views;
using System.Windows.Forms;

namespace TravelAgency.Presenter
{
    internal class PresenterHumanResourcesForm
    {
        IViewHumanResourcesForm view;
        ModelHumanResourcesForm model;

        public event EventHandler OpenFormToCreateNewStaff;
        public event EventHandler OpenFormToEditEmployee;
        public event EventHandler OpenFormToShowUsers;
        public event EventHandler OpenFormToShowAllStaff;

        public PresenterHumanResourcesForm(IViewHumanResourcesForm view, ModelHumanResourcesForm model)
        {
            this.view = view;
            this.model = model;

            view.OpenFormCreateNewStaff += View_OpenFormCreateNewStaff;
            view.OpenFormEditEmployee += View_OpenFormEditEmployee;
            view.OpenFormToShowUsers += View_OpenFormToShowUsers;
            view.OpenFormShowStaff += View_OpenFormShowStaff;
        }

        private void View_OpenFormShowStaff(object sender, EventArgs e)
        {
            OpenFormToShowAllStaff?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenFormToShowUsers(object sender, EventArgs e)
        {
            OpenFormToShowUsers?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenFormEditEmployee(object sender, EventArgs e)
        {
            OpenFormToEditEmployee?.Invoke(this, EventArgs.Empty);
        }

        private void View_OpenFormCreateNewStaff(object sender, EventArgs e)
        {
            OpenFormToCreateNewStaff?.Invoke(this, EventArgs.Empty);
        }

        public void OpenWindow()
        {
            view.OpenWindow();
        }

        public void Show() 
        {
            view.ShowForm();
        }
        
        public void Close()
        {
            view.CloseForm();
        }
        public void ChangeStyle(string text)
        {
            view.ChangeStyle(text);
        }
        public void AddOnPanelForm(Form form)
        {
            view.addOnPanelForm(form);
        }
    }
}
