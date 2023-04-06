using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Models;
using TravelAgency.Views;

namespace TravelAgency.Presenter
{
    internal class PresenterCreateUser
    {
        public ModelCreateUser model;
        public IViewCreateUsers view;

        public event EventHandler CloseWindow;
        public event EventHandler RefreshTable;

        public PresenterCreateUser(ModelCreateUser model, IViewCreateUsers view)
        {
            this.model = model;
            this.view = view;

            view.UpdateInfo += View_UpdateInfo;
            view.CanClose += View_CanClose;
        }

        private void View_CanClose(object sender, EventArgs e)
        {
            CloseWindow?.Invoke(this, EventArgs.Empty);
        }

        private void View_UpdateInfo(object sender, EventArgs e)
        {
            if(model.CreateUser(view.TalonNum, view.Password) == 0)
                view.ErrorMess = model.ErrorMess;
            else
                RefreshTable?.Invoke(this, EventArgs.Empty);

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
