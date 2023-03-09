using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Presenter;
using TravelAgency.Models;
using TravelAgency.Views;
using Npgsql;

namespace TravelAgency.Presenter
{
    internal class PresenterCreateNewStaff
    {
        ModelCreateNewStaff model = new ModelCreateNewStaff();
        IViewCreateNewStaff view;

        public NpgsqlConnection connection { get; set; }
        public event EventHandler getConnection;
        
        public PresenterCreateNewStaff(IViewCreateNewStaff view, ModelCreateNewStaff model)
        {
            this.view = view;
            this.model = model;

            view.sendInfo += View_sendInfo;
        }

        private void View_sendInfo(object sender, EventArgs e)
        {
            if(getConnection != null)
            {
                getConnection(this, EventArgs.Empty);
            }

            model.Name = view.Name;
            model.SecondName = view.SecondName;
            model.Surname = view.Surname;
            model.PhoneNumber = view.PhoneNumber;
            model.Gender = view.Gender;
            model.StartDate = view.StartDate;
            model.BirthDate = view.BirthDate;
            model.Post = view.Post;
            model.Salary = view.Salary;

            model.Connection = connection;
            model.CreateNewStaff();
            view.ResultOfAdding = model.ResultOfAdding;
        }

        public void Close()
        {
            view.CloseForm();
        }

        public void Show()
        {
            view.ShowForm();
        }
    }
}
