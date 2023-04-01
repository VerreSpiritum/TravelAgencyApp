using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Models;
using TravelAgency.Views;

namespace TravelAgency.Presenter
{
    internal class PresenterShowUsers
    {
        ModelShowUsers model;
        IViewShowUsers view;

        public event EventHandler OpenEditorToChangeUserInfo;

        public PresenterShowUsers(ModelShowUsers model, IViewShowUsers view)
        {
            this.model = model;
            this.view = view;

            view.EditUser += View_EditUser;
        }

        private void View_EditUser(object sender, EventArgs e)
        {
            OpenEditorToChangeUserInfo?.Invoke(this, EventArgs.Empty);
        }

        public void AddFormOnPanel(Form form)
        {
            view.addOnPanelForm(form);
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
