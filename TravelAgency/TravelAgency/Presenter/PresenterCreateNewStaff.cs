using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Presenter;
using TravelAgency.Models;
using TravelAgency.Views;

namespace TravelAgency.Presenter
{
    internal class PresenterCreateNewStaff
    {
        ModelCreateNewStaff model = new ModelCreateNewStaff();
        IViewCreateNewStaff view;

        public PresenterCreateNewStaff(IViewCreateNewStaff view, ModelCreateNewStaff model)
        {
            this.view = view;
            this.model = model;
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
