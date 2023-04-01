using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Views;
using TravelAgency.Models;
using Npgsql;

namespace TravelAgency.Presenter
{
    internal class PresenterEditEmployee
    {
        IViewEditEmployee view;
        ModelEditEmployee model;

        public NpgsqlConnection connection;
        public event EventHandler GetConnectionEvent;

        public PresenterEditEmployee(IViewEditEmployee view, ModelEditEmployee model)
        {
            this.view = view;
            this.model = model;

            view.GetInfo += View_GetInfo;
            view.UpdateInfo += View_UpdateInfo;
        }

        private void View_UpdateInfo(object sender, EventArgs e)
        {
            model.UpdateInfo(view.InfoToUpdate, view.TalonNum);
        }

        private void View_GetInfo(object sender, EventArgs e)
        {

            SelectInfo(view.TalonNum);
        }

        private void SelectInfo(int talonNum)
        {
            if (model.GetInfo(talonNum))
            {
                view.Name = model.Name;
                view.Patronymic = model.Patronymic;
                view.Surname = model.Surname;
                view.Salary = model.Salary;
                view.Gender = model.Gender;
                view.Position = model.Position;
                view.PhoneNumber = model.PhoneNumber;

                view.talonNumFind = true;
            }
            else
            {
                view.talonNumFind = false;
            }
        }

        private void GetConnection()
        {
            model.connection = connection;
        }
        public void Show()
        {
            GetConnection();
            view.IsFromTable = false;
            view.ShowForm();
        }
        public void Show(int talonNum)
        {
            GetConnection();
            view.TalonNum = talonNum;
            SelectInfo(talonNum);
            view.IsFromTable = true;
            view.ShowForm();
        }
        public void Close()
        {
            view.CloseForm();
        }
    }
}
