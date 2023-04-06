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
        public event EventHandler OpenWindowToCreateUser;

        public string Login { get; set; }

        public PresenterShowUsers(ModelShowUsers model, IViewShowUsers view)
        {
            this.model = model;
            this.view = view;

            view.EditUser += View_EditUser;
            view.CreateUser += View_CreateUser;
            view.DeleteUser += View_DeleteUser;
        }

        private void View_DeleteUser(object sender, EventArgs e)
        {
            if(model.DeleteUser(view.TalonNum) == 1)
            {
                RefreshTable();
                view.CheckError = 1;
            }
            else
            {
                view.CheckError = 0;
            }
        }

        private void View_CreateUser(object sender, EventArgs e)
        {
            OpenWindowToCreateUser?.Invoke(this, EventArgs.Empty);
        }

        private void View_EditUser(object sender, EventArgs e)
        {
            Login = view.LoginToAccess;
            OpenEditorToChangeUserInfo?.Invoke(this, EventArgs.Empty);
        }

        public void AddFormOnPanel(Form form)
        {
            view.addOnPanelForm(form);
        }

        public void RefreshTable()
        {
            view.userInfo = model.GetInfoAboutUser();
            view.RefreshTable();
        }

        public void Show()
        {
            RefreshTable();
            view.ShowForm();
        }

        public void Close()
        {
            view.CloseForm();
        }
    }
}
