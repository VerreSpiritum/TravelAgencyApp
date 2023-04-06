using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Views;

namespace TravelAgency.Presenter
{
    internal class PresenterEditUser
    {
        public ModelEditUser model;
        public IViewEditUsers view;

        public event EventHandler EditUserEvent;

        public PresenterEditUser(ModelEditUser model, IViewEditUsers view)
        {
            this.model = model;
            this.view = view;

            view.UpdateInfo += View_UpdateInfo;
            view.CloseWindow += View_CloseWindow;
        }

        private void View_CloseWindow(object sender, EventArgs e)
        {
            EditUserEvent?.Invoke(this, EventArgs.Empty);
        }

        private void View_UpdateInfo(object sender, EventArgs e)
        {
            model.ChangePassword(view.Login, view.Password);
            
        }

        public void Show(string login)
        {
            view.ShowForm(login);
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
